using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace CommandDispatcherDemo.Handlers
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCommandHandlers(this IServiceCollection services, Assembly assembly)
        {
            var types = from t in assembly.DefinedTypes
                        where t.ImplementedInterfaces.Any()
                        let i = t.ImplementedInterfaces.First()
                        where i.IsGenericType
                        let d = i.GetGenericTypeDefinition()
                        where d == typeof(ICommandHandler<>)
                           || d == typeof(ICommandHandler<,>)
                        select t;

            foreach (var type in types)
            {
                services.AddTransient(type.ImplementedInterfaces.First(), type);
            }

            return services;
        }
    }
}
