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
                            Date = referral[5],
                            Time = referral[6],
                            Doctor = referral[7],
                            Category = referral[12],
                            
                        }
                    );
            }

            HistoryVisitationCards = new ObservableCollection<VisitationOverviewViewModel>();

            NumberOfActiveVisitations = ActiveVisitationCards.Count;
            NumberOfHistoryVisitations = HistoryVisitationCards.Count;
            GroupedVisitations = ActiveVisitationCards
                                    .OrderBy(x => x.Category != "Akutte Visitationer")
                                    .ThenBy(x => x.Category != "Gemte Visitationer")
                                    .ThenBy(x => x.Category)
                                    .GroupBy(c => c.Category)
                                    .OrderBy(x => x.Key != "Akutte Visitationer")
                                    .ThenBy(x => x.Key != "Gemte Visitationer")
                                    .ThenBy(x => x.Key)
                                    .ToDictionary(group => group.Key, group => new ObservableCollection<VisitationOverviewViewModel>());

        }

        #endregion
    }
}


//HistoryVisitationCards = new ObservableCollection<VisitationOverviewViewModel>
//            {
//                new VisitationOverviewViewModel()
//{
//    Cpr = "238946",
//                    Diagnose = "A historical visitation"
//                }
//            };

//            ActiveVisitationCards = new ObservableCollection<VisitationOverviewViewModel>
//            {
//                new VisitationOverviewViewModel()
//{
//    Cpr = "1",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 1"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "2",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Gemte Visitationer"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "2",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 1"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "4",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 1",
//                    NeedsTranslator = true
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "5",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Akutte Visitationer"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 2"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },

//                new VisitationOverviewViewModel()
//{
//    Cpr = "0102030405",
//                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
//                    Category = "Something 3"
//                },
//            };
