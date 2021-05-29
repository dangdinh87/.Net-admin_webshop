using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibary.Model
{
    public class WebShopDBContext : DbContext
    {
        public WebShopDBContext() : base("name=Model12") { }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }

        public virtual DbSet<SanPham> SanPhams { get; set; }

        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

        public System.Data.Entity.DbSet<MyLibary.Model.HoaDon> HoaDons { get; set; }
    }
}
