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
    
    public partial class detail_vaksinasi
    {
        public int id { get; set; }
        public Nullable<int> id_vaksinasi { get; set; }
        public Nullable<int> periode { get; set; }
        public Nullable<System.DateTime> tanggal_vaksin { get; set; }
        public Nullable<int> id_jenis_vaksin { get; set; }
        public Nullable<int> id_dokter { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual jenis_vaksin jenis_vaksin { get; set; }
        public virtual vaksinasi vaksinasi { get; set; }
    }
}
