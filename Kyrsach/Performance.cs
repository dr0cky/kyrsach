//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kyrsach
{
    using System;
    using System.Collections.Generic;
    
    public partial class Performance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Performance()
        {
            this.RepertoireTeatras = new HashSet<RepertoireTeatra>();
            this.Troupes = new HashSet<Troupe>();
        }
    
        public int Performances_ID { get; set; }
        public int NamePerformance { get; set; }
        public string DirectorPostanovjik { get; set; }
        public string ProductionHudojnik { get; set; }
        public string DerejerPostanovjik { get; set; }
        public string Author { get; set; }
        public string Style { get; set; }
        public string TypePerformances { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RepertoireTeatra> RepertoireTeatras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Troupe> Troupes { get; set; }
    }
}
