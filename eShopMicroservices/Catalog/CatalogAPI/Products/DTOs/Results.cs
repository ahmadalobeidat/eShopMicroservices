namespace CatalogAPI.Products.DTOs
{
    public record CreateProductResult(int Id);
    public record GetProductsResults(IEnumerable<Product> Products);
    public record GetProductByIdResult(Product Product);
}
