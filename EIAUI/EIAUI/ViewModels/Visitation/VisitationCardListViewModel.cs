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

        private string Categorystring;

        private int indexOfCard;

        public VisitationCardListViewModel()
        {
            ApproveVisitation = new RelayCommand(() => ApproveCard());
            DeclineVisitation = new RelayCommand(() => DeclineCard());
            MinimizeVisitationCard = new RelayCommand(() => MinimizeCard());
            SaveNote = new RelayParameterCommand(s => SaveSecretaryNote((string)s));
            GetNextCard = new RelayCommand(() => NextCard());
            ActivateCombo = new RelayParameterCommand(s => ActivateComboTab((string)s));
        }
        
        public ICommand ApproveVisitation { get; set; }

        public ICommand GetNextCard { get; set; }

        public ICommand DeclineVisitation { get; set; }

        public ICommand MinimizeVisitationCard { get; set; }
        
        public ICommand TabChange { get; set; }

        public ICommand SaveNote { get; set; }

        public ICommand ActivateCombo { get; set; }

        public string SearchWord { get; set; } = "";

        public int NumberOfActiveVisitations { get; set; }

        public int NumberOfHistoryVisitations { get; set; }

        public ObservableCollection<VisitationOverviewViewModel> ActiveVisitationCards { get; set; }



        public ObservableCollection<VisitationOverviewViewModel> HistoryVisitationCards { get; set; }

        public ObservableCollection<VisitationOverviewViewModel> PinnedCards { get; set; }

        public IEnumerable<VisitationOverviewViewModel> SearchResult => ActiveVisitationCards.Where(c => c.Cpr.Contains(SearchWord));

        //public IEnumerable<IGrouping<string, VisitationOverviewViewModel>> DiagnosisGroup { get; set; } 

        public Dictionary<string, ObservableCollection<VisitationOverviewViewModel>> GroupedVisitations { get; set; }

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

        private void ActivateComboTab(string s)
        {
            Categorystring = s;

            Dictionary<string, ObservableCollection<VisitationOverviewViewModel>> TempGrouping = ActiveVisitationCards
                                                                                                        .OrderBy(x => x.Category != "Akutte Visitationer")
                                                                                                        .ThenBy(x => x.Category != "Gemte Visitationer")
                                                                                                        .ThenBy(x => x.Category)
                                                                                                        .GroupBy(c => c.Category)
                                                                                                        .OrderBy(x => x.Key != "Akutte Visitationer")
                                                                                                        .ThenBy(x => x.Key != "Gemte Visitationer")
                                                                                                        .ThenBy(x => x.Key)
                                                                                                        .ToDictionary(group => group.Key, group => new ObservableCollection<VisitationOverviewViewModel>(group.ToList()));

            foreach (var item in TempGrouping)
            {
                if(!item.Key.Equals(s))
                    item.Value.Clear();
            }

            GroupedVisitations = TempGrouping;
        }

        private void SaveSecretaryNote(string s)
        {
            _selectedCard.SecretaryNote = s;
            _selectedCard.NoteReceived = true;
            _selectedCard.IsNoteOpen = false;
            // Should save to pinned list here for now it just deletes the card
            //PinnedCards.Add(_selectedCard);
            indexOfCard = ActiveVisitationCards.IndexOf(_selectedCard);
            _selectedCard.Category = "Gemte Visitationer";
            ActivateComboTab(Categorystring);
            NextCard();
        }

        private void MinimizeCard()
        {
            SelectedCard = null;
            CardIsClosed = false;
            IsCardSelected = false;
        }

        private void ApproveCard()
        {
            IsNotDialogMode = false;
            indexOfCard = ActiveVisitationCards.IndexOf(SelectedCard);
            MoveCardToHistory();
            NumberOfActiveVisitations--;
            NumberOfHistoryVisitations++;
        }

        private void DeclineCard()
        {
            IsNotDialogMode = false;
            indexOfCard = ActiveVisitationCards.IndexOf(SelectedCard);
            ActiveVisitationCards.Remove(_selectedCard);
            NumberOfActiveVisitations--;
            ActivateComboTab(Categorystring);
        }

        private void NextCard()
        {
            // Make logic for every situation - Deselect if done with category
            //if(GroupedVisitations[Categorystring].Count == 2 && indexOfCard == 1)
            SelectedCard = ActiveVisitationCards[indexOfCard];
            ChangeSelectedCardInList(ActiveVisitationCards);
            _selectedCard.NoteReceived = false;
            IsNotDialogMode = true;
        }

        private void MoveCardToHistory()
        {
            HistoryVisitationCards.Add(_selectedCard);
            ActiveVisitationCards.Remove(_selectedCard);
            ActivateComboTab(Categorystring);
            //GroupedVisitations = ActiveVisitationCards.GroupBy(c => c.TreatmentType).ToDictionary(group => group.Key, group => new ObservableCollection<VisitationOverviewViewModel>(group.ToList()));
        }

        private void ChangeSelectedCardInList(ObservableCollection<VisitationOverviewViewModel> t)
        {
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

        private void ChangeSelectedCardInList()
        {
            foreach (var item in GroupedVisitations)
            {
                item.Value.FirstOrDefault(x => x ==_selectedCard);
            }
        }

        #endregion


    }
}
