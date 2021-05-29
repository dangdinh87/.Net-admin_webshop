using ConsoleApp1.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1.DAO
{
    public class DanhMucDAO
    {
        private Model1 db = new Model1();

        public List<DanhMuc> getList()
        {
            var list = db.DanhMucs.ToList();
            return list;
        }
        public DanhMuc getCount(int? id)
        {
            var row = db.DanhMucs.Find(id);
            return row;
        }

        public DanhMuc getRow(string slug)
        {
            var row = db.DanhMucs.Where(m => m.id == slug).FirstOrDefault();
            return row;

        }
        public void Insert(DanhMuc row)
        {
            db.DanhMucs.Add(row);
            db.SaveChanges();

        }
        public void Update(DanhMuc row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();

        }
        public void Delete(DanhMuc row)
        {
            db.DanhMucs.Remove(row);
            db.SaveChanges();

        }
    }
}