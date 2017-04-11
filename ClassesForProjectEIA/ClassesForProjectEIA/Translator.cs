using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Translator
    {
        public bool CheckIfTranslatorIsNeed { get; set; }
        public bool NeedTranslator { get; set; }
        public List<string> LanguageList = new List<string>();

        public Translator(bool needTranslator, params string[] arrayOfLanguages)
        {
            NeedTranslator = needTranslator;

            foreach (string language in arrayOfLanguages)
                LanguageList.Add(language);
        }
    }
}
