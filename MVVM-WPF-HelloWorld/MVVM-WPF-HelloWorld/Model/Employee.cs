namespace MVVM_WPF_HelloWorld.Model
{
    public class Employee
    {
        public static Employee CreateEmployee(string firstname, string lastname)
        {
            return new Employee { FirstName = firstname, LastName = lastname };
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
