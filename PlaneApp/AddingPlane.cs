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
    public partial class AddingPlane : Form
    {
        public bool Ready = false;
        private int count;

        public string planeName = "Безымянный";

        public string engineName = "CFMI CFM56-3B1/3B2";
        public double eRate = 2600;
        public int eCount = 2;

        public double curFuel = 0;
        public double maxFuel = 23830;

        public int gerCount = 3;
        public double gerDiam = 400;


        public AddingPlane(int count)
        {
            this.count = ++count;
            InitializeComponent();

            namesCB.DataSource = new string[] { "Boeing 737-300", "ИЛ-86", "A330", "МС-21" };
        }

        private void AcceptB_Click(object sender, EventArgs e)
        {
            Ready = true;

            if (namesCB.Text != "") planeName = $"{namesCB.Text} ({count})";
            else planeName = $"Безымянный{count}";
            if (enameTB.Text != "") engineName = enameTB.Text;

            eRate = Convert.ToDouble(rateTB.Text);
            eCount = Convert.ToInt32(ecountTB.Text);
            curFuel = Convert.ToDouble(curfTB.Text);
            maxFuel = Convert.ToDouble(maxfTB.Text);
            gerCount = Convert.ToInt32(gcountTB.Text);
            gerDiam = Convert.ToDouble(diamTB.Text);

            Close();
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Проверки на правильность заполненных данных

        private void rateTB_Leave(object sender, EventArgs e)
        {
            if (rateTB.Text != "")
                try { Convert.ToDouble(rateTB.Text); }
                catch { MessageBox.Show("Номорасход должен быть числом с плавающей точкой!"); rateTB.Text = ""; }
        }


        private void ecountTB_Leave(object sender, EventArgs e)
        {
            if (ecountTB.Text != "")
                try { Convert.ToInt32(ecountTB.Text); }
                catch { MessageBox.Show("Номорасход должен быть целым числом!"); ecountTB.Text = ""; }
        }

        private void curfTB_Leave(object sender, EventArgs e)
        {
            if (curfTB.Text != "")
                try { Convert.ToDouble(curfTB.Text); }
                catch { MessageBox.Show("Номорасход должен быть числом с плавающей точкой!"); curfTB.Text = ""; }
        }

        private void maxfTB_Leave(object sender, EventArgs e)
        {
            if (maxfTB.Text != "")
                try { Convert.ToDouble(maxfTB.Text); }
                catch { MessageBox.Show("Номорасход должен быть числом с плавающей точкой!"); maxfTB.Text = ""; }
        }

        private void gcountTB_Leave(object sender, EventArgs e)
        {
            if (gcountTB.Text != "")
                try { Convert.ToInt32(gcountTB.Text); }
                catch { MessageBox.Show("Номорасход должен быть целым числом!"); gcountTB.Text = ""; }
        }

        private void diamTB_Leave(object sender, EventArgs e)
        {
            if (diamTB.Text != "")
                try { Convert.ToDouble(diamTB.Text); }
                catch { MessageBox.Show("Номорасход должен быть числом с плавающей точкой!"); diamTB.Text = ""; }
        }


        #endregion

        private void namesCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(namesCB.SelectedIndex == 0)
            {
                planeName = "Boeing 737-300";
                maxfTB.Text = "23830";
                enameTB.Text = "CFMI CFM56-3B1/3B2";
                ecountTB.Text = "2";
                rateTB.Text = "2600";
            }
            else if(namesCB.SelectedIndex == 1)
            {
                planeName = "ИЛ-86";
                maxfTB.Text = "88000";
                enameTB.Text = "НК-8";
                ecountTB.Text = "4";
                rateTB.Text = "4700";
            }
            else if(namesCB.SelectedIndex == 2)
            {
                planeName = "A330";
                maxfTB.Text = "116000";
                enameTB.Text = "R-R Trent 7000";
                ecountTB.Text = "2";
                rateTB.Text = "5100";
            }
            else if (namesCB.SelectedIndex == 3)
            {
                planeName = "МС-21";
                maxfTB.Text = "20400";
                enameTB.Text = "ПД-14А";
                ecountTB.Text = "2";
                rateTB.Text = "3100";
            }
        }
    }
}
