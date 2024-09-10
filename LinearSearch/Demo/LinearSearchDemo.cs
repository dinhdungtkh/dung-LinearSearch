using Dung.Array;
using Dung.LinearSearch;
namespace demo
{
	public class LinearSearchDemo
	{
		//public static void Main(string[] args)
		//{

		//	LinearSearch linearSearch = new LinearSearch();
		//	List<Product> products = new List<Product>();
		//	linearSearch.InsertTable(products, new Product("CPU", 750, 10, 1));
		//	linearSearch.InsertTable(products, new Product("RAM", 50, 2, 2));
		//	linearSearch.InsertTable(products, new Product("HDD", 70, 1, 2));
		//	linearSearch.InsertTable(products, new Product("Main", 400, 3, 1));
		//	linearSearch.InsertTable(products, new Product("Keyboard", 30, 8, 4));
		//	linearSearch.InsertTable(products, new Product("Mouse", 25, 50, 4));
		//	linearSearch.InsertTable(products, new Product("VGA", 60, 35, 3));
		//	linearSearch.InsertTable(products, new Product("Monitor", 120, 28, 2));
		//	linearSearch.InsertTable(products, new Product("Case", 120, 28, 5));

		//	List<Category> categorydemo = new List<Category>();
		//	linearSearch.InsertTable(categorydemo, new Category(1, "Computer"));
		//	linearSearch.InsertTable(categorydemo, new Category(2, "Memory"));
		//	linearSearch.InsertTable(categorydemo, new Category(3, "Card"));
		//	linearSearch.InsertTable(categorydemo, new Category(4, "Accesory"));
		//	linearSearch.InsertTable(categorydemo, new Category(5, "Case"));


		//	Product product = linearSearch.findProduct(products, "CPU");
		//	Console.WriteLine("name  " + product.name + " price " + product.price
		//	+ " quality " + product.quality + " categoryid " + product.categoryID);
		//	Product productss = linearSearch.findProductByPrice(products, 750);
		//	Console.WriteLine("Category: " + productss.name);
		//	for (int i = 0; i < categorydemo.Count; i++)
		//	{
		//		Console.WriteLine("name  " + categorydemo[i].name + " id " + categorydemo[i].id);
		//	}

		//	Console.WriteLine("Bai 11" + " Sort by Price Bubble ");
		//	linearSearch.sortByPrice(products);
		//	for (int i = 0; i < products.Count; i++)
		//	{
		//		Console.WriteLine("name  " + products[i].name + " price " + products[i].price);
		//	}


		//	Console.WriteLine("Bai 12" + " Sort by Name  Short -> Long Insertion ");
		//	linearSearch.sortByName(products);
		//	for (int i = 0; i < products.Count; i++)
		//	{
		//		Console.WriteLine("name  " + products[i].name);
		//	}




		//	Console.WriteLine("Bai 13" + " Sort product by category name ");
		//	linearSearch.sortByCategoryName(products, categorydemo);
		//	for (int i = 0; i < products.Count; i++)
		//	{

		//		Console.WriteLine("name  " + products[i].name + " category id " + products[i].categoryID);
		//	}

		//	Console.WriteLine("Bai 14" + " Map product by category name ");
		//	List<Product> mappedProducts = linearSearch.mapProductByCategory(products, categorydemo);
		//	foreach (var product in mappedProducts)
		//	{
		//		Console.WriteLine("Product name: " + product.name + " Category id: " + product.categoryID + " Category name: " + product.categoryName);
		//	}

		//	Console.WriteLine("Bai 16" + " Min Product Price ");
		//	Product minProduct = linearSearch.minByPrice(mappedProducts);
		//	Console.WriteLine("Min Product: Name: " + minProduct.name + " Price: " + minProduct.price);

		//	Console.WriteLine("Bai 15" + " Max Product Price ");
		//	Product maxProduct = linearSearch.maxByPrice(mappedProducts);
		//	Console.WriteLine("Max Product: Name: " + maxProduct.name + " Price: " + maxProduct.price);

		//	Console.WriteLine("Bai 21" + " Recursion ");
		//	Bai21Recursion bai21Recursion = new Bai21Recursion();
		//	Console.WriteLine($"Salary after 4 year using Recursion is {bai21Recursion.calSalary(10000, 2)}");
		//	Console.WriteLine($"Salary after 4 year is {bai21Recursion.calculateSalary(10000, 2)}");

		//	Console.WriteLine("Bai 22" + " Recursion ");
		//	Bai22Recursion bai22Recursion = new Bai22Recursion();
		//	Console.WriteLine($"Total months need to double up the money is {bai22Recursion.calMonth(10000, 70)}");
		//	Console.WriteLine($"Total months need to double up the money is {bai22Recursion.calculateMonth(10000, 70)}");


		//	Console.ReadLine();
		//}
	}
}