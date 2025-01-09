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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public int W
        {
            get
            {
                string text = tbWidth.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }
        public int H
        {
            get
            {
                string text = tbHeight.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }
        public string FileName
        {
            get
            {
                string value = tbFileName.Text;
                return value;
            }
        }
        bool _canceled = false;
        public bool Canceled
        {
            get { return _canceled; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            _canceled = true;
        }
    }
}
