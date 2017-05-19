using System;
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

        private VisitationOverviewViewModel _dummyCard = new VisitationOverviewViewModel() { Cpr = "" };

        private int indexOfCard;

        public VisitationCardListViewModel()
        {
            ApproveVisitation = new RelayCommand(() => ApproveCard());
            DeclineVisitation = new RelayCommand(() => DeclineToNextCard());
            MinimizeVisitationCard = new RelayCommand(() => MinimizeCard());
            SaveNote = new RelayParameterCommand(s => SaveSecretaryNote((string)s));
            GetNextCard = new RelayCommand(() => NextCard());

        }
        
        public ICommand ApproveVisitation { get; set; }

        public ICommand GetNextCard { get; set; }

        public ICommand DeclineVisitation { get; set; }

        public ICommand MinimizeVisitationCard { get; set; }

        public ICommand TabChange { get; set; }

        public ICommand SaveNote { get; set; }

        public string SearchWord { get; set; } = "";

        public int NumberOfActiveVisitations { get; set; }

        public int NumberOfHistoryVisitations { get; set; } 

        public ObservableCollection<VisitationOverviewViewModel> ActiveVisitationCards { get; set; }

        public ObservableCollection<VisitationOverviewViewModel> HistoryVisitationCards { get; set; }

        public IEnumerable<VisitationOverviewViewModel> SearchResult => ActiveVisitationCards.Where(c => c.Cpr.Contains(SearchWord));

        public IEnumerable<IGrouping<string, VisitationOverviewViewModel>> DiagnosisGroup => ActiveVisitationCards.GroupBy(c => c.TreatmentType);

        public bool IsCardSelected { get; set; }

        public bool CardIsClosed { get; set; }

        public bool IsNotDialogMode { get; set; }

        public VisitationOverviewViewModel SelectedCard
        {
            get { return _selectedCard; }
            set
            {
                CardIsClosed = true;
                _selectedCard = value;
                IsCardSelected = true;
                ChangeSelectedCardInList(ActiveVisitationCards); 
            }
        }

        #region Private Methods

        private void SaveSecretaryNote(string s)
        {
            _selectedCard.SecretaryNote = s;
            // Should save to pinned list here for now it just deletes the card
            DeclineToNextCard();

        }

        private void MinimizeCard()
        {
            SelectedCard = null;
            CardIsClosed = false;
            IsCardSelected = false;
        }

        private void ApproveCard()
        {
            indexOfCard = ActiveVisitationCards.IndexOf(SelectedCard);
            MoveCardToHistory();
            NumberOfActiveVisitations--;
            NumberOfHistoryVisitations++;
        }

        private void NextCard()
        {
            SelectedCard = ActiveVisitationCards[indexOfCard];
            ChangeSelectedCardInList(HistoryVisitationCards);
        }

        private void DeclineToNextCard()
        {
            indexOfCard = ActiveVisitationCards.IndexOf(SelectedCard);
            ActiveVisitationCards.Remove(_selectedCard);
            NumberOfActiveVisitations--;
        }

        private void MoveCardToHistory()
        {
            HistoryVisitationCards.Add(_selectedCard);
            ActiveVisitationCards.Remove(_selectedCard);
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
