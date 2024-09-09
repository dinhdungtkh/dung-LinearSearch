using Dung.Array;
using System;
namespace Dung.LinearSearch
{
    public class Bai4LinearSearch
    {
        /// <summary>
        /// Find Product by name
        /// </summary>
        /// <param name="products"></param>
        /// <param name="nameProduct"></param>
        /// <returns></returns>
        public Product findProduct(List<Product> products, string nameProduct)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (Product.Equals(products[i].name, nameProduct))
                {
                    return products[i];
                }
            }
            return null;

        }
    }
}