using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsercode.Chaeser
{
    internal class CHtoTX
    {
        public string converTXtoCH(string Text, int ofset)
        {
            string erg = "";
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
                else if ((stabe - ofset) < 65)
                {

                    erg += (char)((stabe - ofset) + 26);
                }
                else
                {
                    erg += ((char)(stabe - ofset));
                }
            }
            return erg;
        }
    }
}
