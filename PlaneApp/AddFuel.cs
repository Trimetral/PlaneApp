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

        public AddFuel(double rate)
        {
            this.rate = rate;
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            try
            {
                Capasity = Convert.ToDouble(fuelTB.Text);
                Ready = true;
                Close();
            }
            catch
            {
                MessageBox.Show("Количество топлива должно быть числом с плавающей точкой!", "Ошибка!");
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
                    fuelTB.Text = (route / 900 * rate + 0.001).ToString();
                }
                else { MessageBox.Show("Введите число больше 0!", "Ошибка!"); }
            }
            catch
            {
                MessageBox.Show("Путь должен быть числом с плавающей точкой!", "Ошибка!");
            }
        }
    }
}
