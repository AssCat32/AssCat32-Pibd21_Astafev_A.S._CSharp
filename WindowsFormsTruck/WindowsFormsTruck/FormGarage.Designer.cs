namespace WindowsFormsTruck
{
    partial class FormGarage
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
            this.buttonSetTruck = new System.Windows.Forms.Button();
            this.buttonSetDumpTruck = new System.Windows.Forms.Button();
            this.maskedBox = new System.Windows.Forms.GroupBox();
            this.buttonTakeTruck = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxGarage = new System.Windows.Forms.PictureBox();
            this.maskedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetTruck
            // 
            this.buttonSetTruck.Location = new System.Drawing.Point(746, 12);
            this.buttonSetTruck.Name = "buttonSetTruck";
            this.buttonSetTruck.Size = new System.Drawing.Size(129, 63);
            this.buttonSetTruck.TabIndex = 1;
            this.buttonSetTruck.Text = "Припарковать грузовик";
            this.buttonSetTruck.UseVisualStyleBackColor = true;
            this.buttonSetTruck.Click += new System.EventHandler(this.buttonSetTruck_Click);
            // 
            // buttonSetDumpTruck
            // 
            this.buttonSetDumpTruck.Location = new System.Drawing.Point(747, 81);
            this.buttonSetDumpTruck.Name = "buttonSetDumpTruck";
            this.buttonSetDumpTruck.Size = new System.Drawing.Size(128, 63);
            this.buttonSetDumpTruck.TabIndex = 2;
            this.buttonSetDumpTruck.Text = "Припарковать самосвал";
            this.buttonSetDumpTruck.UseVisualStyleBackColor = true;
            this.buttonSetDumpTruck.Click += new System.EventHandler(this.buttonSetDumpTruck_Click);
            // 
            // maskedBox
            // 
            this.maskedBox.Controls.Add(this.buttonTakeTruck);
            this.maskedBox.Controls.Add(this.maskedTextBox);
            this.maskedBox.Controls.Add(this.label1);
            this.maskedBox.Location = new System.Drawing.Point(747, 150);
            this.maskedBox.Name = "maskedBox";
            this.maskedBox.Size = new System.Drawing.Size(128, 92);
            this.maskedBox.TabIndex = 3;
            this.maskedBox.TabStop = false;
            this.maskedBox.Text = "Забрать машину";
            this.maskedBox.UseCompatibleTextRendering = true;
            // 
            // buttonTakeTruck
            // 
            this.buttonTakeTruck.Location = new System.Drawing.Point(28, 66);
            this.buttonTakeTruck.Name = "buttonTakeTruck";
            this.buttonTakeTruck.Size = new System.Drawing.Size(73, 20);
            this.buttonTakeTruck.TabIndex = 6;
            this.buttonTakeTruck.Text = "Забрать";
            this.buttonTakeTruck.UseVisualStyleBackColor = true;
            this.buttonTakeTruck.Click += new System.EventHandler(this.buttonTakeTruck_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(54, 29);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Место:";
            // 
            // pictureBoxGarage
            // 
            this.pictureBoxGarage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxGarage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxGarage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGarage.Name = "pictureBoxGarage";
            this.pictureBoxGarage.Size = new System.Drawing.Size(740, 461);
            this.pictureBoxGarage.TabIndex = 0;
            this.pictureBoxGarage.TabStop = false;
            // 
            // FormGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.maskedBox);
            this.Controls.Add(this.buttonSetDumpTruck);
            this.Controls.Add(this.buttonSetTruck);
            this.Controls.Add(this.pictureBoxGarage);
            this.Name = "FormGarage";
            this.Text = "Гаражи";
            this.Load += new System.EventHandler(this.FormGarage_Load);
            this.maskedBox.ResumeLayout(false);
            this.maskedBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGarage;
        private System.Windows.Forms.Button buttonSetTruck;
        private System.Windows.Forms.Button buttonSetDumpTruck;
        private System.Windows.Forms.GroupBox maskedBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTakeTruck;
    }
}