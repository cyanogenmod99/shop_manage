namespace test
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.earings_textbox = new System.Windows.Forms.TextBox();
            this.stack_cut = new System.Windows.Forms.Button();
            this.stack_perm = new System.Windows.Forms.Button();
            this.stack_color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "매출액";
            // 
            // earings_textbox
            // 
            this.earings_textbox.Location = new System.Drawing.Point(108, 12);
            this.earings_textbox.MaxLength = 10;
            this.earings_textbox.Name = "earings_textbox";
            this.earings_textbox.Size = new System.Drawing.Size(125, 27);
            this.earings_textbox.TabIndex = 1;
            // 
            // stack_cut
            // 
            this.stack_cut.Location = new System.Drawing.Point(80, 65);
            this.stack_cut.Name = "stack_cut";
            this.stack_cut.Size = new System.Drawing.Size(94, 29);
            this.stack_cut.TabIndex = 2;
            this.stack_cut.Text = "커트";
            this.stack_cut.UseVisualStyleBackColor = true;
            // 
            // stack_perm
            // 
            this.stack_perm.Location = new System.Drawing.Point(80, 124);
            this.stack_perm.Name = "stack_perm";
            this.stack_perm.Size = new System.Drawing.Size(94, 29);
            this.stack_perm.TabIndex = 3;
            this.stack_perm.Text = "펌";
            this.stack_perm.UseVisualStyleBackColor = true;
            // 
            // stack_color
            // 
            this.stack_color.Location = new System.Drawing.Point(80, 187);
            this.stack_color.Name = "stack_color";
            this.stack_color.Size = new System.Drawing.Size(94, 29);
            this.stack_color.TabIndex = 4;
            this.stack_color.Text = "염색";
            this.stack_color.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 297);
            this.Controls.Add(this.stack_color);
            this.Controls.Add(this.stack_perm);
            this.Controls.Add(this.stack_cut);
            this.Controls.Add(this.earings_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox earings_textbox;
        private Button stack_cut;
        private Button stack_perm;
        private Button stack_color;
    }
}