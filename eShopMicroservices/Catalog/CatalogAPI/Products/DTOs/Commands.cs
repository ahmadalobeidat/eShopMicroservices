using CatalogAPI.Products.CreateProduct;
using Shared.CQRS;

namespace CatalogAPI.Products.DTOs
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
       : ICommand<CreateProductResult>;
}
