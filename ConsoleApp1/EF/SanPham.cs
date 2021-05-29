namespace ConsoleApp1.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [StringLength(50)]
        public string id { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public decimal? DonGia { get; set; }

        [StringLength(500)]
        public string HinhAnh { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string idDanhMuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
