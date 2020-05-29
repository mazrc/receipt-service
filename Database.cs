using System;
using System.Collections.Generic;

namespace ReceiptService
{
    public class Database
    {
        // Shopping Cart1

        internal Cart GetShoppingCart1()
        {
            Cart shoppingCart = new Cart
            {
                Number = 1
            };

            /**
             * Item 1 - Book
             */
            Item item1 = new Item();
            item1.id = 1;
            item1.type = 1;
            item1.name = "book";
            item1.price = 12.49;
            item1.quantity = 1;

            /**
             * Item 2 - Music CD
             */
            Item item2 = new Item();
            item2.id = 2;
            item2.type = 33;
            item2.name = "music CD";
            item2.price = 14.99;
            item2.quantity = 1;

            /**
             * Item 3 - Music CD
             */
            Item item3 = new Item();
            item3.id = 2;
            item3.type = 1;
            item3.name = "chocolate bar";
            item3.price = 0.85;
            item3.quantity = 1;

            shoppingCart.Add(item1);
            shoppingCart.Add(item2);
            shoppingCart.Add(item3);
            return shoppingCart;
        }

        // Shopping Cart2

        internal Cart GetShoppingCart2()
        {
            Cart shoppingCart = new Cart
            {
                Number = 2
            };

            /**
             * Item 1 - imported box of chocolates
             */
            Item item1 = new Item();
            item1.id = 1;
            item1.type = 1;
            item1.name = "imported box of chocolates";
            item1.price = 10.00;
            item1.quantity = 1;
            item1.imported = true;

            /**
             * Item 2 - Music CD
             */
            Item item2 = new Item();
            item2.id = 2;
            item2.type = 54;
            item2.name = "imported bottle of perfume ";
            item2.price = 47.50;
            item2.quantity = 1;
            item2.imported = true;

            shoppingCart.Add(item1);
            shoppingCart.Add(item2);

            return shoppingCart;
        }

        // Shopping Cart3

        internal Cart GetShoppingCart3()
        {
            Cart shoppingCart = new Cart
            {
                Number = 3
            };

            /**
             * Item 1 - imported bottle of perfume
             */
            Item item1 = new Item();
            item1.id = 1;
            item1.type = 55;
            item1.name = "imported bottle of perfume";
            item1.price = 27.99;
            item1.quantity = 1;
            item1.imported = true;

            /**
             * Item 2 - bottle of perfume
             */
            Item item2 = new Item();
            item2.id = 2;
            item2.type = 54;
            item2.name = "bottle of perfume";
            item2.price = 18.99;
            item2.quantity = 1;

            /**
             * Item 3 - packet of headache pills 
             */
            Item item3 = new Item();
            item3.id = 3;
            item3.type = 1;
            item3.name = "bottle of perfume";
            item3.price = 9.97;
            item3.quantity = 1;

            /**
             * Item 4 - bottle of perfume
             */
            Item item4 = new Item();
            item4.id = 4;
            item4.type = 1;
            item4.name = "box of imported chocolates ";
            item4.price = 11.25;
            item4.quantity = 1;
            item4.imported = true;


            shoppingCart.Add(item1);
            shoppingCart.Add(item2);
            shoppingCart.Add(item3);
            shoppingCart.Add(item4);

            return shoppingCart;
        }
    }
}
