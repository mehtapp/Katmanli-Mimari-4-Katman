using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;


namespace BusinessORM
{
    public class CallCategoryMethods
    {
        public static List<categories> CategoryList()
        {
            return categoryMethods.listcategory();

        }
        public static bool AddCategory(categories category1)
        {
                return categoryMethods.AddCategory(category1);
        }
        public static bool UpdCategory(categories category1)
        {
            return categoryMethods.UpdateCategory(category1);

        }
        public static bool DelCategory(categories cat1)
        {
            return categoryMethods.DeleteCategory(cat1);
        }
    }
}
