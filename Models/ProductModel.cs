using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PrGer.Models
{
    internal class ProductModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "o campo identifixador é obrigatório ")]
        public string identifier { get; set; }
        [Required(ErrorMessage = "o campo description é obrigatório ")]
        public string description { get; set; }
        [Required(ErrorMessage = "o campo descriptionEN é obrigatório ")]
        public string descriptionEN { get; set; }
        [Required(ErrorMessage = "o campo preço é obrigatório ")]
        public double price { get; set; }
        [Required(ErrorMessage = "o campo unidade é obrigatório ")]
        public string unit { get; set; }
        [Required(ErrorMessage = "o campo availableSTK é obrigatório ")]
        public int availableSTK { get; set; }
        [Required(ErrorMessage = "o campo vat é obrigatório ")]
        public int vat { get; set;}
        [Required(ErrorMessage = "o campo inative é obrigatório ")]
        public bool inactive { get; set; }
        public int remoteId { get; set; }


    }
}
