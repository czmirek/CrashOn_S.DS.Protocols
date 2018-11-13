using AuthLibraryInterface;
using System;
using System.Linq;
using System.IO;
using System.Reflection;

namespace AssemblyLoadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //build solution before starting

            const string libPath = "../../../../AuthLibrary.LDAP/bin/Debug/netcoreapp2.1/AuthLibrary.LDAP.dll";
            var fi = new FileInfo(libPath);

            Assembly assembly = Assembly.LoadFrom(fi.FullName);
            Type type = assembly.GetTypes().Single(t => typeof(IAuthentication).IsAssignableFrom(t));


            IAuthentication auth = Activator.CreateInstance(type) as IAuthentication;

            //crashes on PlatformNotSupportedException
            auth.Authenticate("name", "password");


            Console.WriteLine("Success!");
            Console.ReadLine();
        }
    }
}
