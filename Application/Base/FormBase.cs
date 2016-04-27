using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using SysFood.Application;
using SysFood.Domain;

namespace RestaurantSystem.Base
{
    public partial class FormBase : MetroForm
    {
        public FormBase()
        {
            InitializeComponent();
            Domain.Start();
        }

        private void FormBase_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;

        }
    }
}
