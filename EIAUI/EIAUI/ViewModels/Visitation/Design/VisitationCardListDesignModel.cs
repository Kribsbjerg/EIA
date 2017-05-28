using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EIAUI
{
    /// <summary>
    /// The design-time data for a <see cref="VisitationCardListDesignModel"/> 
    /// </summary>
    public class VisitationCardListDesignModel : VisitationCardListViewModel
    {

        #region Public Properties

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static VisitationCardListDesignModel Instance => new VisitationCardListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public VisitationCardListDesignModel()
        {
            FileHandler patientDocument = new FileHandler(@"../../../Data.csv");

            ActiveVisitationCards = new ObservableCollection<VisitationOverviewViewModel>();
            AcuteVisitationCards = new ObservableCollection<VisitationOverviewViewModel>();

            IEnumerable<string[]> referralList = patientDocument.GetCellsInLinesOfFile(';').Skip(1);

            foreach (string[] referral in referralList)
            {
                
                    ActiveVisitationCards.Add
                        (
                            new VisitationOverviewViewModel()
                            {
                                Cpr = referral[0],
                                Diagnose = referral[2],
                                ReferralCause = referral[3],
                                TreatmentType = referral[4],
                                TextToDisplay = referral[4],
                                Date = referral[5],
                                Time = referral[6],
                                Doctor = referral[7],
                                NeedsTranslator = referral[10].Equals("1"),
                                Category = referral[12],
                            }
                        );

            }

            foreach (var visitation in ActiveVisitationCards)
            {
                if (visitation.Category.Equals("1"))
                {
                    AcuteVisitationCards.Add(visitation);
                }
            }

            foreach (var visitation in AcuteVisitationCards)
            {
                ActiveVisitationCards.Remove(visitation);
            }

            HistoryVisitationCards = new ObservableCollection<VisitationOverviewViewModel>();

            NumberOfHistoryVisitations = HistoryVisitationCards.Count;
            NumberOfAcuteVisitations = AcuteVisitationCards.Count;
            NumberOfRemainingVisitations = ActiveVisitationCards.Count;
            NumberOfActiveVisitations = ActiveVisitationCards.Count + AcuteVisitationCards.Count;
        }

        #endregion
    }
}
