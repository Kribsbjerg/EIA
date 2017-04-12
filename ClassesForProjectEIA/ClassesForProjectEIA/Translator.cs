using System.Collections.Generic;

namespace ClassesForProjectEIA
{
    class Translator
    {
        #region Constructors
        /// <summary>
        /// The default constructor
        /// </summary>
        /// <param name="needTranslator"></param>
        /// <param name="arrayOfLanguages"></param>
        public Translator(bool needTranslator, params string[] arrayOfLanguages)
        {
            NeedTranslator = needTranslator;

            foreach (string language in arrayOfLanguages)
                LanguageList.Add(language);
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Checks if the patient needs a translator
        /// </summary>
        public bool CheckIfTranslatorIsNeed { get; set; }
        /// <summary>
        /// This property will hold a true value if the patient needs a translator
        /// </summary>
        public bool NeedTranslator { get; set; }
        /// <summary>
        /// The list of languages the patient can speak
        /// </summary>
        public List<string> LanguageList = new List<string>();

        #endregion
    }
}
