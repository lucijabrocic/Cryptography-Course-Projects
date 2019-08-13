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

namespace kripto_zadaca1_lucija
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<char, int> slova = new Dictionary<char, int>();
        Dictionary<char, int> sifra = new Dictionary<char, int>();

        private void btnSifriraj_Click(object sender, EventArgs e)
        {
            slova = new Dictionary<char, int>();
            sifra = new Dictionary<char, int>();
            rtxtIspis.Clear();
            if (txtKljucnaRijec.Text == "")
                Sifra(txtKljucnaRijec.Text, 26 - int.Parse(txtPozicija.Text));
            else
                Sifra(txtKljucnaRijec.Text, int.Parse(txtPozicija.Text));
            string text = StyleText(rtxtUnos.Text);
            string s = text;
            string kljuc= " ";


            for (int i=0; i<text.Length; i++)
            {
                char slov = text[i];
                foreach (KeyValuePair<char, int> par in sifra)
                {
                    if (slova[slov] == par.Value)
                        kljuc = par.Key.ToString();
                }
                text=text.Remove(i,1).Insert(i,kljuc);

            }

            //ubacuje razmake na svako 5. mjesto u konacnom tekstu
            for (int i=5; i<text.Length; i+=6)
                text = text.Insert(i, " ");

            rtxtIspis.Text = text;

        }

        //StyleText pretvara uneseni tekst u oblik bez interpunkcijskih znakova, 
        //razmaka, hrvatskih znakova te sva slova postaju velika
        private string StyleText(string text)
        {
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
        


        private void Sifra(string rijec, int poz)
        {
            rijec = rijec.ToUpper();            
            int br = 0;

            //pridruživanje broja slovu
            for (char s = 'A'; s <= 'Z'; s++)
            {
                slova[s] = br;
                br++;
            }

            char l;
            if (rijec == "")
                sifra['A'] = poz;
            else
            {
                l = rijec[0];
                sifra[l] = poz;                
            }
            br = poz;

            //svako slovo iz kljucne rijeci smjestamo u abecedu sifrata
            if (rijec != "")
            {
                foreach (char s in rijec)
                {
                    if (!(sifra.ContainsKey(s)))
                    {
                        br++;
                        if (br >= 26)
                            br = br % 26;

                        sifra[s] = br;                        
                    }

                }
            }
            else
            {
                foreach(char s in slova.Keys)
                {
                    
                    if (br >= 26)
                        br = br % 26;
                    sifra[s] = br;
                    br++;
                }
            }
            

            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (!(sifra.ContainsKey(c)))
                {
                    br++;
                    if (br >= 26)
                        br = br % 26;

                    sifra[c] = br;                    

                }
            }
        }

        private void btnDesifriraj_Click(object sender, EventArgs e)
        {
            //cisti textbox za ispit te abecede
            rtxtIspis.Clear();
            slova = new Dictionary<char, int>();
            sifra = new Dictionary<char, int>();

            //ako je s kljucnom rijeci, onda je pozicija odakle pocinje upisivanje slova
            //ali ako je obicna Cezarova sifra, onda pocinje od pozicije 26 - pocetna_pozicija
            if (txtKljucnaRijec.Text=="")
                Sifra(txtKljucnaRijec.Text, 26-int.Parse(txtPozicija.Text));
            else
                Sifra(txtKljucnaRijec.Text, int.Parse(txtPozicija.Text));

            string text = StyleText(rtxtUnos.Text);
            string s = text;
            string kljuc = " ";

            //u sifratu zamjenjuje slovo po slovo tj. desifrira slovo po slovo
            for (int i = 0; i < text.Length; i++)
            {
                char slov = text[i];
                foreach (KeyValuePair<char, int> par in slova)
                {
                    if (sifra[slov] == par.Value)
                        kljuc = par.Key.ToString();
                }
                text = text.Remove(i, 1).Insert(i, kljuc);

            }

           rtxtIspis.Text = text;


            //sluzi za ispis abecede -za provjeru
            /*rtxtIspis.Text += "\n----";
            foreach (KeyValuePair<char, int> par in slova)
            {
                rtxtIspis.Text += par.Key + " " + par.Value + "\n";
            }

            foreach (KeyValuePair<char, int> par in sifra)
            {
                rtxtIspis.Text += "\n" + par.Key + " " + par.Value;
            }*/
        }
    }
}
