using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;
using BlogApp.Shared.Data.Abstract;
using BlogApp.Shared.Data.Concrete.EntityFramework;

namespace BlogApp.Data.Abstract
{
    public interface IArticleRepository : IEntityRepository<Article>
    {
    }
}
