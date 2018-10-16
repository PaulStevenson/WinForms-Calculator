namespace SimpleCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numberOne = new System.Windows.Forms.Button();
            this.numberTwo = new System.Windows.Forms.Button();
            this.numberThree = new System.Windows.Forms.Button();
            this.numberFour = new System.Windows.Forms.Button();
            this.numberFive = new System.Windows.Forms.Button();
            this.numberSix = new System.Windows.Forms.Button();
            this.numberNine = new System.Windows.Forms.Button();
            this.numberSeven = new System.Windows.Forms.Button();
            this.numberEight = new System.Windows.Forms.Button();
            this.numberZero = new System.Windows.Forms.Button();
            this.dudButton = new System.Windows.Forms.Button();
            this.multiplyOperator = new System.Windows.Forms.Button();
            this.minusOperator = new System.Windows.Forms.Button();
            this.equalsOperator = new System.Windows.Forms.Button();
            this.plusOperator = new System.Windows.Forms.Button();
            this.divideOperator = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numberOne
            // 
            this.numberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOne.Location = new System.Drawing.Point(0, 74);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(75, 23);
            this.numberOne.TabIndex = 2;
            this.numberOne.Text = "1";
            this.numberOne.UseVisualStyleBackColor = true;
            this.numberOne.Click += new System.EventHandler(this.numberOne_Click);
            // 
            // numberTwo
            // 
            this.numberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTwo.Location = new System.Drawing.Point(81, 74);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(75, 23);
            this.numberTwo.TabIndex = 3;
            this.numberTwo.Text = "2";
            this.numberTwo.UseVisualStyleBackColor = true;
            this.numberTwo.Click += new System.EventHandler(this.numberTwo_Click);
            // 
            // numberThree
            // 
            this.numberThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberThree.Location = new System.Drawing.Point(162, 74);
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(75, 23);
            this.numberThree.TabIndex = 4;
            this.numberThree.Text = "3";
            this.numberThree.UseVisualStyleBackColor = true;
            this.numberThree.Click += new System.EventHandler(this.numberThree_Click);
            // 
            // numberFour
            // 
            this.numberFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberFour.Location = new System.Drawing.Point(0, 103);
            this.numberFour.Name = "numberFour";
            this.numberFour.Size = new System.Drawing.Size(75, 23);
            this.numberFour.TabIndex = 5;
            this.numberFour.Text = "4";
            this.numberFour.UseVisualStyleBackColor = true;
            this.numberFour.Click += new System.EventHandler(this.numberFour_Click);
            // 
            // numberFive
            // 
            this.numberFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberFive.Location = new System.Drawing.Point(81, 103);
            this.numberFive.Name = "numberFive";
            this.numberFive.Size = new System.Drawing.Size(75, 23);
            this.numberFive.TabIndex = 6;
            this.numberFive.Text = "5";
            this.numberFive.UseVisualStyleBackColor = true;
            this.numberFive.Click += new System.EventHandler(this.numberFive_Click);
            // 
            // numberSix
            // 
            this.numberSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSix.Location = new System.Drawing.Point(162, 103);
            this.numberSix.Name = "numberSix";
            this.numberSix.Size = new System.Drawing.Size(75, 23);
            this.numberSix.TabIndex = 7;
            this.numberSix.Text = "6";
            this.numberSix.UseVisualStyleBackColor = true;
            this.numberSix.Click += new System.EventHandler(this.numberSix_Click);
            // 
            // numberNine
            // 
            this.numberNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberNine.Location = new System.Drawing.Point(162, 132);
            this.numberNine.Name = "numberNine";
            this.numberNine.Size = new System.Drawing.Size(75, 23);
            this.numberNine.TabIndex = 9;
            this.numberNine.Text = "9";
            this.numberNine.UseVisualStyleBackColor = true;
            this.numberNine.Click += new System.EventHandler(this.numberNine_Click);
            // 
            // numberSeven
            // 
            this.numberSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSeven.Location = new System.Drawing.Point(0, 132);
            this.numberSeven.Name = "numberSeven";
            this.numberSeven.Size = new System.Drawing.Size(75, 23);
            this.numberSeven.TabIndex = 10;
            this.numberSeven.Text = "7";
            this.numberSeven.UseVisualStyleBackColor = true;
            this.numberSeven.Click += new System.EventHandler(this.numberSeven_Click);
            // 
            // numberEight
            // 
            this.numberEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberEight.Location = new System.Drawing.Point(81, 132);
            this.numberEight.Name = "numberEight";
            this.numberEight.Size = new System.Drawing.Size(75, 23);
            this.numberEight.TabIndex = 11;
            this.numberEight.Text = "8";
            this.numberEight.UseVisualStyleBackColor = true;
            this.numberEight.Click += new System.EventHandler(this.numberEight_Click);
            // 
            // numberZero
            // 
            this.numberZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberZero.Location = new System.Drawing.Point(81, 161);
            this.numberZero.Name = "numberZero";
            this.numberZero.Size = new System.Drawing.Size(75, 23);
            this.numberZero.TabIndex = 12;
            this.numberZero.Text = "0";
            this.numberZero.UseVisualStyleBackColor = true;
            this.numberZero.Click += new System.EventHandler(this.numberZero_Click);
            // 
            // dudButton
            // 
            this.dudButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudButton.Location = new System.Drawing.Point(0, 161);
            this.dudButton.Name = "dudButton";
            this.dudButton.Size = new System.Drawing.Size(75, 23);
            this.dudButton.TabIndex = 13;
            this.dudButton.Text = "Modulus";
            this.dudButton.UseVisualStyleBackColor = true;
            this.dudButton.Click += new System.EventHandler(this.dudButton_Click);
            // 
            // multiplyOperator
            // 
            this.multiplyOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyOperator.Location = new System.Drawing.Point(243, 103);
            this.multiplyOperator.Name = "multiplyOperator";
            this.multiplyOperator.Size = new System.Drawing.Size(75, 23);
            this.multiplyOperator.TabIndex = 15;
            this.multiplyOperator.Text = "X";
            this.multiplyOperator.UseVisualStyleBackColor = true;
            this.multiplyOperator.Click += new System.EventHandler(this.multiplyOperator_Click);
            // 
            // minusOperator
            // 
            this.minusOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusOperator.Location = new System.Drawing.Point(243, 74);
            this.minusOperator.Name = "minusOperator";
            this.minusOperator.Size = new System.Drawing.Size(75, 23);
            this.minusOperator.TabIndex = 16;
            this.minusOperator.Text = "-";
            this.minusOperator.UseVisualStyleBackColor = true;
            this.minusOperator.Click += new System.EventHandler(this.minusOperator_Click);
            // 
            // equalsOperator
            // 
            this.equalsOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsOperator.Location = new System.Drawing.Point(243, 161);
            this.equalsOperator.Name = "equalsOperator";
            this.equalsOperator.Size = new System.Drawing.Size(75, 23);
            this.equalsOperator.TabIndex = 18;
            this.equalsOperator.Text = "=";
            this.equalsOperator.UseVisualStyleBackColor = true;
            this.equalsOperator.Click += new System.EventHandler(this.equalsOperator_Click);
            // 
            // plusOperator
            // 
            this.plusOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusOperator.Location = new System.Drawing.Point(243, 45);
            this.plusOperator.Name = "plusOperator";
            this.plusOperator.Size = new System.Drawing.Size(75, 23);
            this.plusOperator.TabIndex = 20;
            this.plusOperator.Text = "+";
            this.plusOperator.UseVisualStyleBackColor = true;
            this.plusOperator.Click += new System.EventHandler(this.plusOperator_Click);
            // 
            // divideOperator
            // 
            this.divideOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideOperator.Location = new System.Drawing.Point(243, 132);
            this.divideOperator.Name = "divideOperator";
            this.divideOperator.Size = new System.Drawing.Size(75, 23);
            this.divideOperator.TabIndex = 21;
            this.divideOperator.Text = "/";
            this.divideOperator.UseVisualStyleBackColor = true;
            this.divideOperator.Click += new System.EventHandler(this.divideOperator_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(0, 45);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(237, 23);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "CLEAR OPERATION";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(162, 161);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(75, 23);
            this.decimalButton.TabIndex = 23;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 188);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divideOperator);
            this.Controls.Add(this.plusOperator);
            this.Controls.Add(this.equalsOperator);
            this.Controls.Add(this.minusOperator);
            this.Controls.Add(this.multiplyOperator);
            this.Controls.Add(this.dudButton);
            this.Controls.Add(this.numberZero);
            this.Controls.Add(this.numberEight);
            this.Controls.Add(this.numberSeven);
            this.Controls.Add(this.numberNine);
            this.Controls.Add(this.numberSix);
            this.Controls.Add(this.numberFive);
            this.Controls.Add(this.numberFour);
            this.Controls.Add(this.numberThree);
            this.Controls.Add(this.numberTwo);
            this.Controls.Add(this.numberOne);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Input Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button numberOne;
        private System.Windows.Forms.Button numberTwo;
        private System.Windows.Forms.Button numberThree;
        private System.Windows.Forms.Button numberFour;
        private System.Windows.Forms.Button numberFive;
        private System.Windows.Forms.Button numberSix;
        private System.Windows.Forms.Button numberNine;
        private System.Windows.Forms.Button numberSeven;
        private System.Windows.Forms.Button numberEight;
        private System.Windows.Forms.Button numberZero;
        private System.Windows.Forms.Button dudButton;
        private System.Windows.Forms.Button multiplyOperator;
        private System.Windows.Forms.Button minusOperator;
        private System.Windows.Forms.Button equalsOperator;
        private System.Windows.Forms.Button plusOperator;
        private System.Windows.Forms.Button divideOperator;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button decimalButton;
    }
}

