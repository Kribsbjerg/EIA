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

        private int indexOfCard;

        private const int _notificationThreshold = 15;

        public VisitationCardListViewModel()
        {

            ApproveVisitation = new RelayCommand(() => ApproveCard());
            DeclineVisitation = new RelayCommand(() => DeclineCard());
            MinimizeVisitationCard = new RelayCommand(() => MinimizeCard());
            SaveNote = new RelayParameterCommand(s => SaveSecretaryNote(s.ToString()));
            GetNextCard = new RelayCommand(() => NextCard());
            //ActivateCombo = new RelayParameterCommand(s => ActivateComboTab((string)s));
            ActiveListButton = new RelayCommand(() => ChangeActiveListState());
            PinnedListButton = new RelayCommand(() => ChangePinnedListState());
            AcuteListButton = new RelayCommand(() => ChangeAcuteListState());
            ActivateNoteDialog = new RelayCommand(() => ActivateNoteCard());
            ShowAcute = new RelayCommand(() => ShowAcuteCards());
        }
        
        /// <summary>
        /// The command for approving a visitationsuggestion
        /// </summary>
        public ICommand ApproveVisitation { get; set; }

        public ICommand GetNextCard { get; set; }

        public ICommand DeclineVisitation { get; set; }

        public ICommand MinimizeVisitationCard { get; set; }
        
        public ICommand TabChange { get; set; }

        public ICommand SaveNote { get; set; }

        public ICommand ActivateCombo { get; set; }

        public ICommand ActiveListButton { get; set; }

        public ICommand PinnedListButton { get; set; }

        public ICommand AcuteListButton { get; set; }

        public ICommand ActivateNoteDialog { get; set; }

        public ICommand ShowAcute { get; set; }

        public string SearchWord { get; set; } = "";

        public int NumberOfActiveVisitations { get; set; }

        public int NumberOfHistoryVisitations { get; set; }

        public int NumberOfPinnedVisitations { get; set; }

        public int NumberOfAcuteVisitations { get; set; }

        public int NumberOfRemainingVisitations { get; set; }

        public ObservableCollection<VisitationOverviewViewModel> ActiveVisitationCards { get; set; }

        public ObservableCollection<VisitationOverviewViewModel> AcuteVisitationCards { get; set; } 

        public ObservableCollection<VisitationOverviewViewModel> HistoryVisitationCards { get; set; } = new ObservableCollection<VisitationOverviewViewModel>();

        public ObservableCollection<VisitationOverviewViewModel> PinnedVisitationCards { get; set; } = new ObservableCollection<VisitationOverviewViewModel>();

        public bool ActiveListActive { get; set; } = true;

        public bool AcuteListActive { get; set; }

        public bool PinnedListActive { get; set; }

        public IEnumerable<VisitationOverviewViewModel> SearchResult => ActiveVisitationCards.Where(c => c.Cpr.Contains(SearchWord));

        public Dictionary<string, ObservableCollection<VisitationOverviewViewModel>> GroupedVisitations { get; set; }

        public bool IsCardSelected { get; set; }

        public bool CardIsClosed { get; set; }

        public bool IsNotDialogMode { get; set; }

        public bool ShowAcuteNotification { get; set; }
        
        public int VisitationCounter { get; set; }

        public VisitationOverviewViewModel SelectedCard
        {
            get { return _selectedCard; }
            set
            {
                CardIsClosed = true;
                _selectedCard = value;
                IsCardSelected = true;
                ChangeSelectedCardInList(); 
            }
        }

        #region Private Methods

        private void ChangeActiveListState()
        {
            ActiveListActive = !ActiveListActive;
            PinnedListActive = false;
            AcuteListActive = false;
        }

        private void ChangePinnedListState()
        {
            PinnedListActive = !PinnedListActive;
            ActiveListActive = false;
            AcuteListActive = false;
        }

        private void ChangeAcuteListState()
        {
            AcuteListActive = !AcuteListActive;
            PinnedListActive = false;
            ActiveListActive = false;
        }

        private void ActivateNoteCard()
        {
            _selectedCard.ChangeNoteFieldState();
        }

        private void SaveSecretaryNote(string s)
        {
            _selectedCard.SecretaryNote = s;
            _selectedCard.NoteReceived = true;
            _selectedCard.IsNoteOpen = false;
            _selectedCard.TextToDisplay = s;
            PinnedVisitationCards.Add(_selectedCard);
            indexOfCard = ActiveVisitationCards.IndexOf(_selectedCard);
            ActiveVisitationCards.Remove(_selectedCard);
            NumberOfRemainingVisitations--;
            NumberOfPinnedVisitations++;
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
            _selectedCard.NeedsTranslator = false;
            indexOfCard = ActiveVisitationCards.IndexOf(SelectedCard);
            MoveCardToHistory();
            NumberOfActiveVisitations--;
            NumberOfHistoryVisitations++;
            NumberOfRemainingVisitations--;
        }

        private void DeclineCard()
        {
            IsNotDialogMode = false;
            _selectedCard.NeedsTranslator = false;
            indexOfCard = ActiveVisitationCards.IndexOf(SelectedCard);
            MoveCardToHistory();
            NumberOfActiveVisitations--;
            NumberOfHistoryVisitations++;
            NumberOfRemainingVisitations--;
        }

        private void NextCard()
        {
            try
            {
                SelectedCard = ActiveVisitationCards[indexOfCard];
            }
            catch (Exception e)
            {
                SelectedCard = ActiveVisitationCards[0];
            }
            ChangeSelectedCardInList();
            _selectedCard.NoteReceived = false;
            IsNotDialogMode = true;
            NotificationRaiser();
        }

        private void MoveCardToHistory()
        {
            _selectedCard.IsActive = false;
            _selectedCard.TextToDisplay = _selectedCard.TreatmentType;
            HistoryVisitationCards.Add(_selectedCard);
            ActiveVisitationCards.Remove(_selectedCard);
        }

        private void NotificationRaiser()
        {
            VisitationCounter++;
            if (VisitationCounter == _notificationThreshold)
                ShowAcuteNotification = true;
        }

        private void ShowAcuteCards()
        {
            AcuteVisitationCards.Add(new VisitationOverviewViewModel()
            {
                Cpr = "1709904353",
                ReferralCause = "Højre og venstre hånds fingre, der sover i hvile, kan vanskeligt holde ved bilrat med begge hænder",
                Diagnose = "Syndroma canalis carpi bilateralis",
                TreatmentType = "CTS - nerveledningsundersøgelse",
                Date = "26. Maj 2017",
                Time = "09:30"
            });
            ShowAcuteNotification = false;
            ChangeAcuteListState();
            SelectedCard = AcuteVisitationCards[1];
        }

        private void ChangeSelectedCardInList()
        {
            foreach (VisitationOverviewViewModel OverviewCard in ActiveVisitationCards)
            {
                if (_selectedCard == OverviewCard)
                {
                    OverviewCard.IsSelected = true;
                }
                else
                    OverviewCard.IsSelected = false;
            }

            foreach (VisitationOverviewViewModel OverviewCard in AcuteVisitationCards)
            {
                if (_selectedCard == OverviewCard)
                {
                    OverviewCard.IsSelected = true;
                }
                else
                    OverviewCard.IsSelected = false;
            }

            foreach (VisitationOverviewViewModel OverviewCard in PinnedVisitationCards)
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
