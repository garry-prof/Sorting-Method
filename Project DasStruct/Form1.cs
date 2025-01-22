using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DasStruct
{
    public partial class FormMain : Form
    {
        private Random random = new Random();
        public List<int> data = new List<int>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            listBoxInitialNum.Items.Clear();
            data.Clear();
            int Count = random.Next(1000, 10000);

            for (int i = 0; i < Count; i++)
            {
                data.Add(random.Next(1000, 10000));
            }
            foreach (var angka in data)
            {
                listBoxInitialNum.Items.Add(angka);
            }
            MessageBox.Show("Gennerate Angka Berhasil");
            int itemCount = data.Count;
            labelTotalData.Text = itemCount.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxInitialNum.Items.Clear();
            listBoxHasilSort.Items.Clear();
            labelWaktuSorting.Text = string.Empty;
            labelTotalData.Text = string.Empty;
        }

        private void buttonAsc_Click(object sender, EventArgs e)
        {
            #region Bubble Sort
            if (comboBoxJenisSort.SelectedIndex == 0)//bubble Sort
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                BubbleSort(data);
                DisplaySorting(data);
                MessageBox.Show("Angka Di Sort dengan Bubble Sort Berhasil");

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                labelWaktuSorting.Text = string.Format("{0:D3}",elapsedTime.Milliseconds);
                
            }
            #endregion

            #region Quick Sort
            else if (comboBoxJenisSort.SelectedIndex == 1)//Quick Sort
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                QuickSort(data, 0, data.Count - 1);
                DisplaySorting(data);
                MessageBox.Show("Angka Di Sort dengan Quick Sort Berhasil");

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                labelWaktuSorting.Text = string.Format("{0:D3}", elapsedTime.Milliseconds);

            }
            #endregion

            #region Heap Sort
            else if (comboBoxJenisSort.SelectedIndex == 2)//Heap Sort
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                HeapSort(data);
                DisplaySorting(data);
                MessageBox.Show("Angka Di Sort dengan Heap Sort Berhasil");

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                labelWaktuSorting.Text = string.Format("{0:D3}", elapsedTime.Milliseconds);

            }
            #endregion

            #region Radix Sort
            else if (comboBoxJenisSort.SelectedIndex == 3)//Radix Sort
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                RadixSort(data);
                DisplaySorting(data);   
                MessageBox.Show("Angka Di Sort dengan Radix Sort Berhasil");

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                labelWaktuSorting.Text = string.Format("{0:D3}", elapsedTime.Milliseconds);

            }
            #endregion

            #region Shell Sort
            else if (comboBoxJenisSort.SelectedIndex == 4)//Shell Sort
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                ShellSort();
                DisplaySorting(data);
                MessageBox.Show("Angka Di Sort dengan Shell Sort Berhasil");

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                labelWaktuSorting.Text = string.Format("{0:D3}", elapsedTime.Milliseconds);

            }
            #endregion
        }

        private void buttonDsc_Click(object sender, EventArgs e)
        {
            #region Bubble Sort
            if (comboBoxJenisSort.SelectedIndex == 0)//bubble Sort
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                BubbleSortDesc(data);
                DisplaySorting(data);
                MessageBox.Show("Angka Di Sorting dengan cara Bubble Sort Berhasil (Descending)");

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                labelWaktuSorting.Text = string.Format("{0:D3}", elapsedTime.Milliseconds);

            }
            #endregion

            #region Quick Sort
            else if (comboBoxJenisSort.SelectedIndex == 1)//Quick Sort
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                QuickSortDesc(data, 0, data.Count - 1);
                DisplaySorting(data);
                MessageBox.Show("Angka Di Sorting dengan cara Quick Sort Berhasil (Descending)");

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                labelWaktuSorting.Text = string.Format("{0:D3}", elapsedTime.Milliseconds);

            }
            #endregion

            #region Heap Sort
            else if (comboBoxJenisSort.SelectedIndex == 2)//Heap Sort 
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                HeapSortDesc(data);
                DisplaySorting(data);
                MessageBox.Show("Angka Di Sorting dengan cara Heap Sort Berhasil (Descending)");

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                labelWaktuSorting.Text = string.Format("{0:D3}", elapsedTime.Milliseconds);

            }
            #endregion

            #region Radix Sort
            else if (comboBoxJenisSort.SelectedIndex == 3)//Radix Sort
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                RadixSortDesc(data);
                DisplaySorting(data);
                MessageBox.Show("Angka Di Sorting dengan cara Radix Sort Berhasil (Descending)");

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                labelWaktuSorting.Text = string.Format("{0:D3}", elapsedTime.Milliseconds);

            }
            #endregion

            #region Shell Sort
            else if (comboBoxJenisSort.SelectedIndex == 4)//Shell Sort
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                ShellSortDescending();
                DisplaySorting(data);
                MessageBox.Show("Angka Di Sorting dengan cara Shell Sort Berhasil (Descending)");

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                labelWaktuSorting.Text = string.Format("{0:D3}", elapsedTime.Milliseconds);

            }
            #endregion
        }

        #region method Sorting ASC

        #region Bubble Sort
        public void BubbleSort(List<int> data)
        {
            int n = data.Count; // jumlah element dalam list
            //mengatur berapa kali proses sorting yang dilakukan
            //kenapa n-1? karena kalo ada 5 data di array maka dia hanya perlu melakukan 4 iterasi karena otomatis element terakhir sudah benar
            for (int i = 0; i < n - 1; i++)
            {
                //loopingan membandingkan dua elemen yang berdekatan dan menukar elemen yang lebih besar untuk sorting 
                //kenapa n - i - 1? n menunjukan batas akhir arr, i indeks iterasi luar, -1 untuk menghindari outbond dari arr
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (data[j] > data[j + 1])//membandingkan data jika lebih besar maka penukaran
                    {
                        //data yang lebih besar dia ditampung 
                        int temp = data[j];
                        //data yang lebih kecil ditukar dengan data yang lebih besar
                        data[j] = data[j + 1];
                        //data yang lebih besar yang ditampung berada di posisi belakang dari data yang lebih besar
                        data[j + 1] = temp;
                    }
                }
            }
        }
        #endregion       

         #region QuickSort
        public static void QuickSort(List<int> data,int low, int high)
        { //low indeks awal dari subarr, high indeks akhir dari subarr
            if(low < high) // untuk proses rekrusif
            {
                int s = Partition(data,low , high);//Fungsi ini memindahkan pivot ke posisi yang benar di array. Mengembalikan posisi pivot setelah elemen dipartisi.
                QuickSort(data, low, s - 1); //kiri
                QuickSort(data, s + 1, high); //kanan
            }
        }

        private static int Partition(List<int> data, int low, int high)
        {
            int pivot = data[high]; //element terakhir 
            int i = (low - 1); //indeks element yang lebih kecil dari pivot. menandai batas element yang lebih kecil dari pivot.     
            for (int j = low; j < high; j++) 
            {
                if (data[j] <= pivot) // Jika elemen lebih kecil/sama dengan pivot
                {
                    i++;// Pindahkan indeks elemen kecil ke depan
                    Swap(data, i, j);// Tukar elemen di posisi i dan j
                }
            }
            Swap(data, i + 1, high);// Pindahkan pivot ke posisi yang benar
            return i + 1;// Kembalikan posisi pivot
        }
        private static void Swap(List<int> data, int i, int j)
        {
            int temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
        #endregion

        #region Heap Sort
        static void HeapSort(List<int> data)
        {
            int n = data.Count;
            //membangun max heap
            for (int i = n / 2 - 1; i >= 0; i--) //indeks elemen yang berada di bawah level daun terakhir di heap dan bergerak ke arah indeks 0.
            {
                Heapify(data, n, i);
            }
            // Mengambil elemen terbesar dan mengatur heap
            for (int i = n - 1; i > 0; i--)
            {
                // Tukar elemen terbesar (root) dengan elemen terakhir
                int temp = data[i];
                data[i] = data[0];
                data[0] = temp;
                // Perbaiki heap untuk subarray yang tersisa
                Heapify(data, i, 0);
            }
        }
        static void Heapify(List<int> data, int n, int i)
        {
            int root = i; //indeks root 
            //Indeks ini mengikuti struktur binary tree di mana anak-anaknya berada pada posisi tertentu tergantung pada indeks orang tua.
            
            int left = 2 * i + 1; //indeks anak kiri
            int right = 2 * i + 2; // indeks anak kanan

            //memilih elemen terbesar yang menjadi root 
            //jika anak kiri lebih besar dari pada root
            if (left < n && data[left] > data[root])
            {
                root = left;
            }
            //jika anak kanan lebih besar daripada root
            if (right < n && data[right] > data[root])
            {
                root = right;
            }
            //jika root tidak berada di posisi yang bener (berbeda dengan i)
            if (root != i)
            {
                //tukar root dengan anak yang lebih besar 
                int swap = data[i];
                data[i] = data[root];
                data[root] = swap;

                // Rekursi pada subtree yang telah diubah
                Heapify(data, n, root);
            }
        }
        #endregion

        #region Radix Sort
        static void RadixSort(List<int> data)
        {
            int max = FindMax(data);//cari elemen terbesar, menentukan berapa digit yang harus di proses
            int exp = 1;//untuk ekspansi digit dimulai dari satuan and so on

            while (max / exp > 0)
            {
                CountingSort(data);//panggil countingSort untuk digit yang sekarang 
                exp *= 10;//pindah ke digit selanjutnya
            }
        }

        static int FindMax(List<int> data)
        {
            int max = data[0]; //asumsi elemen pertama adalah yang terbesar
            for (int i = 1; i < data.Count; i++)
            {
                if (data[i] > max)
                {
                    max = data[i];//perbarui nilai max jika ditemukan elemen yang lebih besar
                }
            }
            return max;//kembali elemen terbesar
        }

        static void CountingSort(List<int> list)
        {
            if (list.Count == 0) return;//jika arr kosong tidak perlu diproses

            int min = list[0];
            int max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min) min = list[i];//cari nilai min
                if (list[i] > max) max = list[i];//cari nilai max
            }

            int range = max - min + 1;//rentang nilai 
            int[] count = new int[range];
            int[] output = new int[list.Count];
            //hitung frekuensi setiap element
            for (int i = 0; i < list.Count; i++)
            {
                count[list[i] - min]++;
            }
            //hitung posisi kumulatif 
            for (int i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }
            //bangun array output berdasarkan posisi kumulatif
            for (int i = list.Count - 1; i >= 0; i--)
            {
                output[count[list[i] - min] - 1] = list[i];
                count[list[i] - min]--;
            }
            // Salin hasil ke array asli
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = output[i];
            }
        }
        #endregion

        #region Shell Sort
        public void ShellSort()
        {
            int n = data.Count;

            // Tentukan gap awal (biasanya n/2)
            // gap awal sebesar n / 2 (setengah dari jumlah elemen array). Gap menentukan jarak antara elemen yang dibandingkan.
            //Setiap iterasi, gap dibagi dua (gap /= 2) hingga mencapai 1, di mana array akan diurutkan sepenuhnya seperti pada Insertion Sort.
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Lakukan Shell sort untuk setiap gap
                for (int i = gap; i < n; i++)
                {
                    int temp = data[i];
                    int j;

                    // Geser elemen ke kanan jika lebih besar dari elemen sementara
                    for (j = i; j >= gap && data[j - gap] > temp; j -= gap)
                    {
                        data[j] = data[j - gap];
                    }

                    // Tempatkan elemen sementara di posisi yang benar
                    data[j] = temp;
                }
            }
        }
        #endregion



        #endregion

        #region Method Sorting DESC

        #region Bubble Sort
        public void BubbleSortDesc(List<int> data)
        {

            int n = data.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (data[j] < data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
        #endregion

        #region QuickSort
        public static void QuickSortDesc(List<int> data, int low, int high)
        {
            if (low < high)
            {
                int s = PartitionDesc(data, low, high);
                QuickSortDesc(data, low, s - 1);
                QuickSortDesc(data, s + 1, high);
            }
        }

        private static int PartitionDesc(List<int> data, int low, int high)
        {
            int pivot = data[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (data[j] >= pivot)
                {
                    i++;
                    SwapDesc(data, i, j);
                }
            }
            SwapDesc(data, i + 1, high);
            return i + 1;
        }
        private static void SwapDesc(List<int> data, int i, int j)
        {
            int temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
        #endregion

        #region Heap Sort
        static void HeapSortDesc(List<int> data)
        {
            int n = data.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                HeapifyDesc(data, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = data[i];
                data[i] = data[0];
                data[0] = temp;
                HeapifyDesc(data, i, 0);
            }
        }
        static void HeapifyDesc(List<int> data, int n, int i)
        {
            int root = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && data[left] < data[root]) 
            {
                root = left;
            }

            if (right < n && data[right] < data[root])
            {
                root = right;
            }

            if (root != i)
            {
                int swap = data[i];
                data[i] = data[root];
                data[root] = swap;

                HeapifyDesc(data, n, root);
            }
        }
        #endregion

        #region Radix Sort
        static void RadixSortDesc(List<int> data)
        {
            int max = FindMaxDesc(data);
            int exp = 1;

            while (max / exp > 0)
            {
                CountingSortDesc(data, exp);
                exp *= 10;
            }
        }

        static int FindMaxDesc(List<int> data)
        {
            int max = data[0];
            for (int i = 1; i < data.Count; i++)
            {
                if (data[i] > max)
                {
                    max = data[i];
                }
            }
            return max;
        }

        static void CountingSortDesc(List<int> list, int exp)
        {
            int n = list.Count;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                int digit = (list[i] / exp) % 10;
                count[digit]++;
            }

            for (int i = 8; i >= 0; i--)
            {
                count[i] += count[i + 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (list[i] / exp) % 10;
                output[count[digit] - 1] = list[i];
                count[digit]--;
            }

            for (int i = 0; i < n; i++)
            {
                list[i] = output[i];
            }
        }
        #endregion

        #region Shell Sort
        public void ShellSortDescending()
        {
            int n = data.Count;

            // Tentukan gap awal (biasanya n/2)
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Lakukan Shell sort untuk setiap gap
                for (int i = gap; i < n; i++)
                {
                    int temp = data[i];
                    int j;

                    // Geser elemen ke kanan jika lebih kecil dari elemen sementara
                    for (j = i; j >= gap && data[j - gap] < temp; j -= gap)
                    {
                        data[j] = data[j - gap];
                    }

                    // Tempatkan elemen sementara di posisi yang benar
                    data[j] = temp;
                }
            }
        }

        #endregion


        #endregion

        public void DisplaySorting(List<int> data)// display method
        {
            listBoxHasilSort.Items.Clear();
            foreach (var number in data)
            {
                listBoxHasilSort.Items.Add(number);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
