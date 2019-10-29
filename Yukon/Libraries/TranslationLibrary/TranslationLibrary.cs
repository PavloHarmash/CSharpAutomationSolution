using Yukon.Enums;
using Yukon.Models.Translation;
using Yukon.Utility.Helpers;

namespace Yukon.Libraries.TranslationLibrary
{
    public class TranslationLibrary
    {
        public static AppLanguage AppLanguage { get; set; }

        public TranslationLibraryModel Library { get; }

        public TranslationLibrary(AppLanguage language)
        {
            AppLanguage = language;

            switch (AppLanguage)
            {
                case AppLanguage.English:
                    Library = JsonHelper.DeserializeJson<TranslationLibraryModel>(
                        @"Libraries\TranslationLibrary\EnglishVersion.json");
                    break;
                case AppLanguage.Russian:
                    Library = JsonHelper.DeserializeJson<TranslationLibraryModel>(
                        @"Libraries\TranslationLibrary\RussianVersion.json");
                    break;
                default:
                    break;
            }
        }
    }
}
