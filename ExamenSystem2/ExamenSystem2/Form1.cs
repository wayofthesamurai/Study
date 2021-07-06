using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace ExamenSystem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(@"D:\ReportProgramm\");
            textBox2.Text = "В программе реализовано: поиск файлов формата .txt и их запись в файл отчёта, + поиск запретных слов в этих же найденых файлах, создание их копий в отдельнюю папку на диску D (ReportProgramm и файлы отчёта FindWordsInFiles,FoundFile), так же копии файлов з заменёнными запретными словами на *******. Не реализовано: кнопки Pause, Continue, Cancel, многопоточность и синхронизация и открытие програмы через консоль";
            progressBar1.Maximum = 1000;
        }
        public StreamWriter Write = new StreamWriter(@"D:\FoundFile.txt");
        public StreamWriter FindWord = new StreamWriter(@"D:\FindWordsInFiles.txt");

        public string[] names;
        public int i = 0;
        public string DriversName;

        private void ShowDrivers_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            int i = 0;
            foreach (DriveInfo d in allDrives)
            {
                checkedListBox1.Items.Add(d.Name);
                checkedListBox1.SetItemChecked(i, true);
                i++;
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)||*.*|";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            textBox1.Text = File.ReadAllText(filename);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            names = new string[textBox1.Lines.Count()];
            for (; i < names.Length; i++)
                names[i] = textBox1.Lines[i];           
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string NameDrivers = itemChecked.ToString();
                GetRecursFiles(NameDrivers);
            }
            progressBar1.Value = 1000;
            Write.Close();
            FindWord.Close();
            progressBar1.Value = 0;
            MessageBox.Show("Work Finish");
        }

        public void GetRecursFiles(string start_path)
        {
            try
            {
                string[] folders = Directory.GetDirectories(start_path);
                foreach (string folder in folders)
                {
                    if (folder != @"D:\ReportProgramm\")
                        GetRecursFiles(folder);
                }
                string[] files = Directory.GetFiles(start_path, "*.txt");
                foreach (string filename in files)
                {
                    Write.WriteLine("File: " + filename);
                    FindWords(filename);
                    progressBar1.Value += 1;
                }
            }
            catch (System.Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }
        public void FindWords(string filename)
        {
            bool Yes = false;
            string text = new StreamReader(filename).ReadToEnd(); // открывает файл
            string[] words = text.Split(new char[] { ' ', ',', '.', '\r', '\n', '\t', '\\', '!', '?', '#', '(', ')', '*', '$', '@' });
            int k = words.Length;
            int f = 0;
            int j = 0;
            int[] count = new int[i];
            for (; j < i; j++)
            {
                for (int t = 0; t < k; t++)
                {
                    if (words[t] == names[j])
                    {
                        count[j]++;
                    }
                }
                if (count[j] > 0)
                {
                    f++;
                    if (f == 1)
                        FindWord.Write(filename + ": have - ");
                    if (f >= 1)
                    {
                        FindWord.Write(names[j] + '(' + count[j] + ") ");
                        Yes = true;
                    }
                }
            }
            if (Yes == true)
            {
                FindWord.WriteLine();
                Copy(filename);
                EditCopy(filename);                
            }
        }

        public void Copy(string PathAndFileName)
        {
            string OnlyFileName = Path.GetFileNameWithoutExtension(PathAndFileName);
            string newpath = @"D:\ReportProgramm\CopyFilesFromProgramm\";
            string newFileName = OnlyFileName+"_copy";
            FileInfo f1 = new FileInfo(PathAndFileName);
            if (f1.Exists)
            {
                if (!Directory.Exists(newpath))
                {
                    Directory.CreateDirectory(newpath);
                }
                f1.CopyTo(string.Format("{0}{1}{2}", newpath, newFileName, f1.Extension));               
            }         
        }

        public void EditCopy(string filename)
        {
            string OnlyFileName = Path.GetFileNameWithoutExtension(filename);
            string newpath2 = @"D:\ReportProgramm\EditFiles\";
            if (!Directory.Exists(newpath2))
            {
                Directory.CreateDirectory(newpath2);
            }
        
            string EditText = new StreamReader(filename).ReadToEnd(); // открывает файл
            for (int t = 0; t < i; t++)
            {
                EditText = EditText.Replace(names[t], "*******");
            }
            StreamWriter e = new StreamWriter(@"D:\ReportProgramm\EditFiles\"+OnlyFileName+"_edit.txt");
            e.Write(EditText);
            e.Close();
        }     
    }
}