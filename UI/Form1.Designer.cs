using System.Collections.Generic;
namespace WindowsForms
{
    partial class Form1
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
        private void Reset()
        {
            panel.Refresh();
            circles = new List<Circle>();
            Cirle = new Circle();
            active_circle = null;
            is_checked = false;
            click_counter = 0;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shape_click_menus = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.Hints = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open_file = new System.Windows.Forms.OpenFileDialog();
            this.save_file = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shape_click_menus,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_Click);
            // 
            // sahpesToolStripMenuItem
            // 
            this.shape_click_menus.Name = "sahpesToolStripMenuItem";
            this.shape_click_menus.Size = new System.Drawing.Size(56, 20);
            this.shape_click_menus.Text = "Sahpes";
            this.shape_click_menus.Click += new System.EventHandler(this.shape_click_menu);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // panelForPainting
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.Hints);
            this.panel.Controls.Add(this.Remove);
            this.panel.Controls.Add(this.Change);
            this.panel.Location = new System.Drawing.Point(11, 26);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panelForPainting";
            this.panel.Size = new System.Drawing.Size(1095, 564);
            this.panel.TabIndex = 1;
            this.panel.Click += new System.EventHandler(this.panel_painting);
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForPainting_Paint);
            this.panel.DoubleClick += new System.EventHandler(this.panelForPainting_DoubleClick);
            // 
            // Hints
            // 
            this.Hints.AutoSize = true;
            this.Hints.BackColor = System.Drawing.Color.DarkGray;
            this.Hints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hints.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hints.Location = new System.Drawing.Point(592, 414);
            this.Hints.MinimumSize = new System.Drawing.Size(500, 150);
            this.Hints.Name = "Hints";
            this.Hints.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Hints.Size = new System.Drawing.Size(500, 150);
            this.Hints.TabIndex = 10;
            this.Hints.Text = "*Double click for choose centre\r\n*Double click for choose edge\r\n*Remove for delet" +
    "e circle\r\n*Change for choose color\r\n";
            // 
            // DeleteCircle
            // 
            this.Remove.BackColor = System.Drawing.Color.Green;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.White;
            this.Remove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Remove.Location = new System.Drawing.Point(0, 294);
            this.Remove.Margin = new System.Windows.Forms.Padding(2);
            this.Remove.Name = "DeleteCircle";
            this.Remove.Size = new System.Drawing.Size(34, 268);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Visible = false;
            this.Remove.Click += new System.EventHandler(this.Remove_circle);
            // 
            // ChooseColor
            // 
            this.Change.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.ForeColor = System.Drawing.Color.Black;
            this.Change.Location = new System.Drawing.Point(0, 2);
            this.Change.Margin = new System.Windows.Forms.Padding(2);
            this.Change.Name = "ChooseColor";
            this.Change.Size = new System.Drawing.Size(34, 288);
            this.Change.TabIndex = 2;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Visible = false;
            this.Change.Click += new System.EventHandler(this.choose_color);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.open_file.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 612);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shape_click_menus;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog open_file;
        private System.Windows.Forms.SaveFileDialog save_file;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label Hints;
    }
}

