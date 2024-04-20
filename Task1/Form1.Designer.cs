namespace Task1
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
            groupBox1 = new GroupBox();
            button1Reset = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1Select = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox_Capacity = new TextBox();
            textBox_TimeClose = new TextBox();
            textBox_TimeOpen = new TextBox();
            textBox_Location = new TextBox();
            textBox_Name = new TextBox();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            button2Reset = new Button();
            button2Select = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBoxMidMark = new TextBox();
            textBoxDegree = new TextBox();
            textBoxEndDate = new TextBox();
            textBoxStartDate = new TextBox();
            textBoxSpeciality = new TextBox();
            textBoxGivenTo = new TextBox();
            textBoxUName = new TextBox();
            listView2 = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1Reset);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1Select);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_Capacity);
            groupBox1.Controls.Add(textBox_TimeClose);
            groupBox1.Controls.Add(textBox_TimeOpen);
            groupBox1.Controls.Add(textBox_Location);
            groupBox1.Controls.Add(textBox_Name);
            groupBox1.Controls.Add(listView1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 623);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Библиотеки";
            // 
            // button1Reset
            // 
            button1Reset.Location = new Point(287, 549);
            button1Reset.Name = "button1Reset";
            button1Reset.Size = new Size(171, 29);
            button1Reset.TabIndex = 12;
            button1Reset.Text = "Отменить выборку";
            button1Reset.UseVisualStyleBackColor = true;
            button1Reset.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 402);
            label5.Name = "label5";
            label5.Size = new Size(217, 20);
            label5.TabIndex = 11;
            label5.Text = "Количество книг больше, чем";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 333);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 10;
            label4.Text = "Время закрытия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 333);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 9;
            label3.Text = "Время открытия";
            // 
            // button1Select
            // 
            button1Select.Location = new Point(47, 549);
            button1Select.Name = "button1Select";
            button1Select.Size = new Size(171, 29);
            button1Select.TabIndex = 1;
            button1Select.Text = "Выбрать";
            button1Select.UseVisualStyleBackColor = true;
            button1Select.Click += buttonSelect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 261);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 8;
            label2.Text = "Расположение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 261);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 7;
            label1.Text = "Имя";
            // 
            // textBox_Capacity
            // 
            textBox_Capacity.Location = new Point(12, 425);
            textBox_Capacity.Name = "textBox_Capacity";
            textBox_Capacity.Size = new Size(244, 27);
            textBox_Capacity.TabIndex = 6;
            // 
            // textBox_TimeClose
            // 
            textBox_TimeClose.Location = new Point(264, 356);
            textBox_TimeClose.Name = "textBox_TimeClose";
            textBox_TimeClose.Size = new Size(237, 27);
            textBox_TimeClose.TabIndex = 5;
            // 
            // textBox_TimeOpen
            // 
            textBox_TimeOpen.Location = new Point(12, 356);
            textBox_TimeOpen.Name = "textBox_TimeOpen";
            textBox_TimeOpen.Size = new Size(244, 27);
            textBox_TimeOpen.TabIndex = 4;
            // 
            // textBox_Location
            // 
            textBox_Location.Location = new Point(264, 284);
            textBox_Location.Name = "textBox_Location";
            textBox_Location.Size = new Size(237, 27);
            textBox_Location.TabIndex = 3;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(12, 284);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(244, 27);
            textBox_Name.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Top;
            listView1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listView1.Location = new Point(3, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(501, 221);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2Reset);
            groupBox2.Controls.Add(button2Select);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBoxMidMark);
            groupBox2.Controls.Add(textBoxDegree);
            groupBox2.Controls.Add(textBoxEndDate);
            groupBox2.Controls.Add(textBoxStartDate);
            groupBox2.Controls.Add(textBoxSpeciality);
            groupBox2.Controls.Add(textBoxGivenTo);
            groupBox2.Controls.Add(textBoxUName);
            groupBox2.Controls.Add(listView2);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(513, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(689, 623);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Высшие образования";
            // 
            // button2Reset
            // 
            button2Reset.Location = new Point(413, 549);
            button2Reset.Name = "button2Reset";
            button2Reset.Size = new Size(169, 29);
            button2Reset.TabIndex = 16;
            button2Reset.Text = "Отменить выборку";
            button2Reset.UseVisualStyleBackColor = true;
            button2Reset.Click += button2Reset_Click;
            // 
            // button2Select
            // 
            button2Select.Location = new Point(110, 549);
            button2Select.Name = "button2Select";
            button2Select.Size = new Size(188, 29);
            button2Select.TabIndex = 15;
            button2Select.Text = "Выбрать";
            button2Select.UseVisualStyleBackColor = true;
            button2Select.Click += button2Select_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(29, 469);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 14;
            label12.Text = "Степень";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(385, 402);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 13;
            label11.Text = "Средний бал";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(385, 333);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 12;
            label10.Text = "Конец обучения";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(385, 261);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 11;
            label9.Text = "Начало обучения";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 402);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 10;
            label8.Text = "Специальность";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 333);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 9;
            label7.Text = "Кем получено";
            // 
            // label6
            // 
            label6.Location = new Point(29, 247);
            label6.Name = "label6";
            label6.Size = new Size(189, 44);
            label6.TabIndex = 8;
            label6.Text = "Университет, в котором получено образование ";
            // 
            // textBoxMidMark
            // 
            textBoxMidMark.Location = new Point(385, 426);
            textBoxMidMark.Name = "textBoxMidMark";
            textBoxMidMark.Size = new Size(241, 27);
            textBoxMidMark.TabIndex = 7;
            // 
            // textBoxDegree
            // 
            textBoxDegree.Location = new Point(29, 492);
            textBoxDegree.Name = "textBoxDegree";
            textBoxDegree.Size = new Size(250, 27);
            textBoxDegree.TabIndex = 6;
            // 
            // textBoxEndDate
            // 
            textBoxEndDate.Location = new Point(385, 357);
            textBoxEndDate.Name = "textBoxEndDate";
            textBoxEndDate.Size = new Size(241, 27);
            textBoxEndDate.TabIndex = 5;
            // 
            // textBoxStartDate
            // 
            textBoxStartDate.Location = new Point(385, 294);
            textBoxStartDate.Name = "textBoxStartDate";
            textBoxStartDate.Size = new Size(241, 27);
            textBoxStartDate.TabIndex = 4;
            // 
            // textBoxSpeciality
            // 
            textBoxSpeciality.Location = new Point(29, 426);
            textBoxSpeciality.Name = "textBoxSpeciality";
            textBoxSpeciality.Size = new Size(250, 27);
            textBoxSpeciality.TabIndex = 3;
            // 
            // textBoxGivenTo
            // 
            textBoxGivenTo.Location = new Point(29, 356);
            textBoxGivenTo.Name = "textBoxGivenTo";
            textBoxGivenTo.Size = new Size(250, 27);
            textBoxGivenTo.TabIndex = 2;
            // 
            // textBoxUName
            // 
            textBoxUName.Location = new Point(29, 294);
            textBoxUName.Name = "textBoxUName";
            textBoxUName.Size = new Size(250, 27);
            textBoxUName.TabIndex = 1;
            // 
            // listView2
            // 
            listView2.Dock = DockStyle.Top;
            listView2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listView2.Location = new Point(3, 23);
            listView2.Name = "listView2";
            listView2.Size = new Size(683, 221);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.SmallIcon;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 623);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private GroupBox groupBox2;
        private ListView listView2;
        private Button button1Select;
        private TextBox textBox_Capacity;
        private TextBox textBox_TimeClose;
        private TextBox textBox_TimeOpen;
        private TextBox textBox_Location;
        private TextBox textBox_Name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1Reset;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBoxMidMark;
        private TextBox textBoxDegree;
        private TextBox textBoxEndDate;
        private TextBox textBoxStartDate;
        private TextBox textBoxSpeciality;
        private TextBox textBoxGivenTo;
        private TextBox textBoxUName;
        private Button button2Reset;
        private Button button2Select;
    }
}
