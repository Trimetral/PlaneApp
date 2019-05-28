using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneApp
{
    public partial class AddFuel : Form
    {
        public bool Ready = false;
        public double Capasity;
        double rate;
        double count;

        public AddFuel(double rate, double count)
        {
            this.rate = rate;
            this.count = count;
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            try
            {
                Capasity = Convert.ToDouble(fuelTB.Text);
                if (Capasity > 0)
                {
                    Ready = true;
                    Close();
                }
                else
                {
                    fuelTB.Text = "";
                    MessageBox.Show("Введите число больше нуля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                fuelTB.Text = "";
                MessageBox.Show("Количество топлива должно быть числом с плавающей точкой!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double route = Convert.ToDouble(routeTB.Text);
                if (route > 0)
                {
                    fuelTB.Text = (route / 900 * rate * count + 0.001).ToString();
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
                MessageBox.Show("Путь должен быть числом с плавающей точкой!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
