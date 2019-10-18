namespace CSharpAutomationSolution.Models.Configs
{
    public class UsersConfigsModel
    {
        public Customer Customer { get; set; }
        public Implementer Implementer { get; set; }
    }

    public class Customer
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Implementer
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
