
namespace CatalogAPI.Products.GetProduct
{
    public class GetProductQueryHandler (IDocumentSession session , ILogger<GetProductQueryHandler> logger)
        : IQueryHandler<GetProductsQuery, GetProductsResults>
    {
        public async Task<GetProductsResults> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation(nameof(GetProductQueryHandler), request);

            var products = await session.Query<Product>().ToListAsync(cancellationToken);
            return new GetProductsResults(products);    
        }
    }
}
