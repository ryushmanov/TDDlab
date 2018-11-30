using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
