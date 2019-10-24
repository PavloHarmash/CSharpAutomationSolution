namespace Yukon.Models.Translation
{
    public class TranslationLibraryModel
    {
        public RegistrationHeader RegistrationHeader { get; set; }
        public ApplicationHeader ApplicationHeader { get; set; }
        public Breadcrumbs Breadcrumbs { get; set; }
        public LogInModal LogInModal { get; set; }
    }

    public class RegistrationHeader
    {
        public string LogInButton { get; set; }
    }

    public class ApplicationHeader
    {
        public string SearchDropDown { get; set; }
        public string ManageDropDown { get; set; }
        public string ProfileDropDown { get; set; }
        public string ExitButton { get; set; }
    }

    public class Breadcrumbs
    {
        public string TaskSearch { get; set; }
    }

    public class LogInModal
    {
        public string LogInHeader { get; set; }
    }
}
