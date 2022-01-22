using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void BojanjeUzorka(string uzorak)
        {
            int indeks = 0;
            string tekst = rtbTekst.Text;
            rtbTekst.Text = "";
            rtbTekst.Text = tekst;

            while (indeks < rtbTekst.Text.LastIndexOf(uzorak))
            {
                rtbTekst.Find(uzorak, indeks, rtbTekst.TextLength, RichTextBoxFinds.None);
                rtbTekst.SelectionColor = Color.Red;
                indeks = rtbTekst.Text.IndexOf(uzorak, indeks) + 1;
            }



        }
        Stopwatch sw;
        private void Form2_Load(object sender, EventArgs e)
        {
            Ispisi();
        }
        public List<Tvrtka> listaTvrtki2 = new List<Tvrtka>();
        public string skupno2 = "";
        private void btnUzlazno_Click(object sender, EventArgs e)
        {
            btnUzlazno.Text = "Sortiraj";
            sw = new Stopwatch();
            sw.Start();
            if (rbBubble.Checked)
            {
                labelVrijeme.Text = "Bubble sort:\n";
                BubbleSort(listaTvrtki2);
                Ispisi();
            }
            else if (rbSelect.Checked)
            {
                labelVrijeme.Text = "Selection sort:\n";
                SelectionSort(listaTvrtki2);
                Ispisi();
            }
            else if (rbMerge.Checked)
            {
                labelVrijeme.Text = "Merge sort:\n";
                List<Tvrtka> temp = new List<Tvrtka>();
                temp = listaTvrtki2;
                listaTvrtki2 = MergeSort2(temp);
                
                Ispisi();
            }
            else if (rbHeap.Checked)
            {
                labelVrijeme.Text = "Heap sort:\n";
                heapSort(listaTvrtki2,listaTvrtki2.Count);
                Ispisi();
            }
            else if (rbInsertion.Checked)
            {
                labelVrijeme.Text = "Insertion sort:\n";
                InsertionSort(listaTvrtki2);
                Ispisi();
            }
            sw.Stop();
            string a = (sw.ElapsedMilliseconds / 1000.0).ToString();

            string vrijeme = a + "ms";
            labelVrijeme.Text += vrijeme;
        }

        private void btnPronadi_Click(object sender, EventArgs e)
        {
            string unos = txtUnos.Text;
            if (unos == "")
                return;

            BojanjeUzorka(unos);

        }

        public void Ispisi()
        {

            rtbTekst.Clear();
            rtbTekst.Text += "IME FIRME:\tVRIJEDNOST:\n";

            foreach (Tvrtka t in listaTvrtki2)
            {
                rtbTekst.Text += t.ImeFirme + "\t\t\t" + t.Vrijednost + "\n";
            }


        }

        // KLASICNA ZAMJENA ELEMENATA:
        public static void zamjeni(List<Tvrtka> data, Tvrtka m, Tvrtka n)
        {
            int privremena;
            string privremenaIme;
            //temp
            privremena = m.Vrijednost;
            privremenaIme = m.ImeFirme;
            //m
            m.Vrijednost = n.Vrijednost;
            m.ImeFirme = n.ImeFirme;
            //n
            n.Vrijednost = privremena;
            n.ImeFirme = privremenaIme;
        }

        // ZA BUBBLE SORT:
        public static void BubbleSort(List<Tvrtka> data)
        {
            int i, j;
            int N = data.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i].Vrijednost > data[i + 1].Vrijednost)
                        zamjeni(data, data[i], data[i + 1]);
                }
            }

            
        }

        //ZA SELECTION SORT:
        public static int IntArrayMin(List<Tvrtka> data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Count; pos++)
                if (data[pos].Vrijednost < data[minPos].Vrijednost)
                    minPos = pos;
            return minPos;
        }

        public static void SelectionSort(List<Tvrtka> data)
        {
            int i;
            int N = data.Count;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    zamjeni(data, data[i], data[k]);
            }
        }


        //INSERTION SORT
        public static void InsertionSort(List<Tvrtka> data)
        {
            int i, j;
            int N = data.Count;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i].Vrijednost < data[i - 1].Vrijednost; i--)
                {
                    zamjeni(data, data[i], data[i - 1]);
                }
            }
        }



        // MERGE SORT 
        public static List<Tvrtka> MergeSort2(List<Tvrtka> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<Tvrtka> left = new List<Tvrtka>();
            List<Tvrtka> right = new List<Tvrtka>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort2(left);
            right = MergeSort2(right);
            
            
            return Merge2(left, right);
        }

        public static List<Tvrtka> Merge2(List<Tvrtka> left, List<Tvrtka> right)
        {
            List<Tvrtka> result = new List<Tvrtka>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First().Vrijednost <= right.First().Vrijednost)  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            
            return result;
        }


        //HEAP SORT
        static void heapSort(List<Tvrtka> arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                Tvrtka temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }
        static void heapify(List<Tvrtka> arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left].Vrijednost > arr[largest].Vrijednost)
                largest = left;
            if (right < n && arr[right].Vrijednost > arr[largest].Vrijednost)
                largest = right;
            if (largest != i)
            {
                zamjeni(arr, arr[i], arr[largest]);
                
                heapify(arr, n, largest);
            }
        }

        //NAIVE PATTERN SEARCHING
        public static void Pretrazi(String txt, String uzorak)
        {
            int M = uzorak.Length;
            int N = txt.Length;

            /* A loop to slide pat one by one */
            for (int i = 0; i <= N - M; i++)
            {
                int j;

                /* For current index i, check for pattern  
                match */
                for (j = 0; j < M; j++)
                    if (txt[i + j] != uzorak[j])
                        break;

                // if pat[0...M-1] = txt[i, i+1, ...i+M-1] 
                if (j == M)
                {
                    
                    MessageBox.Show(uzorak + "-nalazi se na poziciji u tekstu: " + i);
                }
            }
        }

        private void btnPronadiIme_Click(object sender, EventArgs e)
        {
            
            string unos = txtUnos.Text;
            if (unos == "")
                return;
            btnUzlazno.Text = "Vrati na sortirani niz";
            Pretrazi(rtbTekst.Text, unos);
            
            
        }
    }
}
