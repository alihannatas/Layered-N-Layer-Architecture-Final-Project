using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface IProductService
{
    IDataResult<List<Product>> GetAll();
    
    IDataResult<Product> Get(int id);
    IDataResult<List<Product>> GetAllByCategory(int id);

    IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

    IDataResult<List<ProductDetailDto>> GetProductDetails();

    IResult Add(Product product);
}