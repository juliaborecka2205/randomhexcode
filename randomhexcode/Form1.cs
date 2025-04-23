using System.IO;
namespace randomhexcode
{
    public partial class Form1 : Form
    {
        string fileName;
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\HEXCODEgen";

        string hc = "";

        double r = 0;
        double R = 0;

        double g = 0;
        double G = 0;

        double b = 0;
        double B = 0;

        double C = 0;
        double M = 0;
        double Y = 0;
        double K = 0;

        int h1 = 0;
        int h2 = 0;
        int h3 = 0;
        int h4 = 0;
        int h5 = 0;
        int h6 = 0;

        string[] hexcode = ["0", "0", "0", "0", "0", "0"];
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            if (cbCzerwony.Checked)
            {
                h1 = rnd.Next(0, 16);
                h2 = rnd.Next(0, 16);
                HEX(h1, 0);
                HEX(h2, 1);
            }
            if (cbZielony.Checked)
            {
                h3 = rnd.Next(0, 16);
                h4 = rnd.Next(0, 16);
                HEX(h3, 2);
                HEX(h4, 3);
            }
            if (cbNiebieski.Checked)
            {
                h5 = rnd.Next(0, 16);
                h6 = rnd.Next(0, 16);
                HEX(h5, 4);
                HEX(h6, 5);
            }
            r = h1 * 16 + h2;
            g = h3 * 16 + h4;
            b = h5 * 16 + h6;
 
            R = r / 255;
            G = g / 255;
            B = b / 255;

            if (R > G && R > B)
            {
                K = 1 - R;
            }
            else if (G > R && G > B)
            {
                K = 1 - G;
            }
            else if (B > R && B > G)
            {
                K = 1 - B;
            }

            C = (1 - R - K) / (1 - K);
            M = (1 - G - K) / (1 - K);
            Y = (1 - B - K) / (1 - K);

            //HEX code
            hc = hexcode[0] + hexcode[1] + hexcode[2] + hexcode[3] + hexcode[4] + hexcode[5];
            lbHEX.Text = "#" + hc;
            //RGB code
            lbRGB.Text = "(" + r + ", " + g + ", " + b + ")";
            //CMYK code
            lbCMYK.Text = "(" + Math.Round(Math.Round(C, 2) * 100) + "%, " + Math.Round(Math.Round(M, 2) * 100) + "%, " + Math.Round(Math.Round(Y, 2) * 100) + "%, " + Math.Round(Math.Round(K, 2) * 100) + "%)";
        }
        private void HEX(int hn, int i)
        {
            if (hn <= 9) { hexcode[i] = hn.ToString(); }
            else if (hn > 9)
            {
                switch (hn)
                {
                    case 10:
                        hexcode[i] = "A";
                        return;
                    case 11:
                        hexcode[i] = "B";
                        return;
                    case 12:
                        hexcode[i] = "C";
                        return;
                    case 13:
                        hexcode[i] = "D";
                        return;
                    case 14:
                        hexcode[i] = "E";
                        return;
                    case 15:
                        hexcode[i] = "F";
                        return;
                }
            }
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aby wygenerowaæ randomow¹ barwê, zaznacz przynajmniej jeden interesuj¹cy ciê kolor podstawowy i kliknij 'Generuj'. Nastêpnie otrzymasz kod HEX, RGB oraz CMYK. " +
                "Uwaga! Wartoœci kolorów podlegaj¹ pseudolosowemu generowaniu wykonywanemu przez aplikacjê. Natomiast w przypadku zaznaczenia wiêcej ni¿ jednego koloru, u¿ytkownik mo¿e 'zatwierdziæ' wartoœci poprzez odznaczenie tego koloru, którego intensywnoœæ mu odpowiada i losowaæ dalej, do momentu uzyskania subiektywnie ciekawej barwy.", "Pomoc", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            h1 = 0;
            h2 = 0;
            r = h1 * 16 + h2;
            hexcode[0] = h1.ToString();
            hexcode[1] = h1.ToString();

            h3 = 0;
            h4 = 0;
            g = h3 * 16 + h4;
            hexcode[2] = h1.ToString();
            hexcode[3] = h1.ToString();

            h5 = 0;
            h6 = 0;
            b = h5 * 16 + h6;
            hexcode[4] = h1.ToString();
            hexcode[5] = h1.ToString();

            C = 0;
            M = 0;
            Y = 0;
            K = 0;

            hc = hexcode[0] + hexcode[1] + hexcode[2] + hexcode[3] + hexcode[4] + hexcode[5];
            lbHEX.Text = "#" + hc;
            //RGB code
            lbRGB.Text = "(" + r + ", " + g + ", " + b + ")";
            //CMYK code
            lbCMYK.Text = "(" + Math.Round(C, 2) * 100 + "%, " + Math.Round(M, 2) * 100 + "%, " + Math.Round(Y, 2) * 100 + "%, " + Math.Round(K, 2) * 100 + "%)";

            cbCzerwony.Checked = false;
            cbZielony.Checked = false;
            cbNiebieski.Checked = false;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (tbFileName.Text.Length == 0) { fileName = "blank.txt"; }
            else { fileName = tbFileName.Text + ".txt"; }

            string filePath = Path.Combine(folderPath, fileName);            

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                if (!File.Exists(filePath))
                {
                    File.Create(filePath);
                }                
            }

            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine("--------------------" + "\n" + "Data: " + DateTime.Now.ToString() +
                "\n" + "\t* HEX: " + lbHEX.Text + "\n\t* RGB: " + lbRGB.Text +
                "\n\t* CMYK: " + lbCMYK.Text + "\n");

            sw.Close();

            MessageBox.Show("Kolor " + lbHEX.Text + " zapisano do pliku "
                + fileName + " w lokalizacji " + folderPath, "Zapisano kolor", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}


