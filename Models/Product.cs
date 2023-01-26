namespace Models;

public class Product
{

    public int Id { get; set; }
    public string Name { get; set; }
    public ProductStatus Status { get; set; }

    public Product(string name)
    {
        this.Name = name;
        this.Status = ProductStatus.OK;
    }
}

public enum ProductStatus
{
    OK, DEFECTIVE
}
