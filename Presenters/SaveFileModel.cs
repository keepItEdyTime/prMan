using ClosedXML.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using PrGer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrGer.Presenters
{
    internal class SaveFileModel
    {
        public void exportToXLS(IEnumerable<ProductModel> data) { 
            using(SaveFileDialog sfd  = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx"})
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using(XLWorkbook workbook= new XLWorkbook())
                        {
                            var products = this.ToDataTable<ProductModel>(data.ToList());
                            workbook.Worksheets.Add(products);
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Arquivo salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    }catch(Exception ex) {

                        MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        public void exportToCSV(IEnumerable<ProductModel> data)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            var dt = this.ToDataTable(data.ToList());
                            StringBuilder sb = new StringBuilder();

                            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                                              Select(column => column.ColumnName);
                            sb.AppendLine(string.Join(";", columnNames));

                            foreach (DataRow row in dt.Rows)
                            {
                                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                                sb.AppendLine(string.Join(";", fields));
                            }

                            sw.Write(sb.ToString());    
                        }
                        MessageBox.Show("Arquivo salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        public void exportToPDF(IEnumerable<ProductModel> data)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF (*.pdf)|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var dt = this.ToDataTable(data.ToList());

                    IEnumerable<string> columns = dt.Columns.Cast<DataColumn>().
                                                      Select(column => column.ColumnName);

                    try
                    {
                        PdfPTable pTable = new PdfPTable(columns.Count());
                        pTable.DefaultCell.Padding = 2;
                        pTable.WidthPercentage = 100;
                        pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        foreach (string col in columns)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(col));
                            pTable.AddCell(pCell);
                        }
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (var dcell in row.ItemArray)
                            {
                                pTable.AddCell(dcell.ToString());
                            }
                        }
                        using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                            PdfWriter.GetInstance(document, fileStream);
                            document.Open();
                            document.Add(pTable);
                            document.Close();
                            fileStream.Close();
                        }
                        MessageBox.Show("Arquivo salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }

                 }
        }
        private DataTable ToDataTable<T>(List<T> items)
        {
            var tb = new DataTable(typeof(T).Name);

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                tb.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }
    }
}
