namespace LAB_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.label_currFile = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.search_optn = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Study = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_search = new System.Windows.Forms.Button();
            this.textbox_searchbar = new System.Windows.Forms.TextBox();
            this.btn_avg_course = new System.Windows.Forms.Button();
            this.btn_avg_group = new System.Windows.Forms.Button();
            this.btn_avg_study = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(12, 12);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(96, 23);
            this.btn_openFile.TabIndex = 0;
            this.btn_openFile.Text = "Открыть файл";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // label_currFile
            // 
            this.label_currFile.AutoSize = true;
            this.label_currFile.Location = new System.Drawing.Point(12, 51);
            this.label_currFile.Name = "label_currFile";
            this.label_currFile.Size = new System.Drawing.Size(90, 13);
            this.label_currFile.TabIndex = 1;
            this.label_currFile.Text = "Файл не открыт";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(114, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(84, 23);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Обновить";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.getXML_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(204, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_SetXML_Click);
            // 
            // search_optn
            // 
            this.search_optn.FormattingEnabled = true;
            this.search_optn.Location = new System.Drawing.Point(294, 14);
            this.search_optn.Name = "search_optn";
            this.search_optn.Size = new System.Drawing.Size(121, 21);
            this.search_optn.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.GroupID,
            this.LastName,
            this.CheckBookID,
            this.Study,
            this.Mark});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(780, 305);
            this.dataGridView1.TabIndex = 7;
            // 
            // Course
            // 
            this.Course.HeaderText = "Курс";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // GroupID
            // 
            this.GroupID.HeaderText = "Номер группы";
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // CheckBookID
            // 
            this.CheckBookID.HeaderText = "Номер зачетной книжки";
            this.CheckBookID.Name = "CheckBookID";
            this.CheckBookID.ReadOnly = true;
            // 
            // Study
            // 
            this.Study.HeaderText = "Дисциплина";
            this.Study.Name = "Study";
            this.Study.ReadOnly = true;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Оценка";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(666, 14);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Поиск";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textbox_searchbar
            // 
            this.textbox_searchbar.Location = new System.Drawing.Point(421, 14);
            this.textbox_searchbar.Name = "textbox_searchbar";
            this.textbox_searchbar.Size = new System.Drawing.Size(239, 20);
            this.textbox_searchbar.TabIndex = 9;
            // 
            // btn_avg_course
            // 
            this.btn_avg_course.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_avg_course.Location = new System.Drawing.Point(15, 399);
            this.btn_avg_course.Name = "btn_avg_course";
            this.btn_avg_course.Size = new System.Drawing.Size(171, 50);
            this.btn_avg_course.TabIndex = 10;
            this.btn_avg_course.Text = "Средний по курсу";
            this.btn_avg_course.UseVisualStyleBackColor = true;
            this.btn_avg_course.Click += new System.EventHandler(this.btn_avg_course_Click);
            // 
            // btn_avg_group
            // 
            this.btn_avg_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_avg_group.Location = new System.Drawing.Point(192, 399);
            this.btn_avg_group.Name = "btn_avg_group";
            this.btn_avg_group.Size = new System.Drawing.Size(171, 50);
            this.btn_avg_group.TabIndex = 11;
            this.btn_avg_group.Text = "Средний по группе";
            this.btn_avg_group.UseVisualStyleBackColor = true;
            this.btn_avg_group.Click += new System.EventHandler(this.btn_avg_group_Click);
            // 
            // btn_avg_study
            // 
            this.btn_avg_study.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_avg_study.Location = new System.Drawing.Point(369, 399);
            this.btn_avg_study.Name = "btn_avg_study";
            this.btn_avg_study.Size = new System.Drawing.Size(171, 50);
            this.btn_avg_study.TabIndex = 12;
            this.btn_avg_study.Text = "Средний по Дисциплине";
            this.btn_avg_study.UseVisualStyleBackColor = true;
            this.btn_avg_study.Click += new System.EventHandler(this.btn_avg_study_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btn_avg_study);
            this.Controls.Add(this.btn_avg_group);
            this.Controls.Add(this.btn_avg_course);
            this.Controls.Add(this.textbox_searchbar);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_optn);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label_currFile);
            this.Controls.Add(this.btn_openFile);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Label label_currFile;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox search_optn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textbox_searchbar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Study;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.Button btn_avg_course;
        private System.Windows.Forms.Button btn_avg_group;
        private System.Windows.Forms.Button btn_avg_study;
    }
}

