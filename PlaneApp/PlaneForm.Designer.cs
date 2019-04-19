namespace PlaneApp
{
    partial class PlaneForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.planesListBox = new System.Windows.Forms.ListBox();
            this.CreatePlaneButton = new System.Windows.Forms.Button();
            this.specsTextBox = new System.Windows.Forms.TextBox();
            this.ToFlyPlane = new System.Windows.Forms.Button();
            this.SetRoute = new System.Windows.Forms.Button();
            this.ShowRoute = new System.Windows.Forms.Button();
            this.FullRefuel = new System.Windows.Forms.Button();
            this.Refuel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planesListBox
            // 
            this.planesListBox.FormattingEnabled = true;
            this.planesListBox.ItemHeight = 15;
            this.planesListBox.Location = new System.Drawing.Point(211, 81);
            this.planesListBox.Name = "planesListBox";
            this.planesListBox.Size = new System.Drawing.Size(265, 274);
            this.planesListBox.TabIndex = 0;
            this.planesListBox.SelectedIndexChanged += new System.EventHandler(this.planesListBox_SelectedIndexChanged);
            // 
            // CreatePlaneButton
            // 
            this.CreatePlaneButton.Location = new System.Drawing.Point(25, 24);
            this.CreatePlaneButton.Name = "CreatePlaneButton";
            this.CreatePlaneButton.Size = new System.Drawing.Size(149, 27);
            this.CreatePlaneButton.TabIndex = 1;
            this.CreatePlaneButton.Text = "Добавить самолёт";
            this.CreatePlaneButton.UseVisualStyleBackColor = true;
            this.CreatePlaneButton.Click += new System.EventHandler(this.CreatePlaneButton_Click);
            // 
            // specsTextBox
            // 
            this.specsTextBox.Location = new System.Drawing.Point(534, 81);
            this.specsTextBox.Multiline = true;
            this.specsTextBox.Name = "specsTextBox";
            this.specsTextBox.ReadOnly = true;
            this.specsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.specsTextBox.Size = new System.Drawing.Size(396, 274);
            this.specsTextBox.TabIndex = 2;
            // 
            // ToFlyPlane
            // 
            this.ToFlyPlane.Location = new System.Drawing.Point(643, 24);
            this.ToFlyPlane.Name = "ToFlyPlane";
            this.ToFlyPlane.Size = new System.Drawing.Size(149, 28);
            this.ToFlyPlane.TabIndex = 3;
            this.ToFlyPlane.Text = "Полёт";
            this.ToFlyPlane.UseVisualStyleBackColor = true;
            this.ToFlyPlane.Click += new System.EventHandler(this.ToFlyPlane_Click);
            // 
            // SetRoute
            // 
            this.SetRoute.Location = new System.Drawing.Point(236, 23);
            this.SetRoute.Name = "SetRoute";
            this.SetRoute.Size = new System.Drawing.Size(149, 27);
            this.SetRoute.TabIndex = 4;
            this.SetRoute.Text = "Задать маршрут";
            this.SetRoute.UseVisualStyleBackColor = true;
            this.SetRoute.Click += new System.EventHandler(this.SetRoute_Click);
            // 
            // ShowRoute
            // 
            this.ShowRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowRoute.Location = new System.Drawing.Point(404, 23);
            this.ShowRoute.Name = "ShowRoute";
            this.ShowRoute.Size = new System.Drawing.Size(149, 27);
            this.ShowRoute.TabIndex = 5;
            this.ShowRoute.Text = "Показать маршрут";
            this.ShowRoute.UseVisualStyleBackColor = true;
            this.ShowRoute.Click += new System.EventHandler(this.ShowRoute_Click);
            // 
            // FullRefuel
            // 
            this.FullRefuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullRefuel.Location = new System.Drawing.Point(25, 107);
            this.FullRefuel.Name = "FullRefuel";
            this.FullRefuel.Size = new System.Drawing.Size(149, 27);
            this.FullRefuel.TabIndex = 6;
            this.FullRefuel.Text = "Заправить до конца";
            this.FullRefuel.UseVisualStyleBackColor = true;
            this.FullRefuel.Click += new System.EventHandler(this.FullRefuel_Click);
            // 
            // Refuel
            // 
            this.Refuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refuel.Location = new System.Drawing.Point(25, 140);
            this.Refuel.Name = "Refuel";
            this.Refuel.Size = new System.Drawing.Size(149, 27);
            this.Refuel.TabIndex = 7;
            this.Refuel.Text = "Подзаправить";
            this.Refuel.UseVisualStyleBackColor = true;
            this.Refuel.Click += new System.EventHandler(this.Refuel_Click);
            // 
            // PlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 386);
            this.Controls.Add(this.Refuel);
            this.Controls.Add(this.FullRefuel);
            this.Controls.Add(this.ShowRoute);
            this.Controls.Add(this.SetRoute);
            this.Controls.Add(this.ToFlyPlane);
            this.Controls.Add(this.specsTextBox);
            this.Controls.Add(this.CreatePlaneButton);
            this.Controls.Add(this.planesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "PlaneForm";
            this.Text = "Управление самолётами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox planesListBox;
        private System.Windows.Forms.Button CreatePlaneButton;
        private System.Windows.Forms.TextBox specsTextBox;
        private System.Windows.Forms.Button ToFlyPlane;
        private System.Windows.Forms.Button SetRoute;
        private System.Windows.Forms.Button ShowRoute;
        private System.Windows.Forms.Button FullRefuel;
        private System.Windows.Forms.Button Refuel;
    }
}

