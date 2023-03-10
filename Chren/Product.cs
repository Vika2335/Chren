namespace Chren
{
    public class Product
    {
        public int CodeProduct { get; set; }
        public string Name { get; set; }
        public string Measure { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        List<EntryInTheInvoice> entry = new List<EntryInTheInvoice>();
        List<OrderLine> line = new List<OrderLine>();
        List<TheProductIsInStock> theProductIsInStocks = new List<TheProductIsInStock>();
    }
}
