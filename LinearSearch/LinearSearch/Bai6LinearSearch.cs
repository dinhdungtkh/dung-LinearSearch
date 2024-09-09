using Dung.Array;
using System;
namespace Dung.LinearSearch
{
    public class Bai6LinearSearch
    {
        /// <summary>
        /// Find Product by its price
        /// </summary>
        /// <param name="products"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public Product findProductByPrice(List<Product> products, int price)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].price <= price)
                {
                    return products[i];
                }
            }
            return null;
        }
    }
}