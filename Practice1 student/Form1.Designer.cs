namespace Practice1_student
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtcarrer = new TextBox();
            textBox3 = new TextBox();
            txtmotherlastname = new TextBox();
            txtPaternlastname = new TextBox();
            dtBirthdate = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            txtenrollment = new TextBox();
            lblstudentinfo = new Label();
            txtcreate = new Button();
            button1 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 35);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 105);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Average";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 105);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Carrer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(533, 35);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 4;
            label4.Text = "DateBirthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 35);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 5;
            label5.Text = "motherlastname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 35);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 6;
            label6.Text = "Paternlastname";
            // 
            // txtName
            // 
            txtName.Location = new Point(22, 52);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 7;
            // 
            // txtcarrer
            // 
            txtcarrer.Location = new Point(22, 136);
            txtcarrer.Margin = new Padding(3, 2, 3, 2);
            txtcarrer.Name = "txtcarrer";
            txtcarrer.Size = new Size(110, 23);
            txtcarrer.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(543, 51);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(74, 23);
            textBox3.TabIndex = 9;
            // 
            // txtmotherlastname
            // 
            txtmotherlastname.Location = new Point(333, 52);
            txtmotherlastname.Margin = new Padding(3, 2, 3, 2);
            txtmotherlastname.Name = "txtmotherlastname";
            txtmotherlastname.Size = new Size(154, 23);
            txtmotherlastname.TabIndex = 12;
            // 
            // txtPaternlastname
            // 
            txtPaternlastname.Location = new Point(164, 52);
            txtPaternlastname.Margin = new Padding(3, 2, 3, 2);
            txtPaternlastname.Name = "txtPaternlastname";
            txtPaternlastname.Size = new Size(142, 23);
            txtPaternlastname.TabIndex = 11;
            // 
            // dtBirthdate
            // 
            dtBirthdate.Format = DateTimePickerFormat.Short;
            dtBirthdate.Location = new Point(533, 51);
            dtBirthdate.Margin = new Padding(3, 2, 3, 2);
            dtBirthdate.Name = "dtBirthdate";
            dtBirthdate.Size = new Size(88, 23);
            dtBirthdate.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(341, 136);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(102, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 105);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 15;
            label7.Text = "Enrollment";
            // 
            // txtenrollment
            // 
            txtenrollment.Location = new Point(152, 136);
            txtenrollment.Margin = new Padding(3, 2, 3, 2);
            txtenrollment.Name = "txtenrollment";
            txtenrollment.Size = new Size(142, 23);
            txtenrollment.TabIndex = 16;
            // 
            // lblstudentinfo
            // 
            lblstudentinfo.Enabled = false;
            lblstudentinfo.Location = new Point(39, 250);
            lblstudentinfo.Name = "lblstudentinfo";
            lblstudentinfo.Size = new Size(550, 21);
            lblstudentinfo.TabIndex = 16;
            lblstudentinfo.Visible = false;
            // 
            // txtcreate
            // 
            txtcreate.Location = new Point(0, 0);
            txtcreate.Name = "txtcreate";
            txtcreate.Size = new Size(75, 23);
            txtcreate.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(543, 166);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 22);
            button1.TabIndex = 18;
            button1.Text = "create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(430, 188);
            label8.Margin = new Padding(3, 0, 3, 7);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 50;
            label8.Text = "label8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 508);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(lblstudentinfo);
            Controls.Add(txtenrollment);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(dtBirthdate);
            Controls.Add(txtPaternlastname);
            Controls.Add(txtmotherlastname);
            Controls.Add(textBox3);
            Controls.Add(txtcarrer);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtcreate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtcarrer;
        private TextBox textBox3;
        private TextBox txtmotherlastname;
        private TextBox txtPaternlastname;
        private DateTimePicker dtBirthdate;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private TextBox txtenrollment;
        private Label lblstudentinfo;
        private Button Txtcreate;
        private Button button1;
        private Label label8;
    }
}