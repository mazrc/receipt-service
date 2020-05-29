using System;
using System.Collections.Generic;

namespace ReceiptService {
    class Cart {
        public DateTime createdDate { get; set; }
        public IList<Item> items { get; set; }
    }
}

