
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OurHouseApps.Areas.Baby.Models
{
    public class ThingsDoneModelCreate
    {
        public ThingsDoneModelCreate()
        {
            CommonTasks = new List<CommonTask>();
        }

        [Key]
        public int ID { get; set; }


        [DisplayName("Start Time")]
        public DateTime StartTime { get; set; }

        [DisplayName("End Time")]
        public Nullable<DateTime> EndTime { get; set; }

        public string EndTimeOnly {get;set;}

        public List<CommonTask> CommonTasks { get; set; }

        public string Notes { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

    }
   
}




