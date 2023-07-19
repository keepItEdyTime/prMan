using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrGer.Views
{
    public interface IProductView
    {
         string Id { get; set; }
         string Identifier { get; set; }
       
         string Description { get; set; }
       
         string DescriptionEN { get; set; }
       
         string Price { get; set; }
       
         string Unit { get; set; }
       
         string Vat { get; set; }
       
         bool Inactive { get; set; }

        string RemoteId { get; set; }

        string AvailableSTK { get; set; }
         string ComponentType { get; set; }

        string Message { get; set; }
        bool IsSuccessful { get; set; }
        bool IsEdit { get; set; }
        string SearchValue { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler RemoveEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ExportToXLSEvent;
        event EventHandler ExportToPDFEvent;
        event EventHandler ExportToCSVEvent;

        void SetProductBindingSource(BindingSource productList);
        void Show();

    }
}
