﻿namespace Hello_Buttons
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnyes = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnext = new System.Windows.Forms.Button();
            this.btnmdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(106, 70);
            this.btnyes.Margin = new System.Windows.Forms.Padding(10);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(75, 23);
            this.btnyes.TabIndex = 0;
            this.btnyes.Text = "Ok";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(201, 70);
            this.btnno.Margin = new System.Windows.Forms.Padding(10);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 1;
            this.btnno.Text = "O!";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnno_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "How are you?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(391, 70);
            this.btnext.Margin = new System.Windows.Forms.Padding(10);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(75, 23);
            this.btnext.TabIndex = 3;
            this.btnext.Text = "Next";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btnmdi
            // 
            this.btnmdi.Location = new System.Drawing.Point(296, 70);
            this.btnmdi.Margin = new System.Windows.Forms.Padding(10);
            this.btnmdi.Name = "btnmdi";
            this.btnmdi.Size = new System.Drawing.Size(75, 23);
            this.btnmdi.TabIndex = 4;
            this.btnmdi.Text = "MDIp";
            this.btnmdi.UseVisualStyleBackColor = true;
            this.btnmdi.Click += new System.EventHandler(this.btnmdi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 157);
            this.Controls.Add(this.btnmdi);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Important query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnyes;
        private Button btnno;
        private Label label1;
        private Button btnext;
        private Button btnmdi;
    }
}