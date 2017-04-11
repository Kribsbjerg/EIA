using System.Collections.Generic;

namespace ClassesForProjectEIA
{
    class Translator
    {
        #region Properties

        public bool CheckIfTranslatorIsNeed { get; set; }
        public bool NeedTranslator { get; set; }
        public List<string> LanguageList = new List<string>();

        #endregion

        #region Constructors

        public Translator(bool needTranslator, params string[] arrayOfLanguages)
        {
            NeedTranslator = needTranslator;

            foreach (string language in arrayOfLanguages)
                LanguageList.Add(language);
        }

        #endregion
    }
}
