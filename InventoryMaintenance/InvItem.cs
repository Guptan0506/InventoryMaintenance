using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        public InvItem() { }
        public InvItem(string itemNo, string desc, decimal price)
        {
            ItemNo = itemNo;
            Description = desc;
            Price = price;
        }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string GetDisplayText( string sep )
        {
            return $"{ItemNo}{sep}{Description}{sep}{Price.ToString("c")}";
        }

    }
}
