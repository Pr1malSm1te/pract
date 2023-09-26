namespace pract
{
    partial class Captcha
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
            this.BoxCaptcha = new System.Windows.Forms.PictureBox();
            this.GenCaptcha = new System.Windows.Forms.Button();
            this.EntCaptcha = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxCaptcha
            // 
            this.BoxCaptcha.Location = new System.Drawing.Point(17, 16);
            this.BoxCaptcha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxCaptcha.Name = "BoxCaptcha";
            this.BoxCaptcha.Size = new System.Drawing.Size(400, 246);
            this.BoxCaptcha.TabIndex = 0;
            this.BoxCaptcha.TabStop = false;
            // 
            // GenCaptcha
            // 
            this.GenCaptcha.Location = new System.Drawing.Point(17, 270);
            this.GenCaptcha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenCaptcha.Name = "GenCaptcha";
            this.GenCaptcha.Size = new System.Drawing.Size(400, 38);
            this.GenCaptcha.TabIndex = 1;
            this.GenCaptcha.Text = "Сгенерировать новое изображение";
            this.GenCaptcha.UseVisualStyleBackColor = true;
            this.GenCaptcha.Click += new System.EventHandler(this.GenImg);
            // 
            // EntCaptcha
            // 
            this.EntCaptcha.Location = new System.Drawing.Point(219, 329);
            this.EntCaptcha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntCaptcha.Name = "EntCaptcha";
            this.EntCaptcha.Size = new System.Drawing.Size(199, 38);
            this.EntCaptcha.TabIndex = 2;
            this.EntCaptcha.Text = "Ввести";
            this.EntCaptcha.UseVisualStyleBackColor = true;
            this.EntCaptcha.Click += new System.EventHandler(this.Check);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(17, 329);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 37);
            this.textBox1.TabIndex = 3;
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 391);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EntCaptcha);
            this.Controls.Add(this.GenCaptcha);
            this.Controls.Add(this.BoxCaptcha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Captcha";
            this.Text = "Captcha";
            this.Load += new System.EventHandler(this.LoadForm);
            ((System.ComponentModel.ISupportInitialize)(this.BoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoxCaptcha;
        private System.Windows.Forms.Button GenCaptcha;
        private System.Windows.Forms.Button EntCaptcha;
        private System.Windows.Forms.TextBox textBox1;
    }
}