namespace _05_StudentPopulation_For
{
    partial class frmStudentPopulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStuNumNow = new System.Windows.Forms.TextBox();
            this.txtAGR = new System.Windows.Forms.TextBox();
            this.txtNumYear = new System.Windows.Forms.TextBox();
            this.txtStuNumProjected = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of students today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Annual growth rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of years:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(38, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Projected number of students:";
            // 
            // txtStuNumNow
            // 
            this.txtStuNumNow.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtStuNumNow.Location = new System.Drawing.Point(251, 35);
            this.txtStuNumNow.Name = "txtStuNumNow";
            this.txtStuNumNow.Size = new System.Drawing.Size(182, 27);
            this.txtStuNumNow.TabIndex = 1;
            // 
            // txtAGR
            // 
            this.txtAGR.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAGR.Location = new System.Drawing.Point(251, 80);
            this.txtAGR.Name = "txtAGR";
            this.txtAGR.Size = new System.Drawing.Size(182, 27);
            this.txtAGR.TabIndex = 2;
            // 
            // txtNumYear
            // 
            this.txtNumYear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNumYear.Location = new System.Drawing.Point(251, 125);
            this.txtNumYear.Name = "txtNumYear";
            this.txtNumYear.Size = new System.Drawing.Size(182, 27);
            this.txtNumYear.TabIndex = 3;
            // 
            // txtStuNumProjected
            // 
            this.txtStuNumProjected.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtStuNumProjected.Location = new System.Drawing.Point(251, 170);
            this.txtStuNumProjected.Name = "txtStuNumProjected";
            this.txtStuNumProjected.ReadOnly = true;
            this.txtStuNumProjected.Size = new System.Drawing.Size(182, 27);
            this.txtStuNumProjected.TabIndex = 1;
            this.txtStuNumProjected.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCalculate.Location = new System.Drawing.Point(42, 223);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(203, 36);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnExit.Location = new System.Drawing.Point(251, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStudentPopulation
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(478, 303);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtStuNumProjected);
            this.Controls.Add(this.txtNumYear);
            this.Controls.Add(this.txtAGR);
            this.Controls.Add(this.txtStuNumNow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentPopulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStuNumNow;
        private System.Windows.Forms.TextBox txtAGR;
        private System.Windows.Forms.TextBox txtNumYear;
        private System.Windows.Forms.TextBox txtStuNumProjected;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

