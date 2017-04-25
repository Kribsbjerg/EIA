using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Visitation
    {
        private List<VisitationSuggestion> VisitationSuggestionList { get; }
        

        public void AddVisitationSuggestion(VisitationSuggestion visitationSuggestion)
        {
            VisitationSuggestionList.Add(visitationSuggestion);
        }

    }
}
