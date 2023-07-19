using PrGer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrGer.Views
{
    public partial class ProductPage : Form, IProductView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProductPage()
        {
            InitializeComponent();
            AssociateAndeRaiseViewEvents();
       
        }

        private void AssociateAndeRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControlProduct.TabPages.Clear();//
                tabControlProduct.TabPages.Add(tabPageProducts);
            };
            btnRemove.Click += delegate { 
               
                var result = MessageBox.Show("Tens a certeza de que queres apagar?","warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    RemoveEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            btnSave.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControlProduct.TabPages.Clear();
                    tabControlProduct.TabPages.Add(tabPageProducts);
                   
                }
                MessageBox.Show(Message);
            };
            btnAdd.Click += delegate { 
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControlProduct.TabPages.Clear();//
                tabControlProduct.TabPages.Add(tabPageProductForm);
                //tabControlProduct.TabPages.Remove(tabPageProducts);
                tabPageProductForm.Text = "Adcionar";
            };
            btnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlProduct.TabPages.Clear();//
                tabControlProduct.TabPages.Add(tabPageProductForm);
                tabPageProductForm.Text = "Editar";
            };

            btnCSV.Click += delegate
            {
                ExportToCSVEvent.Invoke(this, EventArgs.Empty);
            };

            btnPDF.Click += delegate
            {
                ExportToPDFEvent.Invoke(this, EventArgs.Empty);
            };
            btnXLS.Click += delegate
            {
                ExportToXLSEvent.Invoke(this, EventArgs.Empty);
            };

        }


        public string Id { get => lbId.Text; set => lbId.Text = value; }

        public string RemoteId { get => lbIdRemote.Text; set => lbIdRemote.Text = value; }
        public  string Identifier { get => textBoxIdentifier.Text; set => textBoxIdentifier.Text=value; }
        public  string Description { get => textBoxDescription.Text; set => textBoxDescription.Text=value; }
        public string DescriptionEN { get => textBoxDescriptionEn.Text; set =>textBoxDescriptionEn.Text=value; }
        public  string Price { get => textBoxPrice.Text; set => textBoxPrice.Text=value; }
        public  string Unit { get => textBoxUnit.Text; set => textBoxUnit.Text=value; }
        public string Vat { get => textBoxVat.Text; set =>textBoxVat.Text=value; }
        public bool Inactive { get =>cbBoxInacitve.Text=="sim"; set => cbBoxInacitve.Text = value?"sim":"nao"; }
        public string AvailableSTK { get => textBoxSTK.Text; set => textBoxSTK.Text=value; }

        public string ComponentType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => message; set => message = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value;  }
       public  bool IsEdit { get => isEdit; set => isEdit = value; }
        public string SearchValue { get => textBoxSearch.Text; set => textBoxSearch.Text=value; }

       public  event EventHandler SearchEvent;

        public event EventHandler AddEvent;

        public event EventHandler EditEvent;

        public event EventHandler RemoveEvent;

        public event EventHandler SaveEvent;

        public  event EventHandler CancelEvent;
        public event EventHandler ExportToXLSEvent;
        public event EventHandler ExportToPDFEvent;
        public event EventHandler ExportToCSVEvent;

        public void SetProductBindingSource(BindingSource productList)
        {
            dataGridView1.DataSource = productList;
        }


        private static ProductPage instance;
        public static ProductPage GetInstance()
        {
            if(instance == null || instance.IsDisposed)
                instance = new ProductPage();
            else
            {
                if(instance.WindowState==FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {

                e.Handled = true;
            }
        }

        private void textBoxSTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
