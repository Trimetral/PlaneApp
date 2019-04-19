namespace PlaneApp
{
    partial class AddFuel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fuelTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.routeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fuelTB
            // 
            this.fuelTB.Location = new System.Drawing.Point(147, 13);
            this.fuelTB.Name = "fuelTB";
            this.fuelTB.Size = new System.Drawing.Size(184, 20);
            this.fuelTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество толива (кг)";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(255, 89);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(156, 89);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 4;
            this.Accept.Text = "Принять";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // routeTB
            // 
            this.routeTB.Location = new System.Drawing.Point(146, 49);
            this.routeTB.Name = "routeTB";
            this.routeTB.Size = new System.Drawing.Size(184, 20);
            this.routeTB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Длина пути (км)";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 80);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(104, 41);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Рассчитать по длине пути";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // AddFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 132);
            this.ControlBox = false;
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.routeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fuelTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Name = "AddFuel";
            this.ShowIcon = false;
            this.Text = "Дозаправить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fuelTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.TextBox routeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calculate;
    }
}