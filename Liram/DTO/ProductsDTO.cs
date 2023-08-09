using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductsDTO
    {
        public int ProductId { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }


        public static List<ProductsDTO> ToProductsDTO(List<Products> ListP)
        {
            List<ProductsDTO> ListProducts = new List<ProductsDTO>();
            ListP.ForEach(p => ListProducts.Add(ToProductsDTO(p)));
            return ListProducts;
        }

        public static ProductsDTO ToProductsDTO(Products p)
        {
            return new ProductsDTO
            {
                ProductId = p.ProductId,
                ParentId = p.ParentId,
                Name = p.Name
            };
        }

        public static List<Products> ToProducts(List<ProductsDTO> ListP)
        {
            List<Products> ListProducts = new List<Products>();
            ListP.ForEach(p => ListProducts.Add(ToProducts(p)));
            return ListProducts;
        }

        public static Products ToProducts(ProductsDTO p)
        {
            return new Products
            {
                ProductId = p.ProductId,
                ParentId = p.ParentId,
                Name = p.Name
            };
        }

    }
}
