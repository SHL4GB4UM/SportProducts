using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportProducts.Forms;
using SportProducts.DataBase;
using SportProducts.Properties;
namespace SportProducts
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            var currentUser = TradeEntities.GetContext().User;
            var logintxt = loginBox.Text;
            var passtxt = passwordBox.Text;
            var auth = currentUser.Where(p => p.UserLogin == logintxt && p.UserPassword == passtxt).FirstOrDefault();
                
                
        if (auth!=null)
            {
                MessageBox.Show("Вы успешно вошли в систему", "Вход");
                CatalogForm catalogForm = new CatalogForm();
                this.Hide();
                catalogForm.ShowDialog();
            }


            else MessageBox.Show("Введены неверные данные", "Ошибка");
        }

        private void guestLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            this.Hide();
            catalogForm.ShowDialog();
        }

        private void closeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
