using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LU_разложение
{
    public partial class Form1 : Form
    {
        int n = 0;
        DataTable mxA;
        DataTable mxb;
        string vbstr = "1";

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            n = (int)numericUpDown1.Value;
            mxA = new DataTable("Матрица A");
            mxb = new DataTable("Вектор b");
            if(n>0)
                mxb.Columns.Add(vbstr, typeof(int));
            for (int i = 0; i < n; i++)
            {
                mxA.Columns.Add(Convert.ToString(i), typeof(int));
                mxA.Rows.Add();
                mxb.Rows.Add();
            }
            dataGridView1.DataSource = mxA;
            dataGridView2.DataSource = mxb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            mxA = new DataTable("Матрица A");
            mxb = new DataTable("Вектор b");
            for (int i = 0; i < n; i++)
            {
                mxA.Columns.Add(Convert.ToString(i), typeof(int));
            }
            mxb.Columns.Add(vbstr, typeof(int));
            for (int i = 0; i < n; i++)
            {
                DataRow dataRowA = mxA.NewRow();
                DataRow dataRowb = mxb.NewRow();
                dataRowb[vbstr] = r.Next(-100, 100);
                for (int j = 0; j < n; j++)
                {
                    dataRowA[Convert.ToString(j)] = r.Next(-100, 100);
                }
                mxA.Rows.Add(dataRowA);
                mxb.Rows.Add(dataRowb);
            }
            dataGridView1.DataSource = mxA;
            dataGridView2.DataSource = mxb;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = mxA.Rows[0];
            textBox1.Text = dr[1].ToString();
        }
    }
    public class LUsolver
    {
        public void factorization()
        {

        }

        public void solve()
        {

        }

        public void determinant()
        {

        }

        public void inverse1()
        {

        }

        public void inverse2()
        {

        }

        public void exp1()
        {

        }

        public void exp2()
        {

        }

        public void exp3()
        {

        }
    }
}
