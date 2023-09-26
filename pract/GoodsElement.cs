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
    public partial class GoodsElement : Form
    {
        public GoodsElement()
        {
            InitializeComponent();
            acceptBtn.Click += new EventHandler(Add);

        }

        public GoodsElement(string _name, int _id)
        {
            InitializeComponent();
            acceptBtn.Click += new EventHandler(Edit);
            textBox1.Text = _name;
            label1.Text.Replace("Добавление", "Изменение");
            acceptBtn.Text = "Изменить";
            id = _id;
        }
        private int id;

        private void Add(object sender, EventArgs e)
        {
            DataBaseController.InsertInGoods(textBox1.Text);
            Close();
        }
        
        private void Edit(object sender, EventArgs e)
        {
            DataBaseController.UpdateGoods(id, textBox1.Text);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
