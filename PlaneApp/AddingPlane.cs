using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlaneAppLibrary;

namespace PlaneApp
{
    public partial class AddingPlane : Form
    {
        public bool Ready = false;
        public Plane Plane;

        private bool ChangePlane;
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

            ChangePlane = false;
            namesCB.DataSource = new string[] { "Boeing 737-300", "ИЛ-86", "A330", "МС-21" };
        }

        public AddingPlane(Plane Plane)
        {           
            InitializeComponent();

            this.Plane = Plane;
            ChangePlane = true;
            namesCB.DataSource = new string[] { "Boeing 737-300", "ИЛ-86", "A330", "МС-21" };
            namesCB.SelectedIndex = -1;
            namesCB.Text = Plane.GetName();

            enameTB.Text = Plane.Engine.GetName();
            rateTB.Text = Plane.Engine.GetRate().ToString();
            ecountTB.Text = Plane.Engine.GetEnginesCount().ToString();

            curfTB.Text = Plane.Wing.GetFuelLevel().ToString();
            maxfTB.Text = Plane.Wing.GetFuelLevelMax().ToString();

            gcountTB.Text = Plane.Gear.Count.ToString();
            diamTB.Text = Plane.Gear.Diam.ToString();
        }

        private void AcceptB_Click(object sender, EventArgs e)
        {

            if (namesCB.Text != "") planeName = $"{namesCB.Text} ({count})";
            else planeName = $"Безымянный{count}";
            if (enameTB.Text != "") engineName = enameTB.Text;


            try
            {
                eRate = Convert.ToDouble(rateTB.Text);
                if (eRate < 1) { MessageBox.Show("Недопустимое значение расхода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); rateTB.Text = ""; rateTB.Focus(); return; }

                eCount = Convert.ToInt32(ecountTB.Text);
                if (eCount < 1) { MessageBox.Show("Недопустимое значение количества двигателей!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ecountTB.Text = ""; ecountTB.Focus(); return; }

                curFuel = Convert.ToDouble(curfTB.Text);
                if (curFuel < 0) { MessageBox.Show("Недопустимое значение количества топлива!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); curfTB.Text = ""; curfTB.Focus(); return; }

                maxFuel = Convert.ToDouble(maxfTB.Text);
                if (maxFuel < 1) { MessageBox.Show("Недопустимое значение максимального количества топлива!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); maxfTB.Text = ""; maxfTB.Focus(); return; }
                else if(maxFuel < curFuel) { MessageBox.Show("Текущее количество топлива не может превышать максимальное!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                gerCount = Convert.ToInt32(gcountTB.Text);
                if (gerCount < 1) { MessageBox.Show("Недопустимое значение количества шасси!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); gcountTB.Text = ""; gcountTB.Focus(); return; }

                gerDiam = Convert.ToDouble(diamTB.Text);
                if (gerDiam < 1) { MessageBox.Show("Недопустимое значение диаметра шасси!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); diamTB.Text = ""; diamTB.Focus(); return; }

                if (ChangePlane)
                {
                    Plane.SetName(namesCB.Text);

                    Plane.Engine.SetName(enameTB.Text);
                    Plane.Engine.SetRate(eRate);
                    Plane.Engine.SetEnginesCount(eCount);

                    Plane.Wing.SetFuelLevel(curFuel);
                    Plane.Wing.SetFuelLevelMax(maxFuel);

                    Plane.Gear.Count = gerCount;
                    Plane.Gear.Diam = gerDiam;
                }
            }
            catch
            { MessageBox.Show("Недопустимое значение!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); AcceptB.Enabled = false; return; }


            Ready = true;
            Close();
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            Close();
        }


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

        #region Misc

        private void rateTB_TextChanged(object sender, EventArgs e)
        {
            AcceptB.Enabled = true;
        }

        private void ecountTB_TextChanged(object sender, EventArgs e)
        {
            AcceptB.Enabled = true;
        }

        private void curfTB_TextChanged(object sender, EventArgs e)
        {
            AcceptB.Enabled = true;
        }

        private void maxfTB_TextChanged(object sender, EventArgs e)
        {
            AcceptB.Enabled = true;
        }

        private void gcountTB_TextChanged(object sender, EventArgs e)
        {
            AcceptB.Enabled = true;
        }

        private void diamTB_TextChanged(object sender, EventArgs e)
        {
            AcceptB.Enabled = true;
        }

        #endregion

    }
}
