using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Globalization_01.RESX;
using System.Resources;

namespace Globalization_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture);

            DateTime dt = DateTime.Now;
            decimal val = 1603.42m;
            Console.WriteLine(val.ToString("C3", new CultureInfo("en-US")));
            Console.WriteLine(val.ToString("C3", new CultureInfo("fr-CA")));
            Console.WriteLine(val.ToString("C3", new CultureInfo("fr-FR")));
            Console.WriteLine(val.ToString("C3", new CultureInfo("uk-UA")));

            Console.WriteLine("Input Name:");

            Console.WriteLine(labels.InputNameLabel);

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine(labels.InputNameLabel);

            //ResourceManager resMan = new ResourceManager(typeof(labels));
            //Console.WriteLine(resMan);
            //Console.WriteLine(ResourceManager.);

            Console.ReadKey();

        }
    }
}
