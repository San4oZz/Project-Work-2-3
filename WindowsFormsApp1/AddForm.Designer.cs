namespace WindowsFormsApp1
{
    partial class AddForm
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
            this.Add = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Group = new System.Windows.Forms.TextBox();
            this.Speciality = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.SpecialityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(247, 239);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(183, 26);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(247, 53);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(183, 20);
            this.NameBox.TabIndex = 1;
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(247, 176);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(183, 20);
            this.Group.TabIndex = 2;
            // 
            // Speciality
            // 
            this.Speciality.Location = new System.Drawing.Point(247, 109);
            this.Speciality.Name = "Speciality";
            this.Speciality.Size = new System.Drawing.Size(183, 20);
            this.Speciality.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(142, 59);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(142, 183);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(36, 13);
            this.GroupLabel.TabIndex = 5;
            this.GroupLabel.Text = "Group";
            // 
            // SpecialityLabel
            // 
            this.SpecialityLabel.AutoSize = true;
            this.SpecialityLabel.Location = new System.Drawing.Point(142, 116);
            this.SpecialityLabel.Name = "SpecialityLabel";
            this.SpecialityLabel.Size = new System.Drawing.Size(52, 13);
            this.SpecialityLabel.TabIndex = 6;
            this.SpecialityLabel.Text = "Speciality";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 333);
            this.Controls.Add(this.SpecialityLabel);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Speciality);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Add);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.TextBox Speciality;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label SpecialityLabel;
    }
}