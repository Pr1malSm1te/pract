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
    public partial class PostsElement : Form
    {
        public PostsElement()
        {
            InitializeComponent();
            acceptBtn.Click += new EventHandler(Add);
        }

        public PostsElement(int _code, string _name, int _salary, int _overcharge)
        {
            InitializeComponent();
            acceptBtn.Click += new EventHandler(Edit);
            nameBox.Text = _name;
            overcharge.Value = _overcharge;
            salary.Value = _salary;
            label1.Text.Replace("Добавление", "Изменение");
            acceptBtn.Text = "Изменить";
            code = _code;
        }
        private int code;

        private void Add(object sender, EventArgs e)
        {
            DataBaseController.InsertInPosts(nameBox.Text, ((int)salary.Value), ((int)overcharge.Value));
            Close();
        }
        
        private void Edit(object sender, EventArgs e)
        {
            DataBaseController.UpdatePosts(code, nameBox.Text, ((int)salary.Value), ((int)overcharge.Value));
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
