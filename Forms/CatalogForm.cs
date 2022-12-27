﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportProducts.Forms;
namespace SportProducts.Forms
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            this.Hide();
            authForm.ShowDialog();
        }

        private void closeLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
