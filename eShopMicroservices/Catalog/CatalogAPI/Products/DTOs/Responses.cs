namespace CatalogAPI.Products.DTOs
{
    public record CreateProdcutResponse(int Id);
    public record GetProductsResponse(IEnumerable<Product> Products);
    public record GetProductByIdResponse(Product Product);
}
