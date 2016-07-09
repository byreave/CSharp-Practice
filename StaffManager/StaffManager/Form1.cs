using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUser.AllowUserToDeleteRows = false;

            DataSet ds = UserInfo.getUserInfo();
            dgvUser.DataSource = ds.Tables[0].DefaultView;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if(name == "")
            {
                MessageBox.Show("Enter a name!");
                txtName.Focus();
                return;
            }
            string gender = comGen.Text;
            if(gender == "")
            {
                MessageBox.Show("Enter a gender!");
                return;
            }
            string d_id = (comDepa.SelectedIndex+1).ToString();
            if(d_id == "")
            {
                MessageBox.Show("Enter a department!");
                return;
            }
            string cla = txtClass.Text;
            if(cla == "")
            {
                MessageBox.Show("Enter a class!");
                return;
            }
            string birth = birthDate.Value.ToShortDateString();
            birth = birth.Replace('/', '-'); //convert to the format recognized by mysql

            UserInfo.addStaff(name, gender, d_id, cla, birth);
            refresh();
        }

        private void refresh()
        {
            DataSet ds = UserInfo.getUserInfo();
            dgvUser.DataSource = ds.Tables[0].DefaultView;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string delID = dgvUser.SelectedCells[0].Value.ToString();
            if(delID == "")
            {
                MessageBox.Show("Select One!", "Alert");
                return;
            }
            UserInfo.deleteStaff(delID);
            refresh();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string editID = dgvUser.SelectedCells[0].Value.ToString();
            if (editID == "")
            {
                MessageBox.Show("Select One!", "Alert");
                return;
            }
            string name = txtName.Text;
            if (name == "")
            {
                MessageBox.Show("Enter a name!");
                txtName.Focus();
                return;
            }
            string gender = comGen.Text;
            if (gender == "")
            {
                MessageBox.Show("Enter a gender!");
                return;
            }
            string d_id = (comDepa.SelectedIndex+1).ToString();
            if (d_id == "")
            {
                MessageBox.Show("Enter a department!");
                return;
            }
            string cla = txtClass.Text;
            if (cla == "")
            {
                MessageBox.Show("Enter a class!");
                return;
            }
            string birth = birthDate.Value.ToShortDateString();
            birth = birth.Replace('/', '-'); //convert to the format recognized by mysql

            UserInfo.editStaff(editID, name, gender, d_id, cla, birth);

            refresh();
        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            string type = comSrch.Text;
            string str = txtSrch.Text;
            if(type == "")
            {
                MessageBox.Show("Choose A Method to Search");
                return;
            }
            if(str == "")
            {
                MessageBox.Show("Enter a keyword!");
                txtSrch.Focus();
                return;
            }

            DataSet dset = UserInfo.getDataBySearch(str, type);

            refresh(dset);
        }

        private void refresh(DataSet ds)
        {
            dgvUser.DataSource = ds.Tables[0].DefaultView;
        }

        private void depBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = UserInfo.getDepartmentInfo();
            dgvUser.DataSource = ds.Tables[0].DefaultView;
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
