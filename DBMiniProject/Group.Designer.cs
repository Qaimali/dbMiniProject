namespace DBMiniProject
{
    partial class Group
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
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioActive = new System.Windows.Forms.RadioButton();
            this.radioInActive = new System.Windows.Forms.RadioButton();
            this.dgGroups = new System.Windows.Forms.DataGridView();
            this.deProjectMiniDataSet = new DBMiniProject.deProjectMiniDataSet();
            this.AssignProject = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deProjectMiniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addStudentToolStripMenuItem,
            this.addProjectsToolStripMenuItem,
            this.addAdvisorToolStripMenuItem,
            this.makeGroupToolStripMenuItem,
            this.groupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            // 
            // addProjectsToolStripMenuItem
            // 
            this.addProjectsToolStripMenuItem.Name = "addProjectsToolStripMenuItem";
            this.addProjectsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.addProjectsToolStripMenuItem.Text = "Add Projects";
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
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.groupToolStripMenuItem.Text = "Groups";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // radioActive
            // 
            this.radioActive.AutoSize = true;
            this.radioActive.Checked = true;
            this.radioActive.Location = new System.Drawing.Point(195, 79);
            this.radioActive.Name = "radioActive";
            this.radioActive.Size = new System.Drawing.Size(92, 17);
            this.radioActive.TabIndex = 21;
            this.radioActive.TabStop = true;
            this.radioActive.Text = "Active Groups";
            this.radioActive.UseVisualStyleBackColor = true;
            this.radioActive.CheckedChanged += new System.EventHandler(this.radioActive_CheckedChanged);
            // 
            // radioInActive
            // 
            this.radioInActive.AutoSize = true;
            this.radioInActive.Location = new System.Drawing.Point(335, 79);
            this.radioInActive.Name = "radioInActive";
            this.radioInActive.Size = new System.Drawing.Size(104, 17);
            this.radioInActive.TabIndex = 22;
            this.radioInActive.Text = "In Active Groups";
            this.radioInActive.UseVisualStyleBackColor = true;
            this.radioInActive.CheckedChanged += new System.EventHandler(this.radioInActive_CheckedChanged);
            // 
            // dgGroups
            // 
            this.dgGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignProject});
            this.dgGroups.Location = new System.Drawing.Point(35, 124);
            this.dgGroups.Name = "dgGroups";
            this.dgGroups.Size = new System.Drawing.Size(566, 249);
            this.dgGroups.TabIndex = 23;
            this.dgGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGroups_CellContentClick);
            // 
            // deProjectMiniDataSet
            // 
            this.deProjectMiniDataSet.DataSetName = "deProjectMiniDataSet";
            this.deProjectMiniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AssignProject
            // 
            this.AssignProject.HeaderText = "Assign Project";
            this.AssignProject.Name = "AssignProject";
            this.AssignProject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AssignProject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AssignProject.Text = "Assign";
            this.AssignProject.UseColumnTextForLinkValue = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 237);
            this.dataGridView1.TabIndex = 24;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 385);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgGroups);
            this.Controls.Add(this.radioInActive);
            this.Controls.Add(this.radioActive);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Group";
            this.Text = "Group";
            this.Load += new System.EventHandler(this.Group_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deProjectMiniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioActive;
        private System.Windows.Forms.RadioButton radioInActive;
        private System.Windows.Forms.DataGridView dgGroups;
        private System.Windows.Forms.DataGridViewLinkColumn AssignProject;
        private deProjectMiniDataSet deProjectMiniDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}