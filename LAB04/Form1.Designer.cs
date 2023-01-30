namespace LAB04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxbYear = new System.Windows.Forms.TextBox();
            this.textBoxListName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumofAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGPAmax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGPAmin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGPAavg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNammax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNamemin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(101, 47);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxbYear
            // 
            this.textBoxbYear.Location = new System.Drawing.Point(101, 76);
            this.textBoxbYear.Multiline = true;
            this.textBoxbYear.Name = "textBoxbYear";
            this.textBoxbYear.Size = new System.Drawing.Size(100, 23);
            this.textBoxbYear.TabIndex = 1;
            // 
            // textBoxListName
            // 
            this.textBoxListName.Location = new System.Drawing.Point(351, 170);
            this.textBoxListName.Multiline = true;
            this.textBoxListName.Name = "textBoxListName";
            this.textBoxListName.Size = new System.Drawing.Size(100, 79);
            this.textBoxListName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "BirthYear";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "รายชื่อรวม";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(101, 142);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 45);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "อายุรวม";
            // 
            // textBoxNumofAge
            // 
            this.textBoxNumofAge.Location = new System.Drawing.Point(351, 141);
            this.textBoxNumofAge.Multiline = true;
            this.textBoxNumofAge.Name = "textBoxNumofAge";
            this.textBoxNumofAge.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumofAge.TabIndex = 8;
            this.textBoxNumofAge.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "GPA";
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(101, 105);
            this.textBoxGPA.Multiline = true;
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(100, 23);
            this.textBoxGPA.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "GPA Max";
            // 
            // textBoxGPAmax
            // 
            this.textBoxGPAmax.Location = new System.Drawing.Point(351, 54);
            this.textBoxGPAmax.Multiline = true;
            this.textBoxGPAmax.Name = "textBoxGPAmax";
            this.textBoxGPAmax.Size = new System.Drawing.Size(100, 23);
            this.textBoxGPAmax.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "GPA Min";
            // 
            // textBoxGPAmin
            // 
            this.textBoxGPAmin.Location = new System.Drawing.Point(351, 83);
            this.textBoxGPAmin.Multiline = true;
            this.textBoxGPAmin.Name = "textBoxGPAmin";
            this.textBoxGPAmin.Size = new System.Drawing.Size(100, 23);
            this.textBoxGPAmin.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "GPA Avg";
            // 
            // textBoxGPAavg
            // 
            this.textBoxGPAavg.Location = new System.Drawing.Point(351, 112);
            this.textBoxGPAavg.Multiline = true;
            this.textBoxGPAavg.Name = "textBoxGPAavg";
            this.textBoxGPAavg.Size = new System.Drawing.Size(100, 23);
            this.textBoxGPAavg.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(513, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Name Max Grade";
            // 
            // textBoxNammax
            // 
            this.textBoxNammax.Location = new System.Drawing.Point(513, 71);
            this.textBoxNammax.Multiline = true;
            this.textBoxNammax.Name = "textBoxNammax";
            this.textBoxNammax.Size = new System.Drawing.Size(100, 23);
            this.textBoxNammax.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Name Min Grade";
            // 
            // textBoxNamemin
            // 
            this.textBoxNamemin.Location = new System.Drawing.Point(513, 135);
            this.textBoxNamemin.Multiline = true;
            this.textBoxNamemin.Name = "textBoxNamemin";
            this.textBoxNamemin.Size = new System.Drawing.Size(100, 23);
            this.textBoxNamemin.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(257, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 272);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมููลรายวิชา";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 316);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxNamemin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNammax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxGPAavg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGPAmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGPAmax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGPA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNumofAge);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxListName);
            this.Controls.Add(this.textBoxbYear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxbYear;
        private TextBox textBoxListName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAdd;
        private Label label4;
        private TextBox textBoxNumofAge;
        private Label label5;
        private TextBox textBoxGPA;
        private Label label6;
        private TextBox textBoxGPAmax;
        private Label label7;
        private TextBox textBoxGPAmin;
        private Label label8;
        private TextBox textBoxGPAavg;
        private Label label9;
        private TextBox textBoxNammax;
        private Label label10;
        private TextBox textBoxNamemin;
        private GroupBox groupBox1;
    }
}