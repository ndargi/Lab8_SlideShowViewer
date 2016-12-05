namespace Lab8
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.File_Group = new System.Windows.Forms.GroupBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Show_Button = new System.Windows.Forms.Button();
            this.Interval_Label = new System.Windows.Forms.Label();
            this.Interval_Text = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.File_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCollectionToolStripMenuItem,
            this.saveCollectionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCollectionToolStripMenuItem
            // 
            this.openCollectionToolStripMenuItem.Name = "openCollectionToolStripMenuItem";
            this.openCollectionToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.openCollectionToolStripMenuItem.Text = "Open Collection";
            // 
            // saveCollectionToolStripMenuItem
            // 
            this.saveCollectionToolStripMenuItem.Name = "saveCollectionToolStripMenuItem";
            this.saveCollectionToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.saveCollectionToolStripMenuItem.Text = "Save Collection";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(56, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1063, 147);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // File_Group
            // 
            this.File_Group.Controls.Add(this.Delete_Button);
            this.File_Group.Controls.Add(this.Add_Button);
            this.File_Group.Location = new System.Drawing.Point(100, 288);
            this.File_Group.Name = "File_Group";
            this.File_Group.Size = new System.Drawing.Size(441, 147);
            this.File_Group.TabIndex = 2;
            this.File_Group.TabStop = false;
            this.File_Group.Text = "Files";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(51, 57);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(129, 53);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(260, 57);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(130, 53);
            this.Delete_Button.TabIndex = 1;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Show_Button
            // 
            this.Show_Button.Location = new System.Drawing.Point(859, 332);
            this.Show_Button.Name = "Show_Button";
            this.Show_Button.Size = new System.Drawing.Size(170, 53);
            this.Show_Button.TabIndex = 3;
            this.Show_Button.Text = "Show";
            this.Show_Button.UseVisualStyleBackColor = true;
            // 
            // Interval_Label
            // 
            this.Interval_Label.AutoSize = true;
            this.Interval_Label.Location = new System.Drawing.Point(868, 431);
            this.Interval_Label.Name = "Interval_Label";
            this.Interval_Label.Size = new System.Drawing.Size(82, 25);
            this.Interval_Label.TabIndex = 4;
            this.Interval_Label.Text = "Interval";
            // 
            // Interval_Text
            // 
            this.Interval_Text.Location = new System.Drawing.Point(970, 428);
            this.Interval_Text.Name = "Interval_Text";
            this.Interval_Text.Size = new System.Drawing.Size(67, 31);
            this.Interval_Text.TabIndex = 5;
            this.Interval_Text.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 523);
            this.Controls.Add(this.Interval_Text);
            this.Controls.Add(this.Interval_Label);
            this.Controls.Add(this.Show_Button);
            this.Controls.Add(this.File_Group);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.File_Group.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox File_Group;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Show_Button;
        private System.Windows.Forms.Label Interval_Label;
        private System.Windows.Forms.TextBox Interval_Text;
    }
}

