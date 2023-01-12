using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsercode.Base32
{
    internal class Base32crypto
    {
        private Dictionary<char, int>BaseTabell = new Dictionary<char, int>()
        {
            {'0',0 },
            {'1',1 },
            {'2',2 },
            {'3',3 },
            {'4',4 },
            {'5',5 },
            {'6',6 },
            {'7',7 },
            {'8',8 },
            {'9',9 },
            {'A',10 },
            {'B',11},
            {'C',12},
            {'D',13 },
            {'E',14 },
            {'F',15 },
            {'G',16 },
            {'H',17 },
            {'I',18 },
            {'J',19 },
            {'K',20 },
            {'L',21 },
            {'M',22 },
            {'N',23 },
            {'O',24 },
            {'P',25 },
            {'Q',26 },
            {'R',27 },
            {'S',28 },
            {'T',29 },
            {'U',30 },
            {'V',31 },
        };
       public string ver(string input)
        {
            string ausgabe = "";
            string[] tmp = input.Split(' ');
            List<string> tmp2 = new List<string>();
            List<int[]> bytes = new List<int[]>();
            
            foreach (var item in tmp)
            {
                string a = "";
                foreach (var item2 in item)
                {
                    try
                    {
                        a += BaseTabell[item2];
                    }
                    catch (Exception)
                    {

                        a += item2;
                    }
                    
                }
                tmp2.Add(a);
            }
            byte offset = 0;
            byte voe = 0;
            foreach ( var item in tmp2)
            {
                byte[] a = new byte[8];
                foreach (var item2 in item)
                {
                   offset = Convert.ToByte(item2);
                    for (int i = 0; i < 8; i++)
                    {
                        for (int x = 0;  x <  5- voe.ToString().Length;  x++)
                        {
                            
                        }
                    }
                    //TODO Fest gefahren wann anders weiter machen 
                    
                }
            }
          
            




            return ausgabe;
        }
    }
}
