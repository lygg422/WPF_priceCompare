using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_PriceCompare.ViewModels
{
   public  class MainWindowVModel
    {
        public string Type { get; set; }

        public string Filter { get; set; }
        /// <summary>
        /// 道具名称
        /// </summary>
        public string ItemName { get; set; }

        public double Price { get; set; }
    }
}
