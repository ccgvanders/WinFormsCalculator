namespace WinFormsCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            lblDisplay = new Label();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            buttonClear = new Button();
            btnEquals = new Button();
            btnZero = new Button();
            btnDecinalPoint = new Button();
            SuspendLayout();
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.FromArgb(234, 243, 222);
            btnOne.Font = new Font("Segoe UI", 14.25F);
            btnOne.Location = new Point(12, 250);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(70, 70);
            btnOne.TabIndex = 0;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += digitButton_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.FromArgb(234, 243, 222);
            btnTwo.Font = new Font("Segoe UI", 14.25F);
            btnTwo.Location = new Point(93, 250);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(70, 70);
            btnTwo.TabIndex = 1;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += digitButton_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.FromArgb(234, 243, 222);
            btnThree.Font = new Font("Segoe UI", 14.25F);
            btnThree.Location = new Point(174, 250);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(70, 70);
            btnThree.TabIndex = 2;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += digitButton_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.FromArgb(234, 243, 222);
            btnFour.Font = new Font("Segoe UI", 14.25F);
            btnFour.Location = new Point(12, 174);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(70, 70);
            btnFour.TabIndex = 3;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += digitButton_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.FromArgb(234, 243, 222);
            btnFive.Font = new Font("Segoe UI", 14.25F);
            btnFive.Location = new Point(93, 174);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(70, 70);
            btnFive.TabIndex = 4;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += digitButton_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.FromArgb(234, 243, 222);
            btnSix.Font = new Font("Segoe UI", 14.25F);
            btnSix.Location = new Point(174, 174);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(70, 70);
            btnSix.TabIndex = 5;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += digitButton_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.FromArgb(234, 243, 222);
            btnSeven.Font = new Font("Segoe UI", 14.25F);
            btnSeven.Location = new Point(12, 98);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(70, 70);
            btnSeven.TabIndex = 6;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += digitButton_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.FromArgb(234, 243, 222);
            btnEight.Font = new Font("Segoe UI", 14.25F);
            btnEight.Location = new Point(93, 98);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(70, 70);
            btnEight.TabIndex = 7;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += digitButton_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.FromArgb(234, 243, 222);
            btnNine.Font = new Font("Segoe UI", 14.25F);
            btnNine.Location = new Point(174, 98);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(70, 70);
            btnNine.TabIndex = 8;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += digitButton_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = Color.White;
            lblDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplay.Location = new Point(12, 9);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(308, 70);
            lblDisplay.TabIndex = 9;
            lblDisplay.Text = "0";
            lblDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(250, 235, 231);
            btnDivide.Font = new Font("Segoe UI", 14.25F);
            btnDivide.Location = new Point(250, 98);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(70, 70);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += operatorButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(250, 235, 231);
            btnMultiply.Font = new Font("Segoe UI", 14.25F);
            btnMultiply.Location = new Point(250, 174);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(70, 70);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += operatorButton_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(250, 235, 231);
            btnSubtract.Font = new Font("Segoe UI", 14.25F);
            btnSubtract.Location = new Point(250, 250);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(70, 70);
            btnSubtract.TabIndex = 10;
            btnSubtract.Text = "− ";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += operatorButton_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(250, 235, 231);
            btnAdd.Font = new Font("Segoe UI", 14.25F);
            btnAdd.Location = new Point(250, 326);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 70);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += operatorButton_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(250, 238, 218);
            buttonClear.Font = new Font("Segoe UI", 14.25F);
            buttonClear.Location = new Point(12, 402);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(151, 70);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(238, 237, 254);
            btnEquals.Font = new Font("Segoe UI", 14.25F);
            btnEquals.Location = new Point(174, 402);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(146, 70);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.FromArgb(234, 243, 222);
            btnZero.Font = new Font("Segoe UI", 14.25F);
            btnZero.Location = new Point(12, 326);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(151, 70);
            btnZero.TabIndex = 16;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += digitButton_Click;
            // 
            // btnDecinalPoint
            // 
            btnDecinalPoint.BackColor = Color.FromArgb(234, 243, 222);
            btnDecinalPoint.Font = new Font("Segoe UI", 14.25F);
            btnDecinalPoint.Location = new Point(174, 326);
            btnDecinalPoint.Name = "btnDecinalPoint";
            btnDecinalPoint.Size = new Size(70, 70);
            btnDecinalPoint.TabIndex = 17;
            btnDecinalPoint.Text = ".";
            btnDecinalPoint.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 486);
            Controls.Add(btnDecinalPoint);
            Controls.Add(btnZero);
            Controls.Add(btnEquals);
            Controls.Add(buttonClear);
            Controls.Add(btnAdd);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(lblDisplay);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Name = "CalculatorForm";
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Label lblDisplay;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private Button buttonClear;
        private Button btnEquals;
        private Button btnZero;
        private Button btnDecinalPoint;
    }
}
