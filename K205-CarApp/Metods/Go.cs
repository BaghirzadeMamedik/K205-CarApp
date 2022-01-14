using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K205_CarApp.Metods
{
    public class Go
    {
        public void HereketeBasla(decimal benzin)
        {
            Console.WriteLine("Nece Km yol geceksiniz?");

            string yol = Console.ReadLine();

            decimal netice = (Convert.ToDecimal(yol)* 10) / 100;

            decimal qalanBenzin = benzin - netice;

            Console.WriteLine("Sizin " +  qalanBenzin + " litr benzininiz qaldi");
            
        }
    }
}
