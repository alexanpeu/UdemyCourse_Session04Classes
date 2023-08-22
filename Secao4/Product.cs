using System.Globalization;

namespace Secao4
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalValueStock()
        {
            return Price * Quantity;
        }

        public void AddQuantity(int quantity)
        {
            Quantity += quantity; 
        }

        public void SubtractQuantity(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
                + ", $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " unity, Total: $ "
                + TotalValueStock().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
