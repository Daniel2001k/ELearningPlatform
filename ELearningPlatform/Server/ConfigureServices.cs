using Ardalis.Specification;
using MediatR;
using Scrutor;

namespace ELearningPlatform.Server;

public static class ConfigureServices
{
    public static void AddHub(this IServiceCollection services, IConfiguration configuration)
    {
        services.Scan(scan => scan.FromCallingAssembly()
                              .AddClasses(classes => classes.Where(RegistrationAllowed))
                              .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                              .AsImplementedInterfaces()
                              .WithTransientLifetime());
    }

    public static bool RegistrationAllowed(Type x)
    {
        var doNotRegister = typeof(Exception).IsAssignableFrom(x)
            || IsMediatorRequest(x)
            || IsRecord(x)
            || IsSubclassOfRawGeneric(typeof(Specification<>), x);
        return !doNotRegister;
    }

    static bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
    {
        while (toCheck != null && toCheck != typeof(object))
        {
            var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
            if (generic == cur)
            {
                return true;
            }
            toCheck = toCheck.BaseType;
        }
        return false;
    }

    static bool IsRecord(Type x)
    {
        return x.GetMethods().Any(m => m.Name == "<Clone>$");
    }

    static bool IsMediatorRequest(Type x)
    {
        return x.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IRequest<>));
    }
}
