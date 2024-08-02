using CodeSoup.Domain.Entites._Base;
using CodeSoup.Domain.Interfaces.Repository._Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Infra.Repository._Base
{
    public class RepositoryBase<TDatabaseContext, TEntity> : IRepositoryBase<TEntity> where TEntity : Entity where TDatabaseContext : DbContext
    {
    }
}
