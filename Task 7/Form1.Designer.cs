namespace Task_7
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
            this.unsorted_listBox = new System.Windows.Forms.ListBox();
            this.unsorted_list_label = new System.Windows.Forms.Label();
            this.sorted_array_label = new System.Windows.Forms.Label();
            this.sorted_listBox = new System.Windows.Forms.ListBox();
            this.output_label = new System.Windows.Forms.Label();
            this.student_insert = new System.Windows.Forms.TextBox();
            this.student_label = new System.Windows.Forms.Label();
            this.add_student_button = new System.Windows.Forms.Button();
            this.sort_label = new System.Windows.Forms.Label();
            this.dir_sel_button = new System.Windows.Forms.Button();
            this.bubble_button = new System.Windows.Forms.Button();
            this.dir_act_button = new System.Windows.Forms.Button();
            this.sheik_button = new System.Windows.Forms.Button();
            this.shell_button = new System.Windows.Forms.Button();
            this.sorting_label = new System.Windows.Forms.Label();
            this.fio_sorting_label = new System.Windows.Forms.Label();
            this.speciality_sorting_label = new System.Windows.Forms.Label();
            this.grop_num_sorting_label = new System.Windows.Forms.Label();
            this.speciality_choice_radioButton = new System.Windows.Forms.RadioButton();
            this.fio_choice_radioButton = new System.Windows.Forms.RadioButton();
            this.group_num_choice_radioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // unsorted_listBox
            // 
            this.unsorted_listBox.FormattingEnabled = true;
            this.unsorted_listBox.Location = new System.Drawing.Point(10, 50);
            this.unsorted_listBox.Name = "unsorted_listBox";
            this.unsorted_listBox.Size = new System.Drawing.Size(450, 394);
            this.unsorted_listBox.TabIndex = 0;
            // 
            // unsorted_list_label
            // 
            this.unsorted_list_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.unsorted_list_label.Location = new System.Drawing.Point(10, 10);
            this.unsorted_list_label.Name = "unsorted_list_label";
            this.unsorted_list_label.Size = new System.Drawing.Size(450, 30);
            this.unsorted_list_label.TabIndex = 1;
            this.unsorted_list_label.Text = "Unsorted cafedra array";
            this.unsorted_list_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sorted_array_label
            // 
            this.sorted_array_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sorted_array_label.Location = new System.Drawing.Point(520, 10);
            this.sorted_array_label.Name = "sorted_array_label";
            this.sorted_array_label.Size = new System.Drawing.Size(450, 30);
            this.sorted_array_label.TabIndex = 3;
            this.sorted_array_label.Text = "Sorted cafedra array";
            this.sorted_array_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sorted_listBox
            // 
            this.sorted_listBox.FormattingEnabled = true;
            this.sorted_listBox.Location = new System.Drawing.Point(520, 50);
            this.sorted_listBox.Name = "sorted_listBox";
            this.sorted_listBox.Size = new System.Drawing.Size(450, 290);
            this.sorted_listBox.TabIndex = 2;
            // 
            // output_label
            // 
            this.output_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.output_label.Location = new System.Drawing.Point(520, 350);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(450, 94);
            this.output_label.TabIndex = 4;
            this.output_label.Text = "Time spent: 0 ms\r\nSteps: 0\r\nSorted by: ------- method";
            this.output_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // student_insert
            // 
            this.student_insert.Location = new System.Drawing.Point(10, 504);
            this.student_insert.Name = "student_insert";
            this.student_insert.Size = new System.Drawing.Size(450, 20);
            this.student_insert.TabIndex = 5;
            // 
            // student_label
            // 
            this.student_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.student_label.Location = new System.Drawing.Point(10, 458);
            this.student_label.Name = "student_label";
            this.student_label.Size = new System.Drawing.Size(450, 30);
            this.student_label.TabIndex = 6;
            this.student_label.Text = "Insert student\'s data like this: FIO/Speciality/GroupNumber. But no more than 200" +
    "";
            this.student_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_student_button
            // 
            this.add_student_button.Location = new System.Drawing.Point(10, 531);
            this.add_student_button.Name = "add_student_button";
            this.add_student_button.Size = new System.Drawing.Size(450, 23);
            this.add_student_button.TabIndex = 7;
            this.add_student_button.Text = "Add student to cafedra";
            this.add_student_button.UseVisualStyleBackColor = true;
            this.add_student_button.Click += new System.EventHandler(this.add_student_button_Click);
            // 
            // sort_label
            // 
            this.sort_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sort_label.Location = new System.Drawing.Point(10, 570);
            this.sort_label.Name = "sort_label";
            this.sort_label.Size = new System.Drawing.Size(450, 22);
            this.sort_label.TabIndex = 8;
            this.sort_label.Text = "Sort by:";
            this.sort_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dir_sel_button
            // 
            this.dir_sel_button.Location = new System.Drawing.Point(10, 596);
            this.dir_sel_button.Name = "dir_sel_button";
            this.dir_sel_button.Size = new System.Drawing.Size(180, 53);
            this.dir_sel_button.TabIndex = 9;
            this.dir_sel_button.Text = "Direct selection method";
            this.dir_sel_button.UseVisualStyleBackColor = true;
            // 
            // bubble_button
            // 
            this.bubble_button.Location = new System.Drawing.Point(200, 596);
            this.bubble_button.Name = "bubble_button";
            this.bubble_button.Size = new System.Drawing.Size(180, 53);
            this.bubble_button.TabIndex = 10;
            this.bubble_button.Text = "Bubble method";
            this.bubble_button.UseVisualStyleBackColor = true;
            // 
            // dir_act_button
            // 
            this.dir_act_button.Location = new System.Drawing.Point(390, 596);
            this.dir_act_button.Name = "dir_act_button";
            this.dir_act_button.Size = new System.Drawing.Size(180, 53);
            this.dir_act_button.TabIndex = 11;
            this.dir_act_button.Text = "Direct activation method";
            this.dir_act_button.UseVisualStyleBackColor = true;
            // 
            // sheik_button
            // 
            this.sheik_button.Location = new System.Drawing.Point(580, 596);
            this.sheik_button.Name = "sheik_button";
            this.sheik_button.Size = new System.Drawing.Size(180, 53);
            this.sheik_button.TabIndex = 12;
            this.sheik_button.Text = "Shaker method";
            this.sheik_button.UseVisualStyleBackColor = true;
            // 
            // shell_button
            // 
            this.shell_button.Location = new System.Drawing.Point(770, 596);
            this.shell_button.Name = "shell_button";
            this.shell_button.Size = new System.Drawing.Size(180, 53);
            this.shell_button.TabIndex = 13;
            this.shell_button.Text = "Shell\'s method";
            this.shell_button.UseVisualStyleBackColor = true;
            // 
            // sorting_label
            // 
            this.sorting_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sorting_label.Location = new System.Drawing.Point(520, 458);
            this.sorting_label.Name = "sorting_label";
            this.sorting_label.Size = new System.Drawing.Size(450, 30);
            this.sorting_label.TabIndex = 14;
            this.sorting_label.Text = "Choose 1 sorting field:";
            this.sorting_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fio_sorting_label
            // 
            this.fio_sorting_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fio_sorting_label.Location = new System.Drawing.Point(517, 504);
            this.fio_sorting_label.Name = "fio_sorting_label";
            this.fio_sorting_label.Size = new System.Drawing.Size(81, 30);
            this.fio_sorting_label.TabIndex = 15;
            this.fio_sorting_label.Text = "FIO";
            this.fio_sorting_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speciality_sorting_label
            // 
            this.speciality_sorting_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.speciality_sorting_label.Location = new System.Drawing.Point(637, 504);
            this.speciality_sorting_label.Name = "speciality_sorting_label";
            this.speciality_sorting_label.Size = new System.Drawing.Size(192, 30);
            this.speciality_sorting_label.TabIndex = 16;
            this.speciality_sorting_label.Text = "Speciality";
            this.speciality_sorting_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grop_num_sorting_label
            // 
            this.grop_num_sorting_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grop_num_sorting_label.Location = new System.Drawing.Point(835, 504);
            this.grop_num_sorting_label.Name = "grop_num_sorting_label";
            this.grop_num_sorting_label.Size = new System.Drawing.Size(135, 30);
            this.grop_num_sorting_label.TabIndex = 17;
            this.grop_num_sorting_label.Text = "Group number";
            this.grop_num_sorting_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speciality_choice_radioButton
            // 
            this.speciality_choice_radioButton.AutoSize = true;
            this.speciality_choice_radioButton.Location = new System.Drawing.Point(727, 541);
            this.speciality_choice_radioButton.Name = "speciality_choice_radioButton";
            this.speciality_choice_radioButton.Size = new System.Drawing.Size(14, 13);
            this.speciality_choice_radioButton.TabIndex = 18;
            this.speciality_choice_radioButton.TabStop = true;
            this.speciality_choice_radioButton.UseVisualStyleBackColor = true;
            // 
            // fio_choice_radioButton
            // 
            this.fio_choice_radioButton.AutoSize = true;
            this.fio_choice_radioButton.Location = new System.Drawing.Point(550, 541);
            this.fio_choice_radioButton.Name = "fio_choice_radioButton";
            this.fio_choice_radioButton.Size = new System.Drawing.Size(14, 13);
            this.fio_choice_radioButton.TabIndex = 19;
            this.fio_choice_radioButton.TabStop = true;
            this.fio_choice_radioButton.UseVisualStyleBackColor = true;
            // 
            // group_num_choice_radioButton
            // 
            this.group_num_choice_radioButton.AutoSize = true;
            this.group_num_choice_radioButton.Location = new System.Drawing.Point(895, 541);
            this.group_num_choice_radioButton.Name = "group_num_choice_radioButton";
            this.group_num_choice_radioButton.Size = new System.Drawing.Size(14, 13);
            this.group_num_choice_radioButton.TabIndex = 20;
            this.group_num_choice_radioButton.TabStop = true;
            this.group_num_choice_radioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.group_num_choice_radioButton);
            this.Controls.Add(this.fio_choice_radioButton);
            this.Controls.Add(this.speciality_choice_radioButton);
            this.Controls.Add(this.grop_num_sorting_label);
            this.Controls.Add(this.speciality_sorting_label);
            this.Controls.Add(this.fio_sorting_label);
            this.Controls.Add(this.sorting_label);
            this.Controls.Add(this.shell_button);
            this.Controls.Add(this.sheik_button);
            this.Controls.Add(this.dir_act_button);
            this.Controls.Add(this.bubble_button);
            this.Controls.Add(this.dir_sel_button);
            this.Controls.Add(this.sort_label);
            this.Controls.Add(this.add_student_button);
            this.Controls.Add(this.student_label);
            this.Controls.Add(this.student_insert);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.sorted_array_label);
            this.Controls.Add(this.sorted_listBox);
            this.Controls.Add(this.unsorted_list_label);
            this.Controls.Add(this.unsorted_listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox unsorted_listBox;
        private System.Windows.Forms.Label unsorted_list_label;
        private System.Windows.Forms.Label sorted_array_label;
        private System.Windows.Forms.ListBox sorted_listBox;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.TextBox student_insert;
        private System.Windows.Forms.Label student_label;
        private System.Windows.Forms.Button add_student_button;
        private System.Windows.Forms.Label sort_label;
        private System.Windows.Forms.Button dir_sel_button;
        private System.Windows.Forms.Button bubble_button;
        private System.Windows.Forms.Button dir_act_button;
        private System.Windows.Forms.Button sheik_button;
        private System.Windows.Forms.Button shell_button;
        private System.Windows.Forms.Label sorting_label;
        private System.Windows.Forms.Label fio_sorting_label;
        private System.Windows.Forms.Label speciality_sorting_label;
        private System.Windows.Forms.Label grop_num_sorting_label;
        private System.Windows.Forms.RadioButton speciality_choice_radioButton;
        private System.Windows.Forms.RadioButton fio_choice_radioButton;
        private System.Windows.Forms.RadioButton group_num_choice_radioButton;
    }
}

