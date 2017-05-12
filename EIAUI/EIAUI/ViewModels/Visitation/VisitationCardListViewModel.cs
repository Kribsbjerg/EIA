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
        private VisitationOverviewViewModel _selectedCard;
        private bool _isCardSelected;

        public ObservableCollection<VisitationOverviewViewModel> VisitationCards { get; set; }

        public bool IsCardSelected => SelectedCard != null;

        public VisitationOverviewViewModel SelectedCard
        {
            get
            {
                return _selectedCard;
            }
            set
            {
                //System.Windows.Forms.MessageBox.Show(value.Cpr.ToString());
                _selectedCard = value;
                _isCardSelected = true;
            }
        }
    }
}
