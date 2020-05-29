using System;
using System.Collections.Generic;
// using Newtonsoft.Json;

namespace ReceiptService
{
    public class PrintReceipt
    {
        static void Main(string[] args)
        {
            var receiptPrinter = new PrintReceipt();
            Console.WriteLine("OshCosh Store \n");

            var shoppingCart = receiptPrinter.CreateShoppingCart();
            receiptPrinter.CalculateAndPrint(shoppingCart);
        }

        List<Item> CreateShoppingCart()
        {
            List<Item> shoppingCart = new List<Item>();

            /**
             * Item 1 - Food
             */
            Item item1 = new Item();
            item1.id = 1;
            item1.type = 1;
            item1.name = "Cucumber";
            item1.price = 1;
            item1.quantity = 1;

            /**
             * Item 1 - Electronics
             */
            Item item2 = new Item();
            item2.id = 2;
            item2.type = 33;
            item2.name = "Laptop";
            item2.price = 100;
            item2.quantity = 1;

            shoppingCart.Add(item1);
            shoppingCart.Add(item2);
            return shoppingCart;
        }


        /**
         * Tax Exempt Items
         * TODO: externalize to database
         */
        List<int> taxExemptTypes = new List<int>() { 1, 34, 5, 19 };

        void CalculateAndPrint(List<Item> cart)
        {

            int i = 0;
            Console.WriteLine("Receipt {0}: ", ++i);
            double totalSalesTax = 0.0;
            double totalCost = 0;

            foreach (Item item in cart)
            {
                double tax = 0;

                if (!TaxExempt(item))
                {
                    tax = NewMethod(item, tax);
                }

                item.price += tax;
                if (item.quantity > 1)
                {
                    totalCost += item.price * item.quantity;
                    totalSalesTax += tax * item.quantity;
                }
                else
                {
                    totalCost += item.price;
                    totalSalesTax += tax;
                }
                Console.WriteLine(item.quantity + " " + item.name + ": " + item.price.ToString("F"));
            }
            Console.WriteLine("Sales Taxes: " + totalSalesTax.ToString("F") + "\nTotal: " + totalCost.ToString("F") + "\n");

            static double NewMethod(Item item, double tax)
            {
                tax += Math.Ceiling(item.price * .15 * 20) / 20;
                return tax;
            }
        }

        internal bool TaxExempt(Item item)
        {
            bool result = taxExemptTypes.IndexOf(item.type) == -1 ? false : true;
            return result;
        }
    }
}
