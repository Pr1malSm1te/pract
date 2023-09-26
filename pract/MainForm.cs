using pract.pract2DataSetTableAdapters;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddElement.Enabled = EditElement.Enabled = DeleteElement.Enabled = false;
        }
        string currTable;
        private void ShowTable(object sender, EventArgs e)
        {
            if (sender == goodsBtn)
                currTable = "Goods";
            else if (sender == modelsBtn)
                currTable = "Models";
            else if (sender == supplyBtn)
                currTable = "Supply";
            else if (sender == employeeBtn)
                currTable = "Employees";
            else if (sender == postsBtn)
                currTable = "Posts";

            List<string>[] table = DataBaseController.GetTable(currTable);
            List<string> headers = DataBaseController.GetColumnsNames(currTable);

            dataGridView1.ColumnCount = table.Length;
            dataGridView1.RowCount = table.Last().Count;

            for (int i = 0; i < table.Length; i++)
                dataGridView1.Columns[i].HeaderText = headers[i];
           

            for (int i = 0; i < table.Length; i++)
                for (int j = 0; j < table.Last().Count; j++)
                    dataGridView1.Rows[j].Cells[i].Value = table[i][j];

            label4.Text =  $"Таблица '{currTable}'";
            button1.Hide();
            AddElement.Enabled = EditElement.Enabled = DeleteElement.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void AddEl(object sender, EventArgs e)
        {
            if (currTable == "Goods")
            {
                GoodsElement addform = new GoodsElement();
                addform.ShowDialog();
            }
            else if(currTable == "Models")
            {
                ModelsElement addform = new ModelsElement();
                addform.ShowDialog();
            }
            else if (currTable == "Supply")
            {
                SupplyElement addform = new SupplyElement();
                addform.ShowDialog();
            }
            else if (currTable == "Employees")
            {
                EmployeeElement addform = new EmployeeElement();
                addform.ShowDialog();
            }
            else if (currTable == "Posts")
            {
                PostsElement addform = new PostsElement();
                addform.ShowDialog();
            }
            ShowTable(null, null);
        }

        private void EditEl(object sender, EventArgs e)
        {
            if (currTable == "Goods")
            {
                GoodsElement elementForm = new GoodsElement(
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), 
                    int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                elementForm.ShowDialog();
            }
            else if (currTable == "Models")
            {
                ModelsElement elementForm = new ModelsElement(
                    int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()),
                    int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()));
                elementForm.ShowDialog();
            }
            else if (currTable == "Supply")
            {
                SupplyElement elementForm = new SupplyElement(
                    int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                    int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()),
                    Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()),
                    int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()),
                    int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()),
                    Convert.ToBoolean(int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString())));
                elementForm.ShowDialog();
            }
            else if (currTable == "Employees")
            {
                EmployeeElement elementForm = new EmployeeElement(
                    int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                    int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()),
                    dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                elementForm.ShowDialog();
            }
            else if (currTable == "Posts")
            {
                ModelsElement elementForm = new ModelsElement(
                    int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()),
                    int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()));
                elementForm.ShowDialog();
            }
            ShowTable(null, null);
        }

        private void ShowLog(object sender, EventArgs e)
        {
            object[][] table = DataBaseController.ShowLog();
            string[] headers = new string[]{"Логин", "Дата", "Успешно"};


            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = table.Length;

            for (int i = 0; i < 3; i++)
                dataGridView1.Columns[i].HeaderText = headers[i];


            for (int i = 0; i < table.Length; i++)
                for (int j = 0; j < 3; j++)
                    dataGridView1.Rows[i].Cells[j].Value = table[i][j];

            AddElement.Enabled = EditElement.Enabled = DeleteElement.Enabled = false;

            label4.Text = $"Таблица 'Журнал входа'";

            button1.Show();
        }

        private void DelEl(object sender, EventArgs e)
        {
            DataBaseController.DeleteFromTable(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), currTable);
        }

        private void ClearLog(object sender, EventArgs e)
        {
            DataBaseController.ClearLogs();
        }
    }
}
