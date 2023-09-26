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
    public partial class ModelsElement : Form
    {
        public ModelsElement()
        {
            InitializeComponent();
            acceptBtn.Click += new EventHandler(Add);
            goodCode.Items.AddRange(DataBaseController.GetAllCodes("Goods").ToArray());
        }

        public ModelsElement(int _code, string _name, int _goodCode, int _price)
        {
            InitializeComponent();
            goodCode.Items.AddRange(DataBaseController.GetAllCodes("Goods").ToArray());
            goodCode.SelectedItem = _goodCode;
            acceptBtn.Click += new EventHandler(Edit);
            nameBox.Text = _name;
            price.Value = _price;
            label1.Text.Replace("Добавление", "Изменение");
            acceptBtn.Text = "Изменить";
            code = _code;
        }
        private int code;

        private void Add(object sender, EventArgs e)
        {
            DataBaseController.InsertInModels(nameBox.Text, int.Parse(goodCode.Text), ((int)price.Value));
            Close();
        }
        
        private void Edit(object sender, EventArgs e)
        {
            DataBaseController.UpdateModels(code, nameBox.Text, int.Parse(goodCode.Text), ((int)price.Value));
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
