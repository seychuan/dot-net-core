using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace LoadExternalController.WebAPI.Main.Extensions
{
    public static class MvcBuilderExtension
    {
        internal static IMvcBuilder AddExternalControllers(this IMvcBuilder builder)
        {
            List<Assembly> assemblies = new List<Assembly>();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            foreach (string dll in Directory.GetFiles(path, "*.dll"))
            {
                assemblies.Add(Assembly.LoadFile(dll));
            }

            foreach (var asm in assemblies)
            {
                builder.AddApplicationPart(asm);
            }

            builder.AddControllersAsServices();

            return builder;
        }
    }
}
