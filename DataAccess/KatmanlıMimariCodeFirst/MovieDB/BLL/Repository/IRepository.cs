using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
   public interface IRepository<T> where T : BaseEntity
    {
        string Add(T model);

        List<T> GetList();

        string Update(T model);

        string Delete(int id);

        T SelectById(int id);

    }
}
