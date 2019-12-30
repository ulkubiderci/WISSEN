//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MixErp302.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUrunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUrunler()
        {
            this.tblUrunAlis = new HashSet<tblUrunAli>();
            this.tblUrunAlisAlts = new HashSet<tblUrunAlisAlt>();
            this.tblStokDurums = new HashSet<tblStokDurum>();
            this.tblUrunSatisAlts = new HashSet<tblUrunSatisAlt>();
        }
    
        public int Id { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAciklama { get; set; }
        public Nullable<int> MenseiId { get; set; }
        public Nullable<int> KategoriId { get; set; }
        public Nullable<int> Birim { get; set; }
        public Nullable<int> CariId { get; set; }
    
        public virtual bBirim bBirim { get; set; }
        public virtual bKategori bKategori { get; set; }
        public virtual bMensei bMensei { get; set; }
        public virtual tblCari tblCari { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunAli> tblUrunAlis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunAlisAlt> tblUrunAlisAlts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStokDurum> tblStokDurums { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunSatisAlt> tblUrunSatisAlts { get; set; }
    }
}
