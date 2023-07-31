using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.Mime.MediaTypeNames;



namespace ConsoleUI // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {

            var productManager = new ProductManager(new InMemoryProductDal());
            var inMemoryProductDal = new InMemoryProductDal();
            var product2 = new Product { ProductId = 23, CategoryId = 12, ProductName = "Makas", UnitPrice = 150, UnitsInStock = 1 };
            productManager.Add(product2);

            productManager.Add(new Product
            {
                ProductId = 5,
                CategoryId = 10,
                ProductName = "Maşa",
                UnitPrice = 55,
                UnitsInStock = 2
            });

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine($"{product.ProductName} \t {product.UnitPrice}TL \t {product.UnitsInStock} " +
                    $"Tane kaldı \t {product.CategoryId}. Kategori");
            }

            Console.WriteLine("******************************************************");

            product2.ProductName = "changd";
            product2.UnitsInStock = 0;
            productManager.Update(product2);

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine($"{product.ProductName} \t {product.UnitPrice}TL \t {product.UnitsInStock} " +
                    $"Tane kaldı \t {product.CategoryId}. Kategori");
            }

            Console.WriteLine("******************************************************");

            productManager.Delete(product2);

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine($"{product.ProductName} \t {product.UnitPrice}TL \t {product.UnitsInStock} " +
                    $"Tane kaldı \t {product.CategoryId}. Kategori");
            }


            Console.WriteLine("******************************************************");
            List<Product> liste;
            liste = productManager.GetAll();
            foreach (var s in liste)
            {
                Console.WriteLine(s.ProductName);
            }
            
            

        }
    }
}

