namespace PTPMQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khachhang")]
    public partial class Khachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khachhang()
        {
            Donhang = new HashSet<Donhang>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Makhachhang { get; set; }

        [Required]
        [StringLength(50)]
        public string Hodem { get; set; }

        [Required]
        [StringLength(20)]
        public string Ten { get; set; }

        [StringLength(200)]
        public string Diachi { get; set; }

        [StringLength(20)]
        public string Sodienthoai { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public bool? Gioitinh { get; set; }

        public DateTime? Ngaysinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donhang> Donhang { get; set; }
    }
}
