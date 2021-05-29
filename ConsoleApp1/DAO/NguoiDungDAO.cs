using ConsoleApp1.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1.DAO
{
    public class NguoiDungDAO
    {
        private Model1 db = new Model1();

        public List<NguoiDung> getList()
        {
            var list = db.NguoiDungs.ToList();
            return list;
        }
        public NguoiDung getCount(int? id)
        {
            var row = db.NguoiDungs.Find(id);
            return row;
        }

        public NguoiDung getRow(string slug)
        {
            var row = db.NguoiDungs.Where(m => m.Username == slug).FirstOrDefault();
            return row;

        }
        public void Insert(NguoiDung row)
        {
            db.NguoiDungs.Add(row);
            db.SaveChanges();

        }
        public void Update(NguoiDung row)
        {
            db.Entry(row).State = EntityState.Modified;
            db.SaveChanges();

        }
        public void Delete(UserWeb row)
        {
            db.UserWebs.Remove(row);
            db.SaveChanges();

        }
    }
}
