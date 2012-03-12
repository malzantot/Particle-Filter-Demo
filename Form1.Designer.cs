namespace FastSLAM
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumParticles = new System.Windows.Forms.TextBox();
            this.txtStepSize = new System.Windows.Forms.TextBox();
            this.txtOrientation = new System.Windows.Forms.TextBox();
            this.txtStepNoise = new System.Windows.Forms.TextBox();
            this.txtOrientationNoise = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.rbDiagonal = new System.Windows.Forms.RadioButton();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.panel1 = new FastSLAM.MapControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Initialize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Animate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(673, 225);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(75, 23);
            this.btnStep.TabIndex = 4;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Particles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Step Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oreintation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Step noise";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Orientation noise";
            // 
            // txtNumParticles
            // 
            this.txtNumParticles.Location = new System.Drawing.Point(762, 27);
            this.txtNumParticles.Name = "txtNumParticles";
            this.txtNumParticles.Size = new System.Drawing.Size(103, 20);
            this.txtNumParticles.TabIndex = 6;
            this.txtNumParticles.Leave += new System.EventHandler(this.text_configuration_updated);
            // 
            // txtStepSize
            // 
            this.txtStepSize.Location = new System.Drawing.Point(762, 65);
            this.txtStepSize.Name = "txtStepSize";
            this.txtStepSize.Size = new System.Drawing.Size(103, 20);
            this.txtStepSize.TabIndex = 6;
            this.txtStepSize.Leave += new System.EventHandler(this.text_configuration_updated);
            // 
            // txtOrientation
            // 
            this.txtOrientation.Location = new System.Drawing.Point(762, 91);
            this.txtOrientation.Name = "txtOrientation";
            this.txtOrientation.Size = new System.Drawing.Size(103, 20);
            this.txtOrientation.TabIndex = 6;
            this.txtOrientation.Leave += new System.EventHandler(this.text_configuration_updated);
            // 
            // txtStepNoise
            // 
            this.txtStepNoise.Location = new System.Drawing.Point(762, 123);
            this.txtStepNoise.Name = "txtStepNoise";
            this.txtStepNoise.Size = new System.Drawing.Size(103, 20);
            this.txtStepNoise.TabIndex = 6;
            this.txtStepNoise.Leave += new System.EventHandler(this.text_configuration_updated);
            // 
            // txtOrientationNoise
            // 
            this.txtOrientationNoise.Location = new System.Drawing.Point(762, 153);
            this.txtOrientationNoise.Name = "txtOrientationNoise";
            this.txtOrientationNoise.Size = new System.Drawing.Size(103, 20);
            this.txtOrientationNoise.TabIndex = 6;
            this.txtOrientationNoise.Leave += new System.EventHandler(this.text_configuration_updated);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(762, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRandom);
            this.groupBox1.Controls.Add(this.rbEqual);
            this.groupBox1.Controls.Add(this.rbDiagonal);
            this.groupBox1.Controls.Add(this.rbTop);
            this.groupBox1.Controls.Add(this.rbRight);
            this.groupBox1.Location = new System.Drawing.Point(665, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weights assignment";
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(17, 69);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(181, 17);
            this.rbRight.TabIndex = 0;
            this.rbRight.Text = "Right most particles will be higher";
            this.rbRight.UseVisualStyleBackColor = true;
            this.rbRight.CheckedChanged += new System.EventHandler(this.text_configuration_updated);
            // 
            // rbTop
            // 
            this.rbTop.AutoSize = true;
            this.rbTop.Location = new System.Drawing.Point(17, 92);
            this.rbTop.Name = "rbTop";
            this.rbTop.Size = new System.Drawing.Size(175, 17);
            this.rbTop.TabIndex = 1;
            this.rbTop.Text = "Top most particles will be higher";
            this.rbTop.UseVisualStyleBackColor = true;
            this.rbTop.CheckedChanged += new System.EventHandler(this.text_configuration_updated);
            // 
            // rbDiagonal
            // 
            this.rbDiagonal.AutoSize = true;
            this.rbDiagonal.Location = new System.Drawing.Point(17, 115);
            this.rbDiagonal.Name = "rbDiagonal";
            this.rbDiagonal.Size = new System.Drawing.Size(178, 17);
            this.rbDiagonal.TabIndex = 2;
            this.rbDiagonal.Text = "Diagonals particles will be higher";
            this.rbDiagonal.UseVisualStyleBackColor = true;
            this.rbDiagonal.CheckedChanged += new System.EventHandler(this.text_configuration_updated);
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.Checked = true;
            this.rbEqual.Location = new System.Drawing.Point(17, 19);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(122, 17);
            this.rbEqual.TabIndex = 3;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "All weights are equal";
            this.rbEqual.UseVisualStyleBackColor = true;
            this.rbEqual.CheckedChanged += new System.EventHandler(this.text_configuration_updated);
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(17, 42);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(174, 17);
            this.rbRandom.TabIndex = 3;
            this.rbRandom.Text = "Random weights for all particles";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.text_configuration_updated);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 391);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOrientationNoise);
            this.Controls.Add(this.txtStepNoise);
            this.Controls.Add(this.txtOrientation);
            this.Controls.Add(this.txtStepSize);
            this.Controls.Add(this.txtNumParticles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Particle Filter Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumParticles;
        private System.Windows.Forms.TextBox txtStepSize;
        private System.Windows.Forms.TextBox txtOrientation;
        private System.Windows.Forms.TextBox txtStepNoise;
        private System.Windows.Forms.TextBox txtOrientationNoise;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.RadioButton rbDiagonal;
        private System.Windows.Forms.RadioButton rbTop;
        private System.Windows.Forms.RadioButton rbRight;
    }
}

