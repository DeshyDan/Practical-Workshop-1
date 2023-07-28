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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.horseName = new System.Windows.Forms.TextBox();
            this.horseAge = new System.Windows.Forms.TextBox();
            this.horseHeight = new System.Windows.Forms.TextBox();
            this.time1 = new System.Windows.Forms.TextBox();
            this.time3 = new System.Windows.Forms.TextBox();
            this.time2 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.predictButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.time2);
            this.groupBox1.Controls.Add(this.time3);
            this.groupBox1.Controls.Add(this.time1);
            this.groupBox1.Controls.Add(this.horseHeight);
            this.groupBox1.Controls.Add(this.horseAge);
            this.groupBox1.Controls.Add(this.horseName);
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(657, 441);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Time 3";
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
            // horseName
            // 
            this.horseName.Location = new System.Drawing.Point(76, 29);
            this.horseName.Name = "horseName";
            this.horseName.Size = new System.Drawing.Size(237, 22);
            this.horseName.TabIndex = 6;
            // 
            // horseAge
            // 
            this.horseAge.Location = new System.Drawing.Point(76, 68);
            this.horseAge.Name = "horseAge";
            this.horseAge.Size = new System.Drawing.Size(56, 22);
            this.horseAge.TabIndex = 7;
            // 
            // horseHeight
            // 
            this.horseHeight.Location = new System.Drawing.Point(76, 110);
            this.horseHeight.Name = "horseHeight";
            this.horseHeight.Size = new System.Drawing.Size(74, 22);
            this.horseHeight.TabIndex = 8;
            // 
            // time1
            // 
            this.time1.Location = new System.Drawing.Point(86, 210);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(74, 22);
            this.time1.TabIndex = 9;
            // 
            // time3
            // 
            this.time3.Location = new System.Drawing.Point(86, 279);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(74, 22);
            this.time3.TabIndex = 10;
            this.time3.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // time2
            // 
            this.time2.Location = new System.Drawing.Point(86, 246);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(74, 22);
            this.time2.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(224, 141);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter the last three races";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // predictButton
            // 
            this.predictButton.Location = new System.Drawing.Point(69, 401);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(183, 47);
            this.predictButton.TabIndex = 14;
            this.predictButton.Text = "Predict next winner";
            this.predictButton.UseVisualStyleBackColor = true;
            this.predictButton.Click += new System.EventHandler(this.button1_Click_1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox horseHeight;
        private System.Windows.Forms.TextBox horseAge;
        private System.Windows.Forms.TextBox horseName;
        private System.Windows.Forms.TextBox time2;
        private System.Windows.Forms.TextBox time3;
        private System.Windows.Forms.TextBox time1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button predictButton;
    }
}

