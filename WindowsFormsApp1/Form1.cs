using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txtSoThuHai.Text;
                long nSoThuHai = long.Parse(soThuHai);
                var ketQua = nSoThuNhat + nSoThuHai;

                labelKQ.Text = ketQua.ToString("N2");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số không ký tự. Chi tiết lỗi: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn. Vui lòng nhập số nhỏ hơn. Chi tiết lỗi: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn nhé. Chi tiết lỗi: {ex.Message}");
            }
        }
    }
}
