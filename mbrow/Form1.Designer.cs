namespace mbrow
{
    partial class loginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panelpassword = new System.Windows.Forms.Panel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnmasuk = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 382);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Location = new System.Drawing.Point(238, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 35);
            this.panel4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(26, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Silahkan login untuk mengakses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(69, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama toko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(465, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Yu Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtusername.Location = new System.Drawing.Point(350, 131);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(291, 25);
            this.txtusername.TabIndex = 4;
            this.txtusername.Text = "Username...";
            this.txtusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtusername_KeyDown);
            this.txtusername.Leave += new System.EventHandler(this.Txtusername_Leave);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelUsername.Location = new System.Drawing.Point(350, 154);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(291, 3);
            this.panelUsername.TabIndex = 5;
            // 
            // panelpassword
            // 
            this.panelpassword.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelpassword.Location = new System.Drawing.Point(350, 199);
            this.panelpassword.Name = "panelpassword";
            this.panelpassword.Size = new System.Drawing.Size(291, 3);
            this.panelpassword.TabIndex = 7;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Yu Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtpassword.Location = new System.Drawing.Point(350, 176);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(291, 25);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.Text = "Password...";
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtpassword_KeyDown);
            this.txtpassword.Leave += new System.EventHandler(this.Txtpassword_Leave);
            // 
            // btnmasuk
            // 
            this.btnmasuk.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnmasuk.FlatAppearance.BorderSize = 2;
            this.btnmasuk.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnmasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmasuk.Font = new System.Drawing.Font("Yu Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasuk.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnmasuk.Location = new System.Drawing.Point(350, 229);
            this.btnmasuk.Name = "btnmasuk";
            this.btnmasuk.Size = new System.Drawing.Size(291, 34);
            this.btnmasuk.TabIndex = 8;
            this.btnmasuk.Text = "Masuk";
            this.btnmasuk.UseVisualStyleBackColor = true;
            this.btnmasuk.Click += new System.EventHandler(this.Btnmasuk_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Yu Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.LinkColor = System.Drawing.SystemColors.Highlight;
            this.close.Location = new System.Drawing.Point(474, 294);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 17);
            this.close.TabIndex = 9;
            this.close.TabStop = true;
            this.close.Text = "Close";
            this.close.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Close_LinkClicked);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(715, 381);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnmasuk);
            this.Controls.Add(this.panelpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnmasuk;
        private System.Windows.Forms.LinkLabel close;
    }
}

