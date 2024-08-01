using CodeSoup.Domain.Entites._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Interfaces.Repository._Base
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
    }
}
