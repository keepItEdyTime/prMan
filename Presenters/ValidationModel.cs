using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrGer.Presenters
{
    internal class ValidationModel
    {
        public void validate (object model) {
            string errMsg = "";
            List<ValidationResult> rs = new List<ValidationResult>();
            ValidationContext ctx = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, ctx, rs, true);
            if (!isValid)
            {
                foreach(var item in rs) { 
                    errMsg+= "-"+item.ErrorMessage+";\n";
                }
              
                throw new Exception(errMsg);
            }
        }    
    }
}
