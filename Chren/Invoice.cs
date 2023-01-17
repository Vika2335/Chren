namespace Chren

{
    public enum StatusInvoice { Fresh, Issued, Paused, Ready, Shipped }
    public class Invoice : Document
    {
        StatusInvoice Status;
        public DateTime DateTimeShipment { get; set; }
        public double Sum { get; set; }
        public double Weight { get; set; }
        public string Note { get; set; }
        public string RecipientFullName { get; set; }
        List<EntryInTheInvoice> entry = new List<EntryInTheInvoice>();
        List<Order> order = new List<Order>();
        List<Employee> employee = new List<Employee>();
    }
}
