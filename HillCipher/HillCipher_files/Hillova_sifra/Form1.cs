using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hillova_sifra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private string StyleText(string text)
        {

            //StyleText pretvara uneseni tekst u oblik bez interpunkcijskih znakova, 
            //razmaka, hrvatskih znakova te sva slova postaju velika
            text = text.ToUpper();
            Regex RegObj = new Regex("[^A-ZŠĐŽČĆ]"); //regularni izraz koji obuhvaća sve što nisu velika slova
            text = RegObj.Replace(text, ""); //u tekstu mijenja sve što nije veliko slovo s praznim stringom
            text = text.Replace('Š', 'S');
            text = text.Replace('Ž', 'Z');
            text = text.Replace('Č', 'C');
            text = text.Replace('Ć', 'C');
            text = text.Replace("Đ", "DJ");
            return text;
        }

        Dictionary<char, int> slova;
        Dictionary<int, char> slova2;

        private void btnSifriraj_Click(object sender, EventArgs e)
        {
            string text = StyleText(rtxtUnos.Text);
            int[] res = new int[text.Length];
            
            //korak je 3 jer je m = 3
            for (int i=0; i<=text.Length-3; i+=3)
            {
                //uzmemo 3 slova i pridružimo im brojčanu vrijednost te onda mmnožimo redak s matricom 3x3

                //prvi stupac
                int x = slova[Convert.ToChar(text[i])] * int.Parse(mat11.Text);
                int y = slova[Convert.ToChar(text[i+1])] * int.Parse(mat21.Text);
                int z = slova[Convert.ToChar(text[i+2])] * int.Parse(mat31.Text);
                res[i] = (x + y + z) % 26;

                //drugi stupac
                x = slova[Convert.ToChar(text[i])] * int.Parse(mat12.Text);
                y = slova[Convert.ToChar(text[i + 1])] * int.Parse(mat22.Text);
                z = slova[Convert.ToChar(text[i + 2])] * int.Parse(mat32.Text);
                res[i+1] = (x + y + z) % 26;

                //treci stupac
                x = slova[Convert.ToChar(text[i])] * int.Parse(mat13.Text);
                y = slova[Convert.ToChar(text[i + 1])] * int.Parse(mat23.Text);
                z = slova[Convert.ToChar(text[i + 2])] * int.Parse(mat33.Text);
                res[i+2] = (x + y + z) % 26;

            }

            // u res dobijemo sifrat u brojevima, pa ih sad pretvorimo u slova
            string izlaz = "";
            for (int i = 0; i < res.Length; i++)
                izlaz += slova2[res[i]];
            //ubacujemo razmak nakon 5. slova
            for (int i = 5; i < izlaz.Length; i += 6)
                izlaz = izlaz.Insert(i, " ");

            rtxtIspis.Text = izlaz;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Slova();

        }

        private void Slova()
        {
            //svakom slovu pridružuje njegovu brojevnu vrijednost
            slova = new Dictionary<char, int>();
            slova2 = new Dictionary<int, char>();
            int br = 0;
            for (char s = 'A'; s <= 'Z'; s++)
            {
                slova[s] = br;
                br++;
            }

            for (int i=0; i<26; i++)
            {
                for (char s = 'A'; s <= 'Z'; s++)
                {
                    if (slova[s] == i)
                        slova2[i] = s;
                }
                    
            }
        }

        private void btnDesifriraj_Click(object sender, EventArgs e)
        {
            //spremamo matricu u niz
            int[] niz = new int[9];
            niz[0] = int.Parse(mat11.Text);
            niz[1] = int.Parse(mat12.Text);
            niz[2] = int.Parse(mat13.Text);
            niz[3] = int.Parse(mat21.Text);
            niz[4] = int.Parse(mat22.Text);
            niz[5] = int.Parse(mat23.Text);
            niz[6] = int.Parse(mat31.Text);
            niz[7] = int.Parse(mat32.Text);
            niz[8] = int.Parse(mat33.Text);
            int[] inverz = Inverse(niz); //izračunamo inverz matrice

            
            //radimo isto sto i pri sifriranju, samo s inverznom matricom

            string text = StyleText(rtxtUnos.Text);
            int[] res = new int[text.Length];

            //korak je 3 jer je m = 3
            for (int i = 0; i <= text.Length - 3; i += 3)
            {
                //prvi stupac
                int x = slova[Convert.ToChar(text[i])] * inverz[0];
                int y = slova[Convert.ToChar(text[i + 1])] * inverz[3];
                int z = slova[Convert.ToChar(text[i + 2])] * inverz[6];
                res[i] = (x + y + z) % 26;

                //drugi stupac
                x = slova[Convert.ToChar(text[i])] * inverz[1];
                y = slova[Convert.ToChar(text[i + 1])] * inverz[4];
                z = slova[Convert.ToChar(text[i + 2])] * inverz[7];
                res[i + 1] = (x + y + z) % 26;

                //treci stupac
                x = slova[Convert.ToChar(text[i])] * inverz[2];
                y = slova[Convert.ToChar(text[i + 1])] * inverz[5];
                z = slova[Convert.ToChar(text[i + 2])] * inverz[8];
                res[i + 2] = (x + y + z) % 26;

            }

            string izlaz = "";
            for (int i = 0; i < res.Length; i++)
                izlaz += slova2[res[i]];
            for (int i = 5; i < izlaz.Length; i += 6)
                izlaz = izlaz.Insert(i, " ");

            rtxtIspis.Text = izlaz;


        }

        private int[] Inverse(int[] niz)
        {

            //koristi se za računanje inverza matrice, "niz" su elementi matrice poredani u niz
            int[] inverz = new int[9];
            int mat11 = niz[0];
            int mat12 = niz[1];
            int mat13 = niz[2];

            int mat21 = niz[3];
            int mat22 = niz[4];
            int mat23 = niz[5];

            int mat31 = niz[6];
            int mat32 = niz[7];
            int mat33 = niz[8];

            //računanje determinante
            int det = mat11 * (mat22 * mat33 - mat32 * mat23) - mat12 * (mat21 * mat33 - mat23 * mat31) + mat13 * (mat21 * mat32 - mat22 * mat31);
            det = det % 26;
            if (det < 0)
                det = det + 26;

            //deti je inverz od det
            int deti = 0;
            if (det == 1) deti = 1;
            if (det == 3) deti = 9;
            if (det == 5) deti = 21;
            if (det == 7) deti = 15;
            if (det == 9) deti = 3;
            if (det == 11) deti = 19;
            if (det == 15) deti = 7;
            if (det == 17) deti = 23;
            if (det == 19) deti = 11;
            if (det == 21) deti = 5;
            if (det == 23) deti = 17;
            if (det == 25) deti = 25;

            //determinante minora
            inverz[0] =((((mat22 * mat33 - mat32 * mat23)%26+26)%26)*deti)%26;
            inverz[1] = (-(((mat21 * mat33 - mat23 * mat31)%26+26)%26) * deti)%26+26;
            inverz[2] = ((((mat21 * mat32 - mat22 * mat31)%26+26)%26) * deti)%26;
            inverz[3] = (-(((mat12 * mat33 - mat13 * mat32)%26+26)%26) * deti)%26+26;
            inverz[4] = ((((mat11 * mat33 - mat13 * mat31)%26+26)%26) * deti)%26;
            inverz[5] = (-(((mat11 * mat32 - mat31 * mat12)%26+26)%26) * deti)%26+26;
            inverz[6] = ((((mat12 * mat23 - mat22 * mat13)%26+26)%26) * deti)%26;
            inverz[7] = (-(((mat11 * mat23 - mat21 * mat13)%26+26)%26) * deti)%26+26;
            inverz[8] = ((((mat11 * mat22 - mat12 * mat21)%26+26)%26) * deti)%26;


            //transponiranje
            int x = inverz[3];
            inverz[3] = inverz[1];
            inverz[1] = x;

            x = inverz[6];
            inverz[6] = inverz[2];
            inverz[2] = x;

            x = inverz[5];
            inverz[5] = inverz[7];
            inverz[7] = x;

            return inverz;


        }

        private void btnMat1_Click(object sender, EventArgs e)
        {
            mat11.Text = 5 + "";
            mat12.Text = 8 + "";
            mat13.Text = 22 + "";
            mat21.Text = 2 + "";
            mat22.Text = 5 + "";
            mat23.Text = 24 + "";
            mat31.Text = 10 + "";
            mat32.Text = 20 + "";
            mat33.Text = 17 + "";



        }

        
    }
}
