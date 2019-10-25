using System;
using Yukon.Models.Translation;
using Yukon.TestCases.UITests;
using Yukon.Utility.Helpers;
using Yukon.Enums;

namespace Yukon.Libraries.TranslationLibrary
{
    public static class TranslationLibrary
    {
        private static readonly Func<TranslationLibraryModel, TranslationLibraryModel> LibraryModel = model =>
        {
            switch (UIBaseTest.AppLanguage)
            {
                case AppLanguage.English:
                    return JsonHelper.DeserializeJson<TranslationLibraryModel>(
                        @"Libraries\TranslationLibrary\EnglishVersion.json");
                case AppLanguage.Russian:
                    return JsonHelper.DeserializeJson<TranslationLibraryModel>(
                        @"Libraries\TranslationLibrary\RussianVersion.json");
                default:
                    break;
            }

            return null;
        };

        public static readonly TranslationLibraryModel PageText = LibraryModel(PageText);
    }
}
