using Xunit;

namespace ReceiptService.Tests
{
    public class TestTaxExempt
    {
        [Fact]
        public void Test1()
        {
            /**
             * Item 1 - Food
             */
            Item item1 = new Item();
            item1.id = 1;
            item1.type = 1;
            item1.name = "Cucumber";
            item1.price = 1.25;
            item1.quantity = 1;

            var receiptPrinter = new PrintReceipt();

            //Assert
            Assert.True(receiptPrinter.TaxExempt(item1));
        }
    }

    public class TestNotTaxExempt
    {
        [Fact]
        public void Test1()
        {
            /**
             * Item 2 - Electronics
             */
            Item item2 = new Item();
            item2.id = 1;
            item2.type = 33;
            item2.name = "Laptop";
            item2.price = 1350;
            item2.quantity = 1;

            var receiptPrinter = new PrintReceipt();

            //Assert
            Assert.False(receiptPrinter.TaxExempt(item2));
        }
    }
}
