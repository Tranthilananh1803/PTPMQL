namespace PTPMQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Danhmuchang")]
    public partial class Danhmuchang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Danhmuchang()
        {
            Chitietdonhang = new HashSet<Chitietdonhang>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Mathang { get; set; }

        [Required]
        [StringLength(50)]
        public string Tenhang { get; set; }

    

        [StringLength(30)]
        public string Donvitinh { get; set; }

        [Column(TypeName = "money")]
        public decimal? Dongia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhang { get; set; }

        public virtual Nhomhang Nhomhang { get; set; }
    }
}
