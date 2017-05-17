﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EIAUI
{
    public class VisitationCardListViewModel : BaseViewModel
    {
        private VisitationOverviewViewModel _selectedCard;

        public VisitationCardListViewModel()
        {
            ApproveVisitation = new RelayCommand(() => ApproveToNextCard());
            MinimizeVisitationCard = new RelayCommand(() => SelectedCard = null);
        }

        public ICommand ApproveVisitation { get; set; }

        public ICommand MinimizeVisitationCard { get; set; }

        public ICommand TabChange { get; set; }

        public string SearchWord { get; set; } = "";

        public ObservableCollection<VisitationOverviewViewModel> ActiveVisitationCards { get; set; }

        public ObservableCollection<VisitationOverviewViewModel> HistoryVisitationCards { get; set; }

        public IEnumerable<VisitationOverviewViewModel> SearchResult => ActiveVisitationCards.Where(c => c.Cpr.Contains(SearchWord));

        public IEnumerable<IGrouping<string, VisitationOverviewViewModel>> DiagnosisGroup => ActiveVisitationCards.GroupBy(c => c.TreatmentType);

        public bool IsCardSelected => SelectedCard != null;

        public VisitationOverviewViewModel SelectedCard
        {
            get { return _selectedCard; }
            set
            {
                _selectedCard = value;
                ChangeSelectedCardInList(ActiveVisitationCards);
            }
        }

        #region Private Methods

        private void ApproveToNextCard()
        {
            int indexOfCard = ActiveVisitationCards.IndexOf(SelectedCard);
            MoveCardToHistory();
            SelectedCard = ActiveVisitationCards[indexOfCard];
        }

        private void MoveCardToHistory()
        {
            HistoryVisitationCards.Add(_selectedCard);
            ActiveVisitationCards.Remove(_selectedCard);
            ChangeSelectedCardInList(HistoryVisitationCards);
        }

        private void ChangeSelectedCardInList(ObservableCollection<VisitationOverviewViewModel> t)
        {
            //ActiveVisitationCards.Single(c => c.Cpr == _selectedCard.Cpr).IsSelected = true;

            foreach (VisitationOverviewViewModel OverviewCard in t)
            {
                if (_selectedCard == OverviewCard)
                {
                    OverviewCard.IsSelected = true;
                }
                else
                    OverviewCard.IsSelected = false;
            }
        }

        #endregion


    }
}
