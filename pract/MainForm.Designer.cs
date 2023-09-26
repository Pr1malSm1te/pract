namespace pract
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteElement = new System.Windows.Forms.Button();
            this.EditElement = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.postsBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.modelsBtn = new System.Windows.Forms.Button();
            this.goodsBtn = new System.Windows.Forms.Button();
            this.supplyBtn = new System.Windows.Forms.Button();
            this.AddElement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.DeleteElement);
            this.splitContainer1.Panel2.Controls.Add(this.EditElement);
            this.splitContainer1.Panel2.Controls.Add(this.logBtn);
            this.splitContainer1.Panel2.Controls.Add(this.postsBtn);
            this.splitContainer1.Panel2.Controls.Add(this.employeeBtn);
            this.splitContainer1.Panel2.Controls.Add(this.modelsBtn);
            this.splitContainer1.Panel2.Controls.Add(this.goodsBtn);
            this.splitContainer1.Panel2.Controls.Add(this.supplyBtn);
            this.splitContainer1.Panel2.Controls.Add(this.AddElement);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1033, 610);
            this.splitContainer1.SplitterDistance = 709;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(16, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(671, 542);
            this.dataGridView1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Таблица \'Null\'";
            // 
            // DeleteElement
            // 
            this.DeleteElement.Location = new System.Drawing.Point(13, 169);
            this.DeleteElement.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteElement.Name = "DeleteElement";
            this.DeleteElement.Size = new System.Drawing.Size(292, 39);
            this.DeleteElement.TabIndex = 18;
            this.DeleteElement.Text = "Удалить элемент";
            this.DeleteElement.UseVisualStyleBackColor = true;
            this.DeleteElement.Click += new System.EventHandler(this.DelEl);
            // 
            // EditElement
            // 
            this.EditElement.Location = new System.Drawing.Point(13, 122);
            this.EditElement.Margin = new System.Windows.Forms.Padding(4);
            this.EditElement.Name = "EditElement";
            this.EditElement.Size = new System.Drawing.Size(292, 39);
            this.EditElement.TabIndex = 17;
            this.EditElement.Text = "Изменить элемент";
            this.EditElement.UseVisualStyleBackColor = true;
            this.EditElement.Click += new System.EventHandler(this.EditEl);
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(13, 496);
            this.logBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(292, 39);
            this.logBtn.TabIndex = 16;
            this.logBtn.Text = "Журнал входа";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.ShowLog);
            // 
            // postsBtn
            // 
            this.postsBtn.Location = new System.Drawing.Point(13, 429);
            this.postsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.postsBtn.Name = "postsBtn";
            this.postsBtn.Size = new System.Drawing.Size(292, 39);
            this.postsBtn.TabIndex = 15;
            this.postsBtn.Text = "Должность";
            this.postsBtn.UseVisualStyleBackColor = true;
            this.postsBtn.Click += new System.EventHandler(this.ShowTable);
            // 
            // employeeBtn
            // 
            this.employeeBtn.Location = new System.Drawing.Point(13, 382);
            this.employeeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(292, 39);
            this.employeeBtn.TabIndex = 14;
            this.employeeBtn.Text = "Сотрудники";
            this.employeeBtn.UseVisualStyleBackColor = true;
            this.employeeBtn.Click += new System.EventHandler(this.ShowTable);
            // 
            // modelsBtn
            // 
            this.modelsBtn.Location = new System.Drawing.Point(13, 289);
            this.modelsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modelsBtn.Name = "modelsBtn";
            this.modelsBtn.Size = new System.Drawing.Size(292, 39);
            this.modelsBtn.TabIndex = 13;
            this.modelsBtn.Text = "Модели";
            this.modelsBtn.UseVisualStyleBackColor = true;
            this.modelsBtn.Click += new System.EventHandler(this.ShowTable);
            // 
            // goodsBtn
            // 
            this.goodsBtn.Location = new System.Drawing.Point(13, 242);
            this.goodsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.goodsBtn.Name = "goodsBtn";
            this.goodsBtn.Size = new System.Drawing.Size(292, 39);
            this.goodsBtn.TabIndex = 12;
            this.goodsBtn.Text = "Товары";
            this.goodsBtn.UseVisualStyleBackColor = true;
            this.goodsBtn.Click += new System.EventHandler(this.ShowTable);
            // 
            // supplyBtn
            // 
            this.supplyBtn.Location = new System.Drawing.Point(13, 335);
            this.supplyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.supplyBtn.Name = "supplyBtn";
            this.supplyBtn.Size = new System.Drawing.Size(292, 39);
            this.supplyBtn.TabIndex = 11;
            this.supplyBtn.Text = "Поставки";
            this.supplyBtn.UseVisualStyleBackColor = true;
            this.supplyBtn.Click += new System.EventHandler(this.ShowTable);
            // 
            // AddElement
            // 
            this.AddElement.Location = new System.Drawing.Point(13, 75);
            this.AddElement.Margin = new System.Windows.Forms.Padding(4);
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(292, 39);
            this.AddElement.TabIndex = 10;
            this.AddElement.Text = "Добавить элемент";
            this.AddElement.UseVisualStyleBackColor = true;
            this.AddElement.Click += new System.EventHandler(this.AddEl);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 543);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "Очистка журнала";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.ClearLog);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 610);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "База данных \"НеЧерт\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteElement;
        private System.Windows.Forms.Button EditElement;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button postsBtn;
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Button modelsBtn;
        private System.Windows.Forms.Button goodsBtn;
        private System.Windows.Forms.Button supplyBtn;
        private System.Windows.Forms.Button AddElement;
        private System.Windows.Forms.Button button1;
    }
}