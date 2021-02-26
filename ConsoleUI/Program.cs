using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLİD
    //Open closed Principle:yaptığın yazılıma yeni bir özellik ekliyorsan mevcyttaki hiç bir koda dokunamazsın
    class Program
    {
        static void Main(string[] args)
        {
            //DTO: Data Transformation Object
            //ProductTest();
            //CategoryTest();
           
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName+"/"+product.CategoryName);
            }
        }
    }
}
