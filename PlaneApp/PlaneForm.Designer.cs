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
            this.components = new System.ComponentModel.Container();
            this.planesListBox = new System.Windows.Forms.ListBox();
            this.specsTextBox = new System.Windows.Forms.TextBox();
            this.ToFlyPlane = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьСамолётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьМаршрутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьМаршрутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.топливоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заправитьДоКонцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заправитьНаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.своёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСамолётToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСамолётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // planesListBox
            // 
            this.planesListBox.FormattingEnabled = true;
            this.planesListBox.ItemHeight = 15;
            this.planesListBox.Location = new System.Drawing.Point(12, 37);
            this.planesListBox.Name = "planesListBox";
            this.planesListBox.Size = new System.Drawing.Size(265, 274);
            this.planesListBox.TabIndex = 0;
            this.planesListBox.SelectedIndexChanged += new System.EventHandler(this.planesListBox_SelectedIndexChanged);
            // 
            // specsTextBox
            // 
            this.specsTextBox.Location = new System.Drawing.Point(283, 37);
            this.specsTextBox.Multiline = true;
            this.specsTextBox.Name = "specsTextBox";
            this.specsTextBox.ReadOnly = true;
            this.specsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.specsTextBox.Size = new System.Drawing.Size(396, 274);
            this.specsTextBox.TabIndex = 2;
            // 
            // ToFlyPlane
            // 
            this.ToFlyPlane.Location = new System.Drawing.Point(516, 317);
            this.ToFlyPlane.Name = "ToFlyPlane";
            this.ToFlyPlane.Size = new System.Drawing.Size(163, 38);
            this.ToFlyPlane.TabIndex = 3;
            this.ToFlyPlane.Text = "Полёт";
            this.ToFlyPlane.UseVisualStyleBackColor = true;
            this.ToFlyPlane.Click += new System.EventHandler(this.ToFlyPlane_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСамолётToolStripMenuItem,
            this.маршрутToolStripMenuItem,
            this.топливоToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьСамолётToolStripMenuItem
            // 
            this.добавитьСамолётToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСамолётToolStripMenuItem1,
            this.изменитьСамолётToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.добавитьСамолётToolStripMenuItem.Name = "добавитьСамолётToolStripMenuItem";
            this.добавитьСамолётToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.добавитьСамолётToolStripMenuItem.Text = "Самолёты";
            // 
            // маршрутToolStripMenuItem
            // 
            this.маршрутToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьМаршрутToolStripMenuItem,
            this.показатьМаршрутToolStripMenuItem});
            this.маршрутToolStripMenuItem.Name = "маршрутToolStripMenuItem";
            this.маршрутToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.маршрутToolStripMenuItem.Text = "Маршрут";
            // 
            // задатьМаршрутToolStripMenuItem
            // 
            this.задатьМаршрутToolStripMenuItem.Name = "задатьМаршрутToolStripMenuItem";
            this.задатьМаршрутToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.задатьМаршрутToolStripMenuItem.Text = "Задать маршрут";
            this.задатьМаршрутToolStripMenuItem.Click += new System.EventHandler(this.задатьМаршрутToolStripMenuItem_Click);
            // 
            // показатьМаршрутToolStripMenuItem
            // 
            this.показатьМаршрутToolStripMenuItem.Name = "показатьМаршрутToolStripMenuItem";
            this.показатьМаршрутToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.показатьМаршрутToolStripMenuItem.Text = "Показать маршрут";
            this.показатьМаршрутToolStripMenuItem.Click += new System.EventHandler(this.показатьМаршрутToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // топливоToolStripMenuItem
            // 
            this.топливоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заправитьДоКонцаToolStripMenuItem,
            this.заправитьНаToolStripMenuItem});
            this.топливоToolStripMenuItem.Name = "топливоToolStripMenuItem";
            this.топливоToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.топливоToolStripMenuItem.Text = "Топливо";
            // 
            // заправитьДоКонцаToolStripMenuItem
            // 
            this.заправитьДоКонцаToolStripMenuItem.Name = "заправитьДоКонцаToolStripMenuItem";
            this.заправитьДоКонцаToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.заправитьДоКонцаToolStripMenuItem.Text = "Заправить до конца";
            this.заправитьДоКонцаToolStripMenuItem.Click += new System.EventHandler(this.заправитьДоКонцаToolStripMenuItem_Click);
            // 
            // заправитьНаToolStripMenuItem
            // 
            this.заправитьНаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тToolStripMenuItem,
            this.тToolStripMenuItem1,
            this.своёToolStripMenuItem});
            this.заправитьНаToolStripMenuItem.Name = "заправитьНаToolStripMenuItem";
            this.заправитьНаToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.заправитьНаToolStripMenuItem.Text = "Заправить на...";
            // 
            // тToolStripMenuItem
            // 
            this.тToolStripMenuItem.Name = "тToolStripMenuItem";
            this.тToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тToolStripMenuItem.Text = "1 т";
            this.тToolStripMenuItem.Click += new System.EventHandler(this.тToolStripMenuItem_Click);
            // 
            // тToolStripMenuItem1
            // 
            this.тToolStripMenuItem1.Name = "тToolStripMenuItem1";
            this.тToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.тToolStripMenuItem1.Text = "5 т";
            this.тToolStripMenuItem1.Click += new System.EventHandler(this.тToolStripMenuItem1_Click);
            // 
            // своёToolStripMenuItem
            // 
            this.своёToolStripMenuItem.Name = "своёToolStripMenuItem";
            this.своёToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.своёToolStripMenuItem.Text = "Другое";
            this.своёToolStripMenuItem.Click += new System.EventHandler(this.своёToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // добавитьСамолётToolStripMenuItem1
            // 
            this.добавитьСамолётToolStripMenuItem1.Name = "добавитьСамолётToolStripMenuItem1";
            this.добавитьСамолётToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.добавитьСамолётToolStripMenuItem1.Text = "Добавить самолёт";
            this.добавитьСамолётToolStripMenuItem1.Click += new System.EventHandler(this.добавитьСамолётToolStripMenuItem1_Click);
            // 
            // изменитьСамолётToolStripMenuItem
            // 
            this.изменитьСамолётToolStripMenuItem.Name = "изменитьСамолётToolStripMenuItem";
            this.изменитьСамолётToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьСамолётToolStripMenuItem.Text = "Изменить самолёт";
            this.изменитьСамолётToolStripMenuItem.Click += new System.EventHandler(this.изменитьСамолётToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // PlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 367);
            this.Controls.Add(this.ToFlyPlane);
            this.Controls.Add(this.specsTextBox);
            this.Controls.Add(this.planesListBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PlaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление самолётами";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox planesListBox;
        private System.Windows.Forms.TextBox specsTextBox;
        private System.Windows.Forms.Button ToFlyPlane;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСамолётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьМаршрутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьМаршрутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem топливоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заправитьДоКонцаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заправитьНаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem своёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСамолётToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьСамолётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

