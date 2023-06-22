namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMinus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.btnMultibly = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.viewText = new System.Windows.Forms.TextBox();
            this.viewLabel = new System.Windows.Forms.Label();
            this.btnCleanNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.DarkGray;
            this.btnMinus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(12, 443);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(70, 70);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.Text = "+/-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            this.btnMinus.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.btnMinus.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.DarkGray;
            this.zero.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.Color.White;
            this.zero.Location = new System.Drawing.Point(88, 443);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(70, 70);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Button_Click);
            this.zero.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.zero.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.DarkGray;
            this.dot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.ForeColor = System.Drawing.Color.White;
            this.dot.Location = new System.Drawing.Point(164, 442);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(70, 70);
            this.dot.TabIndex = 2;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            this.dot.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.dot.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Purple;
            this.btnEqual.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.Black;
            this.btnEqual.Location = new System.Drawing.Point(240, 442);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(70, 70);
            this.btnEqual.TabIndex = 3;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            this.btnEqual.MouseEnter += new System.EventHandler(this.btnEqual_MouseEnter);
            this.btnEqual.MouseLeave += new System.EventHandler(this.btnEqual_MouseLeave);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.DarkGray;
            this.one.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.Color.White;
            this.one.Location = new System.Drawing.Point(12, 367);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(70, 70);
            this.one.TabIndex = 5;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.Button_Click);
            this.one.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.one.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.DarkGray;
            this.two.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.Color.White;
            this.two.Location = new System.Drawing.Point(88, 367);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(70, 70);
            this.two.TabIndex = 6;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Button_Click);
            this.two.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.two.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.DarkGray;
            this.three.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.Color.White;
            this.three.Location = new System.Drawing.Point(164, 366);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(70, 70);
            this.three.TabIndex = 7;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Button_Click);
            this.three.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.three.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(240, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 70);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Operator_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnCleanNumber_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnCleanNumber_MouseLeave);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.DarkGray;
            this.four.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.Color.White;
            this.four.Location = new System.Drawing.Point(12, 291);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(70, 70);
            this.four.TabIndex = 10;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Button_Click);
            this.four.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.four.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.DarkGray;
            this.five.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.Color.White;
            this.five.Location = new System.Drawing.Point(88, 291);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(70, 70);
            this.five.TabIndex = 11;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Button_Click);
            this.five.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.five.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.DarkGray;
            this.six.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.Color.White;
            this.six.Location = new System.Drawing.Point(164, 290);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(70, 70);
            this.six.TabIndex = 12;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Button_Click);
            this.six.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.six.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.Gray;
            this.btnSubtract.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.Location = new System.Drawing.Point(240, 290);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(70, 70);
            this.btnSubtract.TabIndex = 13;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.Operator_Click);
            this.btnSubtract.MouseEnter += new System.EventHandler(this.btnCleanNumber_MouseEnter);
            this.btnSubtract.MouseLeave += new System.EventHandler(this.btnCleanNumber_MouseLeave);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.DarkGray;
            this.seven.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.Color.White;
            this.seven.Location = new System.Drawing.Point(12, 215);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(70, 70);
            this.seven.TabIndex = 15;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Button_Click);
            this.seven.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.seven.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.DarkGray;
            this.eight.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.Color.White;
            this.eight.Location = new System.Drawing.Point(88, 215);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(70, 70);
            this.eight.TabIndex = 16;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Button_Click);
            this.eight.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.eight.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.DarkGray;
            this.nine.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.Color.White;
            this.nine.Location = new System.Drawing.Point(164, 214);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(70, 70);
            this.nine.TabIndex = 17;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Button_Click);
            this.nine.MouseEnter += new System.EventHandler(this.nine_MouseEnter);
            this.nine.MouseLeave += new System.EventHandler(this.nine_MouseLeave);
            // 
            // btnMultibly
            // 
            this.btnMultibly.BackColor = System.Drawing.Color.Gray;
            this.btnMultibly.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultibly.ForeColor = System.Drawing.Color.White;
            this.btnMultibly.Location = new System.Drawing.Point(240, 215);
            this.btnMultibly.Name = "btnMultibly";
            this.btnMultibly.Size = new System.Drawing.Size(70, 70);
            this.btnMultibly.TabIndex = 18;
            this.btnMultibly.Text = "x";
            this.btnMultibly.UseVisualStyleBackColor = false;
            this.btnMultibly.Click += new System.EventHandler(this.Operator_Click);
            this.btnMultibly.MouseEnter += new System.EventHandler(this.btnCleanNumber_MouseEnter);
            this.btnMultibly.MouseLeave += new System.EventHandler(this.btnCleanNumber_MouseLeave);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Gray;
            this.btnDivide.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(240, 139);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(70, 70);
            this.btnDivide.TabIndex = 19;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.Operator_Click);
            this.btnDivide.MouseEnter += new System.EventHandler(this.btnCleanNumber_MouseEnter);
            this.btnDivide.MouseLeave += new System.EventHandler(this.btnCleanNumber_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(164, 139);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 70);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnCleanNumber_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnCleanNumber_MouseLeave);
            // 
            // viewText
            // 
            this.viewText.BackColor = System.Drawing.Color.Black;
            this.viewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewText.Enabled = false;
            this.viewText.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewText.ForeColor = System.Drawing.Color.White;
            this.viewText.Location = new System.Drawing.Point(12, 66);
            this.viewText.Multiline = true;
            this.viewText.Name = "viewText";
            this.viewText.Size = new System.Drawing.Size(298, 67);
            this.viewText.TabIndex = 21;
            this.viewText.Text = "0";
            this.viewText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // viewLabel
            // 
            this.viewLabel.BackColor = System.Drawing.Color.Black;
            this.viewLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.ForeColor = System.Drawing.Color.White;
            this.viewLabel.Location = new System.Drawing.Point(12, 21);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(298, 30);
            this.viewLabel.TabIndex = 22;
            this.viewLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCleanNumber
            // 
            this.btnCleanNumber.BackColor = System.Drawing.Color.Gray;
            this.btnCleanNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanNumber.ForeColor = System.Drawing.Color.White;
            this.btnCleanNumber.Location = new System.Drawing.Point(12, 139);
            this.btnCleanNumber.Name = "btnCleanNumber";
            this.btnCleanNumber.Size = new System.Drawing.Size(146, 70);
            this.btnCleanNumber.TabIndex = 23;
            this.btnCleanNumber.Text = "Clean Number";
            this.btnCleanNumber.UseVisualStyleBackColor = false;
            this.btnCleanNumber.Click += new System.EventHandler(this.btnCleanNumber_Click);
            this.btnCleanNumber.MouseEnter += new System.EventHandler(this.btnCleanNumber_MouseEnter);
            this.btnCleanNumber.MouseLeave += new System.EventHandler(this.btnCleanNumber_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(322, 524);
            this.Controls.Add(this.btnCleanNumber);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.viewText);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultibly);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.btnMinus);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(340, 571);
            this.MinimumSize = new System.Drawing.Size(340, 571);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button btnMultibly;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox viewText;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.Button btnCleanNumber;
    }
}

