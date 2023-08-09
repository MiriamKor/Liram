using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PartsPricelistBL
    {
        public static List<PartsPricelistDTO> GetAllPartPriceList()
        {
            return PartsPricelistDTO.ToPartsPricelistDTO(PartsPriceListDAL.SelectProducts());
        }
    }
}
