using System;
using System.Collections.Generic;

namespace ReceiptService {
    class Cart {
        public int Number { get; set; }
        public IList<Item> Items = new List<Item>();

        internal void Add(Item item)
        {
            Items.Add(item);
        }
    }
}
