using System;
using System.Collections.Generic;
// using Newtonsoft.Json;

namespace ReceiptService
{
    public class PrintReceipt
    {
        static void Main(string[] args)
        {
            var data = new Database();
            var receiptPrinter = new PrintReceipt();

            var cart1 = data.GetShoppingCart1();
            var cart2 = data.GetShoppingCart2();
            var cart3 = data.GetShoppingCart3();

            Console.WriteLine("\n\n\n\n\n Dynamo Store");

            receiptPrinter.CalculateAndPrint(cart1);
            receiptPrinter.CalculateAndPrint(cart2);
            receiptPrinter.CalculateAndPrint(cart3);
        }

        


        /**
         * Tax Exempt Items
         * TODO: externalize to database
         */
        List<int> taxExemptTypes = new List<int>() { 1, 34, 5, 19 };

        void CalculateAndPrint(Cart cart)
        {
            int i = 0;
            Console.WriteLine("Receipt {0}: ", cart.Number);
            double totalSalesTax = 0.0;
            double totalCost = 0;

            foreach (Item item in cart.Items)
            {
                double tax = 0;

                if (item.imported && TaxExempt(item))
                {
                    tax += Math.Ceiling(item.price * .05 * 20) / 20;
                }
                else if (item.imported && !TaxExempt(item))
                {
                    tax += Math.Ceiling(item.price * .15 * 20) / 20;
                }
                else if (!TaxExempt(item))
                {
                    tax += Math.Ceiling(item.price * .10 * 20) / 20;
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
                Console.WriteLine(item.quantity + " " + item.name + ": " + item.price.ToString("0.##"));
            }
            Console.WriteLine("Sales Taxes: " + totalSalesTax.ToString("0.##") + "\nTotal: " + totalCost.ToString("#.##") + "\n");
        }

        internal bool TaxExempt(Item item)
        {
            bool result = taxExemptTypes.IndexOf(item.type) == -1 ? false : true;
            return result;
        }
    }
}
