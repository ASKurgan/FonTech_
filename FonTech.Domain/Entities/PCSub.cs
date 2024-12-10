using FonTech.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonTech.Domain.Entities
{
    public class PCSub : Entity
    {
        private PCSub() { }
        private PCSub(string name)
        {
            Name = name;

        }

        public string Name { get; private set; } = string.Empty;
        // public Guid ProductCategoryId { get; private set; } = Guid.Empty;
        //public IReadOnlyList<Product> Products => _products;
        //private readonly List<Product> _products = [];


        //public Result<Guid> AddProduct(Product product)
        //{
        //    if (product == null)
        //    {
        //        return Errors.General.NotFound();
        //    }
        //    if (_products.Any(p => p.Name == product.Name))
        //    {
        //        return Errors.General.ProductAlreadyExists(product.Name);
        //    }

        //    _products.Add(product);

        //    return product.Id;
        //}

        //public Result<Guid> DeleteProduct(Guid id)
        //{
        //    var product = _products.FirstOrDefault(p => p.Id == id);
        //    if (product is null)
        //        return Errors.General.NotFound();
        //    var productId = product.Id;
        //    _products.Remove(product);
        //    return productId;

        //}

        public static Result<PCSub> Create(string name)
        {
            if (name.IsEmpty() || name.Length > Constraints.SHORT_TITLE_LENGTH
                 || name.Length < Constraints.MINIMUM_TITLE_LENGTH)
                return Errors.General.InvalidLength(nameof(name));


            return new PCSub(name);
        }
    }
}
