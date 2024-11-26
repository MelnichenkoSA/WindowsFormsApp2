namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ToCrreateFormButton = new System.Windows.Forms.Button();
            this.radioButtonAscSort = new System.Windows.Forms.RadioButton();
            this.radioButtonDescSort = new System.Windows.Forms.RadioButton();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Показать Юзеров";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(330, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ToCrreateFormButton
            // 
            this.ToCrreateFormButton.Location = new System.Drawing.Point(280, 225);
            this.ToCrreateFormButton.Name = "ToCrreateFormButton";
            this.ToCrreateFormButton.Size = new System.Drawing.Size(225, 46);
            this.ToCrreateFormButton.TabIndex = 2;
            this.ToCrreateFormButton.Text = "Добавить/Изменить/Удалить";
            this.ToCrreateFormButton.UseVisualStyleBackColor = true;
            this.ToCrreateFormButton.Click += new System.EventHandler(this.ToCrreateFormButton_Click);
            // 
            // radioButtonAscSort
            // 
            this.radioButtonAscSort.AutoSize = true;
            this.radioButtonAscSort.Location = new System.Drawing.Point(490, 60);
            this.radioButtonAscSort.Name = "radioButtonAscSort";
            this.radioButtonAscSort.Size = new System.Drawing.Size(137, 20);
            this.radioButtonAscSort.TabIndex = 3;
            this.radioButtonAscSort.TabStop = true;
            this.radioButtonAscSort.Text = "По возрастанию";
            this.radioButtonAscSort.UseVisualStyleBackColor = true;
            this.radioButtonAscSort.CheckedChanged += new System.EventHandler(this.radioButtonAscSort_CheckedChanged);
            // 
            // radioButtonDescSort
            // 
            this.radioButtonDescSort.AutoSize = true;
            this.radioButtonDescSort.Location = new System.Drawing.Point(490, 99);
            this.radioButtonDescSort.Name = "radioButtonDescSort";
            this.radioButtonDescSort.Size = new System.Drawing.Size(116, 20);
            this.radioButtonDescSort.TabIndex = 4;
            this.radioButtonDescSort.TabStop = true;
            this.radioButtonDescSort.Text = "По убыванию";
            this.radioButtonDescSort.UseVisualStyleBackColor = true;
            this.radioButtonDescSort.CheckedChanged += new System.EventHandler(this.radioButtonDescSort_CheckedChanged);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "login = l1",
            "password = p2",
            "без фильтра"});
            this.comboBoxFilter.Location = new System.Drawing.Point(644, 60);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilter.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.radioButtonDescSort);
            this.Controls.Add(this.radioButtonAscSort);
            this.Controls.Add(this.ToCrreateFormButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ToCrreateFormButton;
        private System.Windows.Forms.RadioButton radioButtonAscSort;
        private System.Windows.Forms.RadioButton radioButtonDescSort;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button button2;
    }
}

