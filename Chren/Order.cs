namespace Chren
{
    public enum StatusOrder { Fresh, Paid, Canceled }
    public class Order
    {
        StatusOrder Status;
        public DateTime DateShipment { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Price { get; set; }
        public static void Cancel() { }
        List<OrderLine> line = new List<OrderLine>();
        public Invoice InvoiceInvoice { get; set; }
        List<Employee> employee = new List<Employee>();
        public Employee Manager { get; set; }
    }
}
