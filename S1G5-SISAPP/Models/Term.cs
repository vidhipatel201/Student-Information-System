//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G5_SISAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Term
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Term()
        {
            this.Registrations = new HashSet<Registration>();
            this.TeachingAssignments = new HashSet<TeachingAssignment>();
        }
    
        public int Term_ID { get; set; }
        public string Term_Name { get; set; }
        public System.DateTime Term_Start_Date { get; set; }
        public System.DateTime Term_End_Date { get; set; }
        public string Term_Season { get; set; }
        public int Term_Year { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeachingAssignment> TeachingAssignments { get; set; }
    }
}
