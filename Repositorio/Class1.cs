using System;
using System.Linq;
using System.Reflection;

namespace Repositorio
{
    public static class Class1
    {
        [STAThread]
        static void Main(string[] args)
        {
            var tipo = Assembly.Load(new AssemblyName("Biblioteca.Entidades"));
            var classes = tipo.ExportedTypes.Where(t =>
            {
                var ti = t.GetTypeInfo();
                return ti.IsClass && !ti.IsAbstract;
            }).ToList();

            Console.WriteLine("Olá");

            //.SelectMany(a => a.GetTypes().Where(t => t.Namespace == ns).Select(t => t.Name));
        }
    }
}
