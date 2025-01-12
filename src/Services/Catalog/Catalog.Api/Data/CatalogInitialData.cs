using Marten.Schema;

namespace Catalog.Api.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        await using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync(token: cancellation))
            return;
        
        
        session.Store<Product>(GetPreconfiguredProducts());
        await session.SaveChangesAsync(cancellation);
    }

    private static IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>()
{
    new Product()
    {
        Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
        Name = "IPhone X",
        Description = "Experience Apple's cutting-edge design with a near-borderless display, Face ID, and advanced camera capabilities.",
        ImageFile = "product-1.png",
        Price = 950.00M,
        Categories = new List<string> { "Smart Phone" }
    },
    new Product()
    {
        Id = new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"),
        Name = "Samsung 10",
        Description = "Samsung's 10th flagship phone boasts an Infinity Display, powerful performance, and pro-level photography features.",
        ImageFile = "product-2.png",
        Price = 840.00M,
        Categories = new List<string> { "Smart Phone" }
    },
    new Product()
    {
        Id = new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"),
        Name = "Huawei Plus",
        Description = "Revolutionize your mobile experience with a FullView display, AI-driven camera, and ultrafast processing speeds.",
        ImageFile = "product-3.png",
        Price = 650.00M,
        Categories = new List<string> { "White Appliances" }
    },
    new Product()
    {
        Id = new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"),
        Name = "Xiaomi Mi 9",
        Description = "Combining powerful specs, triple-camera setup, and an exceptional price point, it delivers premium features for less.",
        ImageFile = "product-4.png",
        Price = 470.00M,
        Categories = new List<string> { "White Appliances" }
    },
    new Product()
    {
        Id = new Guid("b786103d-c621-4f5a-b498-23452610f88c"),
        Name = "HTC U11+ Plus",
        Description = "Immerse yourself in dynamic audio, vibrant Liquid Surface design, and a large screen optimized for entertainment.",
        ImageFile = "product-5.png",
        Price = 380.00M,
        Categories = new List<string> { "Smart Phone" }
    },
    new Product()
    {
        Id = new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"),
        Name = "LG G7 ThinQ",
        Description = "Feature-packed with an AI-powered camera, Super Bright Display, and robust audio capabilities for everyday adventures.",
        ImageFile = "product-6.png",
        Price = 240.00M,
        Categories = new List<string> { "Home Kitchen" }
    },
    new Product()
    {
        Id = new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"),
        Name = "Panasonic Lumix",
        Description = "A dedicated camera phone capturing crisp images and stable videos, ideal for photographers seeking portability.",
        ImageFile = "product-6.png",
        Price = 240.00M,
        Categories = new List<string> { "Camera" }
    }
};

}