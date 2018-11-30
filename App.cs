using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TDDlab
{
    public partial class App : Form
    {
        public string[,] loginpass;
        public string[] users;
        public string path;
        public App()
        {
            InitializeComponent();
        }

        public void AddUser(object sender, EventArgs e)
        {
            passerr.Visible = false;
            loginerr.Visible = false;
            bool err = false;
            err = EmptyCheck();
            if (err == false)
            {
                for (int i = 0; i < loginpass.GetLength(0); i++)
                {
                    if (loginpass[i, 0].Equals(login.Text))
                    {
                        err = true;
                        loginerr.Visible = true;
                        toolTip.SetToolTip(loginerr, "Такой логин уже существует");
                        break;
                    }
                }
            }
            if (err == false)
            {
                string s = login.Text + "\t" + PassHash(pass.Text);
                AddLine(s);
                MessageBox.Show("Пользователь успешно добавлен", "Добавление пользователя", MessageBoxButtons.OK);
                GetUsers();
            }
        }

        public bool EmptyCheck()
        {
            bool err = false;
            if (login.Text == "")
            {
                err = true;
                loginerr.Visible = true;
                toolTip.SetToolTip(loginerr, "Введите логин");
            }
            if (pass.Text == "")
            {
                err = true;
                passerr.Visible = true;
                toolTip.SetToolTip(passerr, "Введите пароль");
            }
            return err;
        }

        public string PassHash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));
            return sb.ToString();
        }

        public void AddLine(string s)
        {
            StreamWriter encoded = new StreamWriter(path, true);
            encoded.WriteLine(s);
            encoded.Close();
        }

        public void GetUsers()
        {
            users = File.ReadAllLines(path);
            loginpass = new string[users.Length, 2];
            for (int i = 0; i < users.Length; i++)
            {
                loginpass[i, 0] = users[i].Split('\t')[0];
                loginpass[i, 1] = users[i].Split('\t')[1];
            }
        }
    }
}
