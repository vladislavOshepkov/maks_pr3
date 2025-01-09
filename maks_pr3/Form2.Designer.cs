namespace maks_pr3
{
    partial class paint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFigure_backSlash = new System.Windows.Forms.Button();
            this.btnFigure_slash = new System.Windows.Forms.Button();
            this.btnFigure_rectangle = new System.Windows.Forms.Button();
            this.btnFigure_circle = new System.Windows.Forms.Button();
            this.btnFigure_square = new System.Windows.Forms.Button();
            this.trbBrushSize = new System.Windows.Forms.TrackBar();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrushSize)).BeginInit();
            this.drawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem3.Text = "Создать";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem4.Text = "Сохранить";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem5.Text = "Открыть";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem6.Text = "Выход";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem2.Text = "Справка";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem7.Text = "О программе";
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolsPanel.Controls.Add(this.groupBox1);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.Location = new System.Drawing.Point(0, 24);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(206, 426);
            this.toolsPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFigure_backSlash);
            this.groupBox1.Controls.Add(this.btnFigure_slash);
            this.groupBox1.Controls.Add(this.btnFigure_rectangle);
            this.groupBox1.Controls.Add(this.btnFigure_circle);
            this.groupBox1.Controls.Add(this.btnFigure_square);
            this.groupBox1.Controls.Add(this.trbBrushSize);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор кисти";
            // 
            // btnFigure_backSlash
            // 
            this.btnFigure_backSlash.Location = new System.Drawing.Point(13, 126);
            this.btnFigure_backSlash.Name = "btnFigure_backSlash";
            this.btnFigure_backSlash.Size = new System.Drawing.Size(75, 23);
            this.btnFigure_backSlash.TabIndex = 5;
            this.btnFigure_backSlash.Text = "Обратная черта";
            this.btnFigure_backSlash.UseVisualStyleBackColor = true;
            this.btnFigure_backSlash.Click += new System.EventHandler(this.btnFigure_backSlash_Click);
            // 
            // btnFigure_slash
            // 
            this.btnFigure_slash.Location = new System.Drawing.Point(107, 97);
            this.btnFigure_slash.Name = "btnFigure_slash";
            this.btnFigure_slash.Size = new System.Drawing.Size(75, 23);
            this.btnFigure_slash.TabIndex = 4;
            this.btnFigure_slash.Text = "Черта";
            this.btnFigure_slash.UseVisualStyleBackColor = true;
            this.btnFigure_slash.Click += new System.EventHandler(this.btnFigure_slash_Click);
            // 
            // btnFigure_rectangle
            // 
            this.btnFigure_rectangle.Location = new System.Drawing.Point(13, 97);
            this.btnFigure_rectangle.Name = "btnFigure_rectangle";
            this.btnFigure_rectangle.Size = new System.Drawing.Size(75, 23);
            this.btnFigure_rectangle.TabIndex = 3;
            this.btnFigure_rectangle.Text = "Окружность";
            this.btnFigure_rectangle.UseVisualStyleBackColor = true;
            this.btnFigure_rectangle.Click += new System.EventHandler(this.btnFigure_rectangle_Click);
            // 
            // btnFigure_circle
            // 
            this.btnFigure_circle.Location = new System.Drawing.Point(107, 67);
            this.btnFigure_circle.Name = "btnFigure_circle";
            this.btnFigure_circle.Size = new System.Drawing.Size(75, 23);
            this.btnFigure_circle.TabIndex = 2;
            this.btnFigure_circle.Text = "Круг";
            this.btnFigure_circle.UseVisualStyleBackColor = true;
            this.btnFigure_circle.Click += new System.EventHandler(this.btnFigure_circle_Click);
            // 
            // btnFigure_square
            // 
            this.btnFigure_square.Location = new System.Drawing.Point(13, 67);
            this.btnFigure_square.Name = "btnFigure_square";
            this.btnFigure_square.Size = new System.Drawing.Size(75, 23);
            this.btnFigure_square.TabIndex = 1;
            this.btnFigure_square.Text = "Квадрат";
            this.btnFigure_square.UseVisualStyleBackColor = true;
            this.btnFigure_square.Click += new System.EventHandler(this.btnFigure_square_Click);
            // 
            // trbBrushSize
            // 
            this.trbBrushSize.AutoSize = false;
            this.trbBrushSize.Location = new System.Drawing.Point(6, 28);
            this.trbBrushSize.Name = "trbBrushSize";
            this.trbBrushSize.Size = new System.Drawing.Size(177, 45);
            this.trbBrushSize.TabIndex = 0;
            // 
            // drawPanel
            // 
            this.drawPanel.AutoScroll = true;
            this.drawPanel.Controls.Add(this.pictureBox1);
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(206, 24);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(594, 426);
            this.drawPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "paint";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trbBrushSize)).EndInit();
            this.drawPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trbBrushSize;
        private System.Windows.Forms.Button btnFigure_slash;
        private System.Windows.Forms.Button btnFigure_rectangle;
        private System.Windows.Forms.Button btnFigure_circle;
        private System.Windows.Forms.Button btnFigure_square;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFigure_backSlash;
    }
}