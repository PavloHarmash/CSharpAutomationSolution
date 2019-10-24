using Yukon.Models.Translation;
using Yukon.Utility.Helpers;

namespace Yukon.Libraries.TranslationLibrary
{
    public static class TranslationLibrary
    {
        public static readonly TranslationLibraryModel TranslationFor
            = JsonHelper.DeserializeJson<TranslationLibraryModel>(@"Libraries\TranslationLibrary\RussianVersion.json");
    }
}
