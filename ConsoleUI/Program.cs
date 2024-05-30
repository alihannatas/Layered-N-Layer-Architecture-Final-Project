using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        ProductTest();

        // Console.WriteLine("---------------");

       // OrderTest();

        //Console.WriteLine("---------------");

        CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        var temp3 = categoryManager.GetAll();
        foreach (var VARIABLE in temp3)
        {
            Console.WriteLine(VARIABLE.CategoryName);
        }
    }

    private static void OrderTest()
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        var temp2 = orderManager.GetAll();
        foreach (var VARIABLE in temp2)
        {
            Console.WriteLine(VARIABLE.ShipCity);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProducDal());
        var temp = productManager.GetProductDetails();
        foreach (var VARIABLE in temp)
        {
            Console.WriteLine(VARIABLE.ProductName + " " + VARIABLE.CategoryName );
        }
    }
}