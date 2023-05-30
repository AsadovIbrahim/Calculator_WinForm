namespace Calculator
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            txtDisplay = new TextBox();
            btn_clear = new Button();
            btn_plus_minus = new Button();
            btn_percent = new Button();
            btn_divide = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_product = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_substraction = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_sum = new Button();
            btn_0 = new Button();
            btn_point = new Button();
            btn_delete = new Button();
            btn_equal = new Button();
            contextMenuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 77);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(24, 24);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(161, 39);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 31);
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplay.Location = new Point(122, 3);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(264, 189);
            txtDisplay.TabIndex = 5;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.ControlDarkDark;
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(121, 187);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(71, 54);
            btn_clear.TabIndex = 6;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_plus_minus
            // 
            btn_plus_minus.BackColor = SystemColors.ControlDarkDark;
            btn_plus_minus.ForeColor = Color.White;
            btn_plus_minus.Location = new Point(186, 187);
            btn_plus_minus.Name = "btn_plus_minus";
            btn_plus_minus.Size = new Size(70, 54);
            btn_plus_minus.TabIndex = 7;
            btn_plus_minus.Text = "+/-";
            btn_plus_minus.UseVisualStyleBackColor = false;
            btn_plus_minus.Click += btn_plus_minus_Click;
            // 
            // btn_percent
            // 
            btn_percent.BackColor = SystemColors.ControlDarkDark;
            btn_percent.ForeColor = Color.White;
            btn_percent.Location = new Point(249, 187);
            btn_percent.Name = "btn_percent";
            btn_percent.Size = new Size(70, 54);
            btn_percent.TabIndex = 8;
            btn_percent.Text = "%";
            btn_percent.UseVisualStyleBackColor = false;
            btn_percent.Click += allOperations_Click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = Color.DarkSlateBlue;
            btn_divide.ForeColor = SystemColors.Control;
            btn_divide.Location = new Point(316, 187);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(70, 54);
            btn_divide.TabIndex = 9;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += allOperations_Click;
            // 
            // btn_7
            // 
            btn_7.BackColor = SystemColors.ControlDarkDark;
            btn_7.ForeColor = Color.White;
            btn_7.Location = new Point(121, 238);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(70, 54);
            btn_7.TabIndex = 10;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += btnNumbers_Click;
            // 
            // btn_8
            // 
            btn_8.BackColor = SystemColors.ControlDarkDark;
            btn_8.ForeColor = Color.White;
            btn_8.Location = new Point(186, 238);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(66, 54);
            btn_8.TabIndex = 11;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += btnNumbers_Click;
            // 
            // btn_9
            // 
            btn_9.BackColor = SystemColors.ControlDarkDark;
            btn_9.ForeColor = Color.White;
            btn_9.Location = new Point(249, 238);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(70, 54);
            btn_9.TabIndex = 12;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += btnNumbers_Click;
            // 
            // btn_product
            // 
            btn_product.BackColor = Color.DarkSlateBlue;
            btn_product.ForeColor = Color.White;
            btn_product.Location = new Point(316, 238);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(70, 54);
            btn_product.TabIndex = 13;
            btn_product.Text = "X";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += allOperations_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = SystemColors.ControlDarkDark;
            btn_4.ForeColor = Color.White;
            btn_4.Location = new Point(121, 288);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(68, 54);
            btn_4.TabIndex = 14;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btnNumbers_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = SystemColors.ControlDarkDark;
            btn_5.ForeColor = Color.White;
            btn_5.Location = new Point(186, 288);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(66, 54);
            btn_5.TabIndex = 15;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btnNumbers_Click;
            // 
            // btn_6
            // 
            btn_6.BackColor = SystemColors.ControlDarkDark;
            btn_6.ForeColor = Color.White;
            btn_6.Location = new Point(249, 288);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(70, 54);
            btn_6.TabIndex = 16;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += btnNumbers_Click;
            // 
            // btn_substraction
            // 
            btn_substraction.BackColor = Color.DarkSlateBlue;
            btn_substraction.ForeColor = Color.White;
            btn_substraction.Location = new Point(316, 288);
            btn_substraction.Name = "btn_substraction";
            btn_substraction.Size = new Size(70, 54);
            btn_substraction.TabIndex = 17;
            btn_substraction.Text = "-";
            btn_substraction.UseVisualStyleBackColor = false;
            btn_substraction.Click += allOperations_Click;
            // 
            // btn_1
            // 
            btn_1.BackColor = SystemColors.ControlDarkDark;
            btn_1.ForeColor = Color.White;
            btn_1.Location = new Point(121, 338);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(68, 54);
            btn_1.TabIndex = 18;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btnNumbers_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = SystemColors.ControlDarkDark;
            btn_2.ForeColor = Color.White;
            btn_2.Location = new Point(186, 338);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(66, 54);
            btn_2.TabIndex = 19;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btnNumbers_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = SystemColors.ControlDarkDark;
            btn_3.ForeColor = Color.White;
            btn_3.Location = new Point(249, 338);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(70, 54);
            btn_3.TabIndex = 20;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += btnNumbers_Click;
            // 
            // btn_sum
            // 
            btn_sum.BackColor = Color.DarkSlateBlue;
            btn_sum.ForeColor = Color.White;
            btn_sum.Location = new Point(316, 338);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(70, 54);
            btn_sum.TabIndex = 21;
            btn_sum.Text = "+";
            btn_sum.UseVisualStyleBackColor = false;
            btn_sum.Click += allOperations_Click;
            // 
            // btn_0
            // 
            btn_0.BackColor = SystemColors.ControlDarkDark;
            btn_0.ForeColor = Color.White;
            btn_0.Location = new Point(121, 388);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(68, 54);
            btn_0.TabIndex = 22;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += btnNumbers_Click;
            // 
            // btn_point
            // 
            btn_point.BackColor = SystemColors.ControlDarkDark;
            btn_point.ForeColor = Color.White;
            btn_point.Location = new Point(186, 388);
            btn_point.Name = "btn_point";
            btn_point.Size = new Size(66, 54);
            btn_point.TabIndex = 23;
            btn_point.Text = ".";
            btn_point.UseVisualStyleBackColor = false;
            btn_point.Click += btn_point_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ControlDarkDark;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(249, 388);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(70, 54);
            btn_delete.TabIndex = 24;
            btn_delete.Text = "del";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_equal
            // 
            btn_equal.BackColor = Color.Gold;
            btn_equal.ForeColor = SystemColors.ControlText;
            btn_equal.Location = new Point(317, 388);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(69, 54);
            btn_equal.TabIndex = 25;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = false;
            btn_equal.Click += btn_equal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(800, 502);
            Controls.Add(btn_equal);
            Controls.Add(btn_delete);
            Controls.Add(btn_point);
            Controls.Add(btn_0);
            Controls.Add(btn_sum);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_substraction);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_product);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_divide);
            Controls.Add(btn_percent);
            Controls.Add(btn_plus_minus);
            Controls.Add(btn_clear);
            Controls.Add(txtDisplay);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculator";
            Click += allOperations_Click;
            contextMenuStrip3.ResumeLayout(false);
            contextMenuStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripTextBox toolStripTextBox1;
        private TextBox txtDisplay;
        private Button btn_clear;
        private Button btn_plus_minus;
        private Button btn_percent;
        private Button btn_divide;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_product;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_substraction;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_sum;
        private Button btn_0;
        private Button btn_point;
        private Button btn_delete;
        private Button btn_equal;
    }
}