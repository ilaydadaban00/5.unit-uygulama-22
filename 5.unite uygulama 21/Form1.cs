﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.unite_uygulama_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVeri_Click(object sender, EventArgs e)
        {
            string[] diller = { "Java" , "python" , "c#" };
            listVeriler.DataSource = diller;
        }
    }
}
