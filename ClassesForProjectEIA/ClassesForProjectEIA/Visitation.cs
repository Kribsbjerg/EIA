using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Visitation
    {
        #region Private Members

        private List<VisitationSuggestion> VisitationSuggestionList { get; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a visitation suggestion to a list
        /// </summary>
        /// <param name="visitationSuggestion"></param>
        public void AddVisitationSuggestion(VisitationSuggestion visitationSuggestion)
        {
            VisitationSuggestionList.Add(visitationSuggestion);
        }

        #endregion

    }
}
