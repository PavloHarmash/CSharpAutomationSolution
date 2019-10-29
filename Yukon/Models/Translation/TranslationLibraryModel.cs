using Yukon.Models.Translation.Headers;
using Yukon.Models.Translation.Headers.Dropdowns;
using Yukon.Models.Translation.Modals.HeaderModals;
using Yukon.Models.Translation.Tasks;

namespace Yukon.Models.Translation
{
    public class TranslationLibraryModel
    {
        public RegistrationHeader RegistrationHeader { get; set; }
        public ApplicationHeader ApplicationHeader { get; set; }
        public LogInModal LogInModal { get; set; }
        public MessageAccessModal MessageAccessModal { get; set; }
        public SearchDropDown SearchDropDown { get; set; }
        public ManageDropDown ManageDropDown { get; set; }
        public ProfileDropDown ProfileDropDown { get; set; }
        public TasksPage TasksPage { get; set; }
        public CreateTaskPage CreateTaskPage { get; set; }
    }
}
