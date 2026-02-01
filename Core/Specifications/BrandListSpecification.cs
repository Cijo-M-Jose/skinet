using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications;

public class BrandListSpecification : BaseSpecification<Product, String>
{
    public BrandListSpecification()
    {
        AddSelect(p => p.Brand);
        ApplyDistinct();
    }
}
