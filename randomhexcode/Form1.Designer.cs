namespace randomhexcode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbNiebieski = new CheckBox();
            cbCzerwony = new CheckBox();
            cbZielony = new CheckBox();
            btnGeneruj = new Button();
            label1 = new Label();
            label2 = new Label();
            lbHEX = new Label();
            lbRGB = new Label();
            btnZapisz = new Button();
            btnPomoc = new Button();
            lbCMYK = new Label();
            label4 = new Label();
            btnReset = new Button();
            tbFileName = new TextBox();
            SuspendLayout();
            // 
            // cbNiebieski
            // 
            cbNiebieski.AutoSize = true;
            cbNiebieski.Font = new Font("Microsoft Sans Serif", 12.8F);
            cbNiebieski.Location = new Point(25, 88);
            cbNiebieski.Name = "cbNiebieski";
            cbNiebieski.Size = new Size(123, 30);
            cbNiebieski.TabIndex = 4;
            cbNiebieski.Text = "Niebieski";
            cbNiebieski.UseVisualStyleBackColor = true;
            // 
            // cbCzerwony
            // 
            cbCzerwony.AutoSize = true;
            cbCzerwony.Font = new Font("Microsoft Sans Serif", 12.8F);
            cbCzerwony.Location = new Point(25, 35);
            cbCzerwony.Name = "cbCzerwony";
            cbCzerwony.Size = new Size(131, 30);
            cbCzerwony.TabIndex = 5;
            cbCzerwony.Text = "Czerwony";
            cbCzerwony.UseVisualStyleBackColor = true;
            // 
            // cbZielony
            // 
            cbZielony.AutoSize = true;
            cbZielony.Font = new Font("Microsoft Sans Serif", 12.8F);
            cbZielony.Location = new Point(25, 62);
            cbZielony.Name = "cbZielony";
            cbZielony.Size = new Size(104, 30);
            cbZielony.TabIndex = 6;
            cbZielony.Text = "Zielony";
            cbZielony.UseVisualStyleBackColor = true;
            // 
            // btnGeneruj
            // 
            btnGeneruj.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeneruj.Location = new Point(14, 131);
            btnGeneruj.Name = "btnGeneruj";
            btnGeneruj.Size = new Size(221, 55);
            btnGeneruj.TabIndex = 7;
            btnGeneruj.Text = "Generuj!";
            btnGeneruj.UseVisualStyleBackColor = true;
            btnGeneruj.Click += btnGeneruj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 8;
            label1.Text = "HEX:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 62);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 9;
            label2.Text = "RGB:";
            // 
            // lbHEX
            // 
            lbHEX.AutoSize = true;
            lbHEX.Location = new Point(296, 42);
            lbHEX.Name = "lbHEX";
            lbHEX.Size = new Size(66, 20);
            lbHEX.TabIndex = 12;
            lbHEX.Text = "#000000";
            lbHEX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbRGB
            // 
            lbRGB.AutoSize = true;
            lbRGB.Location = new Point(296, 62);
            lbRGB.Name = "lbRGB";
            lbRGB.Size = new Size(105, 20);
            lbRGB.TabIndex = 13;
            lbRGB.Text = "(000, 000, 000)";
            lbRGB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnZapisz
            // 
            btnZapisz.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnZapisz.Location = new Point(252, 131);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(80, 55);
            btnZapisz.TabIndex = 16;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnPomoc
            // 
            btnPomoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPomoc.Location = new Point(455, 131);
            btnPomoc.Name = "btnPomoc";
            btnPomoc.Size = new Size(80, 55);
            btnPomoc.TabIndex = 17;
            btnPomoc.Text = "Pomoc";
            btnPomoc.UseVisualStyleBackColor = true;
            btnPomoc.Click += btnPomoc_Click;
            // 
            // lbCMYK
            // 
            lbCMYK.AutoSize = true;
            lbCMYK.Location = new Point(307, 82);
            lbCMYK.Name = "lbCMYK";
            lbCMYK.Size = new Size(184, 20);
            lbCMYK.TabIndex = 19;
            lbCMYK.Text = "(000%, 000%, 000%, 000%)";
            lbCMYK.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 82);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 18;
            label4.Text = "CMYK:";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.Location = new Point(356, 131);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(80, 55);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset!";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // tbFileName
            // 
            tbFileName.Location = new Point(10, 7);
            tbFileName.Name = "tbFileName";
            tbFileName.PlaceholderText = "Wpisz nazwę pliku do którego chcesz zapisać kod HEX...";
            tbFileName.Size = new Size(443, 27);
            tbFileName.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 198);
            Controls.Add(tbFileName);
            Controls.Add(btnReset);
            Controls.Add(lbCMYK);
            Controls.Add(label4);
            Controls.Add(btnPomoc);
            Controls.Add(btnZapisz);
            Controls.Add(lbRGB);
            Controls.Add(lbHEX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGeneruj);
            Controls.Add(cbZielony);
            Controls.Add(cbCzerwony);
            Controls.Add(cbNiebieski);
            Name = "Form1";
            Text = "Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox cbNiebieski;
        private CheckBox cbCzerwony;
        private CheckBox cbZielony;
        private Button btnGeneruj;
        private Label label1;
        private Label label2;
        private Label lbHEX;
        private Label lbRGB;
        private Button btnZapisz;
        private Button btnPomoc;
        private Label lbCMYK;
        private Label label4;
        private Button btnReset;
        private TextBox tbFileName;
    }
}
