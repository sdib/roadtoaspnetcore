using System;
using Microsoft.Extensions.DependencyInjection;

namespace MS.Experiences.Migration
{
    public class AspNetCoreDependencyResolver : IDependencyResolver
    {
        private readonly IServiceProvider _serviceProvider;

        public AspNetCoreDependencyResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public T Resolve<T>()
        {
            return _serviceProvider.GetService<T>();
        }
    }
}