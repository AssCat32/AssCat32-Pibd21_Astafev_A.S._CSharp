namespace WindowsFormsTruck
{
    partial class FormTruckConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDumpTruck = new System.Windows.Forms.Label();
            this.labelTruck = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxTruck = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.mainColor = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDumpTruck);
            this.groupBox1.Controls.Add(this.labelTruck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип грузовика";
            // 
            // labelDumpTruck
            // 
            this.labelDumpTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDumpTruck.Location = new System.Drawing.Point(26, 67);
            this.labelDumpTruck.Name = "labelDumpTruck";
            this.labelDumpTruck.Size = new System.Drawing.Size(73, 34);
            this.labelDumpTruck.TabIndex = 7;
            this.labelDumpTruck.Text = "Самосвал";
            this.labelDumpTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDumpTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDumpTruck_ClickDown);
            // 
            // labelTruck
            // 
            this.labelTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTruck.Location = new System.Drawing.Point(26, 27);
            this.labelTruck.Name = "labelTruck";
            this.labelTruck.Size = new System.Drawing.Size(73, 31);
            this.labelTruck.TabIndex = 6;
            this.labelTruck.Text = "Грузовик";
            this.labelTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTruck_ClickDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(159, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Груз";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(159, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Прицеп";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(32, 79);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(32, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс. скорость:";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.pictureBoxTruck);
            this.panel1.Location = new System.Drawing.Point(163, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 114);
            this.panel1.TabIndex = 3;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragEnter);
            // 
            // pictureBoxTruck
            // 
            this.pictureBoxTruck.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxTruck.Name = "pictureBoxTruck";
            this.pictureBoxTruck.Size = new System.Drawing.Size(181, 108);
            this.pictureBoxTruck.TabIndex = 0;
            this.pictureBoxTruck.TabStop = false;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.mainColor);
            this.groupBoxColor.Controls.Add(this.panel9);
            this.groupBoxColor.Controls.Add(this.panel8);
            this.groupBoxColor.Controls.Add(this.panel7);
            this.groupBoxColor.Controls.Add(this.panel6);
            this.groupBoxColor.Controls.Add(this.panel5);
            this.groupBoxColor.Controls.Add(this.panel4);
            this.groupBoxColor.Controls.Add(this.panel3);
            this.groupBoxColor.Controls.Add(this.panel2);
            this.groupBoxColor.Location = new System.Drawing.Point(369, 16);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(200, 194);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(112, 23);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(81, 23);
            this.labelDopColor.TabIndex = 9;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainColor_DragEnter);
            // 
            // mainColor
            // 
            this.mainColor.AllowDrop = true;
            this.mainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainColor.Location = new System.Drawing.Point(6, 23);
            this.mainColor.Name = "mainColor";
            this.mainColor.Size = new System.Drawing.Size(100, 23);
            this.mainColor.TabIndex = 8;
            this.mainColor.Text = "Основый цвет";
            this.mainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainColor.Click += new System.EventHandler(this.mainColor_Click);
            this.mainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainColor_DragDrop);
            this.mainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainColor_DragEnter);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Pink;
            this.panel9.Location = new System.Drawing.Point(142, 103);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(34, 34);
            this.panel9.TabIndex = 7;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Orange;
            this.panel8.Location = new System.Drawing.Point(102, 103);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(34, 34);
            this.panel8.TabIndex = 6;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Violet;
            this.panel7.Location = new System.Drawing.Point(62, 103);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(34, 34);
            this.panel7.TabIndex = 5;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Location = new System.Drawing.Point(22, 103);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(34, 34);
            this.panel6.TabIndex = 4;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Location = new System.Drawing.Point(142, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(34, 34);
            this.panel5.TabIndex = 3;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(102, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 34);
            this.panel4.TabIndex = 2;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(62, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 34);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(22, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 34);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(494, 216);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(494, 247);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Отмена";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // FormTruckConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 287);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTruckConfig";
            this.Text = "FormTruckConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTruck;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDumpTruck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxTruck;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Label mainColor;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReset;
    }
}