using Lab02_02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class Form1 : Form
    {
        StudentContextDB db = new StudentContextDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lab02 - ko co DB
            //cmbFaculty.SelectedIndex = 0;
            //countGenger();

            //lab03 - connect DB
            try
            {
                List<Faculty> listFacultys = db.Faculties.ToList();
                List<Student> listStudents = db.Students.ToList();
                FillFacultyCombox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Student> listStudents)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudents)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.AverageScore;
                dgvStudent.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
            }
        }

        private void FillFacultyCombox(List<Faculty> listFacultys)
        {
            this.cmbFaculty.DataSource = listFacultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAverageScore.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên");

                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    Student st = new Student()
                    {
                        StudentID = txtStudentID.Text,
                        FullName = txtFullName.Text,
                        FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString()),
                        AverageScore = float.Parse(txtAverageScore.Text)
                    };
                    db.Students.Add(st);
                    db.SaveChanges();

                    dgvStudent.Rows[selectedRow].Cells[0].Value = st.StudentID;
                    dgvStudent.Rows[selectedRow].Cells[1].Value = st.FullName;
                    dgvStudent.Rows[selectedRow].Cells[2].Value = st.AverageScore;
                    dgvStudent.Rows[selectedRow].Cells[3].Value = st.Faculty.FacultyName;

                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow != -1)
                {
                    Student st = db.Students.FirstOrDefault(n => n.StudentID == txtStudentID.Text);
                    if (st != null)
                    {
                        st.FullName = txtFullName.Text;
                        st.AverageScore = float.Parse(txtAverageScore.Text);
                        st.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                        db.SaveChanges();

                        dgvStudent.Rows[selectedRow].Cells[0].Value = st.StudentID;
                        dgvStudent.Rows[selectedRow].Cells[1].Value = st.FullName;
                        dgvStudent.Rows[selectedRow].Cells[2].Value = st.AverageScore;
                        dgvStudent.Rows[selectedRow].Cells[3].Value = st.Faculty.FacultyName;

                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void InsertUpdate(int ID)
        //{
        //    dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
        //    dgvStudent.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
        //    dgvStudent.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
        //    dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtAverageScore.Text).ToString();
        //    dgvStudent.Rows[selectedRow].Cells[4].Value = cmbFaculty.Text;
        //}

        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        Student st = db.Students.FirstOrDefault(n => n.StudentID == txtStudentID.Text);
                        if (st != null)
                        {
                            db.Students.Remove(st);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                //countGenger();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //2.4
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            txtStudentID.Text = dgvStudent.Rows[selectedRow].Cells[0].Value.ToString();
            txtFullName.Text = dgvStudent.Rows[selectedRow].Cells[1].Value.ToString();
            txtAverageScore.Text = dgvStudent.Rows[selectedRow].Cells[2].Value.ToString();
            cmbFaculty.Text = dgvStudent.Rows[selectedRow].Cells[3].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "YES/NO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }




        //2.5 Dem tong SV nam, nu
        //private void countGenger()
        //{
        //    int countMale = 0, countFemale = 0;
        //    for (int i = 0; i < dgvStudent.Rows.Count; i++)
        //    {
        //        if (dgvStudent.Rows[i].Cells[2].Value.ToString() == "Nam")
        //        {
        //            countMale++;
        //        }
        //        else
        //        {
        //            countFemale++;
        //        }
        //    }
        //    this.txtSumMale.Text = countMale.ToString();
        //    this.txtSumFemale.Text = countFemale.ToString();
        //}

    }
}
