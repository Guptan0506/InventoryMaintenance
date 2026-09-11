using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // this class demonstrates encapsulation by grouping the data of the item
    // and related methods into one class and can be accessed using
    // properties
    public class InvItem
    {
        // Navya Gupta
        // this gets rid of the default constructor
        public InvItem() { }

        // the constructor expects three pieces of info, in that order
        public InvItem(int itemNo, string desc, decimal price)
        {
            // constructor saves the values it collects in properties
            ItemNo = itemNo;
            Description = desc;
            Price = price;
        }
        // get and set take the value and assign it to the hidden variable for you.
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // sep adds a separator to the text displayed
        public string GetDisplayText( string sep )
        {
            // c means currency. It would format price as currency
            return $"{ItemNo}{sep}{Description}{sep}{Price.ToString("c")}";
        }

    }
}
