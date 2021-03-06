//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OurHouseApps
{
    using System;
    using System.Collections.Generic;
    
    public partial class Action
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Action()
        {
            this.Reminders = new HashSet<Reminder>();
            this.ThingsDones = new HashSet<ThingsDone>();
        }
    
        public int index { get; set; }
        public string Title { get; set; }
        public bool Delete { get; set; }
        public Nullable<System.Guid> CategoryID { get; set; }
        public string IPAddress { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    
        public virtual ActionCategory ActionCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reminder> Reminders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThingsDone> ThingsDones { get; set; }
    }
}
