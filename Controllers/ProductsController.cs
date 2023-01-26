using Microsoft.AspNetCore.Mvc;
using Models;

using tr_backend_itsense.Models.Dto;

namespace tr_backend_itsense.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ProductContext productContext;

    public ProductsController(ProductContext productsContext)
    {
        this.productContext = productsContext;
    }

    [HttpPost()]
    public void Create([FromBody] CreateProductDto productDto)
    {
        this.productContext.Add(new Product(productDto.name));
        this.productContext.SaveChanges();
    }

    [HttpGet(Name = "findAll")]
    public List<Product> FindAll() => this.productContext.Products.ToList();

    [HttpGet("{id}")]
    public Product? FindOne(int id) => this.productContext.Products.Find(id);

    [HttpPatch("{id}")]
    public void Update([FromBody] UpdateProductDto productDto, int id)
    {
        var product = this.productContext.Products.Find(id);
        if (product != null) {
            product.Name = productDto.name;
            product.Status = productDto.status;

            this.productContext.SaveChanges();
        }
    }

    [HttpDelete("{id}")]
    public void Remove(int id)
    {
        var product = this.productContext.Products.Find(id);
        if (product != null) {
            this.productContext.Products.Remove(product);
            this.productContext.SaveChanges();
        }
    }
}
