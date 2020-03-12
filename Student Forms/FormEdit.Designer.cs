namespace Student_Forms
{
    partial class FormEdit
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOriginaLastlName = new System.Windows.Forms.Label();
            this.lblOriginalFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblNewFirstName = new System.Windows.Forms.Label();
            this.lblNewLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(24, 128);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(91, 23);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(143, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblOriginaLastlName
            // 
            this.lblOriginaLastlName.AutoSize = true;
            this.lblOriginaLastlName.Location = new System.Drawing.Point(21, 64);
            this.lblOriginaLastlName.Name = "lblOriginaLastlName";
            this.lblOriginaLastlName.Size = new System.Drawing.Size(80, 13);
            this.lblOriginaLastlName.TabIndex = 2;
            this.lblOriginaLastlName.Text = "Old Last Name:";
            // 
            // lblOriginalFirstName
            // 
            this.lblOriginalFirstName.AutoSize = true;
            this.lblOriginalFirstName.Location = new System.Drawing.Point(22, 9);
            this.lblOriginalFirstName.Name = "lblOriginalFirstName";
            this.lblOriginalFirstName.Size = new System.Drawing.Size(79, 13);
            this.lblOriginalFirstName.TabIndex = 3;
            this.lblOriginalFirstName.Text = "Old First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(113, 34);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblNewFirstName
            // 
            this.lblNewFirstName.AutoSize = true;
            this.lblNewFirstName.Location = new System.Drawing.Point(22, 37);
            this.lblNewFirstName.Name = "lblNewFirstName";
            this.lblNewFirstName.Size = new System.Drawing.Size(85, 13);
            this.lblNewFirstName.TabIndex = 5;
            this.lblNewFirstName.Text = "New First Name:";
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.AutoSize = true;
            this.lblNewLastName.Location = new System.Drawing.Point(22, 94);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(86, 13);
            this.lblNewLastName.TabIndex = 6;
            this.lblNewLastName.Text = "New Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(113, 91);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 172);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblNewLastName);
            this.Controls.Add(this.lblNewFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblOriginalFirstName);
            this.Controls.Add(this.lblOriginaLastlName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Name = "FormEdit";
            this.Text = "Edit Student";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOriginaLastlName;
        private System.Windows.Forms.Label lblOriginalFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblNewFirstName;
        private System.Windows.Forms.Label lblNewLastName;
        private System.Windows.Forms.TextBox txtLastName;
    }
}