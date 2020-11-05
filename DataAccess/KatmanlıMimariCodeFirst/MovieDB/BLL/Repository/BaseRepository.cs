using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        AppDbContext db = new AppDbContext();
        public string Add(T model)
        {
            db.Set(typeof(T)).Add(model);
            string result = db.SaveChanges() > 0 ? "Kayıt ekleme başarılı" : "Bir hata meydana geldi";
            return result;
        }

        public string Delete(int id)
        {
            var deleted = db.Set(typeof(T)).Find(id);
            db.Set(typeof(T)).Remove(deleted);
            string result = db.SaveChanges() > 0 ? "silme işlemi başarılı" : "bir hata meydana geldi";
            return result;
        }

        public List<T> GetList()
        {
           return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public T SelectById(int id)
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);
        }

        public string Update(T model)
        {
            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            string result = db.SaveChanges() > 0 ? "güncelleme başarılı" : "bir hata meydana geldi";
            return result;
        }
    }
}
