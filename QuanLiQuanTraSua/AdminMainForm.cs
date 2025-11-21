using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
            

            
        }

        

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminMainForm_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void logout1_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Ban co muon thoat khong ", "thong bao xac nhan ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void adminAddUsers2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = true;
            adminAddUsers2.Visible = false;
            adminAddProducts1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            adminAddProducts1.Visible = true;
            adminDashboardForm1.Visible = false;
            adminAddUsers2.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminAddUsers2.Visible = true;
            adminDashboardForm1.Visible = false;
            
            adminAddProducts1.Visible = false;
        }


    }
}
