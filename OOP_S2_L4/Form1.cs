using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_S2_L4
{
    public partial class Form1 : Form
    {
        RectangleMatrix matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void findFirstZeroNegativesColumnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int first = matrix.FirstNullNegativesColumn();
                firstColumnTextBox.Text = first != -1 ? (first + 1).ToString() : "Відсутній";
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Не вдалось здійснити операцію пошуку, оскільки матриця ще не створена.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void createMatrixBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(rowsTextBox.Text);
                int cols = int.Parse(colsTextBox.Text);

                matrix = new RectangleMatrix(rows, cols);

                int min = int.Parse(minNumberTextBox.Text);
                int max = int.Parse(maxNumberTextBox.Text);
                matrix.FillElemnentsRandom(min, max);

                ShowNewMatrix(matrix);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не вдалось здійснити операцію створенння нової матриці.\nПеревірте, чи всі поля заповнені числами.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Не вдалось здійснити операцію створенння нової матриці.\nОскільки рядки та стовпці матриці не можуть набувати від'ємних значень.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ShowNewMatrix(RectangleMatrix matrix)
        {
            DataTable dt = new DataTable();
            int rows = matrix.GetRows();
            int cols = matrix.GetCols();
            for (int j = 0; j < cols; j++)
            {
                dt.Columns.Add(j.ToString(), typeof(double));
            }
            for (int i = 0; i < rows; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < cols; j++)
                {
                    dr[j] = matrix[i, j];
                }
                dt.Rows.Add(dr);
            }
            dataGridView.DataSource = dt;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.CancelEdit();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rowsInputLabel_Click(object sender, EventArgs e)
        {

        }

        private void colsTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rowsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void colsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void minNumberTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void maxNumberTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            try
            {
                matrix = matrix.GetSortedMatrix_ByMaxTheSameNumberCount_OfEachRow();
                ShowNewMatrix(matrix);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не вдалось здійснити операцію сортування рядків матриці\nпо кількості повторень чисел за зростанням, оскільки попередня матриця ще не створена.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }

}
