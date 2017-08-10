

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Areas.Baby.Models
{
    public class ThingsDoneModelView
    {
        public ThingsDoneModelView()
        {
        }

        public int index { get; set; }

        [DisplayName("Action")]
        public int ActionID { get; set; }

        public Action Action { get; set; }

        [DisplayName("Start Time")]
        public DateTime StartTime { get; set; }

        [DisplayName("End Time")]
        public Nullable<DateTime> EndTime { get; set; }

        public string EndTimeOnly {get;set;}

        [DisplayName("OZ")]
        public Nullable<double> OZ { get; set; }

        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DisplayName("Liquid Size ID")]
        public Nullable<int> LiquidSizeID { get; set; }

        [DisplayName("Baby Name ID")]
        public int BabyNameID { get; set; }

        public BabyName Baby { get; set; }

        public string TotalTime { get; set; }

    }
}


