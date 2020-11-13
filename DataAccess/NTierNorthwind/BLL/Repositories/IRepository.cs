using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
   public interface IRepository <T> where T : class
    {
        string Add(T model);
        //List
        List<T> GetList();
        //Update
        string Update(T model);
        //Delete
        string Delete(int? id);
        T SelectById(int? id);

        List<T> GetDefault(Expression<Func<T, bool>> exp);
        
    }
}
