using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OurHouseApps.Areas.Baby.Models
{
    public class CommonTask

    { 
     private SDNAppsEntities db = new SDNAppsEntities();

        public CommonTask()
        {
            BabyNames = new SelectList(db.BabyNames, "ID", "BabyName1");
            LiquidSize = new SelectList(db.LiquidSizes, "Id", "Type");
            //Actions = new SelectList(db.Actions, "index", "Title");
        }
        
        [Key]
        public int ID { get; set; }
        
        [DisplayName("OZ")]
        public Nullable<double> OZ { get; set; }

        [DisplayName("Liquid Size ID")]
        public Nullable<int> LiquidSizeID { get; set; }

        [DisplayName("Baby Name ID")]
        public int BabyNameID { get; set; }

        [DisplayName("Baby Name")]
        public SelectList BabyNames { get; set; }

        [DisplayName("Liquid Size")]
        public SelectList LiquidSize { get; set; }

        public int ActionID { get; set; }

        [DisplayName("Actions")]
        public string Actions { get; set; }

    }
}