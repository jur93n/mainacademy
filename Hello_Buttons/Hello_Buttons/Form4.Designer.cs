namespace Hello_Buttons
{
    partial class Form4
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
            this.ChildTextBox = new System.Windows.Forms.RichTextBox();
            this.ChildMenu = new System.Windows.Forms.MenuStrip();
            this.FormatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToggleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OvalWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChildMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildTextBox
            // 
            this.ChildTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildTextBox.Location = new System.Drawing.Point(0, 24);
            this.ChildTextBox.Name = "ChildTextBox";
            this.ChildTextBox.Size = new System.Drawing.Size(384, 337);
            this.ChildTextBox.TabIndex = 0;
            this.ChildTextBox.Text = "";
            // 
            // ChildMenu
            // 
            this.ChildMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ChildMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatMenuItem});
            this.ChildMenu.Location = new System.Drawing.Point(0, 0);
            this.ChildMenu.Name = "ChildMenu";
            this.ChildMenu.Size = new System.Drawing.Size(384, 24);
            this.ChildMenu.TabIndex = 1;
            this.ChildMenu.Text = "menuStrip1";
            // 
            // FormatMenuItem
            // 
            this.FormatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToggleMenuItem,
            this.OvalWindowMenuItem});
            this.FormatMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.FormatMenuItem.MergeIndex = 1;
            this.FormatMenuItem.Name = "FormatMenuItem";
            this.FormatMenuItem.Size = new System.Drawing.Size(57, 20);
            this.FormatMenuItem.Text = "F&ormat";
            // 
            // ToggleMenuItem
            // 
            this.ToggleMenuItem.Name = "ToggleMenuItem";
            this.ToggleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ToggleMenuItem.Text = "&Toggle Foreground";
            this.ToggleMenuItem.Click += new System.EventHandler(this.ToggleMenuItem_Click);
            // 
            // OvalWindowMenuItem
            // 
            this.OvalWindowMenuItem.Name = "OvalWindowMenuItem";
            this.OvalWindowMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OvalWindowMenuItem.Text = "&Oval Window";
            this.OvalWindowMenuItem.Click += new System.EventHandler(this.OvalWindowMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.ChildTextBox);
            this.Controls.Add(this.ChildMenu);
            this.MainMenuStrip = this.ChildMenu;
            this.Name = "Form4";
            this.Text = "MDI child";
            this.ChildMenu.ResumeLayout(false);
            this.ChildMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox ChildTextBox;
        private MenuStrip ChildMenu;
        private ToolStripMenuItem FormatMenuItem;
        private ToolStripMenuItem ToggleMenuItem;
        private ToolStripMenuItem OvalWindowMenuItem;
    }
}