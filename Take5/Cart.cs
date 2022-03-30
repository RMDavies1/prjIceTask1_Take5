namespace Take5
{
    internal class Cart : Item
    {
        double grandTotal, vatPercent;
        public Cart(double v, double total)
        {
            VAT = v;
            Total = total;
        }

        public double VAT { get; }
        public double Total { get; }

        public void Calculate()
        {
            this.vatPercent = this.Total * 0.14;
            this.grandTotal = this.Total * this.VAT;
        }

        public string Display(string str)
        {
            string strDisplay = str + "---------------\n" +
                "Total R " + this.Total.ToString("F") + "\n+ " +
                "VAT R " + this.vatPercent.ToString("F") + "\n" +
                "-------------------\n" +
                "Grand Total: R " + this.grandTotal.ToString("F");
            return strDisplay;
        }
    }
}