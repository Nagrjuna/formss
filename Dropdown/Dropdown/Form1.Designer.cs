namespace Dropdown
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1_Name = new System.Windows.Forms.Label();
            this.label2_Age = new System.Windows.Forms.Label();
            this.label3_Address = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(546, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1_Name
            // 
            this.label1_Name.AutoSize = true;
            this.label1_Name.Location = new System.Drawing.Point(23, 32);
            this.label1_Name.Name = "label1_Name";
            this.label1_Name.Size = new System.Drawing.Size(35, 13);
            this.label1_Name.TabIndex = 1;
            this.label1_Name.Text = "Name";
            // 
            // label2_Age
            // 
            this.label2_Age.AutoSize = true;
            this.label2_Age.Location = new System.Drawing.Point(23, 65);
            this.label2_Age.Name = "label2_Age";
            this.label2_Age.Size = new System.Drawing.Size(26, 13);
            this.label2_Age.TabIndex = 2;
            this.label2_Age.Text = "Age";
            // 
            // label3_Address
            // 
            this.label3_Address.AutoSize = true;
            this.label3_Address.Location = new System.Drawing.Point(23, 100);
            this.label3_Address.Name = "label3_Address";
            this.label3_Address.Size = new System.Drawing.Size(45, 13);
            this.label3_Address.TabIndex = 3;
            this.label3_Address.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // button1_save
            // 
            this.button1_save.Location = new System.Drawing.Point(26, 153);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(75, 23);
            this.button1_save.TabIndex = 7;
            this.button1_save.Text = "save";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 261);
            this.Controls.Add(this.button1_save);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3_Address);
            this.Controls.Add(this.label2_Age);
            this.Controls.Add(this.label1_Name);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1_Name;
        private System.Windows.Forms.Label label2_Age;
        private System.Windows.Forms.Label label3_Address;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1_save;
    }
}

