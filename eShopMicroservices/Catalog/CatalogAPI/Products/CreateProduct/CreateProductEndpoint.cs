using CatalogAPI.Products.DTOs;

namespace CatalogAPI.Products.CreateProduct
{
    public class CreateProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/products", async (CreateProdcutRequest request, ISender sender) =>
            {
                var command = request.Adapt<CreateProductCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<CreateProdcutResponse>();

                return Results.Created($"products/{response.Id}", response);
            })
            .WithName("CreateProduct")
            .Produces<CreateProdcutResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Create Product")
            .WithDescription("Create Product");
        }
    }
}
