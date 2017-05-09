using System.Collections.Generic;
using System.Linq;

namespace ClassesForProjectEIA
{
    class Translator
    {
        #region Private Members

        /// <summary>
        /// The list of languages the patient can speak
        /// </summary>
        private List<string> LanguageList = new List<string>();

        #endregion

        #region Constructors
        /// <summary>
        /// The default constructor
        /// </summary>
        /// <param name="needTranslator"></param>
        /// <param name="arrayOfLanguages"></param>
        public Translator(bool needTranslator, params string[] arrayOfLanguages)
        {
            NeedTranslator = needTranslator;
            LanguageList = arrayOfLanguages.ToList();
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// This property will hold a true value if the patient needs a translator
        /// </summary>
        public bool NeedTranslator { get; set; }

        /// <summary>
        /// Gets all languages the patients speaks
        /// </summary>
        public List<string> Languages => LanguageList;

        #endregion
    }
}
