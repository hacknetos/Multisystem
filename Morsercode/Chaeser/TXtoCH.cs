using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Morsercode.Chaeser
{
    public class TXtoCH
    {
        //public char array with the Alphabet
        public char[] alphabet = new char[26] { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
        public char[] Kryptoalphabet = new char[26] { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };

       
        public char[] getaphabet() { return alphabet; }
        public char[] getKryptoAlphabet() { return Kryptoalphabet; }
        public void ander(int ofset)
        {
            string erg = "";
            foreach (var tmp in alphabet)
            {
                if ((tmp + ofset) > 90)
                {
                    int i = 90 - tmp;
                    var a = ((char)((ofset - i) + 64));
                    erg += ((char)((ofset - i) + 64));
                }
                else
                {
                    erg += ((char)(tmp + ofset));
                }
                System.Console.WriteLine(erg);
                Kryptoalphabet = erg.ToArray();
                
            }
        }
        public String convertChaesar(String Text,int ofset)
        {
            String erg = "";
            foreach (var stabe in Text.ToUpper())
            {
                if (((int)(stabe)) > 90 || ((int)(stabe)) < 65)
                {
                    erg += stabe;
                }
                else if (stabe == ' ')
                {
                    erg += ' ';
                }
                else if ((stabe + ofset) > 90)
                {
                    int i = 90 - stabe;
                    erg += ((char)((ofset - i) + 64));
                }
                else
                {
                    erg += ((char)(stabe + ofset));
                }
            }


            return erg;
        }


    }
}
