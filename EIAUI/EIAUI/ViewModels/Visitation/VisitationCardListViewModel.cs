using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIAUI
{
    public class VisitationCardListViewModel : BaseViewModel
    {
        public ObservableCollection<VisitationOverviewViewModel> VisitationCards { get; set; }
    }
}
