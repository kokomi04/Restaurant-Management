using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.DAO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			TableManager f = new TableManager();
            string user = tbUser.Text;
            string pass = tbPass.Text;
            if (Login(user, pass))
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

         private bool Login(string user, string pass)
        {
            return AccountDAO.Instance.Login(user, pass);
        }

		private void button2_Click(object sender, EventArgs e)
		{
			
			DialogResult = MessageBox.Show("Bạn có muốn thoát?","Xác nhận thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
			if (DialogResult == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
