using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore_NTIER_AI_DataAccessLayer.Repositories
{
   public class GenericRepository<T> : IGenericDal<T> where T : class
    {

    }
}
