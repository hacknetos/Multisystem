namespace Morsercode
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabPane = new System.Windows.Forms.TabControl();
            this.Morser = new System.Windows.Forms.TabPage();
            this.wahtsave = new System.Windows.Forms.CheckBox();
            this.clearMorser = new System.Windows.Forms.Button();
            this.clearnormal = new System.Windows.Forms.Button();
            this.beep = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Loade = new System.Windows.Forms.Button();
            this.TrenZeichen = new System.Windows.Forms.TextBox();
            this.ZeichenLang = new System.Windows.Forms.TextBox();
            this.zeichenKurtz = new System.Windows.Forms.TextBox();
            this.Morsertext = new System.Windows.Forms.Label();
            this.NormelText = new System.Windows.Forms.Label();
            this.MorserinText = new System.Windows.Forms.Button();
            this.TextinMorser = new System.Windows.Forms.Button();
            this.morsercode = new System.Windows.Forms.TextBox();
            this.Normalinput = new System.Windows.Forms.TextBox();
            this.chaesar = new System.Windows.Forms.TabPage();
            this.kryptotextbuttons = new System.Windows.Forms.GroupBox();
            this.ClearCH = new System.Windows.Forms.Button();
            this.LoadeCH = new System.Windows.Forms.Button();
            this.saveCH = new System.Windows.Forms.Button();
            this.Kalrtextbuttons = new System.Windows.Forms.GroupBox();
            this.ClearCHT = new System.Windows.Forms.Button();
            this.LoadeCHT = new System.Windows.Forms.Button();
            this.SaveCHT = new System.Windows.Forms.Button();
            this.Kryproalpa = new System.Windows.Forms.TextBox();
            this.alphabetnormal = new System.Windows.Forms.TextBox();
            this.ConverttoTextCH = new System.Windows.Forms.Button();
            this.ConvertoChaesar = new System.Windows.Forms.Button();
            this.Chaesarupdown = new System.Windows.Forms.NumericUpDown();
            this.Chaesartracker = new System.Windows.Forms.TrackBar();
            this.KryptolabelChaesar = new System.Windows.Forms.Label();
            this.KlartextChaesar = new System.Windows.Forms.Label();
            this.Kryptotext = new System.Windows.Forms.TextBox();
            this.Klartext = new System.Windows.Forms.TextBox();
            this.vigenere = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.GrupeBox2 = new System.Windows.Forms.GroupBox();
            this.VigenereClearKrypto = new System.Windows.Forms.Button();
            this.VigenereLoadeKrypto = new System.Windows.Forms.Button();
            this.VigenereSaveKrypto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VigenereClearklar = new System.Windows.Forms.Button();
            this.VigenereSaveklar = new System.Windows.Forms.Button();
            this.VigenereLoadeklar = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VirgenereKlarCon = new System.Windows.Forms.Button();
            this.Vigenekyriptocon = new System.Windows.Forms.Button();
            this.KryptoTextVigenere = new System.Windows.Forms.TextBox();
            this.KlarTextVigenere = new System.Windows.Forms.TextBox();
            this.RLE = new System.Windows.Forms.TabPage();
            this.Base16 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Base16Cry = new System.Windows.Forms.TextBox();
            this.Base16klahr = new System.Windows.Forms.TextBox();
            this.Base32 = new System.Windows.Forms.TabPage();
            this.Base32Klahr = new System.Windows.Forms.TextBox();
            this.Base32cry = new System.Windows.Forms.TextBox();
            this.verschlüsseln = new System.Windows.Forms.Button();
            this.Entschlüsseln = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RLEver = new System.Windows.Forms.Button();
            this.RLEklar = new System.Windows.Forms.Button();
            this.TabPane.SuspendLayout();
            this.Morser.SuspendLayout();
            this.chaesar.SuspendLayout();
            this.kryptotextbuttons.SuspendLayout();
            this.Kalrtextbuttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chaesarupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chaesartracker)).BeginInit();
            this.vigenere.SuspendLayout();
            this.GrupeBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RLE.SuspendLayout();
            this.Base16.SuspendLayout();
            this.Base32.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPane
            // 
            this.TabPane.Controls.Add(this.Morser);
            this.TabPane.Controls.Add(this.chaesar);
            this.TabPane.Controls.Add(this.vigenere);
            this.TabPane.Controls.Add(this.RLE);
            this.TabPane.Controls.Add(this.Base16);
            this.TabPane.Controls.Add(this.Base32);
            this.TabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPane.Location = new System.Drawing.Point(0, 0);
            this.TabPane.Name = "TabPane";
            this.TabPane.SelectedIndex = 0;
            this.TabPane.Size = new System.Drawing.Size(800, 450);
            this.TabPane.TabIndex = 0;
            // 
            // Morser
            // 
            this.Morser.Controls.Add(this.wahtsave);
            this.Morser.Controls.Add(this.clearMorser);
            this.Morser.Controls.Add(this.clearnormal);
            this.Morser.Controls.Add(this.beep);
            this.Morser.Controls.Add(this.Save);
            this.Morser.Controls.Add(this.Loade);
            this.Morser.Controls.Add(this.TrenZeichen);
            this.Morser.Controls.Add(this.ZeichenLang);
            this.Morser.Controls.Add(this.zeichenKurtz);
            this.Morser.Controls.Add(this.Morsertext);
            this.Morser.Controls.Add(this.NormelText);
            this.Morser.Controls.Add(this.MorserinText);
            this.Morser.Controls.Add(this.TextinMorser);
            this.Morser.Controls.Add(this.morsercode);
            this.Morser.Controls.Add(this.Normalinput);
            this.Morser.Location = new System.Drawing.Point(4, 22);
            this.Morser.Name = "Morser";
            this.Morser.Padding = new System.Windows.Forms.Padding(3);
            this.Morser.Size = new System.Drawing.Size(792, 424);
            this.Morser.TabIndex = 0;
            this.Morser.Text = "Morser";
            this.Morser.UseVisualStyleBackColor = true;
            // 
            // wahtsave
            // 
            this.wahtsave.AutoSize = true;
            this.wahtsave.Checked = true;
            this.wahtsave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wahtsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wahtsave.Location = new System.Drawing.Point(261, 160);
            this.wahtsave.Name = "wahtsave";
            this.wahtsave.Size = new System.Drawing.Size(106, 17);
            this.wahtsave.TabIndex = 14;
            this.wahtsave.Text = "Morser Speichern";
            this.wahtsave.UseVisualStyleBackColor = true;
            // 
            // clearMorser
            // 
            this.clearMorser.Location = new System.Drawing.Point(466, 395);
            this.clearMorser.Name = "clearMorser";
            this.clearMorser.Size = new System.Drawing.Size(75, 23);
            this.clearMorser.TabIndex = 13;
            this.clearMorser.Text = "Clear";
            this.clearMorser.UseVisualStyleBackColor = true;
            this.clearMorser.Click += new System.EventHandler(this.clearMorser_Click);
            // 
            // clearnormal
            // 
            this.clearnormal.Location = new System.Drawing.Point(91, 396);
            this.clearnormal.Name = "clearnormal";
            this.clearnormal.Size = new System.Drawing.Size(75, 23);
            this.clearnormal.TabIndex = 12;
            this.clearnormal.Text = "Clear";
            this.clearnormal.UseVisualStyleBackColor = true;
            this.clearnormal.Click += new System.EventHandler(this.clearnormal_Click);
            // 
            // beep
            // 
            this.beep.Location = new System.Drawing.Point(671, 128);
            this.beep.Name = "beep";
            this.beep.Size = new System.Drawing.Size(75, 23);
            this.beep.TabIndex = 11;
            this.beep.Text = "beep";
            this.beep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beep.UseVisualStyleBackColor = true;
            this.beep.Click += new System.EventHandler(this.beep_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(671, 99);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Loade
            // 
            this.Loade.Location = new System.Drawing.Point(671, 70);
            this.Loade.Name = "Loade";
            this.Loade.Size = new System.Drawing.Size(75, 23);
            this.Loade.TabIndex = 9;
            this.Loade.Text = "Loade";
            this.Loade.UseVisualStyleBackColor = true;
            this.Loade.Click += new System.EventHandler(this.Loade_Click);
            // 
            // TrenZeichen
            // 
            this.TrenZeichen.Location = new System.Drawing.Point(56, 398);
            this.TrenZeichen.Name = "TrenZeichen";
            this.TrenZeichen.ReadOnly = true;
            this.TrenZeichen.Size = new System.Drawing.Size(18, 20);
            this.TrenZeichen.TabIndex = 8;
            this.TrenZeichen.Text = "/";
            // 
            // ZeichenLang
            // 
            this.ZeichenLang.Location = new System.Drawing.Point(32, 398);
            this.ZeichenLang.Name = "ZeichenLang";
            this.ZeichenLang.ReadOnly = true;
            this.ZeichenLang.Size = new System.Drawing.Size(18, 20);
            this.ZeichenLang.TabIndex = 7;
            this.ZeichenLang.Text = "-";
            // 
            // zeichenKurtz
            // 
            this.zeichenKurtz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeichenKurtz.Location = new System.Drawing.Point(8, 398);
            this.zeichenKurtz.Name = "zeichenKurtz";
            this.zeichenKurtz.ReadOnly = true;
            this.zeichenKurtz.Size = new System.Drawing.Size(18, 20);
            this.zeichenKurtz.TabIndex = 6;
            this.zeichenKurtz.Text = ".";
            // 
            // Morsertext
            // 
            this.Morsertext.AutoSize = true;
            this.Morsertext.Location = new System.Drawing.Point(478, 8);
            this.Morsertext.Name = "Morsertext";
            this.Morsertext.Size = new System.Drawing.Size(63, 13);
            this.Morsertext.TabIndex = 5;
            this.Morsertext.Text = "Morser Text";
            // 
            // NormelText
            // 
            this.NormelText.AutoSize = true;
            this.NormelText.Location = new System.Drawing.Point(69, 8);
            this.NormelText.Name = "NormelText";
            this.NormelText.Size = new System.Drawing.Size(46, 13);
            this.NormelText.TabIndex = 4;
            this.NormelText.Text = "KlarText";
            // 
            // MorserinText
            // 
            this.MorserinText.Location = new System.Drawing.Point(272, 111);
            this.MorserinText.Name = "MorserinText";
            this.MorserinText.Size = new System.Drawing.Size(75, 23);
            this.MorserinText.TabIndex = 3;
            this.MorserinText.Text = "<< Convert";
            this.MorserinText.UseVisualStyleBackColor = true;
            this.MorserinText.Click += new System.EventHandler(this.MorserinText_Click);
            // 
            // TextinMorser
            // 
            this.TextinMorser.Location = new System.Drawing.Point(272, 70);
            this.TextinMorser.Name = "TextinMorser";
            this.TextinMorser.Size = new System.Drawing.Size(75, 23);
            this.TextinMorser.TabIndex = 2;
            this.TextinMorser.Text = "Convert >>";
            this.TextinMorser.UseVisualStyleBackColor = true;
            this.TextinMorser.Click += new System.EventHandler(this.TextinMorser_Click);
            // 
            // morsercode
            // 
            this.morsercode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morsercode.Location = new System.Drawing.Point(370, 24);
            this.morsercode.Multiline = true;
            this.morsercode.Name = "morsercode";
            this.morsercode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.morsercode.Size = new System.Drawing.Size(265, 367);
            this.morsercode.TabIndex = 1;
            this.morsercode.TextChanged += new System.EventHandler(this.morsercode_TextChanged);
            // 
            // Normalinput
            // 
            this.Normalinput.Location = new System.Drawing.Point(8, 25);
            this.Normalinput.Multiline = true;
            this.Normalinput.Name = "Normalinput";
            this.Normalinput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Normalinput.Size = new System.Drawing.Size(247, 367);
            this.Normalinput.TabIndex = 0;
            this.Normalinput.TextChanged += new System.EventHandler(this.Normalinput_TextChanged);
            // 
            // chaesar
            // 
            this.chaesar.Controls.Add(this.kryptotextbuttons);
            this.chaesar.Controls.Add(this.Kalrtextbuttons);
            this.chaesar.Controls.Add(this.Kryproalpa);
            this.chaesar.Controls.Add(this.alphabetnormal);
            this.chaesar.Controls.Add(this.ConverttoTextCH);
            this.chaesar.Controls.Add(this.ConvertoChaesar);
            this.chaesar.Controls.Add(this.Chaesarupdown);
            this.chaesar.Controls.Add(this.Chaesartracker);
            this.chaesar.Controls.Add(this.KryptolabelChaesar);
            this.chaesar.Controls.Add(this.KlartextChaesar);
            this.chaesar.Controls.Add(this.Kryptotext);
            this.chaesar.Controls.Add(this.Klartext);
            this.chaesar.Location = new System.Drawing.Point(4, 22);
            this.chaesar.Name = "chaesar";
            this.chaesar.Size = new System.Drawing.Size(792, 424);
            this.chaesar.TabIndex = 1;
            this.chaesar.Text = "Chaesar";
            this.chaesar.UseVisualStyleBackColor = true;
            // 
            // kryptotextbuttons
            // 
            this.kryptotextbuttons.Controls.Add(this.ClearCH);
            this.kryptotextbuttons.Controls.Add(this.LoadeCH);
            this.kryptotextbuttons.Controls.Add(this.saveCH);
            this.kryptotextbuttons.Location = new System.Drawing.Point(698, 58);
            this.kryptotextbuttons.Name = "kryptotextbuttons";
            this.kryptotextbuttons.Size = new System.Drawing.Size(86, 182);
            this.kryptotextbuttons.TabIndex = 12;
            this.kryptotextbuttons.TabStop = false;
            this.kryptotextbuttons.Text = "Kryptotext buttons";
            // 
            // ClearCH
            // 
            this.ClearCH.Location = new System.Drawing.Point(6, 130);
            this.ClearCH.Name = "ClearCH";
            this.ClearCH.Size = new System.Drawing.Size(75, 23);
            this.ClearCH.TabIndex = 2;
            this.ClearCH.Text = "Clear";
            this.ClearCH.UseVisualStyleBackColor = true;
            this.ClearCH.Click += new System.EventHandler(this.ClearCH_Click);
            // 
            // LoadeCH
            // 
            this.LoadeCH.Location = new System.Drawing.Point(6, 80);
            this.LoadeCH.Name = "LoadeCH";
            this.LoadeCH.Size = new System.Drawing.Size(75, 23);
            this.LoadeCH.TabIndex = 1;
            this.LoadeCH.Text = "Loade";
            this.LoadeCH.UseVisualStyleBackColor = true;
            this.LoadeCH.Click += new System.EventHandler(this.LoadeCH_Click);
            // 
            // saveCH
            // 
            this.saveCH.Location = new System.Drawing.Point(6, 31);
            this.saveCH.Name = "saveCH";
            this.saveCH.Size = new System.Drawing.Size(75, 23);
            this.saveCH.TabIndex = 0;
            this.saveCH.Text = "Save";
            this.saveCH.UseVisualStyleBackColor = true;
            this.saveCH.Click += new System.EventHandler(this.saveCH_Click);
            // 
            // Kalrtextbuttons
            // 
            this.Kalrtextbuttons.Controls.Add(this.ClearCHT);
            this.Kalrtextbuttons.Controls.Add(this.LoadeCHT);
            this.Kalrtextbuttons.Controls.Add(this.SaveCHT);
            this.Kalrtextbuttons.Location = new System.Drawing.Point(547, 58);
            this.Kalrtextbuttons.Name = "Kalrtextbuttons";
            this.Kalrtextbuttons.Size = new System.Drawing.Size(86, 182);
            this.Kalrtextbuttons.TabIndex = 11;
            this.Kalrtextbuttons.TabStop = false;
            this.Kalrtextbuttons.Text = "Kalrtext buttons";
            // 
            // ClearCHT
            // 
            this.ClearCHT.Location = new System.Drawing.Point(7, 130);
            this.ClearCHT.Name = "ClearCHT";
            this.ClearCHT.Size = new System.Drawing.Size(75, 23);
            this.ClearCHT.TabIndex = 2;
            this.ClearCHT.Text = "Clear";
            this.ClearCHT.UseVisualStyleBackColor = true;
            this.ClearCHT.Click += new System.EventHandler(this.ClearCHT_Click);
            // 
            // LoadeCHT
            // 
            this.LoadeCHT.Location = new System.Drawing.Point(6, 80);
            this.LoadeCHT.Name = "LoadeCHT";
            this.LoadeCHT.Size = new System.Drawing.Size(75, 23);
            this.LoadeCHT.TabIndex = 1;
            this.LoadeCHT.Text = "Loade";
            this.LoadeCHT.UseVisualStyleBackColor = true;
            this.LoadeCHT.Click += new System.EventHandler(this.LoadeCHT_Click);
            // 
            // SaveCHT
            // 
            this.SaveCHT.Location = new System.Drawing.Point(7, 31);
            this.SaveCHT.Name = "SaveCHT";
            this.SaveCHT.Size = new System.Drawing.Size(75, 23);
            this.SaveCHT.TabIndex = 0;
            this.SaveCHT.Text = "Save";
            this.SaveCHT.UseVisualStyleBackColor = true;
            this.SaveCHT.Click += new System.EventHandler(this.SaveCHT_Click);
            // 
            // Kryproalpa
            // 
            this.Kryproalpa.Location = new System.Drawing.Point(332, 16);
            this.Kryproalpa.Name = "Kryproalpa";
            this.Kryproalpa.ReadOnly = true;
            this.Kryproalpa.Size = new System.Drawing.Size(273, 20);
            this.Kryproalpa.TabIndex = 10;
            // 
            // alphabetnormal
            // 
            this.alphabetnormal.Location = new System.Drawing.Point(12, 16);
            this.alphabetnormal.Name = "alphabetnormal";
            this.alphabetnormal.ReadOnly = true;
            this.alphabetnormal.Size = new System.Drawing.Size(269, 20);
            this.alphabetnormal.TabIndex = 9;
            this.alphabetnormal.Text = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            // 
            // ConverttoTextCH
            // 
            this.ConverttoTextCH.Location = new System.Drawing.Point(240, 163);
            this.ConverttoTextCH.Name = "ConverttoTextCH";
            this.ConverttoTextCH.Size = new System.Drawing.Size(75, 23);
            this.ConverttoTextCH.TabIndex = 8;
            this.ConverttoTextCH.Text = "<< Convert";
            this.ConverttoTextCH.UseVisualStyleBackColor = true;
            this.ConverttoTextCH.Click += new System.EventHandler(this.ConverttoTextCH_Click);
            // 
            // ConvertoChaesar
            // 
            this.ConvertoChaesar.Location = new System.Drawing.Point(240, 100);
            this.ConvertoChaesar.Name = "ConvertoChaesar";
            this.ConvertoChaesar.Size = new System.Drawing.Size(75, 23);
            this.ConvertoChaesar.TabIndex = 7;
            this.ConvertoChaesar.Text = "Convert >>";
            this.ConvertoChaesar.UseVisualStyleBackColor = true;
            this.ConvertoChaesar.Click += new System.EventHandler(this.ConvertoChaesar_Click);
            // 
            // Chaesarupdown
            // 
            this.Chaesarupdown.Location = new System.Drawing.Point(421, 396);
            this.Chaesarupdown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Chaesarupdown.Name = "Chaesarupdown";
            this.Chaesarupdown.Size = new System.Drawing.Size(68, 20);
            this.Chaesarupdown.TabIndex = 6;
            this.Chaesarupdown.ValueChanged += new System.EventHandler(this.Chaesarupdown_ValueChanged);
            // 
            // Chaesartracker
            // 
            this.Chaesartracker.Location = new System.Drawing.Point(8, 394);
            this.Chaesartracker.Maximum = 25;
            this.Chaesartracker.Name = "Chaesartracker";
            this.Chaesartracker.Size = new System.Drawing.Size(407, 45);
            this.Chaesartracker.TabIndex = 4;
            this.Chaesartracker.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Chaesartracker.Scroll += new System.EventHandler(this.Chaesartracker_Scroll);
            // 
            // KryptolabelChaesar
            // 
            this.KryptolabelChaesar.AutoSize = true;
            this.KryptolabelChaesar.Location = new System.Drawing.Point(329, 39);
            this.KryptolabelChaesar.Name = "KryptolabelChaesar";
            this.KryptolabelChaesar.Size = new System.Drawing.Size(59, 13);
            this.KryptolabelChaesar.TabIndex = 3;
            this.KryptolabelChaesar.Text = "Kryptolabel";
            // 
            // KlartextChaesar
            // 
            this.KlartextChaesar.AutoSize = true;
            this.KlartextChaesar.Location = new System.Drawing.Point(9, 39);
            this.KlartextChaesar.Name = "KlartextChaesar";
            this.KlartextChaesar.Size = new System.Drawing.Size(42, 13);
            this.KlartextChaesar.TabIndex = 2;
            this.KlartextChaesar.Text = "Klartext";
            // 
            // Kryptotext
            // 
            this.Kryptotext.Location = new System.Drawing.Point(332, 58);
            this.Kryptotext.Multiline = true;
            this.Kryptotext.Name = "Kryptotext";
            this.Kryptotext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Kryptotext.Size = new System.Drawing.Size(209, 330);
            this.Kryptotext.TabIndex = 1;
            // 
            // Klartext
            // 
            this.Klartext.Location = new System.Drawing.Point(8, 58);
            this.Klartext.Multiline = true;
            this.Klartext.Name = "Klartext";
            this.Klartext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Klartext.Size = new System.Drawing.Size(209, 330);
            this.Klartext.TabIndex = 0;
            // 
            // vigenere
            // 
            this.vigenere.Controls.Add(this.label3);
            this.vigenere.Controls.Add(this.GrupeBox2);
            this.vigenere.Controls.Add(this.groupBox1);
            this.vigenere.Controls.Add(this.Key);
            this.vigenere.Controls.Add(this.label2);
            this.vigenere.Controls.Add(this.label1);
            this.vigenere.Controls.Add(this.VirgenereKlarCon);
            this.vigenere.Controls.Add(this.Vigenekyriptocon);
            this.vigenere.Controls.Add(this.KryptoTextVigenere);
            this.vigenere.Controls.Add(this.KlarTextVigenere);
            this.vigenere.Location = new System.Drawing.Point(4, 22);
            this.vigenere.Name = "vigenere";
            this.vigenere.Size = new System.Drawing.Size(792, 424);
            this.vigenere.TabIndex = 2;
            this.vigenere.Text = "Vigenere ";
            this.vigenere.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key";
            // 
            // GrupeBox2
            // 
            this.GrupeBox2.Controls.Add(this.VigenereClearKrypto);
            this.GrupeBox2.Controls.Add(this.VigenereLoadeKrypto);
            this.GrupeBox2.Controls.Add(this.VigenereSaveKrypto);
            this.GrupeBox2.Location = new System.Drawing.Point(586, 176);
            this.GrupeBox2.Name = "GrupeBox2";
            this.GrupeBox2.Size = new System.Drawing.Size(200, 123);
            this.GrupeBox2.TabIndex = 9;
            this.GrupeBox2.TabStop = false;
            this.GrupeBox2.Text = "Krypto Buttons";
            // 
            // VigenereClearKrypto
            // 
            this.VigenereClearKrypto.Location = new System.Drawing.Point(62, 77);
            this.VigenereClearKrypto.Name = "VigenereClearKrypto";
            this.VigenereClearKrypto.Size = new System.Drawing.Size(75, 23);
            this.VigenereClearKrypto.TabIndex = 2;
            this.VigenereClearKrypto.Text = "Clear";
            this.VigenereClearKrypto.UseVisualStyleBackColor = true;
            // 
            // VigenereLoadeKrypto
            // 
            this.VigenereLoadeKrypto.Location = new System.Drawing.Point(62, 48);
            this.VigenereLoadeKrypto.Name = "VigenereLoadeKrypto";
            this.VigenereLoadeKrypto.Size = new System.Drawing.Size(75, 23);
            this.VigenereLoadeKrypto.TabIndex = 1;
            this.VigenereLoadeKrypto.Text = "Loade";
            this.VigenereLoadeKrypto.UseVisualStyleBackColor = true;
            // 
            // VigenereSaveKrypto
            // 
            this.VigenereSaveKrypto.Location = new System.Drawing.Point(62, 19);
            this.VigenereSaveKrypto.Name = "VigenereSaveKrypto";
            this.VigenereSaveKrypto.Size = new System.Drawing.Size(75, 23);
            this.VigenereSaveKrypto.TabIndex = 0;
            this.VigenereSaveKrypto.Text = "Save";
            this.VigenereSaveKrypto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VigenereClearklar);
            this.groupBox1.Controls.Add(this.VigenereSaveklar);
            this.groupBox1.Controls.Add(this.VigenereLoadeklar);
            this.groupBox1.Location = new System.Drawing.Point(586, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klar Buttons";
            // 
            // VigenereClearklar
            // 
            this.VigenereClearklar.Location = new System.Drawing.Point(62, 77);
            this.VigenereClearklar.Name = "VigenereClearklar";
            this.VigenereClearklar.Size = new System.Drawing.Size(75, 23);
            this.VigenereClearklar.TabIndex = 5;
            this.VigenereClearklar.Text = "Clear";
            this.VigenereClearklar.UseVisualStyleBackColor = true;
            // 
            // VigenereSaveklar
            // 
            this.VigenereSaveklar.Location = new System.Drawing.Point(62, 19);
            this.VigenereSaveklar.Name = "VigenereSaveklar";
            this.VigenereSaveklar.Size = new System.Drawing.Size(75, 23);
            this.VigenereSaveklar.TabIndex = 3;
            this.VigenereSaveklar.Text = "Save";
            this.VigenereSaveklar.UseVisualStyleBackColor = true;
            // 
            // VigenereLoadeklar
            // 
            this.VigenereLoadeklar.Location = new System.Drawing.Point(62, 48);
            this.VigenereLoadeklar.Name = "VigenereLoadeklar";
            this.VigenereLoadeklar.Size = new System.Drawing.Size(75, 23);
            this.VigenereLoadeklar.TabIndex = 4;
            this.VigenereLoadeklar.Text = "Loade";
            this.VigenereLoadeklar.UseVisualStyleBackColor = true;
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(8, 396);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(776, 20);
            this.Key.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Krypto Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Klart Text";
            // 
            // VirgenereKlarCon
            // 
            this.VirgenereKlarCon.Location = new System.Drawing.Point(250, 62);
            this.VirgenereKlarCon.Name = "VirgenereKlarCon";
            this.VirgenereKlarCon.Size = new System.Drawing.Size(75, 23);
            this.VirgenereKlarCon.TabIndex = 4;
            this.VirgenereKlarCon.Text = "Convert >>";
            this.VirgenereKlarCon.UseVisualStyleBackColor = true;
            this.VirgenereKlarCon.Click += new System.EventHandler(this.VirgenereKlarCon_Click);
            // 
            // Vigenekyriptocon
            // 
            this.Vigenekyriptocon.Location = new System.Drawing.Point(250, 311);
            this.Vigenekyriptocon.Name = "Vigenekyriptocon";
            this.Vigenekyriptocon.Size = new System.Drawing.Size(75, 23);
            this.Vigenekyriptocon.TabIndex = 3;
            this.Vigenekyriptocon.Text = "<< Convert ";
            this.Vigenekyriptocon.UseVisualStyleBackColor = true;
            this.Vigenekyriptocon.Click += new System.EventHandler(this.Vigenekyriptocon_Click);
            // 
            // KryptoTextVigenere
            // 
            this.KryptoTextVigenere.Location = new System.Drawing.Point(350, 32);
            this.KryptoTextVigenere.Multiline = true;
            this.KryptoTextVigenere.Name = "KryptoTextVigenere";
            this.KryptoTextVigenere.Size = new System.Drawing.Size(230, 356);
            this.KryptoTextVigenere.TabIndex = 1;
            this.KryptoTextVigenere.TextChanged += new System.EventHandler(this.KryptoTextVigenere_TextChanged);
            // 
            // KlarTextVigenere
            // 
            this.KlarTextVigenere.Location = new System.Drawing.Point(8, 32);
            this.KlarTextVigenere.Multiline = true;
            this.KlarTextVigenere.Name = "KlarTextVigenere";
            this.KlarTextVigenere.Size = new System.Drawing.Size(222, 356);
            this.KlarTextVigenere.TabIndex = 0;
            this.KlarTextVigenere.TextChanged += new System.EventHandler(this.KlarTextVigenere_TextChanged);
            // 
            // RLE
            // 
            this.RLE.Controls.Add(this.RLEklar);
            this.RLE.Controls.Add(this.RLEver);
            this.RLE.Controls.Add(this.textBox2);
            this.RLE.Controls.Add(this.textBox1);
            this.RLE.Location = new System.Drawing.Point(4, 22);
            this.RLE.Name = "RLE";
            this.RLE.Size = new System.Drawing.Size(792, 424);
            this.RLE.TabIndex = 3;
            this.RLE.Text = "RLE";
            this.RLE.UseVisualStyleBackColor = true;
            // 
            // Base16
            // 
            this.Base16.Controls.Add(this.button2);
            this.Base16.Controls.Add(this.button1);
            this.Base16.Controls.Add(this.label5);
            this.Base16.Controls.Add(this.label4);
            this.Base16.Controls.Add(this.Base16Cry);
            this.Base16.Controls.Add(this.Base16klahr);
            this.Base16.Location = new System.Drawing.Point(4, 22);
            this.Base16.Name = "Base16";
            this.Base16.Size = new System.Drawing.Size(792, 424);
            this.Base16.TabIndex = 4;
            this.Base16.Text = "Base16";
            this.Base16.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "<< Endschlüsseln";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Verschlüsseln >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Crypto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Klartext";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Base16Cry
            // 
            this.Base16Cry.Location = new System.Drawing.Point(501, 25);
            this.Base16Cry.Multiline = true;
            this.Base16Cry.Name = "Base16Cry";
            this.Base16Cry.Size = new System.Drawing.Size(283, 342);
            this.Base16Cry.TabIndex = 1;
            // 
            // Base16klahr
            // 
            this.Base16klahr.Location = new System.Drawing.Point(8, 25);
            this.Base16klahr.Multiline = true;
            this.Base16klahr.Name = "Base16klahr";
            this.Base16klahr.Size = new System.Drawing.Size(283, 342);
            this.Base16klahr.TabIndex = 0;
            // 
            // Base32
            // 
            this.Base32.Controls.Add(this.label7);
            this.Base32.Controls.Add(this.label6);
            this.Base32.Controls.Add(this.Entschlüsseln);
            this.Base32.Controls.Add(this.verschlüsseln);
            this.Base32.Controls.Add(this.Base32cry);
            this.Base32.Controls.Add(this.Base32Klahr);
            this.Base32.Location = new System.Drawing.Point(4, 22);
            this.Base32.Name = "Base32";
            this.Base32.Size = new System.Drawing.Size(792, 424);
            this.Base32.TabIndex = 5;
            this.Base32.Text = "Base32";
            this.Base32.UseVisualStyleBackColor = true;
            // 
            // Base32Klahr
            // 
            this.Base32Klahr.Location = new System.Drawing.Point(3, 3);
            this.Base32Klahr.Multiline = true;
            this.Base32Klahr.Name = "Base32Klahr";
            this.Base32Klahr.Size = new System.Drawing.Size(243, 364);
            this.Base32Klahr.TabIndex = 0;
            // 
            // Base32cry
            // 
            this.Base32cry.Location = new System.Drawing.Point(546, 3);
            this.Base32cry.Multiline = true;
            this.Base32cry.Name = "Base32cry";
            this.Base32cry.Size = new System.Drawing.Size(243, 364);
            this.Base32cry.TabIndex = 1;
            // 
            // verschlüsseln
            // 
            this.verschlüsseln.Location = new System.Drawing.Point(275, 26);
            this.verschlüsseln.Name = "verschlüsseln";
            this.verschlüsseln.Size = new System.Drawing.Size(239, 23);
            this.verschlüsseln.TabIndex = 2;
            this.verschlüsseln.Text = "verschlüsseln >>";
            this.verschlüsseln.UseVisualStyleBackColor = true;
            this.verschlüsseln.Click += new System.EventHandler(this.button3_Click);
            // 
            // Entschlüsseln
            // 
            this.Entschlüsseln.Location = new System.Drawing.Point(275, 298);
            this.Entschlüsseln.Name = "Entschlüsseln";
            this.Entschlüsseln.Size = new System.Drawing.Size(239, 23);
            this.Entschlüsseln.TabIndex = 3;
            this.Entschlüsseln.Text = "<< Entschlüsseln";
            this.Entschlüsseln.UseVisualStyleBackColor = true;
            this.Entschlüsseln.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 370);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(530, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 370);
            this.textBox2.TabIndex = 1;
            // 
            // RLEver
            // 
            this.RLEver.Location = new System.Drawing.Point(271, 21);
            this.RLEver.Name = "RLEver";
            this.RLEver.Size = new System.Drawing.Size(253, 23);
            this.RLEver.TabIndex = 2;
            this.RLEver.TabStop = false;
            this.RLEver.Text = "Übersetzen >>";
            this.RLEver.UseVisualStyleBackColor = true;
            // 
            // RLEklar
            // 
            this.RLEklar.Location = new System.Drawing.Point(271, 304);
            this.RLEklar.Name = "RLEklar";
            this.RLEklar.Size = new System.Drawing.Size(253, 23);
            this.RLEklar.TabIndex = 3;
            this.RLEklar.Text = "button4";
            this.RLEklar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabPane);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.TabPane.ResumeLayout(false);
            this.Morser.ResumeLayout(false);
            this.Morser.PerformLayout();
            this.chaesar.ResumeLayout(false);
            this.chaesar.PerformLayout();
            this.kryptotextbuttons.ResumeLayout(false);
            this.Kalrtextbuttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chaesarupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chaesartracker)).EndInit();
            this.vigenere.ResumeLayout(false);
            this.vigenere.PerformLayout();
            this.GrupeBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.RLE.ResumeLayout(false);
            this.RLE.PerformLayout();
            this.Base16.ResumeLayout(false);
            this.Base16.PerformLayout();
            this.Base32.ResumeLayout(false);
            this.Base32.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPane;
        private System.Windows.Forms.TabPage Morser;
        private System.Windows.Forms.TextBox morsercode;
        private System.Windows.Forms.TextBox Normalinput;
        private System.Windows.Forms.Button MorserinText;
        private System.Windows.Forms.Button TextinMorser;
        private System.Windows.Forms.Label NormelText;
        private System.Windows.Forms.Label Morsertext;
        private System.Windows.Forms.TextBox TrenZeichen;
        private System.Windows.Forms.TextBox ZeichenLang;
        private System.Windows.Forms.TextBox zeichenKurtz;
        private System.Windows.Forms.Button Loade;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button beep;
        private System.Windows.Forms.Button clearMorser;
        private System.Windows.Forms.Button clearnormal;
        private System.Windows.Forms.CheckBox wahtsave;
        private System.Windows.Forms.TabPage chaesar;
        private System.Windows.Forms.TabPage vigenere;
        private System.Windows.Forms.TabPage RLE;
        private System.Windows.Forms.Label KryptolabelChaesar;
        private System.Windows.Forms.Label KlartextChaesar;
        private System.Windows.Forms.TextBox Kryptotext;
        private System.Windows.Forms.TextBox Klartext;
        private System.Windows.Forms.NumericUpDown Chaesarupdown;
        private System.Windows.Forms.TrackBar Chaesartracker;
        private System.Windows.Forms.Button ConverttoTextCH;
        private System.Windows.Forms.Button ConvertoChaesar;
        private System.Windows.Forms.TextBox Kryproalpa;
        private System.Windows.Forms.TextBox alphabetnormal;
        private System.Windows.Forms.GroupBox kryptotextbuttons;
        private System.Windows.Forms.GroupBox Kalrtextbuttons;
        private System.Windows.Forms.Button ClearCH;
        private System.Windows.Forms.Button LoadeCH;
        private System.Windows.Forms.Button saveCH;
        private System.Windows.Forms.Button ClearCHT;
        private System.Windows.Forms.Button LoadeCHT;
        private System.Windows.Forms.Button SaveCHT;
        private System.Windows.Forms.Button VirgenereKlarCon;
        private System.Windows.Forms.Button Vigenekyriptocon;
        private System.Windows.Forms.TextBox KryptoTextVigenere;
        private System.Windows.Forms.TextBox KlarTextVigenere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GrupeBox2;
        private System.Windows.Forms.Button VigenereClearKrypto;
        private System.Windows.Forms.Button VigenereLoadeKrypto;
        private System.Windows.Forms.Button VigenereSaveKrypto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VigenereClearklar;
        private System.Windows.Forms.Button VigenereSaveklar;
        private System.Windows.Forms.Button VigenereLoadeklar;
        private System.Windows.Forms.TabPage Base16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Base16Cry;
        private System.Windows.Forms.TextBox Base16klahr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Base32;
        private System.Windows.Forms.Button Entschlüsseln;
        private System.Windows.Forms.Button verschlüsseln;
        private System.Windows.Forms.TextBox Base32cry;
        private System.Windows.Forms.TextBox Base32Klahr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RLEklar;
        private System.Windows.Forms.Button RLEver;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

