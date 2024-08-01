using CodeSoup.Domain.Entites._Base;
using CodeSoup.Domain.Interfaces.Service._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Services._Base
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : Entity
    {
    }
}
