using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        public static List<Products> SelectProducts()
        {
            try
            {
                using (LiramEntities db = new LiramEntities())
                {
                    return db.Products.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
