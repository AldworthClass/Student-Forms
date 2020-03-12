namespace Student_Forms
{
    partial class FormDetails
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
            this.lblFirstNameTitle = new System.Windows.Forms.Label();
            this.lblLastNameTitle = new System.Windows.Forms.Label();
            this.lblStudentNumTitle = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstNameTitle
            // 
            this.lblFirstNameTitle.AutoSize = true;
            this.lblFirstNameTitle.Location = new System.Drawing.Point(12, 9);
            this.lblFirstNameTitle.Name = "lblFirstNameTitle";
            this.lblFirstNameTitle.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameTitle.TabIndex = 0;
            this.lblFirstNameTitle.Text = "FirstName:";
            // 
            // lblLastNameTitle
            // 
            this.lblLastNameTitle.AutoSize = true;
            this.lblLastNameTitle.Location = new System.Drawing.Point(12, 33);
            this.lblLastNameTitle.Name = "lblLastNameTitle";
            this.lblLastNameTitle.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameTitle.TabIndex = 1;
            this.lblLastNameTitle.Text = "LastName:";
            // 
            // lblStudentNumTitle
            // 
            this.lblStudentNumTitle.AutoSize = true;
            this.lblStudentNumTitle.Location = new System.Drawing.Point(12, 58);
            this.lblStudentNumTitle.Name = "lblStudentNumTitle";
            this.lblStudentNumTitle.Size = new System.Drawing.Size(87, 13);
            this.lblStudentNumTitle.TabIndex = 2;
            this.lblStudentNumTitle.Text = "Student Number:";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Location = new System.Drawing.Point(12, 83);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(35, 13);
            this.lblEmailTitle.TabIndex = 3;
            this.lblEmailTitle.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(127, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 16);
            this.lblEmail.TabIndex = 7;
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNum.Location = new System.Drawing.Point(127, 58);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(0, 16);
            this.lblStudentNum.TabIndex = 6;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(127, 33);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(0, 16);
            this.lblLast.TabIndex = 5;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(127, 9);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 16);
            this.lblFirst.TabIndex = 4;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(15, 102);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 137);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblStudentNum);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblEmailTitle);
            this.Controls.Add(this.lblStudentNumTitle);
            this.Controls.Add(this.lblLastNameTitle);
            this.Controls.Add(this.lblFirstNameTitle);
            this.Name = "FormDetails";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.FormDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNameTitle;
        private System.Windows.Forms.Label lblLastNameTitle;
        private System.Windows.Forms.Label lblStudentNumTitle;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStudentNum;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Button btnDone;
    }
}