using Day_7.Database;
using Day_7.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Category category = new Category() { Name ="Furniture"};
            //Category category2 = new Category() { Name ="Electronics"};
            //Category category3 = new Category() { Name ="Home_Appliance"};
            //var categories = new[]
            //{
            //    new Category(){Name="Clothing"},
            //    new Category(){Name="Stationaries"},
            //    new Category(){Name="Vehicles"}
            //};


            SMEcommerceDbcontext db = new SMEcommerceDbcontext();
            //var category = new Category()
            //{
            //    Name = "Gadgets"
            //};
            //var items = new List<Item>()
            //{
            //    new Item()
            //    {
            //        Name="Smart Watch",
            //        Price =61361,
            //        Manufacturedate=DateTime.Now
            //    },

            //     new Item()
            //    {
            //        Name="Google glass",
            //        Price =648746,
            //        Manufacturedate=DateTime.Now
            //    }
            //};

            //category.Items = items;
            //db.Categories.Add(category);
            //db.SaveChanges();

            //db.Categories.Add(category);
            //db.Categories.Add(category2);
            //db.Add(category3);
            //db.Categories.AddRange(categories);

            #region Brand

            var brand = new Brand()
            { 
                Name="Hatil"
            };
            var items = new List<Item>()
            {
                new Item()
                {
                    Name="Chair",
                    Price =3136,
                    Manufacturedate=DateTime.Now
                },
                 new Item()
                {
                    Name="Table",
                    Price =31362,
                    Manufacturedate=DateTime.Now
                },
                  new Item()
                {
                    Name="Bed",
                    Price =313645,
                    Manufacturedate=DateTime.Now
                }
            };

            brand.Items = items;
            db.Brands.Add(brand);
            int sucessCount = db.SaveChanges();

            if(sucessCount>0)
            {
               Console.WriteLine($"Build Sucessfully and the SucessCount is: {sucessCount}");
            }

            //Read Data

            var brands = db.Brands;

            int i = 0;
            foreach (var item in brands)
            {
              Console.WriteLine($"[{++i}] Id:{item.Id} name: {item.Name}");
            }

            #endregion

            //Console.WriteLine("Please provide input......");
            //var id=int.Parse(Console.ReadLine());
            //var category = db.Categories.FirstOrDefault(x => x.Id == id);
            //Console.WriteLine($"The Id: {category.Id} and the Name:{category.Name}");

            //Console.WriteLine("Change the Name:");
            //var changedName = Console.ReadLine();
            //category.Name = changedName;
            //int successCount = db.SaveChanges();
            //if(successCount>0)
            //{
            //    Console.WriteLine($"Sucessfully Updated! and the Sucess Count is : {successCount}");
            //}
        }
    }
}
