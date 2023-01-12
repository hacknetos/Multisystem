using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsercode
{
    internal class convertText
    {
        List<string> text;
        String erg;
        char Trenzeichen = ' ';
        private Dictionary<string , char> Morsecode = new Dictionary<string, char>()
        {
            {".-",'a'},
            {"-...",'b'},
            {"-.-.",'c'},
            {"-..",'d'},
            {".",'e'},
            {"..-.",'f'},
            {"--.",'g'},
            {"....",'h'},
            {"..",'i'},
            {".---",'j'},
            {"-.-",'k'},
            {".-..",'l'},
            {"--",'m'},
            {"-.",'n'},
            {"---",'o'},
            {".--.",'p'},
            {"--.-",'q'},
            {".-.",'r'},
            {"...",'s'},
            {"-",'t'},
            {"..-",'u'},
            {"...-",'v'},
            {".--",'w'},
            {"-..-",'x'},
            {"-.--",'y'},
            {"--..",'z'},
            {"-----",'0'},
            {".----",'1'},
            {"..---",'2'},
            {"...--",'3'},
            {"....-",'4'},
            {".....",'5'},
            {"-....",'6'},
            {"--...",'7'},
            {"---..",'8'},
            {"----.",'9'},
            {".-.-.-",'.'},
            {"--.--",','},
            {"..--..",'?'},
            {"---...",':'},
            {"-.-.-.",';'},
            {"-..-.",'/'},
            {".-..-.",'"'},
            {"",' '},
            {".-.-",'ä'},
            {"..--",'ü'},
            {"...--..",'ß'},
            {"-.--.",'('},
            {"-.--.-",')'},
            {"-...-",'='},
            {".--.-.",'@'},
            {"-.-.--",'!'},
            {"-....-",'-'},
            {"..--.-",'_'},
            {"\r",' '},
            {"\n",' '},
            {"\r\n",' '},
            {"\n\r",' '},

        };

       
        public List<String> getText() { return text; }
        public void setText(String text) { this.text = text.Split(Trenzeichen).ToList(); }
        public char getTrenzeichen() { return Trenzeichen; }
        public void setTrenzeichen(char Trenzeichen) { this.Trenzeichen = Trenzeichen; }
        public String getErg() { return erg; }
        public void setErg(String erg) { this.erg = erg; }

        public String translation()
        {
            
                String translation = "";

                foreach (var zeichen in text)
                {
                    if(zeichen == "")
                    translation += " ";
                
                    if (zeichen != "")
                    translation += Morsecode[zeichen];
                    
                }


                return translation;
            
            
        }

    }
}
