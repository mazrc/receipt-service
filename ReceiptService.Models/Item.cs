namespace ReceiptService {
    class Item {
            public int type { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public double price { get; set; }
            public int quantity { get; set; }
            public bool imported = false;
    }
}