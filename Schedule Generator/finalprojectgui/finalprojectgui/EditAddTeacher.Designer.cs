namespace finalprojectgui
{
    partial class EditAddTeacher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(155, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 470);
            this.panel1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(667, 192);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(249, 251);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(812, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(812, 503);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(667, 503);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(472, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 32);
            this.button5.TabIndex = 9;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(367, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 32);
            this.button6.TabIndex = 8;
            this.button6.Text = "Export";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(258, 41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 32);
            this.button7.TabIndex = 7;
            this.button7.Text = "View";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(157, 41);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(82, 32);
            this.Dashboard.TabIndex = 6;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // EditAddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalprojectgui.Properties.Resources._1234556;
            this.ClientSize = new System.Drawing.Size(1062, 681);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.panel1);
            this.Name = "EditAddTeacher";
            this.Text = "EditAddTeacher";
            this.Load += new System.EventHandler(this.EditAddTeacher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Dashboard;
    }
}