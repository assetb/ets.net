//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AltaMySqlDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class auctions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public auctions()
        {
            this.applicants = new HashSet<applicants>();
            this.lots = new HashSet<lots>();
            this.order = new HashSet<order>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> sectionid { get; set; }
        public Nullable<int> typeid { get; set; }
        public string number { get; set; }
        public Nullable<int> status { get; set; }
        public string comments { get; set; }
        public Nullable<bool> ndsincluded { get; set; }
        public Nullable<bool> signstatusid { get; set; }
        public Nullable<bool> published { get; set; }
        public Nullable<int> regulationid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<applicants> applicants { get; set; }
        public virtual brokers brokers { get; set; }
        public virtual companies companies { get; set; }
        public virtual person person { get; set; }
        public virtual sites sites { get; set; }
        public virtual users users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lots> lots { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> order { get; set; }
    }
}
