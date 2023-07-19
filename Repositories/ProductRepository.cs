using PrGer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrGer.Repositories
{
    internal class ProductRepository : LocalRepository, IProductRepository
    {

        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;

        }

        async void IProductRepository.Add(ProductModel productModel)
        {
            var products = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = @"insert into products 
                                        values(@description,@descriptionEN,@price,@unit,@vat,@identifier,@inactive,@availableSTK,@remoteId)";

                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.description;
                command.Parameters.Add("@descriptionEN", SqlDbType.NVarChar).Value = productModel.descriptionEN;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.price;
                command.Parameters.Add("@unit", SqlDbType.NVarChar).Value = productModel.unit;
                command.Parameters.Add("@vat", SqlDbType.Int).Value = productModel.vat;
                command.Parameters.Add("@identifier", SqlDbType.NVarChar).Value = productModel.identifier;
                command.Parameters.Add("@inactive", SqlDbType.TinyInt).Value = productModel.inactive;
                command.Parameters.Add("@availableSTK", SqlDbType.Int).Value = productModel.availableSTK;
                command.Parameters.Add("@remoteId", SqlDbType.Int).Value = productModel.remoteId;

                await command.ExecuteNonQueryAsync();

            }
        }

        public void Delete(int id)
        {
            var products = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = @"delete from products where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                 command.ExecuteNonQuery();
            }
        }
        IEnumerable<ProductModel> IProductRepository.GetAll()
        {
            var products = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "select * from products order by id desc";
                using (var reader = command.ExecuteReader())
                {
                    string intv;
                    while (reader.Read())
                    {
                        var prodModel = new ProductModel();

                        prodModel.id = (int)reader[0];
                        prodModel.description = reader[1].ToString();
                        prodModel.descriptionEN = reader[2].ToString();
                        prodModel.price = double.Parse(reader[3].ToString());
                        prodModel.unit = reader[4].ToString();
                        prodModel.vat = (int)reader[5];
                        prodModel.identifier = reader[6].ToString();
                        intv = reader[7].ToString();
                        prodModel.inactive = intv.Equals("1");
                        prodModel.availableSTK = (int)reader[8];
                        prodModel.remoteId = (int)reader[9];
                        products.Add(prodModel);
                    }
                }
            }
            return products;
        }

        IEnumerable<ProductModel> IProductRepository.GetByValue(string value)
        {
            var products = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = @"select * from products 
                                        where description like '%'+@value+'%'
                                        or descriptionEN like '%'+@value+'%'
                                        or identifier like '%'+@value+'%'
                                        order by id desc";

                command.Parameters.Add("@value", SqlDbType.NVarChar).Value = value;

                using (var reader = command.ExecuteReader())
                {
                    string intv;
                    while (reader.Read())
                    {
                        var prodModel = new ProductModel();
                        prodModel.id = (int)reader[0];
                        prodModel.description = reader[1].ToString();
                        prodModel.descriptionEN = reader[2].ToString();
                        prodModel.price = double.Parse(reader[3].ToString());
                        prodModel.unit = reader[4].ToString();
                        prodModel.vat = (int)reader[5];
                        prodModel.identifier = reader[6].ToString();
                        intv = reader[7].ToString();
                        prodModel.inactive = intv.Equals("1");
                        prodModel.availableSTK = (int)reader[8];
                        prodModel.remoteId = (int)reader[9];

                        products.Add(prodModel);
                    }
                }
            }
            return products;
        }

        void IProductRepository.Update(ProductModel productModel)
        {
            var products = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = @"update products set
                                        description=@description,
                                        descriptionEn=@descriptionEN,
                                        price=@price,
                                        unit=@unit,
                                        vat=@vat,
                                        identifier=@identifier,
                                        inactive=@inactive,
                                        availableSTK=@availableSTK
                                        where id=@id";

                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.description;
                command.Parameters.Add("@descriptionEN", SqlDbType.NVarChar).Value = productModel.descriptionEN;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.price;
                command.Parameters.Add("@unit", SqlDbType.NVarChar).Value = productModel.unit;
                command.Parameters.Add("@vat", SqlDbType.Int).Value = productModel.vat;
                command.Parameters.Add("@identifier", SqlDbType.NVarChar).Value = productModel.identifier;
                command.Parameters.Add("@inactive", SqlDbType.TinyInt).Value = productModel.inactive;
                command.Parameters.Add("@availableSTK", SqlDbType.Int).Value = productModel.availableSTK;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.remoteId;

                 command.ExecuteNonQuery();
            }
        }
    }
}
