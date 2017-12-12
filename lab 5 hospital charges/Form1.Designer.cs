namespace lab_5_hospital_charges
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.daysChargesTextbox = new System.Windows.Forms.TextBox();
            this.medChargesTextBox = new System.Windows.Forms.TextBox();
            this.surgChargesTextBox = new System.Windows.Forms.TextBox();
            this.labChargesTextBox = new System.Windows.Forms.TextBox();
            this.rehabChargsTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.totalDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The number of days spent in the hospital:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "The amount of medication charges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "The amount of surgical charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "The amounut of lab fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "The amount of physical rehabilitation charges:";
            // 
            // daysChargesTextbox
            // 
            this.daysChargesTextbox.Location = new System.Drawing.Point(240, 56);
            this.daysChargesTextbox.Name = "daysChargesTextbox";
            this.daysChargesTextbox.Size = new System.Drawing.Size(100, 20);
            this.daysChargesTextbox.TabIndex = 5;
            // 
            // medChargesTextBox
            // 
            this.medChargesTextBox.Location = new System.Drawing.Point(213, 97);
            this.medChargesTextBox.Name = "medChargesTextBox";
            this.medChargesTextBox.Size = new System.Drawing.Size(100, 20);
            this.medChargesTextBox.TabIndex = 6;
            // 
            // surgChargesTextBox
            // 
            this.surgChargesTextBox.Location = new System.Drawing.Point(198, 136);
            this.surgChargesTextBox.Name = "surgChargesTextBox";
            this.surgChargesTextBox.Size = new System.Drawing.Size(100, 20);
            this.surgChargesTextBox.TabIndex = 7;
            // 
            // labChargesTextBox
            // 
            this.labChargesTextBox.Location = new System.Drawing.Point(175, 179);
            this.labChargesTextBox.Name = "labChargesTextBox";
            this.labChargesTextBox.Size = new System.Drawing.Size(100, 20);
            this.labChargesTextBox.TabIndex = 8;
            // 
            // rehabChargsTextBox
            // 
            this.rehabChargsTextBox.Location = new System.Drawing.Point(262, 18);
            this.rehabChargsTextBox.Name = "rehabChargsTextBox";
            this.rehabChargsTextBox.Size = new System.Drawing.Size(100, 20);
            this.rehabChargsTextBox.TabIndex = 9;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(101, 237);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 46);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "Calculate total";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(182, 237);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 46);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(33, 212);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 12;
            this.Total.Text = "Total:";
            // 
            // totalDisplayLabel
            // 
            this.totalDisplayLabel.Location = new System.Drawing.Point(89, 212);
            this.totalDisplayLabel.Name = "totalDisplayLabel";
            this.totalDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.totalDisplayLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 295);
            this.Controls.Add(this.totalDisplayLabel);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.rehabChargsTextBox);
            this.Controls.Add(this.labChargesTextBox);
            this.Controls.Add(this.surgChargesTextBox);
            this.Controls.Add(this.medChargesTextBox);
            this.Controls.Add(this.daysChargesTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox daysChargesTextbox;
        private System.Windows.Forms.TextBox medChargesTextBox;
        private System.Windows.Forms.TextBox surgChargesTextBox;
        private System.Windows.Forms.TextBox labChargesTextBox;
        private System.Windows.Forms.TextBox rehabChargsTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label totalDisplayLabel;
    }
}

