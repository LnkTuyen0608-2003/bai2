using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lap02_02 : Form
    {
        public Lap02_02()
        {
            InitializeComponent();
        }

        private void Lap02_02_Load(object sender, EventArgs e)
        {
            cmbFaculty.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private int GetSelectedRow(String studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID.ToString())
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtAverageScore.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cmbFaculty.Text;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAverageScore.Text == "")
                    throw new Exception("Vui long nhap day du thong tin");
                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Them moi du lieu thanh cong", "Thong bao", MessageBoxButtons.OK);
                    Sum();
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cap nhat du lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
                    Sum();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Sum();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectRow = GetSelectedRow(txtStudentID.Text);
                if (selectRow == -1)
                {
                    throw new Exception("Khong tim thay MSSV can xoa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Ban co muon xoa?", "Yes/No", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectRow);
                        MessageBox.Show("Xoa sinh vien thanh cong!", "Thong bao", MessageBoxButtons.OK);
                        Sum();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Sum()
        {
            int DemNam = dgvStudent.Rows.Cast<DataGridViewRow>().Count(p => p.Cells[2].Value + "" == "Nam");


            optMale.Text = DemNam.ToString();
            optFemale.Text = (dgvStudent.Rows.Count - DemNam).ToString();
        }

    }
}

