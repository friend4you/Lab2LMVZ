namespace DrawingVector
{
    partial class Form2
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.XBar = new System.Windows.Forms.TrackBar();
            this.YBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateLineBtn = new System.Windows.Forms.Button();
            this.RxBar = new System.Windows.Forms.TrackBar();
            this.RyBar = new System.Windows.Forms.TrackBar();
            this.RzBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trackSizeBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.XBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RyBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RzBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.Location = new System.Drawing.Point(2, 3);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(789, 517);
            this.DrawPanel.TabIndex = 0;
            // 
            // XBar
            // 
            this.XBar.Location = new System.Drawing.Point(12, 533);
            this.XBar.Maximum = 63;
            this.XBar.Name = "XBar";
            this.XBar.Size = new System.Drawing.Size(228, 45);
            this.XBar.TabIndex = 2;
            this.XBar.TickFrequency = 5;
            this.XBar.Value = 8;
            this.XBar.Scroll += new System.EventHandler(this.XBar_Scroll);
            // 
            // YBar
            // 
            this.YBar.Location = new System.Drawing.Point(246, 533);
            this.YBar.Maximum = 63;
            this.YBar.Name = "YBar";
            this.YBar.Size = new System.Drawing.Size(228, 45);
            this.YBar.TabIndex = 5;
            this.YBar.TickFrequency = 5;
            this.YBar.Value = 11;
            this.YBar.Scroll += new System.EventHandler(this.YBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Z1";
            // 
            // CreateLineBtn
            // 
            this.CreateLineBtn.Location = new System.Drawing.Point(841, 170);
            this.CreateLineBtn.Name = "CreateLineBtn";
            this.CreateLineBtn.Size = new System.Drawing.Size(132, 35);
            this.CreateLineBtn.TabIndex = 13;
            this.CreateLineBtn.Text = "Отрисовать отрезок";
            this.CreateLineBtn.UseVisualStyleBackColor = true;
            this.CreateLineBtn.Click += new System.EventHandler(this.CreateLineBtn_Click);
            // 
            // RxBar
            // 
            this.RxBar.Location = new System.Drawing.Point(1076, 431);
            this.RxBar.Name = "RxBar";
            this.RxBar.Size = new System.Drawing.Size(104, 45);
            this.RxBar.TabIndex = 14;
            this.RxBar.Visible = false;
            // 
            // RyBar
            // 
            this.RyBar.Location = new System.Drawing.Point(1076, 482);
            this.RyBar.Name = "RyBar";
            this.RyBar.Size = new System.Drawing.Size(104, 45);
            this.RyBar.TabIndex = 15;
            this.RyBar.Visible = false;
            // 
            // RzBar
            // 
            this.RzBar.Location = new System.Drawing.Point(1076, 533);
            this.RzBar.Name = "RzBar";
            this.RzBar.Size = new System.Drawing.Size(111, 45);
            this.RzBar.TabIndex = 16;
            this.RzBar.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(996, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "X2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(996, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Y2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(996, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Z2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(899, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(820, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Размер поля";
            // 
            // trackSizeBar
            // 
            this.trackSizeBar.Location = new System.Drawing.Point(594, 533);
            this.trackSizeBar.Maximum = 100;
            this.trackSizeBar.Name = "trackSizeBar";
            this.trackSizeBar.Size = new System.Drawing.Size(197, 45);
            this.trackSizeBar.TabIndex = 28;
            this.trackSizeBar.Value = 3;
            this.trackSizeBar.ValueChanged += new System.EventHandler(this.trackSizeBar_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Маштаб";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(848, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(848, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 21);
            this.comboBox2.TabIndex = 31;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(848, 82);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(76, 21);
            this.comboBox3.TabIndex = 32;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(1035, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(76, 21);
            this.comboBox4.TabIndex = 33;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(1035, 49);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(76, 21);
            this.comboBox5.TabIndex = 34;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(1035, 82);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(76, 21);
            this.comboBox6.TabIndex = 31;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 586);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackSizeBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RzBar);
            this.Controls.Add(this.RyBar);
            this.Controls.Add(this.RxBar);
            this.Controls.Add(this.CreateLineBtn);
            this.Controls.Add(this.YBar);
            this.Controls.Add(this.XBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawPanel);
            this.Name = "Form2";
            this.Text = "Линия в прост";
            ((System.ComponentModel.ISupportInitialize)(this.XBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RyBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RzBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSizeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.TrackBar XBar;
        private System.Windows.Forms.TrackBar YBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateLineBtn;
        private System.Windows.Forms.TrackBar RxBar;
        private System.Windows.Forms.TrackBar RyBar;
        private System.Windows.Forms.TrackBar RzBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackSizeBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}

