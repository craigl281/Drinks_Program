namespace Drinks_Program
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmb_DrinkType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Fruit = new System.Windows.Forms.Panel();
            this.txt_Fruit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Alcohol = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nm_alcohol = new System.Windows.Forms.NumericUpDown();
            this.cb_Carbonation = new System.Windows.Forms.CheckBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnl_Fruit.SuspendLayout();
            this.pnl_Alcohol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_alcohol)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmb_DrinkType
            // 
            this.cmb_DrinkType.FormattingEnabled = true;
            this.cmb_DrinkType.Location = new System.Drawing.Point(163, 44);
            this.cmb_DrinkType.Name = "cmb_DrinkType";
            this.cmb_DrinkType.Size = new System.Drawing.Size(223, 28);
            this.cmb_DrinkType.TabIndex = 3;
            this.cmb_DrinkType.SelectedIndexChanged += new System.EventHandler(this.cmb_DrinkType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type of Beverage";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(163, 78);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(223, 26);
            this.txt_Name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name of Beverage";
            // 
            // pnl_Fruit
            // 
            this.pnl_Fruit.Controls.Add(this.txt_Fruit);
            this.pnl_Fruit.Controls.Add(this.label3);
            this.pnl_Fruit.Location = new System.Drawing.Point(0, 110);
            this.pnl_Fruit.Name = "pnl_Fruit";
            this.pnl_Fruit.Size = new System.Drawing.Size(800, 41);
            this.pnl_Fruit.TabIndex = 7;
            // 
            // txt_Fruit
            // 
            this.txt_Fruit.Location = new System.Drawing.Point(163, 6);
            this.txt_Fruit.Name = "txt_Fruit";
            this.txt_Fruit.Size = new System.Drawing.Size(223, 26);
            this.txt_Fruit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fruit";
            // 
            // pnl_Alcohol
            // 
            this.pnl_Alcohol.Controls.Add(this.nm_alcohol);
            this.pnl_Alcohol.Controls.Add(this.label4);
            this.pnl_Alcohol.Location = new System.Drawing.Point(0, 110);
            this.pnl_Alcohol.Name = "pnl_Alcohol";
            this.pnl_Alcohol.Size = new System.Drawing.Size(800, 37);
            this.pnl_Alcohol.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alcohol Percentage";
            // 
            // nm_alcohol
            // 
            this.nm_alcohol.DecimalPlaces = 2;
            this.nm_alcohol.Location = new System.Drawing.Point(189, 6);
            this.nm_alcohol.Name = "nm_alcohol";
            this.nm_alcohol.Size = new System.Drawing.Size(72, 26);
            this.nm_alcohol.TabIndex = 2;
            // 
            // cb_Carbonation
            // 
            this.cb_Carbonation.AutoSize = true;
            this.cb_Carbonation.Checked = true;
            this.cb_Carbonation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Carbonation.Location = new System.Drawing.Point(163, 157);
            this.cb_Carbonation.Name = "cb_Carbonation";
            this.cb_Carbonation.Size = new System.Drawing.Size(131, 24);
            this.cb_Carbonation.TabIndex = 2;
            this.cb_Carbonation.Text = "Carbonation?";
            this.cb_Carbonation.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem1.Text = "View";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 223);
            this.Controls.Add(this.cb_Carbonation);
            this.Controls.Add(this.pnl_Alcohol);
            this.Controls.Add(this.pnl_Fruit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_DrinkType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Fruit.ResumeLayout(false);
            this.pnl_Fruit.PerformLayout();
            this.pnl_Alcohol.ResumeLayout(false);
            this.pnl_Alcohol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_alcohol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cmb_DrinkType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Fruit;
        private System.Windows.Forms.TextBox txt_Fruit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_Alcohol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nm_alcohol;
        private System.Windows.Forms.CheckBox cb_Carbonation;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

