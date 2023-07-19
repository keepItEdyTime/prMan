using PrGer.Models;
using PrGer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrGer.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository localRepository;
        private IApiRepoitory apiRepoitory;
        private BindingSource bindingSource;
        private IEnumerable<ProductModel> productList;

       public ProductPresenter(IProductView view, IProductRepository localRepository, IApiRepoitory apiRepoitory)
        {
            this.view = view;
            this.localRepository = localRepository;
            this.apiRepoitory = apiRepoitory;
            this.bindingSource = new BindingSource();
            //this.view.IsEdit = false;

            this.view.Inactive = true;
            this.view.SearchEvent += SearchProduct;
            this.view.AddEvent += AddProduct;
            this.view.EditEvent += EditProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.RemoveEvent += RemoveProduct;
            this.view.CancelEvent += CancelAction;
            this.view.ExportToCSVEvent += ExportToXSV;
            this.view.ExportToPDFEvent += ExportToPDF;
            this.view.ExportToXLSEvent += ExportToXLS;

            this.view.SetProductBindingSource(this.bindingSource);

            LoadAllProducts();

            this.view.Show();
        }

        private void ExportToXSV(object sender, EventArgs e)
        {
            productList = this.localRepository.GetAll();
            SaveFileModel sv = new SaveFileModel();
            sv.exportToCSV(productList);
        }

        private void ExportToXLS(object sender, EventArgs e)
        {
            productList = this.localRepository.GetAll();
            SaveFileModel sv = new SaveFileModel();
            sv.exportToXLS(productList);
        }

        private void ExportToPDF(object sender, EventArgs e)
        {
            productList = this.localRepository.GetAll();
            SaveFileModel sv = new SaveFileModel();
            sv.exportToPDF(productList);
        }

        private  void  SaveProduct(object sender, EventArgs e)
        {
            var product = new ProductModel();

            product.id = int.Parse(view.Id!=""? view.Id : "0");
            product.remoteId = int.Parse(view.RemoteId != "" ? view.RemoteId : "0");
            product.identifier = view.Identifier;
            product.description = view.Description;
            product.descriptionEN = view.DescriptionEN;
            product.price = double.Parse(view.Price!= "" ? view.Price.Replace('.', ',') : "0");
            Console.WriteLine(product.price);
            product.unit = view.Unit;
            product.vat = int.Parse(view.Vat != "" ? view.Vat : "0");
            product.availableSTK = int.Parse(view.AvailableSTK != "" ? view.AvailableSTK : "0");
            product.inactive = view.Inactive;


            try
            {
                
                new ValidationModel().validate(product);

                if (view.IsEdit)
                {

                    localRepository.Update(product);
                    product.id = product.remoteId;
                    var rs =apiRepoitory.Update(product).Result;
                    view.Message = "Produto actualizado com sucesso!";
                }
                else
                {
                    var rId = apiRepoitory.Add(product).Result;
                    product.remoteId = rId;
                    localRepository.Add(product);
                    view.Message = "Produto adicionado com sucesso!";
                }

                view.IsSuccessful = true;
                LoadAllProducts();
                CleanAllFields();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void LoadAllProducts()
        {
            productList = this.localRepository.GetAll();
            this.bindingSource.DataSource = productList;
        }

        private  void RemoveProduct(object sender, EventArgs e)
        {
           
            try
            {

                var product = (ProductModel)bindingSource.Current;

                var i = apiRepoitory.Delete(product.remoteId).Result;
                localRepository.Delete(product.id);    

                view.IsSuccessful = true;
                view.Message = "Removido com sucesso";
                LoadAllProducts();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Erro ao apagar, tente novamente!";
            }
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanAllFields();      
        }

        private void EditProduct(object sender, EventArgs e)
        {
            var product = (ProductModel)bindingSource.Current;
            view.Id = product.id.ToString();
            view.RemoteId = product.remoteId.ToString();
            view.Identifier = product.identifier;
            view.Description = product.description;
            view.DescriptionEN = product.descriptionEN;
            view.Price = product.price.ToString();
            view.Unit = product.unit;
            view.Vat = product.vat.ToString();
            view.AvailableSTK = product.availableSTK.ToString();
            view.Inactive = product.inactive;
            view.IsEdit = true;

        }

        private void AddProduct(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

     

        private void SearchProduct(object sender, EventArgs e)
        {
            productList = this.localRepository.GetByValue(this.view.SearchValue);
            this.bindingSource.DataSource = productList;
        }

        private void CleanAllFields()
        {
            view.Id = "";
            view.RemoteId = "";
            view.Identifier = "";
            view.Description = "";
            view.DescriptionEN = "";
            view.Price = "0";
            view.Unit = "";
            view.Vat = "0";
            view.Inactive = true;
            view.AvailableSTK = "0";
            view.IsEdit = false;
        }

        
    }
}
