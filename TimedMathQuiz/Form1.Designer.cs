
namespace TimedMathQuiz
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.equalsLabel1 = new System.Windows.Forms.Label();
            this.equalsLabel2 = new System.Windows.Forms.Label();
            this.subRightLabel = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.Label();
            this.subLeftLabel = new System.Windows.Forms.Label();
            this.equalsLabel3 = new System.Windows.Forms.Label();
            this.multRightLabel = new System.Windows.Forms.Label();
            this.multiply = new System.Windows.Forms.Label();
            this.multLeftLabel = new System.Windows.Forms.Label();
            this.equalsLabel4 = new System.Windows.Forms.Label();
            this.divRightLabel = new System.Windows.Forms.Label();
            this.divide = new System.Windows.Forms.Label();
            this.divLeftLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(277, 19);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftLabel.Location = new System.Drawing.Point(158, 19);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(108, 30);
            this.TimeLeftLabel.TabIndex = 1;
            this.TimeLeftLabel.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(74, 94);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusLeftLabel.Click += new System.EventHandler(this.plusLeftLabel_Click);
            // 
            // plusLabel
            // 
            this.plusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLabel.Location = new System.Drawing.Point(140, 94);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLabel.TabIndex = 3;
            this.plusLabel.Text = "+";
            this.plusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusLabel.Click += new System.EventHandler(this.plusLabel_Click);
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(206, 94);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusRightLabel.Click += new System.EventHandler(this.plusRightLabel_Click);
            // 
            // equalsLabel1
            // 
            this.equalsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel1.Location = new System.Drawing.Point(272, 94);
            this.equalsLabel1.Name = "equalsLabel1";
            this.equalsLabel1.Size = new System.Drawing.Size(60, 50);
            this.equalsLabel1.TabIndex = 5;
            this.equalsLabel1.Text = "=";
            this.equalsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.equalsLabel1.Click += new System.EventHandler(this.equalsLabel_Click);
            // 
            // equalsLabel2
            // 
            this.equalsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel2.Location = new System.Drawing.Point(272, 144);
            this.equalsLabel2.Name = "equalsLabel2";
            this.equalsLabel2.Size = new System.Drawing.Size(60, 50);
            this.equalsLabel2.TabIndex = 10;
            this.equalsLabel2.Text = "=";
            this.equalsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subRightLabel
            // 
            this.subRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRightLabel.Location = new System.Drawing.Point(206, 144);
            this.subRightLabel.Name = "subRightLabel";
            this.subRightLabel.Size = new System.Drawing.Size(60, 50);
            this.subRightLabel.TabIndex = 9;
            this.subRightLabel.Text = "?";
            this.subRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(140, 144);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 50);
            this.minus.TabIndex = 8;
            this.minus.Text = "-";
            this.minus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subLeftLabel
            // 
            this.subLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLeftLabel.Location = new System.Drawing.Point(74, 144);
            this.subLeftLabel.Name = "subLeftLabel";
            this.subLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.subLeftLabel.TabIndex = 7;
            this.subLeftLabel.Text = "?";
            this.subLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsLabel3
            // 
            this.equalsLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel3.Location = new System.Drawing.Point(272, 194);
            this.equalsLabel3.Name = "equalsLabel3";
            this.equalsLabel3.Size = new System.Drawing.Size(60, 50);
            this.equalsLabel3.TabIndex = 15;
            this.equalsLabel3.Text = "=";
            this.equalsLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multRightLabel
            // 
            this.multRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multRightLabel.Location = new System.Drawing.Point(206, 194);
            this.multRightLabel.Name = "multRightLabel";
            this.multRightLabel.Size = new System.Drawing.Size(60, 50);
            this.multRightLabel.TabIndex = 14;
            this.multRightLabel.Text = "?";
            this.multRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(140, 193);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 50);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "X";
            this.multiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multLeftLabel
            // 
            this.multLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multLeftLabel.Location = new System.Drawing.Point(74, 194);
            this.multLeftLabel.Name = "multLeftLabel";
            this.multLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.multLeftLabel.TabIndex = 12;
            this.multLeftLabel.Text = "?";
            this.multLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsLabel4
            // 
            this.equalsLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel4.Location = new System.Drawing.Point(272, 244);
            this.equalsLabel4.Name = "equalsLabel4";
            this.equalsLabel4.Size = new System.Drawing.Size(60, 50);
            this.equalsLabel4.TabIndex = 20;
            this.equalsLabel4.Text = "=";
            this.equalsLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divRightLabel
            // 
            this.divRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRightLabel.Location = new System.Drawing.Point(206, 244);
            this.divRightLabel.Name = "divRightLabel";
            this.divRightLabel.Size = new System.Drawing.Size(60, 50);
            this.divRightLabel.TabIndex = 19;
            this.divRightLabel.Text = "?";
            this.divRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(140, 244);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 50);
            this.divide.TabIndex = 18;
            this.divide.Text = "/";
            this.divide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divLeftLabel
            // 
            this.divLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divLeftLabel.Location = new System.Drawing.Point(74, 244);
            this.divLeftLabel.Name = "divLeftLabel";
            this.divLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.divLeftLabel.TabIndex = 17;
            this.divLeftLabel.Text = "?";
            this.divLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(337, 103);
            this.sum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 2;
            this.sum.ValueChanged += new System.EventHandler(this.Sum_ValueChanged);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(337, 153);
            this.difference.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 3;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(337, 203);
            this.product.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 4;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(337, 253);
            this.quotient.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(171, 297);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(131, 34);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.equalsLabel4);
            this.Controls.Add(this.divRightLabel);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.product);
            this.Controls.Add(this.divLeftLabel);
            this.Controls.Add(this.equalsLabel3);
            this.Controls.Add(this.multRightLabel);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.multLeftLabel);
            this.Controls.Add(this.equalsLabel2);
            this.Controls.Add(this.subRightLabel);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.subLeftLabel);
            this.Controls.Add(this.equalsLabel1);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label equalsLabel1;
        private System.Windows.Forms.Label equalsLabel2;
        private System.Windows.Forms.Label subRightLabel;
        private System.Windows.Forms.Label minus;
        private System.Windows.Forms.Label subLeftLabel;
        private System.Windows.Forms.Label equalsLabel3;
        private System.Windows.Forms.Label multRightLabel;
        private System.Windows.Forms.Label multiply;
        private System.Windows.Forms.Label multLeftLabel;
        private System.Windows.Forms.Label equalsLabel4;
        private System.Windows.Forms.Label divRightLabel;
        private System.Windows.Forms.Label divide;
        private System.Windows.Forms.Label divLeftLabel;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

