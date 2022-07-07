using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> 
    {
        T GetById();
        List<T> GetAll();
        void Add(T T);
        void Update(T T);
        void Delete(T T);

    }
}
