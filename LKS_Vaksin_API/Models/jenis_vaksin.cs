//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LKS_Vaksin_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class jenis_vaksin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public jenis_vaksin()
        {
            this.detail_vaksinasi = new HashSet<detail_vaksinasi>();
        }
    
        public int id { get; set; }
        public string nama_vaksin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detail_vaksinasi> detail_vaksinasi { get; set; }
    }
}