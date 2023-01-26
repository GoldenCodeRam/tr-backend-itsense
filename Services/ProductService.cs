using Models;

namespace tr_backend_itsense.Services;

public class ProductService
{
    private readonly ProductContext context;

    public ProductService(ProductContext context)
    {
        this.context = context;
    }

    public string Add()
    {
        this.context.Add(new Product("aoeu"));
        return "";
    }
}
