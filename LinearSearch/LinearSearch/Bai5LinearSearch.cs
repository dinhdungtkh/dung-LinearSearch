using Dung.Array;
using System;
namespace Dung.LinearSearch
{
    public class Bai5LinearSearch
    {
        /// <summary>
        /// Find Product By its Category
        /// </summary>
        /// <param name="products"></param>
        /// <param name="CategoryId"></param>
        /// <returns></returns>
        public Product findProductByCategory(List<Product> products, int CategoryId)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].categoryID == CategoryId)
                {
                    return products[i];
                }
            }
            return null;
        }
        
    }
}