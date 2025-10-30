using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore_NTIER_AI_DataAccessLayer.Dtos
{
   public class CategoryWithArticleCountDto
    {
        public string CategoryName { get; set; }
        public int ArticleCount { get; set; }
    }
}
