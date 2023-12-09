namespace MidtermReview.GUI
{
    partial class FormTeacher
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
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.listViewTeacher = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxTeacherId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWrite
            // 
            this.buttonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrite.Location = new System.Drawing.Point(40, 31);
            this.buttonWrite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(191, 42);
            this.buttonWrite.TabIndex = 0;
            this.buttonWrite.Text = "Write Data";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(40, 94);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(191, 42);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Read Data";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToList.Location = new System.Drawing.Point(275, 31);
            this.buttonAddToList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(191, 42);
            this.buttonAddToList.TabIndex = 2;
            this.buttonAddToList.Text = "&Add To List";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // buttonList
            // 
            this.buttonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Location = new System.Drawing.Point(275, 94);
            this.buttonList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(191, 42);
            this.buttonList.TabIndex = 3;
            this.buttonList.Text = "&List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // listViewTeacher
            // 
            this.listViewTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTeacher.GridLines = true;
            this.listViewTeacher.HideSelection = false;
            this.listViewTeacher.Location = new System.Drawing.Point(40, 249);
            this.listViewTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewTeacher.Name = "listViewTeacher";
            this.listViewTeacher.Size = new System.Drawing.Size(850, 154);
            this.listViewTeacher.TabIndex = 4;
            this.listViewTeacher.UseCompatibleStateImageBehavior = false;
            this.listViewTeacher.View = System.Windows.Forms.View.Details;
            this.listViewTeacher.SelectedIndexChanged += new System.EventHandler(this.listViewTeacher_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Teacher ID";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 319;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(542, 31);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(191, 42);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxTeacherId
            // 
            this.textBoxTeacherId.Location = new System.Drawing.Point(537, 127);
            this.textBoxTeacherId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTeacherId.Name = "textBoxTeacherId";
            this.textBoxTeacherId.Size = new System.Drawing.Size(189, 22);
            this.textBoxTeacherId.TabIndex = 6;
            this.textBoxTeacherId.TextChanged += new System.EventHandler(this.textBoxTeacherId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teacher ID";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTeacherId);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listViewTeacher);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonAddToList);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonWrite);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTeacher";
            this.Text = "Teacher Information";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ListView listViewTeacher;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxTeacherId;
        private System.Windows.Forms.Label label1;
    }
}