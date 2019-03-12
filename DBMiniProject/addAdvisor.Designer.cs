namespace DBMiniProject
{
    partial class addAdvisor
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
            this.comboAddesig = new System.Windows.Forms.ComboBox();
            this.Designation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSalary = new System.Windows.Forms.TextBox();
            this.btnAddAdvisor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboAddesig
            // 
            this.comboAddesig.FormattingEnabled = true;
            this.comboAddesig.Location = new System.Drawing.Point(303, 150);
            this.comboAddesig.Name = "comboAddesig";
            this.comboAddesig.Size = new System.Drawing.Size(121, 21);
            this.comboAddesig.TabIndex = 0;
            // 
            // Designation
            // 
            this.Designation.AutoSize = true;
            this.Designation.Location = new System.Drawing.Point(233, 158);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(63, 13);
            this.Designation.TabIndex = 1;
            this.Designation.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salary";
            // 
            // txtAdSalary
            // 
            this.txtAdSalary.Location = new System.Drawing.Point(303, 188);
            this.txtAdSalary.Name = "txtAdSalary";
            this.txtAdSalary.Size = new System.Drawing.Size(121, 20);
            this.txtAdSalary.TabIndex = 3;
            // 
            // btnAddAdvisor
            // 
            this.btnAddAdvisor.Location = new System.Drawing.Point(317, 245);
            this.btnAddAdvisor.Name = "btnAddAdvisor";
            this.btnAddAdvisor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdvisor.TabIndex = 4;
            this.btnAddAdvisor.Text = "Add";
            this.btnAddAdvisor.UseVisualStyleBackColor = true;
            this.btnAddAdvisor.Click += new System.EventHandler(this.btnAddAdvisor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Advisor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addStudentToolStripMenuItem,
            this.addProjectsToolStripMenuItem,
            this.addAdvisorToolStripMenuItem,
            this.makeGroupToolStripMenuItem,
            this.groupsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // addProjectsToolStripMenuItem
            // 
            this.addProjectsToolStripMenuItem.Name = "addProjectsToolStripMenuItem";
            this.addProjectsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.addProjectsToolStripMenuItem.Text = "Add Projects";
            this.addProjectsToolStripMenuItem.Click += new System.EventHandler(this.addProjectsToolStripMenuItem_Click);
            // 
            // addAdvisorToolStripMenuItem
            // 
            this.addAdvisorToolStripMenuItem.Name = "addAdvisorToolStripMenuItem";
            this.addAdvisorToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.addAdvisorToolStripMenuItem.Text = "Add Advisor";
            // 
            // makeGroupToolStripMenuItem
            // 
            this.makeGroupToolStripMenuItem.Name = "makeGroupToolStripMenuItem";
            this.makeGroupToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.makeGroupToolStripMenuItem.Text = "Make Group";
            this.makeGroupToolStripMenuItem.Click += new System.EventHandler(this.makeGroupToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // addAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 385);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddAdvisor);
            this.Controls.Add(this.txtAdSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Designation);
            this.Controls.Add(this.comboAddesig);
            this.Name = "addAdvisor";
            this.Text = "addAdvisor";
            this.Load += new System.EventHandler(this.addAdvisor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAddesig;
        private System.Windows.Forms.Label Designation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSalary;
        private System.Windows.Forms.Button btnAddAdvisor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
    }
}