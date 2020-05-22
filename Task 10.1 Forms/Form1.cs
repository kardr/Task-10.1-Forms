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

namespace Task_10._1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory("C:\\temp");
                Directory.CreateDirectory("C:\\temp\\K1");
                Directory.CreateDirectory("C:\\temp\\K2");
                StreamWriter sw = new StreamWriter("C:\\temp\\K1\\t1.txt");
                sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
                sw.Close();
                sw = new StreamWriter("C:\\temp\\K1\\t2.txt");
                sw.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                sw.Close();
                sw = new StreamWriter("C:\\temp\\K2\\t3.txt");
                StreamReader sr = new StreamReader("C:\\temp\\K1\\t1.txt");
                sw.WriteLine(sr.ReadToEnd());
                sr.Close();
                sr = new StreamReader("C:\\temp\\K1\\t2.txt");
                sw.WriteLine(sr.ReadToEnd());
                sr.Close();
                sw.Close();
                File.Move("C:\\temp\\K1\\t2.txt", "C:\\temp\\K2\\t2.txt");
                File.Copy("C:\\temp\\K1\\t1.txt", "C:\\temp\\K2\\t1.txt");
                Directory.Move("C:\\temp\\K2", "C:\\temp\\ALL");
                Directory.Delete("C:\\temp\\K1", true);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
