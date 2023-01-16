namespace Chren
{
    public enum PositionList { Storekeeper, Manager, ResponsiblePerson}
    public class Employee
    {
        PositionList Status;
        public int Number { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
