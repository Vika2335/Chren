namespace Chren
{
    public class Warehouse
    {
        public int Number { get; set; }
        public string Address { get; set; }
        List<TheProductIsInStock> theProductIsInStocks= new List<TheProductIsInStock>();
        List<Employee> employee = new List<Employee>();
    }
}
