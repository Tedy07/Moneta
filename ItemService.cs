using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneta
{
    public class ItemService
    // zawiera metody do manipulacji danymi związanymi z obiektem danej classy.
    {
        public List<Item> Items {  get; set; }
        //lista produktów, które będziemy dodawać, odejmować i inne rzeczy

        public List<Item> GetAllItems()
        {
             return Items; 
        }

        public int AddNewItem()
        {
            Item item = new Item()
            {
                Id = 1,
                Name = "Liść Klonowy"
            };

            Items.Add(item);
        }

    }
}
