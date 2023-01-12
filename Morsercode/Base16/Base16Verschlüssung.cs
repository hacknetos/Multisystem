using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsercode.Base16
{
    internal class Base16Verschlüssung
    {
        public string verschlüsselung(string Klartext)
        {
            string ausgabe = "";

            char[] tmp = Klartext.ToCharArray();
            foreach (var item in tmp)
            {
                int tmp2 = item;
                ausgabe += Convert.ToString(tmp2, 16) +" ";
            }






            return ausgabe;
        }
    }
}
