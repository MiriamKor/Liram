using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductsBL
    {
        private static List<ProductsDTO> ProductList = new List<ProductsDTO>();
        private static List<PartsPricelistDTO> PartsPricelistList = new List<PartsPricelistDTO>();
        private static int row = 0;
        private static int column = 0;

        public static Dictionary<int, decimal?> priceDic = new Dictionary<int, decimal?>();
        public static Dictionary<int, string> namePartDic = new Dictionary<int, string>();

        public static List<ProductsDTO> GetProducts()
        {
           return ProductsDTO.ToProductsDTO( ProductDAL.SelectProducts());
        }

        public static List<string> EditPrice(int productID)
        {
            ProductList = GetProducts();
            PartsPricelistList = PartsPricelistBL.GetAllPartPriceList();

            List<PartsPricelistDTO> listPart = new List<PartsPricelistDTO>();
            row = 0;
            column = 0;
            ProductsDTO product = ProductList.First(w => w.ProductId == productID);

            FindProductByParent( listPart, product);

            int[][] Array = new int[row ][];
            int num = listPart[0].ProductId;
            int i = 0;
            int j = 0;
            Array[i] = new int[column];

            foreach (var item in listPart)
            {
                if(item.ProductId == num)
                {
                    Array[i][j] = item.PartId;
                    priceDic.Add(item.PartId, item.Price);
                    namePartDic.Add(item.PartId, item.Name);
                    //Array[i][column - 1] = Array[i][column - 1] + item.Price;
                    j++;
                }
                else
                {
                    num = item.ProductId;
                    i++;
                    j = 0;
                    Array[i] = new int[column];
                    Array[i][j] = item.PartId;
                    priceDic.Add(item.PartId, item.Price);
                    namePartDic.Add(item.PartId, item.Name);
                    j++;
                }
            }
            List<List<int>> parts = new List<List<int>>();
            List<int> currentProduct = new List<int>();

            GenerateCombinations(Array, 0, currentProduct, parts);

            decimal price = 0;
            Dictionary<decimal, int> sortL = new Dictionary<decimal, int>();
            int index = 0;
            List<decimal> priceL = new List<decimal>();
            foreach (List<int> part in parts)
            {
                foreach (int p in part)
                {
                    price = Convert.ToDecimal(price + ProductsBL.priceDic[p]);
                }
                sortL.Add(price, index);
                priceL.Add(price);
                index++;
            }
            priceL.Sort();

            string s = "";
            List<string> final = new List<string>();
            foreach (var p in priceL)
            {
                s = "The Price:" + Convert.ToString(p)+Environment.NewLine + " the products:"+ Environment.NewLine;
                foreach (var item in parts[sortL[p]])
                {
                    s = s  + ProductsBL.namePartDic[item]+ Environment.NewLine;
                }
                final.Add(s);
            }
            return final;
        }
        
        public static void FindProductByParent(List<PartsPricelistDTO> listPart, ProductsDTO products)
        {
           var listP = ProductList.Where(w => w.ParentId == products.ProductId);
            if (listP.Count() == 0)
            {
                var listPp = PartsPricelistList.Where(w => w.ProductId == products.ProductId);
                listPart.AddRange(listPp);
                row++;
                if (column < listPp.Count())
                    column = listPp.Count();
                return;
            }

            foreach (ProductsDTO item in listP)
            {
                FindProductByParent( listPart, item);
            }
        }

        static void GenerateCombinations(int[][] Array, int arrayIndex, List<int> currentCombination, List<List<int>> combinations)
        {
            if (arrayIndex == Array.Length )
            {
                combinations.Add(new List<int>(currentCombination));
                return;
            }

            int[] currentArray = Array[arrayIndex];
            for (int i = 0; i < currentArray.Length ; i++)
            {
                if (currentArray[i] == 0)
                    break;
                currentCombination.Add(currentArray[i]);
                GenerateCombinations(Array, arrayIndex + 1, currentCombination, combinations);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}
