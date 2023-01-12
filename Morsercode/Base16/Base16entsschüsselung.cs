using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsercode.Base16
{
    internal class Base16entsschüsselung
    {
        public string entschlüsselnug(string input)
        {
            string ausgabe = "";
            string[] splittet = input.Split(' ');
            for (int i = 0; i<splittet.Length -1;i++)
            {
                ausgabe += (char)System.Convert.ToInt32(splittet[i], 16);
            }
            return ausgabe;
        }

    }
}
