using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Application.Interfaces._Base
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
         TEntity Add(TEntity entity);

         void Delete(TEntity entity);   

         void Update(TEntity entity);    

         List<TEntity> GetAll();

         TEntity GetById(long id);    


    }
}
