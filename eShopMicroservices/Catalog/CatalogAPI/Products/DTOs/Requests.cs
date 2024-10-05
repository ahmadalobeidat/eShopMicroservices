namespace CatalogAPI.Products.DTOs
{
   public record CreateProdcutRequest(string Name, List<string> Category, string Description, string ImageFile, decimal Price);
}
