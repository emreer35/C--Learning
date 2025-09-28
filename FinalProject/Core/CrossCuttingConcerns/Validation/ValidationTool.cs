using System;
using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation;

public static class ValidationTool
{

    // ProductValidator productValidator = new ProductValidator();
    // bu tarz validator yani yukarida ki gibi Product Validator un tuttugu bir interface 
    // yani bir referance tutucu bulmak gerekir ProductValidtor -> AbstractValidatior -> IValidatior -> Validate()
    // daha sonrasinda validation verirken entity herahngi bir entity olabilir dto gibisinden hepsi obejct oldugundan 
    // object entity deriz
    public static void Validate(IValidator validator, object entity)
    {
        var context = new ValidationContext<object>(entity);
        var result = validator.Validate(context);
        if (!result.IsValid)
        {
            throw new ValidationException(result.Errors);
        }
    }
}
