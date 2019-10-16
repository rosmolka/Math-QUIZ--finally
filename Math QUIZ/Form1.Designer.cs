namespace Math_QUIZ
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
            this.components = new System.ComponentModel.Container();
            this.TimeLeft = new System.Windows.Forms.Button();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.NumericUpDown();
            this.multiplication = new System.Windows.Forms.NumericUpDown();
            this.division = new System.Windows.Forms.NumericUpDown();
            this.TimeLabel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.division)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLeft
            // 
            this.TimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeLeft.Location = new System.Drawing.Point(98, 15);
            this.TimeLeft.Margin = new System.Windows.Forms.Padding(6);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(177, 47);
            this.TimeLeft.TabIndex = 1;
            this.TimeLeft.Text = "Time Left";
            this.TimeLeft.UseVisualStyleBackColor = true;
            this.TimeLeft.Click += new System.EventHandler(this.TimeLeft_Click);
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AutoSize = true;
            this.plusLeftLabel.Location = new System.Drawing.Point(123, 134);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(24, 25);
            this.plusLeftLabel.TabIndex = 5;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = true;
            this.plusRightLabel.Location = new System.Drawing.Point(281, 134);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(24, 25);
            this.plusRightLabel.TabIndex = 6;
            this.plusRightLabel.Text = "?";
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AutoSize = true;
            this.minusRightLabel.Location = new System.Drawing.Point(281, 177);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(24, 25);
            this.minusRightLabel.TabIndex = 7;
            this.minusRightLabel.Text = "?";
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.AutoSize = true;
            this.timesLeftLabel.Location = new System.Drawing.Point(123, 223);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(24, 25);
            this.timesLeftLabel.TabIndex = 8;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.Click += new System.EventHandler(this.timesLeftLabel_Click);
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.AutoSize = true;
            this.minusLeftLabel.Location = new System.Drawing.Point(123, 179);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(24, 25);
            this.minusLeftLabel.TabIndex = 9;
            this.minusLeftLabel.Text = "?";
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.AutoSize = true;
            this.timesRightLabel.Location = new System.Drawing.Point(281, 223);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(24, 25);
            this.timesRightLabel.TabIndex = 10;
            this.timesRightLabel.Text = "?";
            // 
            // summary
            // 
            this.summary.AutoSize = true;
            this.summary.Location = new System.Drawing.Point(200, 134);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(24, 25);
            this.summary.TabIndex = 11;
            this.summary.Text = "+";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(396, 132);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 31);
            this.sum.TabIndex = 2;
            this.sum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "x";
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.AutoSize = true;
            this.dividedLeftLabel.Location = new System.Drawing.Point(123, 261);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(24, 25);
            this.dividedLeftLabel.TabIndex = 15;
            this.dividedLeftLabel.Text = "?";
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.AutoSize = true;
            this.dividedRightLabel.Location = new System.Drawing.Point(281, 261);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(24, 25);
            this.dividedRightLabel.TabIndex = 16;
            this.dividedRightLabel.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "÷";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(356, 296);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 39);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(396, 177);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(120, 31);
            this.subtraction.TabIndex = 3;
            this.subtraction.ValueChanged += new System.EventHandler(this.subtraction_ValueChanged);
            this.subtraction.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(396, 218);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(120, 31);
            this.multiplication.TabIndex = 4;
            this.multiplication.ValueChanged += new System.EventHandler(this.multiplication_ValueChanged);
            this.multiplication.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(396, 255);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(120, 31);
            this.division.TabIndex = 5;
            this.division.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Location = new System.Drawing.Point(314, 15);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(156, 47);
            this.TimeLabel.TabIndex = 22;
            this.TimeLabel.UseVisualStyleBackColor = true;
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(805, 376);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.TimeLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quiz matematyczny";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.division)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TimeLeft;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label summary;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown subtraction;
        private System.Windows.Forms.NumericUpDown multiplication;
        private System.Windows.Forms.NumericUpDown division;
        private System.Windows.Forms.Button TimeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

