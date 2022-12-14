using ShoeStore.Controller;
using ShoeStore.Object;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ShoeStore
{
    public partial class Form1 : Form
    {
        EmployeeController employeeCtrler = new EmployeeController();
        private int flagLuu = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable employeeDtb = new DataTable();
            employeeDtb = employeeCtrler.getData();
            dGVEmployee.DataSource = employeeDtb;
            Bindings();
            Block(false);
        }

        void Bindings()
        {
            textID.DataBindings.Clear();
            textID.DataBindings.Add("Text", dGVEmployee.DataSource, "EID");
            textName.DataBindings.Clear();
            textName.DataBindings.Add("Text", dGVEmployee.DataSource, "EmployeeName");
            textUser.DataBindings.Clear();
            textUser.DataBindings.Add("Text", dGVEmployee.DataSource, "EmployeeUser");
            textPass.DataBindings.Clear();
            textPass.DataBindings.Add("Text", dGVEmployee.DataSource, "EmployeePass");
            comboGender.DataBindings.Clear();
            comboGender.DataBindings.Add("Text", dGVEmployee.DataSource, "EmployeeGender");
            textAge.DataBindings.Clear();
            textAge.DataBindings.Add("Text", dGVEmployee.DataSource, "EmployeeAge");
            textPhone.DataBindings.Clear();
            textPhone.DataBindings.Add("Text", dGVEmployee.DataSource, "EmployeePhone");
            textAddress.DataBindings.Clear();
            textAddress.DataBindings.Add("Text", dGVEmployee.DataSource, "EmployeeAddress");
        }

        private void Block(bool e)
        {
            buttonAdd.Enabled = !e;
            buttonDel.Enabled = !e;
            buttonUpdate.Enabled = !e;
            buttonSave.Enabled = e;
            buttonCancel.Enabled = e;
            textID.Enabled = e;
            textName.Enabled = e;
            textUser.Enabled = e;
            textPass.Enabled = e;
            textAge.Enabled = e;
            comboGender.Enabled = e;
            textPhone.Enabled = e;
            textAddress.Enabled = e;
        }

        private void clearText()
        {
            textID.Clear();
            textName.Clear();
            textUser.Clear();
            textPass.Clear();
            textAge.Clear();
            comboGender.SelectedItem = 0;
            textPhone.Clear();
            textAddress.Clear();
        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Form1_Load(sender, e);
            else
                return;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (employeeCtrler.DeleteData(textID.Text.Trim()))
                    MessageBox.Show("Fail!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                else
                    MessageBox.Show("Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form1_Load(sender, e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearText();
            Block(true);
        }

        private void addData(EmployeeObject emp)
        {
            emp.Id = textID.Text.Trim();
            emp.Name = textName.Text.Trim();
            emp.User = textUser.Text.Trim();
            emp.Pass = textPass.Text.Trim();
            emp.Age = Convert.ToInt32(textAge.Text.Trim());
            emp.Gender = comboGender.Text.Trim();
            emp.PhoneNumber = textPhone.Text.Trim();
            emp.Address = textAddress.Text.Trim();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            Block(true);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            EmployeeObject employeeObj = new EmployeeObject();
            addData(employeeObj);
            if (flagLuu == 0)
            {
                if (employeeCtrler.AddData(employeeObj))
                    MessageBox.Show("Fail!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (employeeCtrler.UpdateData(employeeObj))
                    MessageBox.Show("Fail!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form1_Load(sender, e);
        }
    }
}
