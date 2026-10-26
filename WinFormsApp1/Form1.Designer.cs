namespace WinFormsApp1
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
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btndot = new Button();
            btnequals = new Button();
            btndivide = new Button();
            multiply = new Button();
            btnminus = new Button();
            btnplus = new Button();
            textBox2 = new TextBox();
            btnclear = new Button();
            btnallclear = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(33, 159);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 20;
            btn1.Text = "1";
            btn1.Click += Btnnumbersactions;
            // 
            // btn4
            // 
            btn4.Location = new Point(33, 130);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 23);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Btnnumbersactions;
            // 
            // btn7
            // 
            btn7.Location = new Point(33, 101);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 23);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Btnnumbersactions;
            // 
            // btn2
            // 
            btn2.Location = new Point(114, 159);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Btnnumbersactions;
            // 
            // btn5
            // 
            btn5.Location = new Point(114, 130);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 23);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Btnnumbersactions;
            // 
            // btn8
            // 
            btn8.Location = new Point(114, 101);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 23);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Btnnumbersactions;
            // 
            // btn3
            // 
            btn3.Location = new Point(195, 159);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 23);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Btnnumbersactions;
            // 
            // btn6
            // 
            btn6.Location = new Point(195, 130);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 23);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Btnnumbersactions;
            // 
            // btn9
            // 
            btn9.Location = new Point(195, 101);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 23);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Btnnumbersactions;
            // 
            // btn0
            // 
            btn0.Location = new Point(33, 188);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 23);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Btnnumbersactions;
            // 
            // btndot
            // 
            btndot.Location = new Point(114, 188);
            btndot.Name = "btndot";
            btndot.Size = new Size(75, 23);
            btndot.TabIndex = 10;
            btndot.Text = ",";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += dotoperation;
            // 
            // btnequals
            // 
            btnequals.Location = new Point(195, 188);
            btnequals.Name = "btnequals";
            btnequals.Size = new Size(75, 23);
            btnequals.TabIndex = 11;
            btnequals.Text = "=";
            btnequals.UseVisualStyleBackColor = true;
            btnequals.Click += btnequals_Click;
            // 
            // btndivide
            // 
            btndivide.Location = new Point(276, 101);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(75, 23);
            btndivide.TabIndex = 12;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += dotoperation;
            // 
            // multiply
            // 
            multiply.Location = new Point(276, 130);
            multiply.Name = "multiply";
            multiply.Size = new Size(75, 23);
            multiply.TabIndex = 13;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += mathoperation;
            // 
            // btnminus
            // 
            btnminus.Location = new Point(276, 159);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(75, 23);
            btnminus.TabIndex = 14;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += mathoperation;
            // 
            // btnplus
            // 
            btnplus.Location = new Point(276, 188);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(75, 23);
            btnplus.TabIndex = 15;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += mathoperation;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(33, 20);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(318, 43);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(195, 72);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(156, 23);
            btnclear.TabIndex = 18;
            btnclear.Text = "С";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btnallclear
            // 
            btnallclear.Location = new Point(33, 72);
            btnallclear.Name = "btnallclear";
            btnallclear.Size = new Size(156, 23);
            btnallclear.TabIndex = 19;
            btnallclear.Text = "AC";
            btnallclear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 236);
            Controls.Add(btnallclear);
            Controls.Add(btnclear);
            Controls.Add(textBox2);
            Controls.Add(btnplus);
            Controls.Add(btnminus);
            Controls.Add(multiply);
            Controls.Add(btndivide);
            Controls.Add(btnequals);
            Controls.Add(btndot);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btn0;
        private Button btndot;
        private Button btnequals;
        private Button btndivide;
        private Button multiply;
        private Button btnminus;
        private Button btnplus;
        private TextBox textBox2;
        private Button btnclear;
        private Button btnallclear;
    }
}
