using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ApiBazarImag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private List<Product> _products;

        public ValuesController()
        {
            // Esto es solo para simular datos. En una aplicación real, obtendrías datos de una base de datos u otra fuente.
            _products = ObtenerProductos();
        }

        // GET api/values
        [HttpGet("{id}")]
        public ActionResult<Product> ObtenerPorId(int id)
        {
            var producto = _products.FirstOrDefault(p => p.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> ObtenerTodos()
        {
            return Ok(_products);
        }

        private List<Product> ObtenerProductos()
        {
            var productos = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Title = "iPhone 9",
                    Description = "An apple mobile which is nothing like apple",
                    Price = 549,
                    DiscountPercentage = 12.96,
                    Rating = 3,
                    Stock = 94,
                    Brand = "Apple",
                    Category = "smartphones",
                    Thumbnail = "https://i.dummyjson.com/data/products/1/thumbnail.jpg",
                    Images = new List<string>
                    {
                        "https://i.dummyjson.com/data/products/1/1.jpg",
                        "https://i.dummyjson.com/data/products/1/2.jpg",
                        "https://i.dummyjson.com/data/products/1/3.jpg",
                        "https://i.dummyjson.com/data/products/1/4.jpg",
                        "https://i.dummyjson.com/data/products/1/thumbnail.jpg"
                    }
                },
            new Product
            {
                Id = 2,
                Title = "iPhone X",
                Description = "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...",
                Price = 899,
                DiscountPercentage = 17.94,
                Rating = 2,
                Stock = 34,
                Brand = "Apple",
                Category = "smartphones",
                Thumbnail = "https://i.dummyjson.com/data/products/2/thumbnail.jpg",
                Images = new List<string>
                {
                "https://i.dummyjson.com/data/products/2/1.jpg",
                "https://i.dummyjson.com/data/products/2/2.jpg",
                "https://i.dummyjson.com/data/products/2/3.jpg",
                "https://i.dummyjson.com/data/products/2/thumbnail.jpg"
                }
            },
                    new Product
        {
            Id = 3,
            Title = "Samsung Universe 9",
            Description = "Samsung's new variant which goes beyond Galaxy to the Universe",
            Price = 1249,
            DiscountPercentage = 15.46,
            Rating = 5,
            Stock = 36,
            Brand = "Samsung",
            Category = "smartphones",
            Thumbnail = "https://i.dummyjson.com/data/products/3/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/3/1.jpg"
            }
        },
                new Product
        {
            Id = 4,
            Title = "OPPOF19",
            Description = "OPPO F19 is officially announced on April 2021.",
            Price = 280,
            DiscountPercentage = 17.91,
            Rating = 1,
            Stock = 123,
            Brand = "OPPO",
            Category = "smartphones",
            Thumbnail = "https://i.dummyjson.com/data/products/4/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/4/1.jpg",
                "https://i.dummyjson.com/data/products/4/2.jpg",
                "https://i.dummyjson.com/data/products/4/3.jpg",
                "https://i.dummyjson.com/data/products/4/4.jpg",
                "https://i.dummyjson.com/data/products/4/thumbnail.jpg"
            }
        },
                    new Product
        {
            Id = 5,
            Title = "Huawei P30",
            Description = "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.",
            Price = 499,
            DiscountPercentage = 10.58,
            Rating = 3,
            Stock = 32,
            Brand = "Huawei",
            Category = "smartphones",
            Thumbnail = "https://i.dummyjson.com/data/products/5/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/5/1.jpg",
                "https://i.dummyjson.com/data/products/5/2.jpg",
                "https://i.dummyjson.com/data/products/5/3.jpg"
            }
        },
                            new Product
        {
            Id = 6,
            Title = "MacBook Pro",
            Description = "MacBook Pro 2021 with mini-LED display may launch between September, November",
            Price = 1749,
            DiscountPercentage = 11.02,
            Rating = 4.57,
            Stock = 83,
            Brand = "Apple",
            Category = "laptops",
            Thumbnail = "https://i.dummyjson.com/data/products/6/thumbnail.png",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/6/1.png",
                "https://i.dummyjson.com/data/products/6/2.jpg",
                "https://i.dummyjson.com/data/products/6/3.png",
                "https://i.dummyjson.com/data/products/6/4.jpg"
            }
        },
                                    new Product
        {
            Id = 7,
            Title = "Samsung Galaxy Book",
            Description = "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched",
            Price = 1499,
            DiscountPercentage = 4.15,
            Rating = 1,
            Stock = 50,
            Brand = "Samsung",
            Category = "laptops",
            Thumbnail = "https://i.dummyjson.com/data/products/7/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/7/1.jpg",
                "https://i.dummyjson.com/data/products/7/2.jpg",
                "https://i.dummyjson.com/data/products/7/3.jpg",
                "https://i.dummyjson.com/data/products/7/thumbnail.jpg"
            }
        },
                                            new Product
        {
            Id = 8,
            Title = "Microsoft Surface Laptop 4",
            Description = "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.",
            Price = 1499,
            DiscountPercentage = 10.23,
            Rating = 2,
            Stock = 68,
            Brand = "Microsoft Surface",
            Category = "laptops",
            Thumbnail = "https://i.dummyjson.com/data/products/8/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/8/1.jpg",
                "https://i.dummyjson.com/data/products/8/2.jpg",
                "https://i.dummyjson.com/data/products/8/3.jpg",
                "https://i.dummyjson.com/data/products/8/4.jpg",
                "https://i.dummyjson.com/data/products/8/thumbnail.jpg"
            }
        },
                                                    new Product
        {
            Id = 9,
            Title = "Infinix INBOOK",
            Description = "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty",
            Price = 1099,
            DiscountPercentage = 11.83,
            Rating = 5,
            Stock = 96,
            Brand = "Infinix",
            Category = "laptops",
            Thumbnail = "https://i.dummyjson.com/data/products/9/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/9/1.jpg",
                "https://i.dummyjson.com/data/products/9/2.png",
                "https://i.dummyjson.com/data/products/9/3.png",
                "https://i.dummyjson.com/data/products/9/4.jpg",
                "https://i.dummyjson.com/data/products/9/thumbnail.jpg"
            }
        },
                                                    new Product
        {
            Id = 10,
            Title = "HP Pavilion 15-DK1056WM",
            Description = "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10",
            Price = 1099,
            DiscountPercentage = 6.18,
            Rating = 3.43,
            Stock = 89,
            Brand = "HP Pavilion",
            Category = "laptops",
            Thumbnail = "https://i.dummyjson.com/data/products/10/thumbnail.jpeg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/10/1.jpg",
                "https://i.dummyjson.com/data/products/10/2.jpg",
                "https://i.dummyjson.com/data/products/10/3.jpg",
                "https://i.dummyjson.com/data/products/10/thumbnail.jpeg"
            }
        },
                                                            new Product
        {
            Id = 11,
            Title = "perfume Oil",
            Description = "Mega Discount, Impression of Acqua Di Gio by Giorgio Armani concentrated attar perfume Oil",
            Price = 13,
            DiscountPercentage = 8.4,
            Rating = 4.26,
            Stock = 65,
            Brand = "Impression of Acqua Di Gio",
            Category = "fragrances",
            Thumbnail = "https://i.dummyjson.com/data/products/11/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/11/1.jpg",
                "https://i.dummyjson.com/data/products/11/2.jpg",
                "https://i.dummyjson.com/data/products/11/3.jpg",
                "https://i.dummyjson.com/data/products/11/thumbnail.jpg"
            }
        },
                                                                    new Product
        {
            Id = 12,
            Title = "Brown Perfume",
            Description = "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml",
            Price = 40,
            DiscountPercentage = 15.66,
            Rating = 4,
            Stock = 52,
            Brand = "Royal_Mirage",
            Category = "fragrances",
            Thumbnail = "https://i.dummyjson.com/data/products/12/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/12/1.jpg",
                "https://i.dummyjson.com/data/products/12/2.jpg",
                "https://i.dummyjson.com/data/products/12/3.png",
                "https://i.dummyjson.com/data/products/12/4.jpg",
                "https://i.dummyjson.com/data/products/12/thumbnail.jpg"
            }
        },
        new Product
        {
            Id = 13,
            Title = "Fog Scent Xpressio Perfume",
            Description = "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men",
            Price = 13,
            DiscountPercentage = 8.14,
            Rating = 4.59,
            Stock = 61,
            Brand = "Fog Scent Xpressio",
            Category = "fragrances",
            Thumbnail = "https://i.dummyjson.com/data/products/13/thumbnail.webp",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/13/1.jpg",
                "https://i.dummyjson.com/data/products/13/2.png",
                "https://i.dummyjson.com/data/products/13/3.jpg",
                "https://i.dummyjson.com/data/products/13/4.jpg",
                "https://i.dummyjson.com/data/products/13/thumbnail.webp"
            }
        },
                new Product
        {
            Id = 14,
            Title = "Non-Alcoholic Concentrated Perfume Oil",
            Description = "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil",
            Price = 120,
            DiscountPercentage = 15.6,
            Rating = 4.21,
            Stock = 114,
            Brand = "Al Munakh",
            Category = "fragrances",
            Thumbnail = "https://i.dummyjson.com/data/products/14/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/14/1.jpg",
                "https://i.dummyjson.com/data/products/14/2.jpg",
                "https://i.dummyjson.com/data/products/14/3.jpg",
                "https://i.dummyjson.com/data/products/14/thumbnail.jpg"
            }
        },
                        new Product
        {
            Id = 15,
            Title = "Eau De Perfume Spray",
            Description = "Genuine Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality",
            Price = 30,
            DiscountPercentage = 10.99,
            Rating = 4.7,
            Stock = 105,
            Brand = "Lord - Al-Rehab",
            Category = "fragrances",
            Thumbnail = "https://i.dummyjson.com/data/products/15/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/15/1.jpg",
                "https://i.dummyjson.com/data/products/15/2.jpg",
                "https://i.dummyjson.com/data/products/15/3.jpg",
                "https://i.dummyjson.com/data/products/15/4.jpg",
                "https://i.dummyjson.com/data/products/15/thumbnail.jpg"
            }
        },
        new Product
        {
            Id = 16,
            Title = "Hyaluronic Acid Serum",
            Description = "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid",
            Price = 19,
            DiscountPercentage = 13.31,
            Rating = 5,
            Stock = 110,
            Brand = "L'Oreal Paris",
            Category = "skincare",
            Thumbnail = "https://i.dummyjson.com/data/products/16/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/16/1.png",
                "https://i.dummyjson.com/data/products/16/2.webp",
                "https://i.dummyjson.com/data/products/16/3.jpg",
                "https://i.dummyjson.com/data/products/16/4.jpg",
                "https://i.dummyjson.com/data/products/16/thumbnail.jpg"
            }
        },
                new Product
        {
            Id = 17,
            Title = "Tree Oil 30ml",
            Description = "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,",
            Price = 12,
            DiscountPercentage = 4.09,
            Rating = 4,
            Stock = 78,
            Brand = "Hemani Tea",
            Category = "skincare",
            Thumbnail = "https://i.dummyjson.com/data/products/17/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/17/1.jpg",
                "https://i.dummyjson.com/data/products/17/2.jpg",
                "https://i.dummyjson.com/data/products/17/3.jpg",
                "https://i.dummyjson.com/data/products/17/thumbnail.jpg"
            }
        },
                        new Product
        {
            Id = 18,
            Title = "Oil Free Moisturizer 100ml",
            Description = "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.",
            Price = 40,
            DiscountPercentage = 13.1,
            Rating = 3,
            Stock = 88,
            Brand = "Dermive",
            Category = "skincare",
            Thumbnail = "https://i.dummyjson.com/data/products/18/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/18/1.jpg",
                "https://i.dummyjson.com/data/products/18/2.jpg",
                "https://i.dummyjson.com/data/products/18/3.jpg",
                "https://i.dummyjson.com/data/products/18/4.jpg",
                "https://i.dummyjson.com/data/products/18/thumbnail.jpg"
            }
        },
                                new Product
        {
            Id = 19,
            Title = "Skin Beauty Serum",
            Description = "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m",
            Price = 46,
            DiscountPercentage = 10.68,
            Rating = 2,
            Stock = 54,
            Brand = "ROREC White Rice",
            Category = "skincare",
            Thumbnail = "https://i.dummyjson.com/data/products/19/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/19/1.jpg",
                "https://i.dummyjson.com/data/products/19/2.jpg",
                "https://i.dummyjson.com/data/products/19/3.png",
                "https://i.dummyjson.com/data/products/19/thumbnail.jpg"
            }
        },
                                        new Product
        {
            Id = 20,
            Title = "Freckle Treatment Cream- 15gm",
            Description = "Fair & Clear is Pakistan's only pure Freckle cream which helps fade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.",
            Price = 70,
            DiscountPercentage = 16.99,
            Rating = 4.06,
            Stock = 140,
            Brand = "Fair & Clear",
            Category = "skincare",
            Thumbnail = "https://i.dummyjson.com/data/products/20/thumbnail.jpg",
            Images = new List<string>
            {
                "https://i.dummyjson.com/data/products/20/1.jpg",
                "https://i.dummyjson.com/data/products/20/2.jpg",
                "https://i.dummyjson.com/data/products/20/3.jpg",
                "https://i.dummyjson.com/data/products/20/4.jpg",
                "https://i.dummyjson.com/data/products/20/thumbnail.jpg"
            }
        },

        new Product
{
    Id = 21,
    Title = "- Daal Masoor 500 grams",
    Description = "Fine quality Branded Product Keep in a cool and dry place",
    Price = 20,
    DiscountPercentage = 4.81,
    Rating = 5,
    Stock = 133,
    Brand = "Saaf & Khaas",
    Category = "groceries",
    Thumbnail = "https://i.dummyjson.com/data/products/21/thumbnail.png",
    Images = new List<string>
    {
        "https://i.dummyjson.com/data/products/21/1.png",
        "https://i.dummyjson.com/data/products/21/2.jpg",
        "https://i.dummyjson.com/data/products/21/3.jpg"
    }
},
        new Product
{
    Id = 22,
    Title = "Elbow Macaroni - 400 gm",
    Description = "Product details of Bake Parlor Big Elbow Macaroni - 400 gm",
    Price = 14,
    DiscountPercentage = 15.58,
    Rating = 1,
    Stock = 146,
    Brand = "Bake Parlor Big",
    Category = "groceries",
    Thumbnail = "https://i.dummyjson.com/data/products/22/thumbnail.jpg",
    Images = new List<string>
    {
        "https://i.dummyjson.com/data/products/22/1.jpg",
        "https://i.dummyjson.com/data/products/22/2.jpg",
        "https://i.dummyjson.com/data/products/22/3.jpg"
    }
},
        new Product
{
    Id = 23,
    Title = "Orange Essence Food Flavour",
    Description = "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item",
    Price = 14,
    DiscountPercentage = 8.04,
    Rating = 3,
    Stock = 26,
    Brand = "Baking Food Items",
    Category = "groceries",
    Thumbnail = "https://i.dummyjson.com/data/products/23/thumbnail.jpg",
    Images = new List<string>
    {
        "https://i.dummyjson.com/data/products/23/1.jpg",
        "https://i.dummyjson.com/data/products/23/2.jpg",
        "https://i.dummyjson.com/data/products/23/3.jpg",
        "https://i.dummyjson.com/data/products/23/4.jpg",
        "https://i.dummyjson.com/data/products/23/thumbnail.jpg"
    }
},
new Product
{
    Id = 24,
    Title = "Cereals Muesli Fruit Nuts",
    Description = "Original Fauji cereal muesli 250gm box pack. Original Fauji cereals muesli with fruit nuts flakes, perfect for breakfast.",
    Price = 46,
    DiscountPercentage = 16.8,
    Rating = 5,
    Stock = 113,
    Brand = "Fauji",
    Category = "groceries",
    Thumbnail = "https://i.dummyjson.com/data/products/24/thumbnail.jpg",
    Images = new List<string>
    {
        "https://i.dummyjson.com/data/products/24/1.jpg",
        "https://i.dummyjson.com/data/products/24/2.jpg",
        "https://i.dummyjson.com/data/products/24/3.jpg",
        "https://i.dummyjson.com/data/products/24/4.jpg",
        "https://i.dummyjson.com/data/products/24/thumbnail.jpg"
    }
},
new Product
{
    Id = 25,
    Title = "Gulab Powder 50 Gram",
    Description = "Dry Rose Flower Powder Gulab Powder 50 Gram • Treats Wounds",
    Price = 70,
    DiscountPercentage = 13.58,
    Rating = 5,
    Stock = 47,
    Brand = "Dry Rose",
    Category = "groceries",
    Thumbnail = "https://i.dummyjson.com/data/products/25/thumbnail.jpg",
    Images = new List<string>
    {
        "https://i.dummyjson.com/data/products/25/1.png",
        "https://i.dummyjson.com/data/products/25/2.jpg",
        "https://i.dummyjson.com/data/products/25/3.png",
        "https://i.dummyjson.com/data/products/25/4.jpg",
        "https://i.dummyjson.com/data/products/25/thumbnail.jpg"
    }
},
new Product
{
    Id = 26,
    Title = "Plant Hanger For Home",
    Description = "Boho Decor Plant Hanger For Home Wall Decoration Macrame Wall Hanging Shelf",
    Price = 41,
    DiscountPercentage = 17.86,
    Rating =1,
    Stock = 131,
    Brand = "Boho Decor",
    Category = "home-decoration",
    Thumbnail = "https://i.dummyjson.com/data/products/26/thumbnail.jpg",
    Images = new List<string>
    {
        "https://i.dummyjson.com/data/products/26/1.jpg",
        "https://i.dummyjson.com/data/products/26/2.jpg",
        "https://i.dummyjson.com/data/products/26/3.jpg",
        "https://i.dummyjson.com/data/products/26/4.jpg",
        "https://i.dummyjson.com/data/products/26/5.jpg",
        "https://i.dummyjson.com/data/products/26/thumbnail.jpg"
    }
},
new Product
{
    Id = 27,
    Title = "Flying Wooden Bird",
    Description = "Package Include 6 Birds with Adhesive Tape Shape: 3D Shaped Wooden Birds Material: Wooden MDF, Laminated 3.5mm",
    Price = 51,
    DiscountPercentage = 15.58,
    Rating = 2,
    Stock = 17,
    Brand = "Flying Wooden",
    Category = "home-decoration",
    Thumbnail = "https://i.dummyjson.com/data/products/27/thumbnail.webp",
    Images = new List<string>
    {
        "https://i.dummyjson.com/data/products/27/1.jpg",
        "https://i.dummyjson.com/data/products/27/2.jpg",
        "https://i.dummyjson.com/data/products/27/3.jpg",
        "https://i.dummyjson.com/data/products/27/4.jpg",
        "https://i.dummyjson.com/data/products/27/thumbnail.webp"
    }
},
new Product
{
    Id = 28,
    Title = "3D Embellishment Art Lamp",
    Description = "3D led lamp sticker Wall sticker 3d wall art light on/off button cell operated (included)",
    Price = 20,
    DiscountPercentage = 16.49,
    Rating = 2,
    Stock = 54,
    Brand = "LED Lights",
    Category = "home-decoration",
    Thumbnail = "https://i.dummyjson.com/data/products/28/thumbnail.jpg",
    Images = new List<string>
    {
        "https://i.dummyjson.com/data/products/28/1.jpg",
        "https://i.dummyjson.com/data/products/28/2.jpg",
        "https://i.dummyjson.com/data/products/28/3.png",
        "https://i.dummyjson.com/data/products/28/4.jpg",
        "https://i.dummyjson.com/data/products/28/thumbnail.jpg"
    }
},
new Product
{
    Id = 29,
    Title = "Handcraft Chinese style",
    Description = "Handcraft Chinese style art luxury palace hotel villa mansion home decor ceramic vase with brass fruit plate",
    Price = 60,
    DiscountPercentage = 15.34,
    Rating = 3,
    Stock = 7,
    Brand = "Luxury Palace",
    Category = "home-decoration",
    Thumbnail = "https://i.dummyjson.com/data/products/29/thumbnail.webp",
    Images = new List<string>
    {
        "https://i.dummyjson.com/data/products/29/1.jpg",
        "https://i.dummyjson.com/data/products/29/2.jpg",
        "https://i.dummyjson.com/data/products/29/3.webp",
        "https://i.dummyjson.com/data/products/29/4.webp",
        "https://i.dummyjson.com/data/products/29/thumbnail.webp"
    }
},
new Product
{
    Id = 30,
    Title = "Key Holder",
    Description = "Attractive Design Metallic material Four key hooks Reliable & Durable Premium Quality",
    Price = 30,
    DiscountPercentage = 2.92,
    Rating = 5,
    Stock = 54,
    Brand = "Golden",
    Category = "home-decoration",
    Thumbnail = "https://i.dummyjson.com/data/products/30/thumbnail.jpg",
    Images = new List<string>
    {
        "https://i.dummyjson.com/data/products/30/1.jpg",
        "https://i.dummyjson.com/data/products/30/2.jpg",
        "https://i.dummyjson.com/data/products/30/3.jpg",
        "https://i.dummyjson.com/data/products/30/thumbnail.jpg"
    }
}
            };

            return productos;
        }

 
    }

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double DiscountPercentage { get; set; }
        public double Rating { get; set; }
        public int Stock { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Thumbnail { get; set; }
        public List<string> Images { get; set; }
    }
}
