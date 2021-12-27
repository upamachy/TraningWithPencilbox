using RepoPractice.Model.EntityModel;
using RepoPractice.Repositories;
using System;
using System.Collections.Generic;

namespace RepoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandsRepository BrandRepo = new BrandsRepository();
            ProductsRepository ProRepo = new ProductsRepository();

            #region AddItem
            var items = new List<Item>()
            {
                new Item()
                {
                    Name="Sharee",
                    Price =3136,
                    Manufacturedate=DateTime.Now
                },
                 new Item()
                {
                    Name="Kurti",
                    Price =31362,
                    Manufacturedate=DateTime.Now
                },
                  new Item()
                {
                    Name="lehenga",
                    Price =313645,
                    Manufacturedate=DateTime.Now
                }
            };

            var item1 = new List<Item>()
            {
                new Item()
                {
                    Name="Mobile",
                    Price=6365,
                    Manufacturedate=DateTime.Now
                },

                new Item()
                {
                    Name="Laptop",
                    Price=63651,
                    Manufacturedate=DateTime.Now
                }
            };
            var items2 = new List<Item>()
            {
                new Item()
                {
                    Name="Churi",
                    Price =3136,
                    Manufacturedate=DateTime.Now
                },
                 new Item()
                {
                    Name="EarRing",
                    Price =31362,
                    Manufacturedate=DateTime.Now
                },
                  new Item()
                {
                    Name="Necklace",
                    Price =313645,
                    Manufacturedate=DateTime.Now
                }
            };


            var BrandList = new List<Brand>()
            {
              new Brand(){Name="Shoilpik",Items=items},
              new Brand(){Name="Lenevo",Items=item1},
              new Brand(){Name ="Arong",Items=items2}

            };

            //BrandRepo.Add(BrandList);

            var Brands = BrandRepo.GetAll();
            foreach ( var brand in Brands )
            {
                Console.WriteLine($"Brand Id:{brand.Id} and Brand Name:{brand.Name}");
                Console.WriteLine("        ");
                foreach (var item in brand.Items)
                {
                    Console.WriteLine($"Item Id:{item.Id} Item Name:{item.Name} and ManufacturingDate:{item.Manufacturedate}");
                }
                Console.WriteLine("      ");
            }

            var brandName=BrandRepo.GetId(2);
            brandName.Name = "Samsung_Updated";
            BrandRepo.Update(brandName);

            var ProductName = ProRepo.GetId(4);
            ProductName.Name = "Smart Watch";
            ProRepo.Update(ProductName);




            #endregion
        }
    }
}
