using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsercode.Vigenere
{
    public class KlarToKrypto
    {
        public string verschlüsseln(string klartext, string schlüssel)
        {
            string ausgabe = "";
            schlüssel = schlüssel.ToUpper();
            klartext = klartext.ToUpper();
            if (schlüssel.Length < klartext.Length)
            {
                int a = schlüssel.Length;
                string b = "";
                for (int i = 0; i < klartext.Length; i = i + a)
                {

                    b += schlüssel;
                }
                schlüssel += b;
            }
            for (int i = 0; i < klartext.Length; i++)
            {
                
                int  row = klartext[i] - 'A';
                int col = schlüssel[i] - 'A';
                int erg = row + col + 'A';
                ausgabe += (char)erg;
                
                
            }
            return ausgabe;
        }
    }
}
