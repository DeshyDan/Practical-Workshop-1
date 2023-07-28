namespace Practical_Workshop_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.time2Input = new System.Windows.Forms.TextBox();
            this.time3Input = new System.Windows.Forms.TextBox();
            this.time1Input = new System.Windows.Forms.TextBox();
            this.horseHeightInput = new System.Windows.Forms.TextBox();
            this.horseAgeInput = new System.Windows.Forms.TextBox();
            this.horseNameInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.predictButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.time2Input);
            this.groupBox1.Controls.Add(this.time3Input);
            this.groupBox1.Controls.Add(this.time1Input);
            this.groupBox1.Controls.Add(this.horseHeightInput);
            this.groupBox1.Controls.Add(this.horseAgeInput);
            this.groupBox1.Controls.Add(this.horseNameInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter the last three races";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(224, 141);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // time2Input
            // 
            this.time2Input.Location = new System.Drawing.Point(86, 246);
            this.time2Input.Name = "time2Input";
            this.time2Input.Size = new System.Drawing.Size(74, 22);
            this.time2Input.TabIndex = 11;
            // 
            // time3Input
            // 
            this.time3Input.Location = new System.Drawing.Point(86, 279);
            this.time3Input.Name = "time3Input";
            this.time3Input.Size = new System.Drawing.Size(74, 22);
            this.time3Input.TabIndex = 10;
            // 
            // time1Input
            // 
            this.time1Input.Location = new System.Drawing.Point(86, 210);
            this.time1Input.Name = "time1Input";
            this.time1Input.Size = new System.Drawing.Size(74, 22);
            this.time1Input.TabIndex = 9;
            // 
            // horseHeightInput
            // 
            this.horseHeightInput.Location = new System.Drawing.Point(76, 110);
            this.horseHeightInput.Name = "horseHeightInput";
            this.horseHeightInput.Size = new System.Drawing.Size(74, 22);
            this.horseHeightInput.TabIndex = 8;
            // 
            // horseAgeInput
            // 
            this.horseAgeInput.Location = new System.Drawing.Point(76, 68);
            this.horseAgeInput.Name = "horseAgeInput";
            this.horseAgeInput.Size = new System.Drawing.Size(56, 22);
            this.horseAgeInput.TabIndex = 7;
            // 
            // horseNameInput
            // 
            this.horseNameInput.Location = new System.Drawing.Point(76, 29);
            this.horseNameInput.Name = "horseNameInput";
            this.horseNameInput.Size = new System.Drawing.Size(237, 22);
            this.horseNameInput.TabIndex = 6;
            this.horseNameInput.TextChanged += new System.EventHandler(this.horseName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Time 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Time 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Time1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(354, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 484);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roster";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(657, 441);
            this.textBox1.TabIndex = 0;
            // 
            // predictButton
            // 
            this.predictButton.Location = new System.Drawing.Point(69, 401);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(183, 47);
            this.predictButton.TabIndex = 14;
            this.predictButton.Text = "Predict next winner";
            this.predictButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 522);
            this.Controls.Add(this.predictButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Workshop 1 - Revision";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox horseHeightInput;
        private System.Windows.Forms.TextBox horseAgeInput;
        private System.Windows.Forms.TextBox horseNameInput;
        private System.Windows.Forms.TextBox time2Input;
        private System.Windows.Forms.TextBox time3Input;
        private System.Windows.Forms.TextBox time1Input;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button predictButton;
    }
}

