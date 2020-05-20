namespace LAB_8
{
    partial class AddValue
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
            this.Submit = new System.Windows.Forms.Button();
            this.val_mark = new System.Windows.Forms.NumericUpDown();
            this.textbox_course = new System.Windows.Forms.TextBox();
            this.textbox_groupID = new System.Windows.Forms.TextBox();
            this.textbox_lastName = new System.Windows.Forms.TextBox();
            this.textbox_checkBookID = new System.Windows.Forms.TextBox();
            this.textbox_study = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.val_mark)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(12, 250);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(189, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Создать запись";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // val_mark
            // 
            this.val_mark.Location = new System.Drawing.Point(12, 224);
            this.val_mark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.val_mark.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.val_mark.Name = "val_mark";
            this.val_mark.Size = new System.Drawing.Size(189, 20);
            this.val_mark.TabIndex = 1;
            this.val_mark.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textbox_course
            // 
            this.textbox_course.Location = new System.Drawing.Point(12, 29);
            this.textbox_course.Name = "textbox_course";
            this.textbox_course.Size = new System.Drawing.Size(189, 20);
            this.textbox_course.TabIndex = 2;
            // 
            // textbox_groupID
            // 
            this.textbox_groupID.Location = new System.Drawing.Point(12, 68);
            this.textbox_groupID.Name = "textbox_groupID";
            this.textbox_groupID.Size = new System.Drawing.Size(189, 20);
            this.textbox_groupID.TabIndex = 3;
            // 
            // textbox_lastName
            // 
            this.textbox_lastName.Location = new System.Drawing.Point(12, 107);
            this.textbox_lastName.Name = "textbox_lastName";
            this.textbox_lastName.Size = new System.Drawing.Size(189, 20);
            this.textbox_lastName.TabIndex = 4;
            // 
            // textbox_checkBookID
            // 
            this.textbox_checkBookID.Location = new System.Drawing.Point(12, 146);
            this.textbox_checkBookID.Name = "textbox_checkBookID";
            this.textbox_checkBookID.Size = new System.Drawing.Size(189, 20);
            this.textbox_checkBookID.TabIndex = 5;
            // 
            // textbox_study
            // 
            this.textbox_study.Location = new System.Drawing.Point(12, 185);
            this.textbox_study.Name = "textbox_study";
            this.textbox_study.Size = new System.Drawing.Size(189, 20);
            this.textbox_study.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Курс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер группы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Номер Зачетной Книжки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Предмет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Оценка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_study);
            this.Controls.Add(this.textbox_checkBookID);
            this.Controls.Add(this.textbox_lastName);
            this.Controls.Add(this.textbox_groupID);
            this.Controls.Add(this.textbox_course);
            this.Controls.Add(this.val_mark);
            this.Controls.Add(this.Submit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(230, 350);
            this.MinimumSize = new System.Drawing.Size(230, 350);
            this.Name = "AddValue";
            this.Text = "AddValue";
            ((System.ComponentModel.ISupportInitialize)(this.val_mark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.NumericUpDown val_mark;
        private System.Windows.Forms.TextBox textbox_course;
        private System.Windows.Forms.TextBox textbox_groupID;
        private System.Windows.Forms.TextBox textbox_lastName;
        private System.Windows.Forms.TextBox textbox_checkBookID;
        private System.Windows.Forms.TextBox textbox_study;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}