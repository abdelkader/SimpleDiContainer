using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleDiContainer.DI
{
    public class SimpleDiContainer
    {
        private readonly Dictionary<Type, Func<SimpleDiContainer, object>> _registrations =
            new Dictionary<Type, Func<SimpleDiContainer, object>>();

        public void Register<TService, TImplementation>() where TImplementation : TService
        {
            _registrations[typeof(TService)] = (container) =>
                CreateInstance(typeof(TImplementation), container);
        }

        public TService Resolve<TService>()
        {
            var serviceType = typeof(TService);

            if (_registrations.TryGetValue(serviceType, out var factory))
            {
                return (TService)factory(this);
            }

            return (TService)CreateInstance(serviceType, this);
        }

        private object CreateInstance(Type implementationType, SimpleDiContainer container)
        {
            var constructors = implementationType.GetConstructors();

            if (constructors.Length == 0)
            {
                throw new InvalidOperationException(
                    $"No public constructor found for type {implementationType.Name}");
            }

            var constructor = constructors.OrderByDescending(c => c.GetParameters().Length).First();
            var parameters = constructor.GetParameters();

            if (parameters.Length == 0)
            {
                return Activator.CreateInstance(implementationType);
            }

            var parameterInstances = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                var parameterType = parameters[i].ParameterType;

                if (!container._registrations.ContainsKey(parameterType))
                {
                    throw new InvalidOperationException(
                        $"Cannot resolve dependency {parameterType.Name} for {implementationType.Name}");
                }

                parameterInstances[i] = container._registrations[parameterType](container);
            }

            return Activator.CreateInstance(implementationType, parameterInstances);
        }
    }
}
