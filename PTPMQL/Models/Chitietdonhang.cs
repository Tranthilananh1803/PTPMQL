namespace PTPMQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chitietdonhang")]
    public partial class Chitietdonhang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Machitietdonhang { get; set; }

        public int Madonhang { get; set; }

        public int Mathang { get; set; }

        [Column(TypeName = "money")]
        public decimal Dongia { get; set; }

        public int Soluong { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Thanhtien { get; set; }

        public virtual Danhmuchang Danhmuchang { get; set; }

        public virtual Donhang Donhang { get; set; }
    }
}
