using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsercode
{
    public class convertMorser
    {
        String text,erg ;
        char Trenzeichen = ' ';
        private Dictionary<char, string> Morsecode = new Dictionary<char, string>()
        {
            {'a',String.Concat(".-") }, 
            {'b',String.Concat("-...") }, 
            {'c',String.Concat("-.-.") }, 
            {'d',String.Concat("-..") }, 
            {'e',String.Concat(".") }, 
            {'f',String.Concat("..-.") }, 
            {'g',String.Concat("--.") }, 
            {'h',String.Concat("....") }, 
            {'i',String.Concat("..") }, 
            {'j',String.Concat(".---") }, 
            {'k',String.Concat("-.-") }, 
            {'l',String.Concat(".-..") }, 
            {'m',String.Concat("--") }, 
            {'n',String.Concat("-.") }, 
            {'o',String.Concat("---") }, 
            {'p',String.Concat(".--.") }, 
            {'q',String.Concat("--.-") }, 
            {'r',String.Concat(".-.") }, 
            {'s',String.Concat("...") }, 
            {'t',String.Concat("-") }, 
            {'u',String.Concat("..-") }, 
            {'v',String.Concat("...-") }, 
            {'w',String.Concat(".--") }, 
            {'x',String.Concat("-..-") }, 
            {'y',String.Concat("-.--") }, 
            {'z',String.Concat("--..") }, 
            {'0',String.Concat("-----") }, 
            {'1',String.Concat(".----") }, 
            {'2',String.Concat("..---") }, 
            {'3',String.Concat("...--") }, 
            {'4',String.Concat("....-") }, 
            {'5',String.Concat(".....") }, 
            {'6',String.Concat("-....") }, 
            {'7',String.Concat("--...") }, 
            {'8',String.Concat("---..") }, 
            {'9',String.Concat("----.") }, 
            {'.',String.Concat(".-.-.-") }, 
            {',',String.Concat("--.--") }, 
            {'?',String.Concat("..--..") }, 
            {':',String.Concat("---...") }, 
            {';',String.Concat("-.-.-.") }, 
            {' ',String.Concat(" ") }, 
            {'/',String.Concat("-..-.") },
            {'ä',String.Concat(".-.-") },
            {'ü',String.Concat("..--") },
            {'ß',String.Concat("...--..") },
            {'(',String.Concat("-.--.") },
            {')',String.Concat("-.--.-") },
            {'=',String.Concat("-...-") },
            {'@',String.Concat(".--.-.") },
            {'!',String.Concat("-.-.--") },
            {'-',String.Concat("-....-") },
            {'_',String.Concat("..--.-") },
            {'\r',String.Concat("") }, 
            {'\n',String.Concat("") }, 
            
        };

        public convertMorser(String text)
        {
            this.text = text;
            
        }
        public String getText() { return text; }
        public void setText(String text) { this.text = text; }
        public char getTrenzeichen() {return Trenzeichen;}
        public void setTrenzeichen(char Trenzeichen) { this.Trenzeichen = Trenzeichen;}
        public String getErg() { return erg; }
        public void setErg(String erg) { this.erg = erg; }

        public String translation() 
        {
            String translation = "";

            //try
            //{
                foreach (var zeichen in text.ToLower())
                {

                    translation += Morsecode[zeichen];
                    translation += Trenzeichen;


                }
                
                
                return translation;
            //}
            //catch (Exception)
            //{

            //    return "das Zeichen kenne ich nicht Sorry :(";
            //}
           

        }
        public Task Beep(String zeichen)
        {
            foreach (var item in zeichen)
            {
                if (item == ' ')
                {
                    Task.Delay(5000);
                }
                else if (item == '-')
                {
                    Console.Beep(3000, 750);
                }
                else if (item == '.')
                {

                    Console.Beep(2500, 250);
                }
                Task.Delay(750);
            }
            return Task.CompletedTask;
        }

       


    }
}
