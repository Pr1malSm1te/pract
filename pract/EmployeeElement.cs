using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract
{
    public partial class EmployeeElement : Form
    {
        public EmployeeElement()
        {
            InitializeComponent();
            acceptBtn.Click += new EventHandler(Add);
            postCode.Items.AddRange(DataBaseController.GetAllCodes("Posts").ToArray());
        }

        public EmployeeElement(int _code, string _name, string _surname, int _postCode, string _PA)
        {
            InitializeComponent();
            postCode.Items.AddRange(DataBaseController.GetAllCodes("Posts").ToArray());
            postCode.SelectedItem = _postCode;
            acceptBtn.Click += new EventHandler(Edit);
            nameBox.Text = _name;
            surnameBox.Text = _surname;
            PABox.Text = _PA;
            label1.Text.Replace("Добавление", "Изменение");
            acceptBtn.Text = "Изменить";
            code = _code;
        }
        private int code;

        private void Add(object sender, EventArgs e)
        {
            DataBaseController.InsertInEmployees(nameBox.Text, surnameBox.Text, int.Parse(postCode.Text), PABox.Text);
            Close();
        }
        
        private void Edit(object sender, EventArgs e)
        {
            DataBaseController.UpdateEmployees(code, nameBox.Text, surnameBox.Text, int.Parse(postCode.Text), PABox.Text);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
