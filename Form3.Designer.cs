namespace test
{
    partial class Form3
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
            this.new_name = new System.Windows.Forms.TextBox();
            this.new_number = new System.Windows.Forms.TextBox();
            this.new_point = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // new_name
            // 
            this.new_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.new_name.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.new_name.Location = new System.Drawing.Point(177, 23);
            this.new_name.MaxLength = 10;
            this.new_name.Name = "new_name";
            this.new_name.Size = new System.Drawing.Size(164, 43);
            this.new_name.TabIndex = 0;
            this.new_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // new_number
            // 
            this.new_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.new_number.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.new_number.Location = new System.Drawing.Point(177, 88);
            this.new_number.MaxLength = 11;
            this.new_number.Name = "new_number";
            this.new_number.Size = new System.Drawing.Size(164, 43);
            this.new_number.TabIndex = 1;
            // 
            // new_point
            // 
            this.new_point.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.new_point.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.new_point.Location = new System.Drawing.Point(177, 154);
            this.new_point.MaxLength = 10;
            this.new_point.Name = "new_point";
            this.new_point.Size = new System.Drawing.Size(164, 43);
            this.new_point.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(119, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.new_member);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "전화번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "초기포인트";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.new_point);
            this.Controls.Add(this.new_number);
            this.Controls.Add(this.new_name);
            this.Name = "Form3";
            this.Text = "회원등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox new_name;
        private TextBox new_number;
        private TextBox new_point;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}