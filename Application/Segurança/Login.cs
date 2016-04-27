using RestaurantSystem.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Interfaces;
using SysFood.Application;
using SysFood.Domain;

namespace RestaurantSystem.Segurança
{
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtConnectar_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Usuario().Logar(txtUsuario.Text, txtSenha.Text);
            }
            catch (Exception)
            {

            }

        }
    }
}
