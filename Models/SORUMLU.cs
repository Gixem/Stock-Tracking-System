//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakipSistemi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SORUMLU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SORUMLU()
        {
            this.STOK_HAREKET = new HashSet<STOK_HAREKET>();
        }
    
        public int SORUMLU_ID { get; set; }
        public string SORUMLU_ADI { get; set; }
        public Nullable<int> STATU { get; set; }
        public Nullable<int> OLUSTURAN_KULLANICI { get; set; }
        public Nullable<System.DateTime> OLUSTURMA_TARIHI { get; set; }
        public Nullable<int> GUNCELLEYEN_KULLANICI { get; set; }
        public Nullable<System.DateTime> GUNCELLEME_TARIHI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOK_HAREKET> STOK_HAREKET { get; set; }
    }
}