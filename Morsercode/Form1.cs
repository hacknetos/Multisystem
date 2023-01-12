using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Morsercode;
using Morsercode.Chaeser;
using Morsercode.Vigenere;
using Morsercode.Base16;
using Morsercode.Base32;

namespace Morsercode
{
    public partial class Form1 : Form
    {
        private convertMorser m = new convertMorser("");
        private convertText mtext = new convertText();
        private TXtoCH t = new TXtoCH();
        private CHtoTX c = new CHtoTX();
        Loade l = new Loade();
        saveer s = new saveer("Save");
        public Form1()
        {
            InitializeComponent();
        }

        private void TextinMorser_Click(object sender, EventArgs e)
        {
            m.setText(Normalinput.Text);
            morsercode.Text = m.translation();
        }

        private void MorserinText_Click(object sender, EventArgs e)
        {
            mtext.setText(morsercode.Text);
            Normalinput.Text =  mtext.translation();
        }

        private void beep_Click(object sender, EventArgs e)
        {
            Task.Run(() => m.Beep(morsercode.Text));
        }

        private void clearnormal_Click(object sender, EventArgs e)
        {
            Normalinput.Text = "";
        }

        private void clearMorser_Click(object sender, EventArgs e)
        {
            morsercode.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {


            
            saveer s = new saveer("Save");

            if (wahtsave.Checked)
            {
                Task.Run(() => s.filesave(morsercode.Text));
            }
            else
            {
                Task.Run(() => s.filesave(Normalinput.Text));
            }
        }

        private void Loade_Click(object sender, EventArgs e)
        {
           Loade l = new Loade();
            var tmp = l.Loader();
            if (tmp.StartsWith(".") || tmp.StartsWith("-") )
            {
                morsercode.Text = tmp;
            }
            else
            {
                Normalinput.Text = tmp;
            }

        }

        //------------------------------------------------------------------------
        //Chaesar start 
        //------------------------------------------------------------------------

        private void Chaesarupdown_ValueChanged(object sender, EventArgs e)
        {
            Chaesartracker.Value = Int32.Parse(Chaesarupdown.Value.ToString());

            UpdateAlphabet();
        }

        private void Chaesartracker_Scroll(object sender, EventArgs e)
        {
            Chaesarupdown.Value = Chaesartracker.Value;
            UpdateAlphabet();
        }

        private void ClearCHT_Click(object sender, EventArgs e)
        {
            Klartext.Clear();
        }

        private void ClearCH_Click(object sender, EventArgs e)
        {
            Kryptotext.Clear();
        }

        private void ConvertoChaesar_Click(object sender, EventArgs e)
        {
            
            
            Kryptotext.Text = t.convertChaesar(Klartext.Text, Chaesartracker.Value);
        }

        private void UpdateAlphabet() {
            t.ander(Int32.Parse(Chaesarupdown.Value.ToString()));
            char[] a = t.getKryptoAlphabet();
            Kryproalpa.Clear();
            foreach (var item in a)
            {
                Kryproalpa.Text += item + ",";
            }
        }

        private void ConverttoTextCH_Click(object sender, EventArgs e)
        {
            Klartext.Text = c.converTXtoCH(Kryptotext.Text, Chaesartracker.Value);
        }

        private void SaveCHT_Click(object sender, EventArgs e)
        {
            s.filesave(Klartext.Text);
        }

        private void saveCH_Click(object sender, EventArgs e)
        {
            s.filesave(Kryptotext.Text);
        }


        private void LoadeCHT_Click(object sender, EventArgs e)
        {
            KlartextChaesar.Text = l.Loader();
        }

        private void LoadeCH_Click(object sender, EventArgs e)
        {
            Kryptotext.Text = l.Loader();
        }

       
        private void Normalinput_TextChanged(object sender, EventArgs e)
        {
        }

        private void morsercode_TextChanged(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------------
        //Start Vigenere
        //--------------------------------------------------------------
        private void VirgenereKlarCon_Click(object sender, EventArgs e)
        {
            KlarToKrypto a = new KlarToKrypto();
            KryptoTextVigenere.Text = a.verschlüsseln(KlarTextVigenere.Text, Key.Text);
        }

        private void Vigenekyriptocon_Click(object sender, EventArgs e)
        {
            KryptoToKlar a = new KryptoToKlar();
           KlarTextVigenere.Text = a.entschlüsseln(KryptoTextVigenere.Text, Key.Text);
        }
        private void KlarTextVigenere_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void KryptoTextVigenere_TextChanged(object sender, EventArgs e)
        {
            //KryptoToKlar a = new KryptoToKlar();
            //KlarTextVigenere.Text = a.entschlüsseln(KryptoTextVigenere.Text, Key.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base16Verschlüssung a = new Base16Verschlüssung();
            Base16Cry.Text = a.verschlüsselung(Base16klahr.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Base16entsschüsselung a = new Base16entsschüsselung();
            Base16klahr.Text = a.entschlüsselnug(Base16Cry.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Base32crypto a = new Base32crypto();
            Base32cry.Text = a.ver(Base32Klahr.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
