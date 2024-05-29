using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProducDal());
        var temp = productManager.GetByUnitPrice(2, 10);
        foreach (var VARIABLE in temp)
        {
            Console.WriteLine(VARIABLE.ProductName);
        }
    }
}