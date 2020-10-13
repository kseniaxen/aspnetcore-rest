using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;
using System.Threading.Tasks;
namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private DataProducts dataProducts;
        public ProductsController()
        {
            DataProducts data = new DataProducts();
            dataProducts = data;
        }
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return dataProducts.dataProductsList;
        }
        [HttpGet("{id}")]
        public Product GetProduct(long id)
        {
            return dataProducts.dataProductsList.Find(x => x.ProductId == id);
        }
        [HttpPost]
        public void SaveProduct([FromBody] Product product)
        {
            dataProducts.dataProductsList.Add(product);
        }
        // [HttpPut]
        // public void UpdateProduct([FromBody] Product product)
        // {
        //     dataProducts.dataProductsList.Update(product);
        // }
        [HttpDelete("{id}")]
        public void DeleteProduct(long id)
        {
            dataProducts.dataProductsList.Remove(new Product() { ProductId = id });
        }
    }
}