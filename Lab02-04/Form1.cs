using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int KtTonTai(string maTK)//kiểm tra tài khoản có tồn tại hay chưa
        {
            for (int i = 0; i < lwAccount.Items.Count; i++)
                if (lwAccount.Items[i].SubItems[1].Text == maTK)
                    return i;
            return -1;
        }
       
        private int i = 0;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSTK.Text == "" || txtTenKH.Text == "" || txtDiaChiKH.Text == "" || txtSoTienTrongTK.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");

                int selectedRow = KtTonTai(txtSTK.Text);
                int sum = 0;
                if (selectedRow == -1)
                {
                    i++;
                    ListViewItem listViewItem = new ListViewItem(i.ToString());
                    listViewItem.SubItems.Add(txtSTK.Text);
                    listViewItem.SubItems.Add(txtTenKH.Text);
                    listViewItem.SubItems.Add(txtDiaChiKH.Text);
                    listViewItem.SubItems.Add(txtSoTienTrongTK.Text);
                    lwAccount.Items.Add(listViewItem);
                    for (int i = 0; i < lwAccount.Items.Count; i++)
                    {
                        sum += int.Parse(lwAccount.Items[i].SubItems[4].Text);
                    }
                    txtTotal.Text = sum.ToString();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    lwAccount.Items[selectedRow].SubItems[2].Text = txtTenKH.Text;
                    lwAccount.Items[selectedRow].SubItems[3].Text = txtDiaChiKH.Text;
                    lwAccount.Items[selectedRow].SubItems[4].Text = txtSoTienTrongTK.Text;
                    for (int i = 0; i < lwAccount.Items.Count; i++)
                    {
                        sum += int.Parse(lwAccount.Items[i].SubItems[4].Text);
                    }
                    txtTotal.Text = sum.ToString();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = KtTonTai(txtSTK.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy số tài khoản cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        lwAccount.Items.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chươnng trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();   
            }
        }
    }
}
