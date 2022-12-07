using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLab;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mass cll;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            try
            {
                string[] elemstr = textBox1.Text.Split(' ');

                int[] arr = new int[elemstr.Length];


                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(elemstr[i]);
                }
                Conclusion.Text = Mass.MaxMass(arr).ToString();
            }
            catch
            {
                MessageBox.Show("Неверно введены данные, скорее всего значение в массиве не соответствуют типу int");
                MessageBox.Show("Сотрите и введите данные заново");
            }
            
        }

        private void buttonMaxInd_Click(object sender, EventArgs e)
        {
            try
            {
                string[] elemstr = textBox1.Text.Split(' ');

                int[] arr = new int[elemstr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(elemstr[i]);
                }
                int start= Convert.ToInt32(startIndex.Text);
                int end= Convert.ToInt32(endIndex.Text); ;
                Conclusion.Text = Mass.MaxMassInd(arr, start, end).ToString();
            }
            catch
            {
                MessageBox.Show("В указанном диапазоне нет значений");
                MessageBox.Show("введите индексы заново");
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
