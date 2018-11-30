namespace TDDlab
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            this.patherr = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DelButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.passerr = new System.Windows.Forms.Label();
            this.loginerr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // patherr
            // 
            this.patherr.AutoSize = true;
            this.patherr.BackColor = System.Drawing.Color.Transparent;
            this.patherr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patherr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patherr.ForeColor = System.Drawing.Color.Red;
            this.patherr.Location = new System.Drawing.Point(79, 130);
            this.patherr.Name = "patherr";
            this.patherr.Size = new System.Drawing.Size(11, 13);
            this.patherr.TabIndex = 27;
            this.patherr.Text = "!";
            this.patherr.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(145, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Применить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = ".txt";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(76, 127);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(156, 20);
            this.pathTextBox.TabIndex = 24;
            this.pathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Хранить в";
            // 
            // DelButton
            // 
            this.DelButton.Enabled = false;
            this.DelButton.Location = new System.Drawing.Point(185, 58);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 22;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Enabled = false;
            this.LoginButton.Location = new System.Drawing.Point(100, 58);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 21;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // passerr
            // 
            this.passerr.AutoSize = true;
            this.passerr.BackColor = System.Drawing.Color.Transparent;
            this.passerr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passerr.ForeColor = System.Drawing.Color.Red;
            this.passerr.Location = new System.Drawing.Point(246, 35);
            this.passerr.Name = "passerr";
            this.passerr.Size = new System.Drawing.Size(11, 13);
            this.passerr.TabIndex = 20;
            this.passerr.Text = "!";
            this.passerr.Visible = false;
            // 
            // loginerr
            // 
            this.loginerr.AutoSize = true;
            this.loginerr.BackColor = System.Drawing.Color.Transparent;
            this.loginerr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginerr.ForeColor = System.Drawing.Color.Red;
            this.loginerr.Location = new System.Drawing.Point(246, 9);
            this.loginerr.Name = "loginerr";
            this.loginerr.Size = new System.Drawing.Size(11, 13);
            this.loginerr.TabIndex = 19;
            this.loginerr.Text = "!";
            this.loginerr.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логин";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(63, 32);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(197, 20);
            this.pass.TabIndex = 16;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(63, 6);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(197, 20);
            this.login.TabIndex = 15;
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(15, 58);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 185);
            this.Controls.Add(this.patherr);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passerr);
            this.Controls.Add(this.loginerr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.AddButton);
            this.Name = "App";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label patherr;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label passerr;
        private System.Windows.Forms.Label loginerr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox pass;
        public System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

