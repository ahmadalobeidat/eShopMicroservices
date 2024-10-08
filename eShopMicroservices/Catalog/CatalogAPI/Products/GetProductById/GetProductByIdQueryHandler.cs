
using CatalogAPI.Exceptions;

namespace CatalogAPI.Products.GetProductById
{
    public class GetProductByIdQueryHandler(IDocumentSession session ,  ILogger<GetProductByIdQueryHandler> logger)
        : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
    {
        public async Task<GetProductByIdResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation(nameof(GetProductByIdQueryHandler), request);

            var product = await session.Query<Product>().Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (product is null) throw new ProductNotFoundException();

            var result = product.Adapt<GetProductByIdResult>();
            return result;
        }
    }
}
