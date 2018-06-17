namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monoFlat_Button3 = new MonoFlat.MonoFlat_Button();
            this.button2 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "[Status]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // monoFlat_Button3
            // 
            this.monoFlat_Button3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button3.Image = null;
            this.monoFlat_Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button3.Location = new System.Drawing.Point(64, 82);
            this.monoFlat_Button3.Name = "monoFlat_Button3";
            this.monoFlat_Button3.Size = new System.Drawing.Size(102, 19);
            this.monoFlat_Button3.TabIndex = 7;
            this.monoFlat_Button3.Text = "Exit";
            this.monoFlat_Button3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button3.Click += new System.EventHandler(this.monoFlat_Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.Image = null;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(172, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "Copy";
            this.button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button2.Click += new System.EventHandler(this.monoFlat_Button2_Click);
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(15, 12);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(235, 33);
            this.monoFlat_Button1.TabIndex = 5;
            this.monoFlat_Button1.Text = "Inject";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.Lime;
            this.monoFlat_Label1.Location = new System.Drawing.Point(169, 83);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(92, 15);
            this.monoFlat_Label1.TabIndex = 8;
            this.monoFlat_Label1.Text = "Credits:hepbum";
            this.monoFlat_Label1.Click += new System.EventHandler(this.monoFlat_Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 107);
            this.Controls.Add(this.monoFlat_Label1);
            this.Controls.Add(this.monoFlat_Button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monoFlat_Button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "monoFlat_ThemeContainer1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private MonoFlat.MonoFlat_Button button2;
        private MonoFlat.MonoFlat_Button monoFlat_Button3;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
    }
}

