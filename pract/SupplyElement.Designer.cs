namespace pract
{
    partial class SupplyElement
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
            this.AddLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelCode = new System.Windows.Forms.ComboBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.count = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AddLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
            this.SuspendLayout();
            // 
            // AddLayout
            // 
            this.AddLayout.ColumnCount = 2;
            this.AddLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddLayout.Controls.Add(this.label6, 0, 4);
            this.AddLayout.Controls.Add(this.employeeCode, 1, 3);
            this.AddLayout.Controls.Add(this.label2, 0, 1);
            this.AddLayout.Controls.Add(this.label3, 0, 0);
            this.AddLayout.Controls.Add(this.modelCode, 1, 0);
            this.AddLayout.Controls.Add(this.date, 1, 1);
            this.AddLayout.Controls.Add(this.label4, 0, 2);
            this.AddLayout.Controls.Add(this.label5, 0, 3);
            this.AddLayout.Controls.Add(this.count, 1, 2);
            this.AddLayout.Controls.Add(this.checkBox1, 1, 4);
            this.AddLayout.Location = new System.Drawing.Point(16, 92);
            this.AddLayout.Margin = new System.Windows.Forms.Padding(4);
            this.AddLayout.Name = "AddLayout";
            this.AddLayout.RowCount = 5;
            this.AddLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AddLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AddLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AddLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AddLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AddLayout.Size = new System.Drawing.Size(384, 256);
            this.AddLayout.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кол-во";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Код модели";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelCode
            // 
            this.modelCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelCode.FormattingEnabled = true;
            this.modelCode.Location = new System.Drawing.Point(159, 3);
            this.modelCode.Name = "modelCode";
            this.modelCode.Size = new System.Drawing.Size(221, 24);
            this.modelCode.TabIndex = 3;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(4, 4);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(380, 47);
            this.acceptBtn.TabIndex = 1;
            this.acceptBtn.Text = "Добавить";
            this.acceptBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cancelBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.acceptBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 356);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 94);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(4, 59);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(380, 31);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавление элемента \r\nв таблицу \"Supply\"\r\n";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(159, 34);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(221, 22);
            this.date.TabIndex = 4;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(159, 65);
            this.count.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(221, 22);
            this.count.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сотрудник";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeCode
            // 
            this.employeeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeCode.FormattingEnabled = true;
            this.employeeCode.Location = new System.Drawing.Point(159, 96);
            this.employeeCode.Name = "employeeCode";
            this.employeeCode.Size = new System.Drawing.Size(221, 24);
            this.employeeCode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Принято";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(159, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SupplyElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AddLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplyElement";
            this.Text = "Добавление элемента";
            this.AddLayout.ResumeLayout(false);
            this.AddLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddLayout;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox modelCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox employeeCode;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}