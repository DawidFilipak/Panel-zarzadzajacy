namespace Panel_zarządzający
{
    partial class Logowanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.butt_zaloguj = new System.Windows.Forms.Button();
            this.butt_wyczysc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.butt_rejestracja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(94, 67);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // butt_zaloguj
            // 
            this.butt_zaloguj.Location = new System.Drawing.Point(152, 120);
            this.butt_zaloguj.Name = "butt_zaloguj";
            this.butt_zaloguj.Size = new System.Drawing.Size(75, 23);
            this.butt_zaloguj.TabIndex = 4;
            this.butt_zaloguj.Text = "Zaloguj";
            this.butt_zaloguj.UseVisualStyleBackColor = true;
            this.butt_zaloguj.Click += new System.EventHandler(this.butt_zaloguj_Click);
            // 
            // butt_wyczysc
            // 
            this.butt_wyczysc.Location = new System.Drawing.Point(55, 120);
            this.butt_wyczysc.Name = "butt_wyczysc";
            this.butt_wyczysc.Size = new System.Drawing.Size(75, 23);
            this.butt_wyczysc.TabIndex = 5;
            this.butt_wyczysc.Text = "Wyczyśc";
            this.butt_wyczysc.UseVisualStyleBackColor = true;
            this.butt_wyczysc.Click += new System.EventHandler(this.butt_wyczysc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(97, 31);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 2;
            // 
            // butt_rejestracja
            // 
            this.butt_rejestracja.Location = new System.Drawing.Point(55, 160);
            this.butt_rejestracja.Name = "butt_rejestracja";
            this.butt_rejestracja.Size = new System.Drawing.Size(75, 23);
            this.butt_rejestracja.TabIndex = 6;
            this.butt_rejestracja.Text = "Rejestracja";
            this.butt_rejestracja.UseVisualStyleBackColor = true;
            this.butt_rejestracja.Click += new System.EventHandler(this.butt_rejestracja_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.butt_rejestracja);
            this.Controls.Add(this.butt_wyczysc);
            this.Controls.Add(this.butt_zaloguj);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button butt_zaloguj;
        private System.Windows.Forms.Button butt_wyczysc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button butt_rejestracja;
    }
}

