namespace ColorMixer
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
            this.redR1 = new System.Windows.Forms.RadioButton();
            this.yellowR1 = new System.Windows.Forms.RadioButton();
            this.blueR1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.blueR2 = new System.Windows.Forms.RadioButton();
            this.yellowR2 = new System.Windows.Forms.RadioButton();
            this.redR2 = new System.Windows.Forms.RadioButton();
            this.doneBtn = new System.Windows.Forms.Button();
            this.mixItBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blueR1);
            this.groupBox1.Controls.Add(this.yellowR1);
            this.groupBox1.Controls.Add(this.redR1);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose color 1:";
            // 
            // redR1
            // 
            this.redR1.AutoSize = true;
            this.redR1.Location = new System.Drawing.Point(15, 54);
            this.redR1.Name = "redR1";
            this.redR1.Size = new System.Drawing.Size(45, 17);
            this.redR1.TabIndex = 0;
            this.redR1.TabStop = true;
            this.redR1.Text = "Red";
            this.redR1.UseVisualStyleBackColor = true;
            // 
            // yellowR1
            // 
            this.yellowR1.AutoSize = true;
            this.yellowR1.Location = new System.Drawing.Point(15, 93);
            this.yellowR1.Name = "yellowR1";
            this.yellowR1.Size = new System.Drawing.Size(56, 17);
            this.yellowR1.TabIndex = 1;
            this.yellowR1.TabStop = true;
            this.yellowR1.Text = "Yellow";
            this.yellowR1.UseVisualStyleBackColor = true;
            // 
            // blueR1
            // 
            this.blueR1.AutoSize = true;
            this.blueR1.Location = new System.Drawing.Point(15, 132);
            this.blueR1.Name = "blueR1";
            this.blueR1.Size = new System.Drawing.Size(46, 17);
            this.blueR1.TabIndex = 2;
            this.blueR1.TabStop = true;
            this.blueR1.Text = "Blue";
            this.blueR1.UseVisualStyleBackColor = true;
            this.blueR1.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.blueR2);
            this.groupBox3.Controls.Add(this.yellowR2);
            this.groupBox3.Controls.Add(this.redR2);
            this.groupBox3.Location = new System.Drawing.Point(177, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 181);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose color 2:";
            // 
            // blueR2
            // 
            this.blueR2.AutoSize = true;
            this.blueR2.Location = new System.Drawing.Point(15, 132);
            this.blueR2.Name = "blueR2";
            this.blueR2.Size = new System.Drawing.Size(46, 17);
            this.blueR2.TabIndex = 2;
            this.blueR2.TabStop = true;
            this.blueR2.Text = "Blue";
            this.blueR2.UseVisualStyleBackColor = true;
            // 
            // yellowR2
            // 
            this.yellowR2.AutoSize = true;
            this.yellowR2.Location = new System.Drawing.Point(15, 93);
            this.yellowR2.Name = "yellowR2";
            this.yellowR2.Size = new System.Drawing.Size(56, 17);
            this.yellowR2.TabIndex = 1;
            this.yellowR2.TabStop = true;
            this.yellowR2.Text = "Yellow";
            this.yellowR2.UseVisualStyleBackColor = true;
            // 
            // redR2
            // 
            this.redR2.AutoSize = true;
            this.redR2.Location = new System.Drawing.Point(15, 54);
            this.redR2.Name = "redR2";
            this.redR2.Size = new System.Drawing.Size(45, 17);
            this.redR2.TabIndex = 0;
            this.redR2.TabStop = true;
            this.redR2.Text = "Red";
            this.redR2.UseVisualStyleBackColor = true;
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(192, 262);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 2;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // mixItBtn
            // 
            this.mixItBtn.Location = new System.Drawing.Point(49, 262);
            this.mixItBtn.Name = "mixItBtn";
            this.mixItBtn.Size = new System.Drawing.Size(75, 23);
            this.mixItBtn.TabIndex = 3;
            this.mixItBtn.Text = "Mix it up";
            this.mixItBtn.UseVisualStyleBackColor = true;
            this.mixItBtn.Click += new System.EventHandler(this.mixItBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(325, 338);
            this.Controls.Add(this.mixItBtn);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.RadioButton yellowRadio1;
        private System.Windows.Forms.RadioButton redRadio1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton yellowRadio2;
        private System.Windows.Forms.RadioButton redRadio2;
        private System.Windows.Forms.Button mixBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.RadioButton blueRadio1;
        private System.Windows.Forms.RadioButton blueRadio2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton blueR1;
        private System.Windows.Forms.RadioButton yellowR1;
        private System.Windows.Forms.RadioButton redR1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton blueR2;
        private System.Windows.Forms.RadioButton yellowR2;
        private System.Windows.Forms.RadioButton redR2;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button mixItBtn;
    }
}

