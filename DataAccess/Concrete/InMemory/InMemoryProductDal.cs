using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IEntitiyRepository<Product>
    {
        public List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15 },
                new Product{ProductId = 2, CategoryId=2, ProductName="Catal", UnitPrice=12, UnitsInStock=2 },
                new Product{ProductId = 3, CategoryId=2, ProductName="Bıcak", UnitPrice=14, UnitsInStock=4 },
                new Product{ProductId = 4, CategoryId=1, ProductName="Fincan", UnitPrice=20, UnitsInStock=7 },
                new Product{ProductId = 5, CategoryId=1, ProductName="Tabak", UnitPrice=40, UnitsInStock=0 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            _products.Remove(product);
        }


        public Product Get(int id)
        {
            return _products.Where(p => p.ProductId == id).FirstOrDefault();
        }



        public List<Product> GetAll()
        {
            return _products;

        }

        public List<Product> GetAllByCategories(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

         
      

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;


        }
    }
}
