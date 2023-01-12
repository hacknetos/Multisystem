using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsercode
{
    internal class saveer
    {
        
        String   Filename;

        public saveer( string filename)
        {
           
            
            Filename = filename;
        }
        public Task filesave(String lines)
        {
            using (StreamWriter writer = new StreamWriter(Filename + ".txt") )
            {
                    writer.WriteLine(lines);
            }
                return Task.CompletedTask;
        }
    }
}
