namespace Yukon.Models.Configs
{
    public class UsersConfigsModel
    {
        public Customer Customer { get; set; }
        public Supplier Supplier { get; set; }
    }

    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string MessageLogPassword { get; set; }
        public string Hint { get; set; }
    }

    public class Customer : User
    {
    }

    public class Supplier : User
    {
    }
}
