using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maks_pr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_click(object sender, EventArgs e)
        {
            string username = tbName.Text.Trim();
            if (username.Length < 3)
            {
                MessageBox.Show("Введите имя пользователя");
            }
            else
            {
                MessageBox.Show($"Привет {username}");
            }
        }

        private void btnExit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
