using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class ProductService
    {
        List<Product> products = new List<Product>();
        /// <summary>
        /// Sisteme yeni bir ürün ekler
        /// </summary>
        /// <param name="product">Eklenecek yeni ürün</param>
        public void CreateProduct(Product product)
        {
            products.Add(product);
        }

        public int TotalProductsCount { get => products.Count; }

        public int ActiveProductsCount { get => products.Count(p => p.IsActive); }

        public Product GetProductWithMaxPrice() => products.MaxBy(p => p.Price);
        public Product GetProductWithMinPrice() => products.MinBy(p => p.Price);

        /// <summary>
        /// Ürünlerin ortalama fiyatını getirir.
        /// </summary>
        /// <returns>Ortalama fiyat</returns>
        public double GetAveragePrice() => products.Average(p => p.Price);


    }
}
