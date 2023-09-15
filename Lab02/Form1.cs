using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                float number1 = float.Parse(txtSothu1.Text);
                float number2 = float.Parse(txtSothu2.Text);
                float result = number1 + number2;
                txtCauhoi.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {

                float number1 = float.Parse(txtSothu1.Text);
                float number2 = float.Parse(txtSothu2.Text);
                float result = number1 / number2;
                txtCauhoi.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblSothu1_Click(object sender, EventArgs e)
        {

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {

                float number1 = float.Parse(txtSothu1.Text);
                float number2 = float.Parse(txtSothu2.Text);
                float result = number1 - number2;
                txtCauhoi.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {

                float number1 = float.Parse(txtSothu1.Text);
                float number2 = float.Parse(txtSothu2.Text);
                float result = number1 * number2;
                txtCauhoi.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
