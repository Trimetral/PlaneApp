namespace PlaneApp
{
    partial class AddingPlane
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
            this.enameTB = new System.Windows.Forms.TextBox();
            this.rateTB = new System.Windows.Forms.TextBox();
            this.ecountTB = new System.Windows.Forms.TextBox();
            this.curfTB = new System.Windows.Forms.TextBox();
            this.maxfTB = new System.Windows.Forms.TextBox();
            this.diamTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gcountTB = new System.Windows.Forms.TextBox();
            this.AcceptB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.namesCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // enameTB
            // 
            this.enameTB.Location = new System.Drawing.Point(166, 103);
            this.enameTB.Margin = new System.Windows.Forms.Padding(4);
            this.enameTB.Multiline = true;
            this.enameTB.Name = "enameTB";
            this.enameTB.Size = new System.Drawing.Size(139, 37);
            this.enameTB.TabIndex = 1;
            this.enameTB.Text = "CFMI CFM56-3B1/3B2";
            // 
            // rateTB
            // 
            this.rateTB.Location = new System.Drawing.Point(166, 148);
            this.rateTB.Margin = new System.Windows.Forms.Padding(4);
            this.rateTB.Name = "rateTB";
            this.rateTB.Size = new System.Drawing.Size(139, 21);
            this.rateTB.TabIndex = 2;
            this.rateTB.Text = "2600";
            this.rateTB.TextChanged += new System.EventHandler(this.rateTB_TextChanged);
            // 
            // ecountTB
            // 
            this.ecountTB.Location = new System.Drawing.Point(166, 178);
            this.ecountTB.Margin = new System.Windows.Forms.Padding(4);
            this.ecountTB.Name = "ecountTB";
            this.ecountTB.Size = new System.Drawing.Size(139, 21);
            this.ecountTB.TabIndex = 3;
            this.ecountTB.Text = "2";
            this.ecountTB.TextChanged += new System.EventHandler(this.ecountTB_TextChanged);
            // 
            // curfTB
            // 
            this.curfTB.Location = new System.Drawing.Point(563, 103);
            this.curfTB.Margin = new System.Windows.Forms.Padding(4);
            this.curfTB.Name = "curfTB";
            this.curfTB.Size = new System.Drawing.Size(56, 21);
            this.curfTB.TabIndex = 4;
            this.curfTB.Text = "0";
            this.curfTB.TextChanged += new System.EventHandler(this.curfTB_TextChanged);
            // 
            // maxfTB
            // 
            this.maxfTB.Location = new System.Drawing.Point(563, 133);
            this.maxfTB.Margin = new System.Windows.Forms.Padding(4);
            this.maxfTB.Name = "maxfTB";
            this.maxfTB.Size = new System.Drawing.Size(56, 21);
            this.maxfTB.TabIndex = 5;
            this.maxfTB.Text = "23830";
            this.maxfTB.TextChanged += new System.EventHandler(this.maxfTB_TextChanged);
            // 
            // diamTB
            // 
            this.diamTB.Location = new System.Drawing.Point(169, 285);
            this.diamTB.Margin = new System.Windows.Forms.Padding(4);
            this.diamTB.Name = "diamTB";
            this.diamTB.Size = new System.Drawing.Size(139, 21);
            this.diamTB.TabIndex = 7;
            this.diamTB.Text = "400";
            this.diamTB.TextChanged += new System.EventHandler(this.diamTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название самолёта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Норморасход";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество двигателей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Крылья";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Текущее количество топлива";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Максимальное количество топлива";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Шасси";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Двигатель";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Количество стоек";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 288);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Диаметр";
            // 
            // gcountTB
            // 
            this.gcountTB.Location = new System.Drawing.Point(169, 255);
            this.gcountTB.Margin = new System.Windows.Forms.Padding(4);
            this.gcountTB.Name = "gcountTB";
            this.gcountTB.Size = new System.Drawing.Size(139, 21);
            this.gcountTB.TabIndex = 6;
            this.gcountTB.Text = "3";
            this.gcountTB.TextChanged += new System.EventHandler(this.gcountTB_TextChanged);
            // 
            // AcceptB
            // 
            this.AcceptB.Location = new System.Drawing.Point(360, 280);
            this.AcceptB.Margin = new System.Windows.Forms.Padding(4);
            this.AcceptB.Name = "AcceptB";
            this.AcceptB.Size = new System.Drawing.Size(111, 26);
            this.AcceptB.TabIndex = 20;
            this.AcceptB.Text = "Принять";
            this.AcceptB.UseVisualStyleBackColor = true;
            this.AcceptB.Click += new System.EventHandler(this.AcceptB_Click);
            // 
            // CancelB
            // 
            this.CancelB.Location = new System.Drawing.Point(496, 280);
            this.CancelB.Margin = new System.Windows.Forms.Padding(4);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(109, 26);
            this.CancelB.TabIndex = 21;
            this.CancelB.Text = "Отмена";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // namesCB
            // 
            this.namesCB.FormattingEnabled = true;
            this.namesCB.Location = new System.Drawing.Point(175, 25);
            this.namesCB.Name = "namesCB";
            this.namesCB.Size = new System.Drawing.Size(431, 23);
            this.namesCB.TabIndex = 22;
            this.namesCB.SelectionChangeCommitted += new System.EventHandler(this.namesCB_SelectionChangeCommitted);
            // 
            // AddingPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 321);
            this.ControlBox = false;
            this.Controls.Add(this.namesCB);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.AcceptB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diamTB);
            this.Controls.Add(this.gcountTB);
            this.Controls.Add(this.maxfTB);
            this.Controls.Add(this.curfTB);
            this.Controls.Add(this.ecountTB);
            this.Controls.Add(this.rateTB);
            this.Controls.Add(this.enameTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddingPlane";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление самолёта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox enameTB;
        private System.Windows.Forms.TextBox rateTB;
        private System.Windows.Forms.TextBox ecountTB;
        private System.Windows.Forms.TextBox curfTB;
        private System.Windows.Forms.TextBox maxfTB;
        private System.Windows.Forms.TextBox diamTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox gcountTB;
        private System.Windows.Forms.Button AcceptB;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.ComboBox namesCB;
    }
}