namespace CourseProject
{
    partial class SMO
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
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_time_simulation_days = new System.Windows.Forms.TextBox();
            this.label_time_simulation_days = new System.Windows.Forms.Label();
            this.label_max_queue = new System.Windows.Forms.Label();
            this.textBox_max_queue = new System.Windows.Forms.TextBox();
            this.label_order_distribution = new System.Windows.Forms.Label();
            this.comboBox_order_distribution = new System.Windows.Forms.ComboBox();
            this.label_time_simulation_hours = new System.Windows.Forms.Label();
            this.textBox_time_simulation_hours = new System.Windows.Forms.TextBox();
            this.textBox_interval_service_time_before = new System.Windows.Forms.TextBox();
            this.label_interval_service_time_before = new System.Windows.Forms.Label();
            this.label_interval_service_time_from = new System.Windows.Forms.Label();
            this.label_interval_between_byers_before = new System.Windows.Forms.Label();
            this.label_interval_between_byers_from = new System.Windows.Forms.Label();
            this.textBox_interval_between_byers_before = new System.Windows.Forms.TextBox();
            this.textBox_interval_between_byers_from = new System.Windows.Forms.TextBox();
            this.textBox_interval_service_time_from = new System.Windows.Forms.TextBox();
            this.label_interval_service_time = new System.Windows.Forms.Label();
            this.label_interval_between_byers = new System.Windows.Forms.Label();
            this.button_Stop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_clearFields = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Start.Location = new System.Drawing.Point(12, 12);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Запуск";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время работы: 0 дней, 0 часов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Всего клиентов: 0 человек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Обслужено клиентов: 0 человек";
            // 
            // textBox_time_simulation_days
            // 
            this.textBox_time_simulation_days.Location = new System.Drawing.Point(16, 311);
            this.textBox_time_simulation_days.Name = "textBox_time_simulation_days";
            this.textBox_time_simulation_days.Size = new System.Drawing.Size(130, 20);
            this.textBox_time_simulation_days.TabIndex = 4;
            this.textBox_time_simulation_days.Text = "0";
            // 
            // label_time_simulation_days
            // 
            this.label_time_simulation_days.AutoSize = true;
            this.label_time_simulation_days.Location = new System.Drawing.Point(13, 292);
            this.label_time_simulation_days.Name = "label_time_simulation_days";
            this.label_time_simulation_days.Size = new System.Drawing.Size(136, 13);
            this.label_time_simulation_days.TabIndex = 5;
            this.label_time_simulation_days.Text = "Время симуляции в днях:";
            // 
            // label_max_queue
            // 
            this.label_max_queue.AutoSize = true;
            this.label_max_queue.Location = new System.Drawing.Point(304, 292);
            this.label_max_queue.Name = "label_max_queue";
            this.label_max_queue.Size = new System.Drawing.Size(164, 13);
            this.label_max_queue.TabIndex = 7;
            this.label_max_queue.Text = "Максимальная длина очереди:";
            // 
            // textBox_max_queue
            // 
            this.textBox_max_queue.Location = new System.Drawing.Point(307, 311);
            this.textBox_max_queue.Name = "textBox_max_queue";
            this.textBox_max_queue.Size = new System.Drawing.Size(161, 20);
            this.textBox_max_queue.TabIndex = 6;
            this.textBox_max_queue.Text = "3";
            // 
            // label_order_distribution
            // 
            this.label_order_distribution.AutoSize = true;
            this.label_order_distribution.Location = new System.Drawing.Point(477, 292);
            this.label_order_distribution.Name = "label_order_distribution";
            this.label_order_distribution.Size = new System.Drawing.Size(122, 13);
            this.label_order_distribution.TabIndex = 8;
            this.label_order_distribution.Text = "Закон распределения:";
            // 
            // comboBox_order_distribution
            // 
            this.comboBox_order_distribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_order_distribution.FormattingEnabled = true;
            this.comboBox_order_distribution.Items.AddRange(new object[] {
            "Нормальный",
            "Равномерный"});
            this.comboBox_order_distribution.Location = new System.Drawing.Point(480, 310);
            this.comboBox_order_distribution.Name = "comboBox_order_distribution";
            this.comboBox_order_distribution.Size = new System.Drawing.Size(119, 21);
            this.comboBox_order_distribution.TabIndex = 9;
            // 
            // label_time_simulation_hours
            // 
            this.label_time_simulation_hours.AutoSize = true;
            this.label_time_simulation_hours.Location = new System.Drawing.Point(155, 292);
            this.label_time_simulation_hours.Name = "label_time_simulation_hours";
            this.label_time_simulation_hours.Size = new System.Drawing.Size(141, 13);
            this.label_time_simulation_hours.TabIndex = 11;
            this.label_time_simulation_hours.Text = "Время симуляции в часах:";
            // 
            // textBox_time_simulation_hours
            // 
            this.textBox_time_simulation_hours.Location = new System.Drawing.Point(158, 311);
            this.textBox_time_simulation_hours.Name = "textBox_time_simulation_hours";
            this.textBox_time_simulation_hours.Size = new System.Drawing.Size(138, 20);
            this.textBox_time_simulation_hours.TabIndex = 10;
            this.textBox_time_simulation_hours.Text = "8";
            // 
            // textBox_interval_service_time_before
            // 
            this.textBox_interval_service_time_before.Location = new System.Drawing.Point(412, 370);
            this.textBox_interval_service_time_before.Name = "textBox_interval_service_time_before";
            this.textBox_interval_service_time_before.Size = new System.Drawing.Size(48, 20);
            this.textBox_interval_service_time_before.TabIndex = 35;
            this.textBox_interval_service_time_before.Text = "5";
            // 
            // label_interval_service_time_before
            // 
            this.label_interval_service_time_before.AutoSize = true;
            this.label_interval_service_time_before.Location = new System.Drawing.Point(384, 373);
            this.label_interval_service_time_before.Name = "label_interval_service_time_before";
            this.label_interval_service_time_before.Size = new System.Drawing.Size(22, 13);
            this.label_interval_service_time_before.TabIndex = 41;
            this.label_interval_service_time_before.Text = "До";
            // 
            // label_interval_service_time_from
            // 
            this.label_interval_service_time_from.AutoSize = true;
            this.label_interval_service_time_from.Location = new System.Drawing.Point(304, 373);
            this.label_interval_service_time_from.Name = "label_interval_service_time_from";
            this.label_interval_service_time_from.Size = new System.Drawing.Size(20, 13);
            this.label_interval_service_time_from.TabIndex = 40;
            this.label_interval_service_time_from.Text = "От";
            // 
            // label_interval_between_byers_before
            // 
            this.label_interval_between_byers_before.AutoSize = true;
            this.label_interval_between_byers_before.Location = new System.Drawing.Point(93, 373);
            this.label_interval_between_byers_before.Name = "label_interval_between_byers_before";
            this.label_interval_between_byers_before.Size = new System.Drawing.Size(22, 13);
            this.label_interval_between_byers_before.TabIndex = 39;
            this.label_interval_between_byers_before.Text = "До";
            // 
            // label_interval_between_byers_from
            // 
            this.label_interval_between_byers_from.AutoSize = true;
            this.label_interval_between_byers_from.Location = new System.Drawing.Point(13, 373);
            this.label_interval_between_byers_from.Name = "label_interval_between_byers_from";
            this.label_interval_between_byers_from.Size = new System.Drawing.Size(20, 13);
            this.label_interval_between_byers_from.TabIndex = 38;
            this.label_interval_between_byers_from.Text = "От";
            // 
            // textBox_interval_between_byers_before
            // 
            this.textBox_interval_between_byers_before.Location = new System.Drawing.Point(122, 370);
            this.textBox_interval_between_byers_before.Name = "textBox_interval_between_byers_before";
            this.textBox_interval_between_byers_before.Size = new System.Drawing.Size(48, 20);
            this.textBox_interval_between_byers_before.TabIndex = 33;
            this.textBox_interval_between_byers_before.Text = "4";
            // 
            // textBox_interval_between_byers_from
            // 
            this.textBox_interval_between_byers_from.Location = new System.Drawing.Point(39, 370);
            this.textBox_interval_between_byers_from.Name = "textBox_interval_between_byers_from";
            this.textBox_interval_between_byers_from.Size = new System.Drawing.Size(48, 20);
            this.textBox_interval_between_byers_from.TabIndex = 32;
            this.textBox_interval_between_byers_from.Text = "2";
            // 
            // textBox_interval_service_time_from
            // 
            this.textBox_interval_service_time_from.Location = new System.Drawing.Point(330, 370);
            this.textBox_interval_service_time_from.Name = "textBox_interval_service_time_from";
            this.textBox_interval_service_time_from.Size = new System.Drawing.Size(48, 20);
            this.textBox_interval_service_time_from.TabIndex = 34;
            this.textBox_interval_service_time_from.Text = "3";
            // 
            // label_interval_service_time
            // 
            this.label_interval_service_time.AutoSize = true;
            this.label_interval_service_time.Location = new System.Drawing.Point(304, 345);
            this.label_interval_service_time.Name = "label_interval_service_time";
            this.label_interval_service_time.Size = new System.Drawing.Size(270, 13);
            this.label_interval_service_time.TabIndex = 37;
            this.label_interval_service_time.Text = "Интервал обслуживания одного клиента в минутах:";
            // 
            // label_interval_between_byers
            // 
            this.label_interval_between_byers.AutoSize = true;
            this.label_interval_between_byers.Location = new System.Drawing.Point(13, 345);
            this.label_interval_between_byers.Name = "label_interval_between_byers";
            this.label_interval_between_byers.Size = new System.Drawing.Size(223, 13);
            this.label_interval_between_byers.TabIndex = 36;
            this.label_interval_between_byers.Text = "Интервал между покупателями в минутах:";
            // 
            // button_Stop
            // 
            this.button_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Stop.Location = new System.Drawing.Point(93, 12);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 42;
            this.button_Stop.Text = "Стоп";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "Количество отказов: 0 человек";
            // 
            // button_clearFields
            // 
            this.button_clearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clearFields.Location = new System.Drawing.Point(174, 12);
            this.button_clearFields.Name = "button_clearFields";
            this.button_clearFields.Size = new System.Drawing.Size(123, 23);
            this.button_clearFields.TabIndex = 45;
            this.button_clearFields.Text = "Очистка полей";
            this.button_clearFields.UseVisualStyleBackColor = true;
            this.button_clearFields.Click += new System.EventHandler(this.button_clearFields_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(513, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "Среднее время пребывания покупател у кассы: 0 минут";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(514, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Процент непроизводительного времени продавца: 0 %";
            // 
            // SMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_clearFields);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.textBox_interval_service_time_before);
            this.Controls.Add(this.label_interval_service_time_before);
            this.Controls.Add(this.label_interval_service_time_from);
            this.Controls.Add(this.label_interval_between_byers_before);
            this.Controls.Add(this.label_interval_between_byers_from);
            this.Controls.Add(this.textBox_interval_between_byers_before);
            this.Controls.Add(this.textBox_interval_between_byers_from);
            this.Controls.Add(this.textBox_interval_service_time_from);
            this.Controls.Add(this.label_interval_service_time);
            this.Controls.Add(this.label_interval_between_byers);
            this.Controls.Add(this.label_time_simulation_hours);
            this.Controls.Add(this.textBox_time_simulation_hours);
            this.Controls.Add(this.comboBox_order_distribution);
            this.Controls.Add(this.label_order_distribution);
            this.Controls.Add(this.label_max_queue);
            this.Controls.Add(this.textBox_max_queue);
            this.Controls.Add(this.label_time_simulation_days);
            this.Controls.Add(this.textBox_time_simulation_days);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Start);
            this.MaximizeBox = false;
            this.Name = "SMO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система массового обслуживания";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_time_simulation_days;
        private System.Windows.Forms.Label label_time_simulation_days;
        private System.Windows.Forms.Label label_max_queue;
        private System.Windows.Forms.TextBox textBox_max_queue;
        private System.Windows.Forms.Label label_order_distribution;
        private System.Windows.Forms.ComboBox comboBox_order_distribution;
        private System.Windows.Forms.Label label_time_simulation_hours;
        private System.Windows.Forms.TextBox textBox_time_simulation_hours;
        private System.Windows.Forms.Label label_interval_service_time_before;
        private System.Windows.Forms.Label label_interval_service_time_from;
        private System.Windows.Forms.Label label_interval_between_byers_before;
        private System.Windows.Forms.Label label_interval_between_byers_from;
        private System.Windows.Forms.Label label_interval_service_time;
        private System.Windows.Forms.Label label_interval_between_byers;
        private System.Windows.Forms.Button button_Stop;
        public System.Windows.Forms.TextBox textBox_interval_service_time_before;
        public System.Windows.Forms.TextBox textBox_interval_between_byers_before;
        public System.Windows.Forms.TextBox textBox_interval_between_byers_from;
        public System.Windows.Forms.TextBox textBox_interval_service_time_from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_clearFields;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

