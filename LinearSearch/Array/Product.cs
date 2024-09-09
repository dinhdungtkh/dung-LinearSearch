namespace Dung.Array
{
    public class Product
    {
        public Product(string Name, int Price, int Quality, int CategoryID)
        {
            name = Name;
            price = Price;
            this.quality = Quality;
            this.categoryID = CategoryID;
        }

        public Product (string Name,int CategoryID , string CategoryName)
        {
            name = Name;
            this.categoryID = CategoryID;
            this.categoryName = CategoryName;
        }

        public string name { get; set; }
        public int price { get; set; }
        public int quality { get; set; }
        public int categoryID { get; set; } 
        public string categoryName { get; set; }


    }
}