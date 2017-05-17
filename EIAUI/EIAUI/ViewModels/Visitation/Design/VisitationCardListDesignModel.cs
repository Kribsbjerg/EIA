using System.Collections.Generic;
using System.Collections.ObjectModel;

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
            HistoryVisitationCards = new ObservableCollection<VisitationOverviewViewModel>
            {
                new VisitationOverviewViewModel()
                {
                    Cpr = "238946",
                    Diagnose = "A historical visitation"
                }
            };

            ActiveVisitationCards = new ObservableCollection<VisitationOverviewViewModel>
            {
                new VisitationOverviewViewModel()
                {
                    Cpr = "1",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 1"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "2",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 1"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "2",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 1"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "4",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 1"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "5",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 2"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },

                new VisitationOverviewViewModel()
                {
                    Cpr = "0102030405",
                    Diagnose = "Noget langt og besværligt der fylder flere linjer som vist her",
                    TreatmentType = "Something 3"
                },
            };

        }

        #endregion
    }
}
