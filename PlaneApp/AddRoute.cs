using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneAppLibrary
{
    public partial class AddRoute : Form
    {
        public bool Ready = false;
        public double route = 0;

        public AddRoute()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            try
            {
                route = Convert.ToDouble(routeTB.Text);
                if (route > 0)
                {
                    Ready = true;
                    Close();
                }
                else
                {
                    routeTB.Text = "";
                    MessageBox.Show("Введите число больше нуля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                routeTB.Text = "";
                MessageBox.Show("Длина пути должна быть числом с плавающей точкой", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
