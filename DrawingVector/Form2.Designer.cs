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
            this.components = new System.ComponentModel.Container();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.CreateLineBtn = new System.Windows.Forms.Button();
            this.RxBar = new System.Windows.Forms.TrackBar();
            this.RyBar = new System.Windows.Forms.TrackBar();
            this.RzBar = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackSizeBar = new System.Windows.Forms.TrackBar();
            this.YBar = new System.Windows.Forms.TrackBar();
            this.XBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RyBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RzBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBar)).BeginInit();
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
            // CreateLineBtn
            // 
            this.CreateLineBtn.Location = new System.Drawing.Point(851, 417);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(909, 377);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "120";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(830, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Размер поля";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(825, 540);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "вариант 4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(825, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "вариант 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(825, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "вариант 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 533);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 533);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Вращение камеры";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(587, 533);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Маштабирование";
            // 
            // trackSizeBar
            // 
            this.trackSizeBar.Location = new System.Drawing.Point(678, 533);
            this.trackSizeBar.Maximum = 100;
            this.trackSizeBar.Name = "trackSizeBar";
            this.trackSizeBar.Size = new System.Drawing.Size(113, 45);
            this.trackSizeBar.TabIndex = 56;
            this.trackSizeBar.Value = 3;
            this.trackSizeBar.ValueChanged += new System.EventHandler(this.trackSizeBar_ValueChanged_1);
            // 
            // YBar
            // 
            this.YBar.Location = new System.Drawing.Point(382, 533);
            this.YBar.Maximum = 63;
            this.YBar.Name = "YBar";
            this.YBar.Size = new System.Drawing.Size(159, 45);
            this.YBar.TabIndex = 55;
            this.YBar.TickFrequency = 5;
            this.YBar.Value = 11;
            this.YBar.ValueChanged += new System.EventHandler(this.YBar_ValueChanged);
            // 
            // XBar
            // 
            this.XBar.Location = new System.Drawing.Point(207, 533);
            this.XBar.Maximum = 63;
            this.XBar.Name = "XBar";
            this.XBar.Size = new System.Drawing.Size(137, 45);
            this.XBar.TabIndex = 54;
            this.XBar.TickFrequency = 5;
            this.XBar.Value = 8;
            this.XBar.ValueChanged += new System.EventHandler(this.XBar_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(814, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Координаты прямой";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(825, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 120);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(1020, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 120);
            this.panel2.TabIndex = 63;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(825, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 120);
            this.panel3.TabIndex = 64;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(1020, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 120);
            this.panel4.TabIndex = 65;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1146, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(947, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1000, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(814, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1000, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(814, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(947, 339);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 73;
            this.label14.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(805, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 72;
            this.label15.Text = "Z";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1013, 339);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 77;
            this.label16.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1146, 339);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 76;
            this.label17.Text = "X";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1004, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 75;
            this.label18.Text = "Z";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 586);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trackSizeBar);
            this.Controls.Add(this.YBar);
            this.Controls.Add(this.XBar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RzBar);
            this.Controls.Add(this.RyBar);
            this.Controls.Add(this.RxBar);
            this.Controls.Add(this.CreateLineBtn);
            this.Controls.Add(this.DrawPanel);
            this.Name = "Form2";
            this.Text = "Линия в пространстве";
            ((System.ComponentModel.ISupportInitialize)(this.RxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RyBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RzBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button CreateLineBtn;
        private System.Windows.Forms.TrackBar RxBar;
        private System.Windows.Forms.TrackBar RyBar;
        private System.Windows.Forms.TrackBar RzBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackSizeBar;
        private System.Windows.Forms.TrackBar YBar;
        private System.Windows.Forms.TrackBar XBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer timer1;
    }
}

