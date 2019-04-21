using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_PriceCompare.Models
{
    class PriceNote
    {
        public string  ItemName {get;set;}

        public double Price { get; set; }

        public int TypeId { get; set; }

        public  string Remark { get; set; }
    }
}
