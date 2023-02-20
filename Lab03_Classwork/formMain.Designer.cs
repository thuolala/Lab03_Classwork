namespace Lab03_Classwork
{
    partial class formMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departmentAndEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependentForEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oleDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(265, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lab 03 - Classwork";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(145, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "One - Many Relationship Form Demo ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentAndEmployeeToolStripMenuItem,
            this.dependentForEmployeeToolStripMenuItem,
            this.oleDBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departmentAndEmployeeToolStripMenuItem
            // 
            this.departmentAndEmployeeToolStripMenuItem.Name = "departmentAndEmployeeToolStripMenuItem";
            this.departmentAndEmployeeToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.departmentAndEmployeeToolStripMenuItem.Text = "Department and Employee";
            this.departmentAndEmployeeToolStripMenuItem.Click += new System.EventHandler(this.departmentAndEmployeeToolStripMenuItem_Click);
            // 
            // dependentForEmployeeToolStripMenuItem
            // 
            this.dependentForEmployeeToolStripMenuItem.Name = "dependentForEmployeeToolStripMenuItem";
            this.dependentForEmployeeToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.dependentForEmployeeToolStripMenuItem.Text = "Dependent for Employee";
            this.dependentForEmployeeToolStripMenuItem.Click += new System.EventHandler(this.dependentForEmployeeToolStripMenuItem_Click);
            // 
            // oleDBToolStripMenuItem
            // 
            this.oleDBToolStripMenuItem.Name = "oleDBToolStripMenuItem";
            this.oleDBToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.oleDBToolStripMenuItem.Text = "OleDB";
            this.oleDBToolStripMenuItem.Click += new System.EventHandler(this.oleDBToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem departmentAndEmployeeToolStripMenuItem;
        private ToolStripMenuItem dependentForEmployeeToolStripMenuItem;
        private ToolStripMenuItem oleDBToolStripMenuItem;
    }
}