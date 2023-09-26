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
    public partial class SupplyElement : Form
    {
        public SupplyElement()
        {
            InitializeComponent();
            acceptBtn.Click += new EventHandler(Add);
            modelCode.Items.AddRange(DataBaseController.GetAllCodes("Models").ToArray());
            employeeCode.Items.AddRange(DataBaseController.GetAllCodes("Employees").ToArray());

        }

        public SupplyElement(int _code, int _modelCode, DateTime _date, int _count, int _employeeCode, bool accepted)
        {
            InitializeComponent();
            acceptBtn.Click += new EventHandler(Edit);
            modelCode.Items.AddRange(DataBaseController.GetAllCodes("Models").ToArray());
            modelCode.SelectedItem = _modelCode;
            employeeCode.Items.AddRange(DataBaseController.GetAllCodes("Employees").ToArray());
            employeeCode.SelectedItem = _modelCode;
            date.Value = _date;
            count.Value = _count;
            checkBox1.Checked = accepted;
            label1.Text.Replace("Добавление", "Изменение");
            acceptBtn.Text = "Изменить";
            code = _code;
        }
        private int code;

        private void Add(object sender, EventArgs e)
        {
            DataBaseController.InsertInSupply(int.Parse(modelCode.Text), date.Value, (int)count.Value, int.Parse(employeeCode.Text), checkBox1.Checked);
            Close();
        }
        
        private void Edit(object sender, EventArgs e)
        {
            DataBaseController.UpdateSupply(code, int.Parse(modelCode.Text), date.Value, (int)count.Value, int.Parse(employeeCode.Text), checkBox1.Checked);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
