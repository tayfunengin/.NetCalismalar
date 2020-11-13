using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        NorthwindEntities db = new NorthwindEntities();
        public string Add(T model)
        {
            try
            {
                db.Set(typeof(T)).Add(model);
                db.SaveChanges();
                return "veri eklendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }           
            
        }

        public string Delete(int? id)
        {
            try
            {
                var deleted = db.Set(typeof(T)).Find(id);
                db.Set(typeof(T)).Remove(deleted);
                db.SaveChanges();                
                return $"{id} ID numaralı kategori silindi";                
            }
            catch (Exception ex)
            {
               return ex.Message;
            }
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set(typeof(T)).Cast<T>().Where(exp).ToList();
        }

        public List<T> GetList()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public T SelectById(int? id)
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);
        }

        public string Update(T model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "veri güncellendi";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
