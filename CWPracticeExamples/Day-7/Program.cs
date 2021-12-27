using Day_7.Database;
using Day_7.Models.EntityModels;
using Day_7.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_7
{
    class Program
    {
        static void Main(string[] args)
        {

            SMEcommerceDbcontext db = new SMEcommerceDbcontext();

            #region Category

            //var items = new List<Item>()
            //{
            //    new Item()
            //    {
            //        Name="Sharee",
            //        Price =3136,
            //        Manufacturedate=DateTime.Now
            //    },
            //     new Item()
            //    {
            //        Name="Kurti",
            //        Price =31362,
            //        Manufacturedate=DateTime.Now
            //    },
            //      new Item()
            //    {
            //        Name="lehenga",
            //        Price =313645,
            //        Manufacturedate=DateTime.Now
            //    }
            //};

            //var items2 = new List<Item>()
            //{
            //    new Item()
            //    {
            //        Name="Churi",
            //        Price =3136,
            //        Manufacturedate=DateTime.Now
            //    },
            //     new Item()
            //    {
            //        Name="EarRing",
            //        Price =31362,
            //        Manufacturedate=DateTime.Now
            //    },
            //      new Item()
            //    {
            //        Name="Necklace",
            //        Price =313645,
            //        Manufacturedate=DateTime.Now
            //    }
            //};

            //var categortList = new List<Category>()
            //{
            //    new Category(){Name="Dress",Items=items},
            //    new Category(){Name="Ornaments",Items=items2}
            //};


            //var BrandList = new List<Brand>()
            //{
            //  new Brand(){Name="Shoilpik",Items=items},
            //  new Brand(){Name ="Arong",Items=items2}

            //};


            ////db.Categories.AddRange(categortList);
            ////db.Brands.AddRange(BrandList);

            //int sucessCount = db.SaveChanges();

            //if (sucessCount > 0)
            //{
            //    Console.WriteLine($"Build Sucessfully and the SucessCount is: {sucessCount}");
            //}


            #endregion

            #region Brand


            //var items = new List<Item>()
            //{
            //    new Item()
            //    {
            //        Name="Chair",
            //        Price =3136,
            //        Manufacturedate=DateTime.Now
            //    },
            //     new Item()
            //    {
            //        Name="Table",
            //        Price =31362,
            //        Manufacturedate=DateTime.Now
            //    },
            //      new Item()
            //    {
            //        Name="Bed",
            //        Price =313645,
            //        Manufacturedate=DateTime.Now
            //    }
            //};

            //var items2 = new List<Item>()
            //{
            //    new Item()
            //    {
            //        Name="Mobile",
            //        Price =3136,
            //        Manufacturedate=DateTime.Now
            //    },
            //     new Item()
            //    {
            //        Name="Laptop",
            //        Price =31362,
            //        Manufacturedate=DateTime.Now
            //    },
            //      new Item()
            //    {
            //        Name="Keybroad",
            //        Price =313645,
            //        Manufacturedate=DateTime.Now
            //    }
            //};

            //var BrandList = new List<Brand>()
            //{
            //  new Brand(){Name="Otobi",Items=items},
            //  new Brand(){Name ="Lenovo",Items=items2}

            //};



            //db.Brands.AddRange(BrandList);
            //int sucessCount = db.SaveChanges();

            //if (sucessCount > 0)
            //{
            //    Console.WriteLine($"Build Sucessfully and the SucessCount is: {sucessCount}");
            //}

            //Read Data

            //var brands = db.Brands.ToList();


            //foreach (var item in brands)
            //{
            //    Console.WriteLine($" BrandId:{item.Id} BrandName: {item.Name}");
            //    db.Entry(item).Collection(c => c.Items).Load();
            //    Console.WriteLine();
            //    Console.WriteLine($"........items of Brand {item.Name}........");
            //    foreach (var it in item.Items)
            //    {

            //        Console.WriteLine($"Item Name:{it.Name}");
            //    }
            //}

            //var items1 = db.Products.ToList();

            //foreach (var it in items1)
            //{
            //    db.Entry(it).Reference(c => c.Brand).Load();
            //    Console.WriteLine($"Items Brand  Name:{it.Brand.Name}");
            //}


            #endregion

            #region OperationOnSpecificData

            //var brand = db.Brands.FirstOrDefault(c => c.Id == 4);
            //var items = db.Products.Where(c => c.BrandId == 4).ToList();
            //items.Add(new Item() { Name="Smart Watch"});
            ////var item = db.Products.FirstOrDefault(c => c.Id == 4);
            ////item.Name = item.Name + "Changed";

            ////brand.Name = "Samsung";
            //brand.Items = items;
            //int sucessCount = db.SaveChanges();
            //if(sucessCount>0)
            //{
            //    Console.WriteLine("Sucessful");
            //}



            #endregion

            #region UpdateCategoryWithRepository

            CategoryRepositories catRepo = new CategoryRepositories();
            ProductRepositories proRepo = new ProductRepositories();
            var category = catRepo.GetId(1);


            //var items=catRepo.GetAll().ToList();
            //foreach (var item in items)
            //{
            //    foreach (var it in item.Items)
            //    {
            //        Console.WriteLine(it.Name);
            //    }
            //}


            var items = db.Products.Where(c => c.CategoryId == 1 && c.BrandId==1).ToList();
            items.Add(new Item() { Name = "New item 2"});
            var item = db.Products.FirstOrDefault(c => c.Id == 3);
            item.Name = item.Name + "Changed 2";

            //var item = proRepo.GetId(4);
            //item.Name = item.Name + "_Changed";
            //proRepo.Add(item);
            //category.Name = "new Sharees";

            category.Items = items;
            bool issucess = catRepo.Update(category);
            //int successCount = db.SaveChanges();
            if (issucess)
            {
                Console.WriteLine("Sucessful");
            }

            #endregion
        }
    }
}
