using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // dodajemo za prikazivanje grafova


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            btnDetaljno.Hide();
            chart1.Series.Clear(); // ocisti sve




        }
        public string skupno;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        List<Tvrtka> listaTvrtki = new List<Tvrtka>();
        int suma = 0;
        
        private void btnPokreni_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear(); // ocisti sve
            chart1.Legends.Clear(); // ocisti legendu ispod grafa


            
            string unosImena;
            unosImena = txtImeFirme.Text;
            if (unosImena == "")
                return;
            int vrijednostDionice;
            if (txtVrijednost.Text == "" || !int.TryParse(txtVrijednost.Text, out vrijednostDionice))
                return;
            if(int.Parse(txtVrijednost.Text)<=0)
                return;
            vrijednostDionice = int.Parse(txtVrijednost.Text);
            

            Tvrtka a = new Tvrtka(unosImena,vrijednostDionice);
            if(!listaTvrtki.Contains(a))
            {
                listaTvrtki.Add(a);
                
            }
            else
            {
                suma -= a.Vrijednost;
                a.Vrijednost = int.Parse(txtVrijednost.Text);
            }
            
            suma += a.Vrijednost;


            btnDetaljno.Show();
            
            skupno = "";
            chart1.Series.Clear(); // ocisti sve
            chart1.Legends.Clear(); // ocisti legendu ispod grafa


            chart1.Legends.Add("Legenda");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "Prikaz cjelokupnog trzista u RH:";
            chart1.Legends[0].BorderColor = Color.Black;

            string imegrafa = "Graf";
            chart1.Series.Add(imegrafa);

            chart1.Series[imegrafa].ChartType = SeriesChartType.Pie;
            foreach (Tvrtka t in listaTvrtki)
            {
                
                double iznos = t.Vrijednost * 100 / suma;
                chart1.Series[imegrafa].Points.AddXY(t.ImeFirme+" " +iznos+" %", t.Vrijednost);
                skupno += t.ImeFirme+"\n";
            }
            
            
        }

        private void btnDetaljno_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni za detaljan prikaz?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                Form2 druga = new Form2();
                druga.skupno2 = skupno;
                druga.listaTvrtki2 = listaTvrtki;
                druga.Show();
            }
            else
            {
                return;
            }


        }

        private void btnRandom_Click(object sender, EventArgs e)
        {



            // Get the number of words and letters per word.
            int num_letters = 6;
            int num_words = 1000;

            // Make an array of the letters we will use.
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            // Make a random number generator.
            Random rand = new Random();

            // Make the words.
            for (int i = 1; i <= num_words; i++)
            {
                // Make a word.
                string word = "";
                for (int j = 1; j <= num_letters; j++)
                {
                    // Pick a random number between 0 and 25
                    // to select a letter from the letters array.
                    int letter_num = rand.Next(0, letters.Length - 1);

                    // Append the letter.
                    word += letters[letter_num];
                }

                // Add the word to the list.
                int vr = rand.Next(0, 1000);
                Tvrtka nova = new Tvrtka(word, vr);
                listaTvrtki.Add(nova);
                skupno += word;
                suma += vr;
            }
        }
    }
}
