using Dung.Array;
namespace Dung.LinearSearch
{
   

    public class LinearSearch
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
                if (products[i].price == price)
                {
                    return products[i];
                }
            }
            return null;
        }

        /// <summary>
		/// sort the product list by price using Bubble Sort
		/// </summary>
		/// <param name="products"></param>
        public void sortByPrice(List<Product> products)
        {
            int i, j;
            Product temp = null;
            bool swapped;
            for (i = 0; i < (products.Count - 1); i++)
            {
                swapped = false;
                for (j = 0; j < products.Count - i - 1; j++)
                {
                    if (products[j].price > products[j + 1].price)
                    {
                        temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
        }

        /// <summary>
        /// sort the product by name using Insertion Sort
        /// </summary>
        /// <param name="products"></param>
        public void sortByName(List<Product> products)
        {
            for (int i = 1; i < products.Count; i++)
            {
                Product rememberedValue = products[i];
                int j = i - 1;
                while (j >= 0 && products[j].name.Length > rememberedValue.name.Length)
                {
                    products[j + 1] = products[j];
                    j = j - 1;
                }
                products[j + 1] = rememberedValue;
            }
        }


        /// <summary>
        /// sort product by categories(ABC) which product.categoryid = category.id 
        /// </summary>
        /// <param name="products"></param>
        /// <param name="categories"></param>
        public void sortByCategoryName(List<Product> products, List<Category> categories)
        {
            string getCategoryName(int productcategoryID, List<Category> categories)
            {
                for (int i = 0; i < categories.Count; i++)
                {
                    if (categories[i].id == productcategoryID)
                    {
                        return categories[i].name;
                    }
                }
                return null;
            }

            for (int i = 1; i < products.Count; i++)
            {
                Product rememberedValue = products[i];

                string categoryName = getCategoryName(rememberedValue.categoryID, categories);

                int j = i - 1;
                while (j >= 0)
                {
                    string currentCategoryName = getCategoryName(products[j].categoryID, categories);

                    if (string.Compare(currentCategoryName, categoryName) <= 0)
                    {
                        break;
                    }

                    products[j + 1] = products[j];
                    j = j - 1;
                }
                products[j + 1] = rememberedValue;

            }

        }

        public List<Product> mapProductByCategory(List<Product> products, List<Category> categories)
        {
            foreach (var product in products)
            {
                foreach (var category in categories)
                {
                    if (product.categoryID == category.id)
                    {
                        product.categoryName = category.name; 
                        break;
                    }
                }
            }
            return products;
        }

        public Product minByPrice(List<Product> products)
        {
            if (products.Count == 0) return null; 
            sortByPrice(products);
            return products[0]; 
        }

        public Product maxByPrice(List<Product> products)
        {
            if (products.Count == 0) return null;
            sortByPrice(products);
            return products[products.Count - 1]; 
        }






        /// <summary>
        /// Insert Data into List
        /// </summary>
        /// <param name="products"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public int InsertTable<T>(List<T> data, T row)
        {
            data.Add(row);
            return data.Count;
        }

        
    }
}