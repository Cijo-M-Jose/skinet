using System;
using Core.Entities;

namespace Core.Specifications;

public class TypeListSpecification : BaseSpecification<Product, String>
{
    public TypeListSpecification()
    {
        AddSelect(p => p.Type);
        ApplyDistinct();
    }
}
