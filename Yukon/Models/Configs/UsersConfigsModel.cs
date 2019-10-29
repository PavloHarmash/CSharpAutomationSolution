namespace Yukon.Models.Configs
{
    public class UsersConfigsModel
    {
        public Customer Customer { get; set; }
        public Contractor Contractor { get; set; }
    }

    public class Users
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string MessageLogPassword { get; set; }
        public string Hint { get; set; }
    }

    public class Customer : Users
    {
    }

    public class Contractor : Users
    {
    }
}
