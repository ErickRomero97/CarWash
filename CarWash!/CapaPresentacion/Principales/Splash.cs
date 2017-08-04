using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Principales
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        int n = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n == 0)
            {
                lblInitial.Text = ("Initializing.");
            }
            else if (n == 1)
            {
                lblInitial.Text = ("Initializing..");
            }
            else if (n == 2)
            {
                lblInitial.Text = ("Initializing...");
            }
            else if (n == 3)
            {
                lblInitial.Text = ("Initializing.");
            }
            else if (n == 4)
            {
                lblInitial.Text = ("Initializing..");
            }
            else if (n == 5)
            {
                lblInitial.Text = ("Initializing...");
            }
            else if (n == 6)
            {
                lblInitial.Text = ("Initializing.");
            }
            else if (n == 7)
            {
                lblInitial.Text = ("Initializing..");
            }
            else if (n == 8)
            {
                lblInitial.Text = ("Initializing...");
                timer1.Interval = 1000;
            }
            else if (n == 9)
            {
                lblInitial.Text = ("C:/Program Files/IIS Express/AppServer/root/ServerFile_Connection");
            }
            else if (n == 10)
            {
                lblInitial.Text = ("C:/Program Files/IIS Express/AppServer/root/Server_CarWashSystem");
            }
            else if (n == 11)
            {
                lblInitial.Text = ("C:/CarWashSystem_Database/Connection-successfully");
                timer1.Interval = 500;
            }
            else if (n == 12)
            {
                lblInitial.Text = ("C:/CarWashSystem/Program/Download.File/Starter");
            }
            else if (n == 13)
            {
                lblInitial.Text = ("C:/CarWashSystem/Program/Download.File/Runnig");
            }
            else if (n == 14)
            {
                lblInitial.Text = ("C:/Enable/cmd/CarWashSystem.exe");
            }
            else if (n == 15)
            {
                lblInitial.Text = ("C:/Load:File/Interfaces./Login");
            }
            else if (n == 16)
            {
                lblInitial.Text = ("C:/Load:File/Interfaces./Login");
            }
            else if (n == 17)
            {
                lblInitial.Text = ("Load Complete. Open Program");
            }
            else if (n == 18)
            {
                FrmLogin s = new FrmLogin();
                s.Show();
                Hide();
            }

            n += 1;
        }
    }
}
