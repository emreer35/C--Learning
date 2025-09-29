using System;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;


namespace Core.Aspects.Autofac.Validation;

 public class ValidationAspect:MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            // defensive coding
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
        {
            throw new System.Exception("Bu bir dogrulama sinifi degildir");
        }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; // basetype ini bul(abstractValidator<Product vb...>) ilk generigi al
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator,entity);
            }
        }
    }
