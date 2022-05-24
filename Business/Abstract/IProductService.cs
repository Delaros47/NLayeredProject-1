using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {

        List<Product> GetAll();
        Product Get(int productId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);


    }
}
