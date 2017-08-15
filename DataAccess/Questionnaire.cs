using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Questionnaire
    {
        [Key,ForeignKey("Order")]
        public int OrderID { get; set; }

        public string LastBalanced { get; set; }

        public string FinalRegisterBalance { get; set; }

        public string FinalRegisterDate { get; set; }

        public string ErrorCorrection { get; set; }

        public virtual Order Order { get; set; }
    }
}
