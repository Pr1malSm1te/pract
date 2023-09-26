namespace pract
{
    partial class EmployeeElement
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.postCode = new System.Windows.Forms.ComboBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.PABox = new System.Windows.Forms.TextBox();
            this.AddLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddLayout
            // 
            this.AddLayout.ColumnCount = 2;
            this.AddLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddLayout.Controls.Add(this.label4, 0, 3);
            this.AddLayout.Controls.Add(this.label2, 0, 0);
            this.AddLayout.Controls.Add(this.nameBox, 1, 0);
            this.AddLayout.Controls.Add(this.label3, 0, 4);
            this.AddLayout.Controls.Add(this.label5, 0, 1);
            this.AddLayout.Controls.Add(this.surnameBox, 1, 1);
            this.AddLayout.Controls.Add(this.postCode, 1, 3);
            this.AddLayout.Controls.Add(this.PABox, 1, 4);
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
            this.label4.Text = "Должность";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Расчетный счет";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameBox
            // 
            this.nameBox.AllowDrop = true;
            this.nameBox.Location = new System.Drawing.Point(160, 4);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(220, 22);
            this.nameBox.TabIndex = 0;
            // 
            // postCode
            // 
            this.postCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postCode.FormattingEnabled = true;
            this.postCode.Location = new System.Drawing.Point(159, 65);
            this.postCode.Name = "postCode";
            this.postCode.Size = new System.Drawing.Size(221, 24);
            this.postCode.TabIndex = 3;
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
            this.label1.Text = "Добавление элемента \r\nв таблицу \"Employees\"\r\n";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Имя";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surnameBox
            // 
            this.surnameBox.AllowDrop = true;
            this.surnameBox.Location = new System.Drawing.Point(160, 35);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(220, 22);
            this.surnameBox.TabIndex = 6;
            // 
            // PABox
            // 
            this.PABox.AllowDrop = true;
            this.PABox.Location = new System.Drawing.Point(160, 97);
            this.PABox.Margin = new System.Windows.Forms.Padding(4);
            this.PABox.Name = "PABox";
            this.PABox.Size = new System.Drawing.Size(220, 22);
            this.PABox.TabIndex = 8;
            // 
            // EmployeeElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AddLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeElement";
            this.Text = "Добавление элемента";
            this.AddLayout.ResumeLayout(false);
            this.AddLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddLayout;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox postCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox PABox;
    }
}