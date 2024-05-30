using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface IProductService
{
    List<Product> GetAll();
    List<Product> GetAllByCategory(int id);

    List<Product> GetByUnitPrice(decimal min, decimal max);

    List<ProductDetailDto> GetProductDetails();
}