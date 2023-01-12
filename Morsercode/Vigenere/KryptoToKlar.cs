using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsercode.Vigenere
{
    public class KryptoToKlar
    {
        public string entschlüsseln(string kryptotext, string schlüssel)
        {
            string ausgabe = "";
            schlüssel = schlüssel.ToUpper();
            
            if (schlüssel.Length < kryptotext.Length)
            {
                int a = schlüssel.Length;
                string b = "";
                for (int i = 0; i < kryptotext.Length; i = i + a)
                {

                    b += schlüssel;
                }
                schlüssel += b;
            }
            for (int i = 0; i < kryptotext.Length; i++)
            {



                    int erg;
                    int row = kryptotext[i] -'A';
                    int col = schlüssel[i]-'A';
                
                
                     erg = Math.Abs(row - col +'A');
                
                    
                    ausgabe += (char)erg;


                

             }
            return ausgabe;
        }
    }
}
