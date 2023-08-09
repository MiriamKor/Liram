using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PartsPriceListDAL
    {
        public static List<PartsPricelist> SelectProducts()
        {
            using (LiramEntities db = new LiramEntities())
            {
                return db.PartsPricelist.ToList();
            }
        }
    }
}
