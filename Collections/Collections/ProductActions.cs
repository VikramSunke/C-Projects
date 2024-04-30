using System;
using System.Collections.Generic;

namespace Collections
{
    public class ProductActions
    {
        List<ProductModel> productsList = new List<ProductModel>();

        public void Create(ProductModel newProduct)
        {
            productsList.Add(newProduct);
        }

        public List<ProductModel> ReadAll()
        {
            return productsList;
        }

        public ProductModel ReadById(int productId)
        {
            return productsList.FirstOrDefault(p => p.ProductId == productId);
        }

        public void Update(ProductModel updatedProduct)
        {
            ProductModel productToUpdate = productsList.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (productToUpdate != null)
            {
                productToUpdate.Name = updatedProduct.Name;
                productToUpdate.Description = updatedProduct.Description;
                productToUpdate.Price = updatedProduct.Price;
                productToUpdate.ProductImage = updatedProduct.ProductImage;
            }
        }

        public void Delete(int deleteById)
        {
            foreach (ProductModel product in productsList)
            {
                if (product.ProductId == deleteById)
                {
                    productsList.Remove(product);
                    break;
                }
            }
        }
    }
}
