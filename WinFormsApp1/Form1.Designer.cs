namespace CsCalcApp
{
    partial class CsCalcForm
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
            equal_button = new Button();
            calc_display = new TextBox();
            minus_button = new Button();
            divide_button = new Button();
            all_clear_button = new Button();
            six_button = new Button();
            nine_button = new Button();
            five_button = new Button();
            seven_button = new Button();
            mem_recall_clear_button = new Button();
            mem_minus_button = new Button();
            mem_plus_button = new Button();
            two_button = new Button();
            four_button = new Button();
            three_button = new Button();
            plus_button = new Button();
            double_zero_button = new Button();
            one_button = new Button();
            multiply_button = new Button();
            zero_button = new Button();
            eight_button = new Button();
            decimal_button = new Button();
            clear_button = new Button();
            SuspendLayout();
            // 
            // equal_button
            // 
            equal_button.BackColor = Color.Black;
            equal_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equal_button.ForeColor = Color.White;
            equal_button.Location = new Point(388, 380);
            equal_button.Name = "equal_button";
            equal_button.Size = new Size(60, 60);
            equal_button.TabIndex = 0;
            equal_button.Text = "=";
            equal_button.UseVisualStyleBackColor = false;
            equal_button.Click += equal_button_Click;
            // 
            // calc_display
            // 
            calc_display.BackColor = Color.Black;
            calc_display.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calc_display.ForeColor = Color.White;
            calc_display.Location = new Point(40, 40);
            calc_display.MaxLength = 20;
            calc_display.Name = "calc_display";
            calc_display.PlaceholderText = "0";
            calc_display.ReadOnly = true;
            calc_display.Size = new Size(400, 50);
            calc_display.TabIndex = 2;
            calc_display.Text = "0";
            calc_display.TextAlign = HorizontalAlignment.Right;
            // 
            // minus_button
            // 
            minus_button.BackColor = Color.Black;
            minus_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minus_button.ForeColor = Color.White;
            minus_button.Location = new Point(388, 315);
            minus_button.Name = "minus_button";
            minus_button.Size = new Size(60, 60);
            minus_button.TabIndex = 3;
            minus_button.Text = "-";
            minus_button.UseVisualStyleBackColor = false;
            minus_button.Click += minus_button_Click;
            // 
            // divide_button
            // 
            divide_button.BackColor = Color.Black;
            divide_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divide_button.ForeColor = Color.White;
            divide_button.Location = new Point(388, 250);
            divide_button.Name = "divide_button";
            divide_button.Size = new Size(60, 60);
            divide_button.TabIndex = 4;
            divide_button.Text = "÷";
            divide_button.UseVisualStyleBackColor = false;
            divide_button.Click += divide_button_Click;
            // 
            // all_clear_button
            // 
            all_clear_button.BackColor = Color.Black;
            all_clear_button.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            all_clear_button.ForeColor = Color.White;
            all_clear_button.Location = new Point(388, 185);
            all_clear_button.Name = "all_clear_button";
            all_clear_button.Size = new Size(60, 60);
            all_clear_button.TabIndex = 5;
            all_clear_button.Text = "AC";
            all_clear_button.UseVisualStyleBackColor = false;
            all_clear_button.Click += all_clear_button_Click;
            // 
            // six_button
            // 
            six_button.BackColor = Color.Black;
            six_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            six_button.ForeColor = Color.White;
            six_button.Location = new Point(216, 250);
            six_button.Name = "six_button";
            six_button.Size = new Size(60, 60);
            six_button.TabIndex = 6;
            six_button.Text = "6";
            six_button.UseVisualStyleBackColor = false;
            six_button.Click += six_button_Click;
            // 
            // nine_button
            // 
            nine_button.BackColor = Color.Black;
            nine_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nine_button.ForeColor = Color.White;
            nine_button.Location = new Point(216, 185);
            nine_button.Name = "nine_button";
            nine_button.Size = new Size(60, 60);
            nine_button.TabIndex = 7;
            nine_button.Text = "9";
            nine_button.UseVisualStyleBackColor = false;
            nine_button.Click += nine_button_Click;
            // 
            // five_button
            // 
            five_button.BackColor = Color.Black;
            five_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            five_button.ForeColor = Color.White;
            five_button.Location = new Point(127, 250);
            five_button.Name = "five_button";
            five_button.Size = new Size(60, 60);
            five_button.TabIndex = 8;
            five_button.Text = "5";
            five_button.UseVisualStyleBackColor = false;
            five_button.Click += five_button_Click;
            // 
            // seven_button
            // 
            seven_button.BackColor = Color.Black;
            seven_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            seven_button.ForeColor = Color.White;
            seven_button.Location = new Point(40, 185);
            seven_button.Name = "seven_button";
            seven_button.Size = new Size(60, 60);
            seven_button.TabIndex = 9;
            seven_button.Text = "7";
            seven_button.UseVisualStyleBackColor = false;
            seven_button.Click += seven_button_Click;
            // 
            // mem_recall_clear_button
            // 
            mem_recall_clear_button.BackColor = Color.Black;
            mem_recall_clear_button.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mem_recall_clear_button.ForeColor = Color.White;
            mem_recall_clear_button.Location = new Point(216, 120);
            mem_recall_clear_button.Name = "mem_recall_clear_button";
            mem_recall_clear_button.Size = new Size(60, 60);
            mem_recall_clear_button.TabIndex = 10;
            mem_recall_clear_button.Text = "MRC";
            mem_recall_clear_button.UseVisualStyleBackColor = false;
            mem_recall_clear_button.Click += mem_recall_clear_button_Click;
            // 
            // mem_minus_button
            // 
            mem_minus_button.BackColor = Color.Black;
            mem_minus_button.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mem_minus_button.ForeColor = Color.White;
            mem_minus_button.Location = new Point(127, 120);
            mem_minus_button.Name = "mem_minus_button";
            mem_minus_button.Size = new Size(60, 60);
            mem_minus_button.TabIndex = 11;
            mem_minus_button.Text = "M-";
            mem_minus_button.UseVisualStyleBackColor = false;
            mem_minus_button.Click += mem_minus_button_Click;
            // 
            // mem_plus_button
            // 
            mem_plus_button.BackColor = Color.Black;
            mem_plus_button.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mem_plus_button.ForeColor = Color.White;
            mem_plus_button.Location = new Point(40, 120);
            mem_plus_button.Name = "mem_plus_button";
            mem_plus_button.Size = new Size(60, 60);
            mem_plus_button.TabIndex = 12;
            mem_plus_button.Text = "M+";
            mem_plus_button.UseVisualStyleBackColor = false;
            mem_plus_button.Click += mem_plus_button_Click;
            // 
            // two_button
            // 
            two_button.BackColor = Color.Black;
            two_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            two_button.ForeColor = Color.White;
            two_button.Location = new Point(127, 315);
            two_button.Name = "two_button";
            two_button.Size = new Size(60, 60);
            two_button.TabIndex = 14;
            two_button.Text = "2";
            two_button.UseVisualStyleBackColor = false;
            two_button.Click += two_button_Click;
            // 
            // four_button
            // 
            four_button.BackColor = Color.Black;
            four_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            four_button.ForeColor = Color.White;
            four_button.Location = new Point(40, 250);
            four_button.Name = "four_button";
            four_button.Size = new Size(60, 60);
            four_button.TabIndex = 15;
            four_button.Text = "4";
            four_button.UseVisualStyleBackColor = false;
            four_button.Click += four_button_Click;
            // 
            // three_button
            // 
            three_button.BackColor = Color.Black;
            three_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            three_button.ForeColor = Color.White;
            three_button.Location = new Point(216, 315);
            three_button.Name = "three_button";
            three_button.Size = new Size(60, 60);
            three_button.TabIndex = 16;
            three_button.Text = "3";
            three_button.UseVisualStyleBackColor = false;
            three_button.Click += three_button_Click;
            // 
            // plus_button
            // 
            plus_button.BackColor = Color.Black;
            plus_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plus_button.ForeColor = Color.White;
            plus_button.Location = new Point(304, 315);
            plus_button.Name = "plus_button";
            plus_button.Size = new Size(60, 125);
            plus_button.TabIndex = 17;
            plus_button.Text = "+";
            plus_button.UseVisualStyleBackColor = false;
            plus_button.Click += plus_button_Click;
            // 
            // double_zero_button
            // 
            double_zero_button.BackColor = Color.Black;
            double_zero_button.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            double_zero_button.ForeColor = Color.White;
            double_zero_button.Location = new Point(127, 380);
            double_zero_button.Name = "double_zero_button";
            double_zero_button.Size = new Size(60, 60);
            double_zero_button.TabIndex = 18;
            double_zero_button.Text = "00";
            double_zero_button.UseVisualStyleBackColor = false;
            double_zero_button.Click += double_zero_button_Click;
            // 
            // one_button
            // 
            one_button.BackColor = Color.Black;
            one_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            one_button.ForeColor = Color.White;
            one_button.Location = new Point(40, 315);
            one_button.Name = "one_button";
            one_button.Size = new Size(60, 60);
            one_button.TabIndex = 19;
            one_button.Text = "1";
            one_button.UseVisualStyleBackColor = false;
            one_button.Click += one_button_Click;
            // 
            // multiply_button
            // 
            multiply_button.BackColor = Color.Black;
            multiply_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multiply_button.ForeColor = Color.White;
            multiply_button.Location = new Point(304, 250);
            multiply_button.Name = "multiply_button";
            multiply_button.Size = new Size(60, 60);
            multiply_button.TabIndex = 20;
            multiply_button.Text = "X";
            multiply_button.UseVisualStyleBackColor = false;
            multiply_button.Click += multiply_button_Click;
            // 
            // zero_button
            // 
            zero_button.BackColor = Color.Black;
            zero_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zero_button.ForeColor = Color.White;
            zero_button.Location = new Point(40, 380);
            zero_button.Name = "zero_button";
            zero_button.Size = new Size(60, 60);
            zero_button.TabIndex = 21;
            zero_button.Text = "0";
            zero_button.UseVisualStyleBackColor = false;
            zero_button.Click += zero_button_Click;
            // 
            // eight_button
            // 
            eight_button.BackColor = Color.Black;
            eight_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eight_button.ForeColor = Color.White;
            eight_button.Location = new Point(127, 185);
            eight_button.Name = "eight_button";
            eight_button.Size = new Size(60, 60);
            eight_button.TabIndex = 22;
            eight_button.Text = "8";
            eight_button.UseVisualStyleBackColor = false;
            eight_button.Click += eight_button_Click;
            // 
            // decimal_button
            // 
            decimal_button.BackColor = Color.Black;
            decimal_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decimal_button.ForeColor = Color.White;
            decimal_button.Location = new Point(216, 380);
            decimal_button.Name = "decimal_button";
            decimal_button.Size = new Size(60, 60);
            decimal_button.TabIndex = 23;
            decimal_button.Text = ".";
            decimal_button.UseVisualStyleBackColor = false;
            decimal_button.Click += decimal_button_Click;
            // 
            // clear_button
            // 
            clear_button.BackColor = Color.Black;
            clear_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_button.ForeColor = Color.White;
            clear_button.Location = new Point(304, 185);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(60, 60);
            clear_button.TabIndex = 24;
            clear_button.Text = "C";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // CsCalcForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(478, 444);
            Controls.Add(clear_button);
            Controls.Add(decimal_button);
            Controls.Add(eight_button);
            Controls.Add(zero_button);
            Controls.Add(multiply_button);
            Controls.Add(one_button);
            Controls.Add(double_zero_button);
            Controls.Add(plus_button);
            Controls.Add(three_button);
            Controls.Add(four_button);
            Controls.Add(two_button);
            Controls.Add(mem_plus_button);
            Controls.Add(mem_minus_button);
            Controls.Add(mem_recall_clear_button);
            Controls.Add(seven_button);
            Controls.Add(five_button);
            Controls.Add(nine_button);
            Controls.Add(six_button);
            Controls.Add(all_clear_button);
            Controls.Add(divide_button);
            Controls.Add(minus_button);
            Controls.Add(calc_display);
            Controls.Add(equal_button);
            Name = "CsCalcForm";
            ShowIcon = false;
            Text = "C# Calculator by Nicholas Sayre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox calc_display;
        private Button zero_button;
        private Button equal_button;
        private Button double_zero_button;
        private Button one_button;
        private Button two_button;
        private Button three_button;
        private Button four_button;
        private Button five_button;
        private Button six_button;
        private Button seven_button;
        private Button eight_button;
        private Button nine_button;
        private Button decimal_button;
        private Button plus_button;
        private Button minus_button;
        private Button multiply_button;
        private Button divide_button;
        private Button clear_button;
        private Button all_clear_button;
        private Button mem_recall_clear_button;
        private Button mem_minus_button;
        private Button mem_plus_button;
    }
}
