using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductDal : IProductDal
{
    private List<Product> _products;

    public InMemoryProductDal()
    {
        _products = new List<Product>
        {
            new Product { ProductId = 1, CategoryId = 1, ProductName = "mouse", UnitPrice = 100, UnitsInStock = 15 },
            new Product { ProductId = 2, CategoryId = 1, ProductName = "keyboard", UnitPrice = 200, UnitsInStock = 20 },
            new Product { ProductId = 3, CategoryId = 2, ProductName = "monitor", UnitPrice = 1000, UnitsInStock = 25 },
            new Product { ProductId = 4, CategoryId = 2, ProductName = "gpu", UnitPrice = 2000, UnitsInStock = 30 },
            new Product { ProductId = 5, CategoryId = 2, ProductName = "cpu", UnitPrice = 1500, UnitsInStock = 35 },
        };
    }

    public List<Product> GetAll()
    {
        return _products;
    }

    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Update(Product product)
    {
        Product productUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        productUpdate.ProductName = product.ProductName;
        productUpdate.CategoryId = product.CategoryId;
        productUpdate.UnitPrice = product.UnitPrice;
        productUpdate.UnitsInStock = product.UnitsInStock;
    }

    public void Delete(Product product)
    {
        Product productDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        _products.Remove(productDelete);
    }

    public List<ProductDetailDto> GetProductDetails()
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAllByCategory(int categoryId)
    {
        return _products.Where(p => p.CategoryId == categoryId).ToList();
    }
}