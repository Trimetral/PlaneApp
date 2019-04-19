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
            this.button1 = new System.Windows.Forms.Button();
            this.specsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // planesListBox
            // 
            this.planesListBox.FormattingEnabled = true;
            this.planesListBox.Location = new System.Drawing.Point(38, 95);
            this.planesListBox.Name = "planesListBox";
            this.planesListBox.Size = new System.Drawing.Size(348, 355);
            this.planesListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить самолёт";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // specsListBox
            // 
            this.specsListBox.FormattingEnabled = true;
            this.specsListBox.Location = new System.Drawing.Point(430, 95);
            this.specsListBox.Name = "specsListBox";
            this.specsListBox.Size = new System.Drawing.Size(348, 355);
            this.specsListBox.TabIndex = 2;
            // 
            // PlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 585);
            this.Controls.Add(this.specsListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.planesListBox);
            this.Name = "PlaneForm";
            this.Text = "Управление самолётами";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox planesListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox specsListBox;
    }
}

