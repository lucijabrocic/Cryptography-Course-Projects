using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifriraj_Click(object sender, EventArgs e)
        {
            //unos potrebnih parametara i racunanje bete
            int p = int.Parse(txtP.Text);
            int alfa = int.Parse(txtAlfa.Text);            
            int a = int.Parse(txtA.Text);
            int beta = KvadrirajiMnozi(alfa, a, p);

            //ispis javnog i tajnog kljuca
            rtxtIspis.Text = "Ključ: (" + p + ", " + alfa + ", " + a + ", " + beta + ")\n";
            rtxtIspis.Text += "Javni ključ: p = " + p + ", α = " + alfa + ", β = " + beta + "\nTajni ključ: a = " + a+"\n";

            //unos broja k i otvorenog teksta m
            int k=int.Parse(txtK.Text);
            int m = int.Parse(txtM.Text);           

            //racunanje y1 i y2
            int y1 = KvadrirajiMnozi(alfa, k, p);
            int y2 = m * KvadrirajiMnozi(beta, k, p) % p;
            rtxtIspis.Text += "\nŠifrat: (" + y1 + ", " + y2 + ")";

        }

        private int KvadrirajiMnozi(int x, int e, int n)
        {
            int a = (int)Math.Floor(Math.Log(e) / Math.Log(2)) + 1;
            int[] bin = new int[a];

            int b = e;
            for (int i = 0; i < a; i++)
            {
                bin[i] = b % 2;
                b = b / 2;
            }

            int y;
            if (bin[a - 1] == 1)
                y = x;
            else
                y = 1;
            for (int i = a-2; i >=0; i--)
            {
                y = y * y % n;
                if (bin[i] == 1)
                    y = y * x % n;

            }
            if (y < 0)
                y = y + n;

            return y;
        }

        private void btnDesifriraj_Click(object sender, EventArgs e)
        {
            rtxtIspis.Text = "";

            //unos potrebnih parametara
            int p = int.Parse(txtP.Text);
            int alfa = int.Parse(txtAlfa.Text);
            int a = int.Parse(txtA.Text);
            int beta = KvadrirajiMnozi(alfa, a, p);

            //ispis tajnog i javnog kljuca
            rtxtIspis.Text = "Ključ: (" + p + ", " + alfa + ", " + a + ", " + beta + ")\n";
            rtxtIspis.Text += "Javni ključ: p = " + p + ", α = " + alfa + ", β = " + beta + "\nTajni ključ: a = " + a + "\n";

            //ucitavanje vrijednosti y1 i y2
            int y1 = int.Parse(txtY1.Text);
            int y2 = int.Parse(txtY2.Text);

            //racunanje inverza od y1 ^ a
            int inv=1, i=1;
            int j = KvadrirajiMnozi(y1, a, p);

            //gleda brojeve vece od nule i kad nađe inverz, izađe iz petlje jer je inverz jedinstven
            while (i>0)
            {               
                if (j * i % p == 1)
                {
                    inv = i;
                    break;
                }
                i++;
                    
            }

            //racunanje otvorenog teksta
            int m = y2 * inv % p;

            rtxtIspis.Text += "\nOtvoreni tekst: " + m;
            
        }
    }
}
