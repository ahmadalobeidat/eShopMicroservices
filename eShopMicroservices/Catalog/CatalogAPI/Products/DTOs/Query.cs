namespace CatalogAPI.Products.DTOs
{
    public record GetProductsQuery : IQuery<GetProductsResults>;
    public record GetProductByIdQuery(int Id) : IQuery<GetProductByIdResult>;
}
