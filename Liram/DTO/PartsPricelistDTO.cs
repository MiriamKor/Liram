using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PartsPricelistDTO
    {
        public int PartId { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public decimal? Price { get; set; }

        public static List<PartsPricelistDTO> ToPartsPricelistDTO(List<PartsPricelist> ListPpt)
        {
            List<PartsPricelistDTO> ListPartsPricelist = new List<PartsPricelistDTO>();
            ListPpt.ForEach(ppt => ListPartsPricelist.Add(ToPartsPricelistDTO(ppt)));
            return ListPartsPricelist;
        }

        public static PartsPricelistDTO ToPartsPricelistDTO(PartsPricelist ppt)
        {
            return new PartsPricelistDTO
            {
                PartId = ppt.PartId,
                Name = ppt.Name,
                ProductId = ppt.ProductId,
                Price =  ppt.Price
            };
        }

        public static List<PartsPricelist> ToPartsPricelist(List<PartsPricelistDTO> ListPpt)
        {
            List<PartsPricelist> ListPartsPricelist = new List<PartsPricelist>();
            ListPpt.ForEach(ppt => ListPartsPricelist.Add(ToPartsPricelist(ppt)));
            return ListPartsPricelist;
        }

        public static PartsPricelist ToPartsPricelist(PartsPricelistDTO ppt)
        {
            return new PartsPricelist
            {
                PartId = ppt.PartId,
                Name = ppt.Name,
                ProductId = ppt.ProductId,
                Price = ppt.Price
            };
        }
    }
}
