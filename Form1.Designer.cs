namespace test
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
            this.check_member = new System.Windows.Forms.Button();
            this.gdown = new System.Windows.Forms.Button();
            this.member_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check_member
            // 
            this.check_member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_member.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_member.Location = new System.Drawing.Point(145, 42);
            this.check_member.Margin = new System.Windows.Forms.Padding(4);
            this.check_member.Name = "check_member";
            this.check_member.Size = new System.Drawing.Size(120, 54);
            this.check_member.TabIndex = 0;
            this.check_member.Text = "조회";
            this.check_member.UseVisualStyleBackColor = true;
            this.check_member.Click += new System.EventHandler(this.checkbtn_click);
            // 
            // gdown
            // 
            this.gdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gdown.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gdown.Location = new System.Drawing.Point(145, 238);
            this.gdown.Margin = new System.Windows.Forms.Padding(4);
            this.gdown.Name = "gdown";
            this.gdown.Size = new System.Drawing.Size(120, 54);
            this.gdown.TabIndex = 0;
            this.gdown.Text = "수정";
            this.gdown.UseVisualStyleBackColor = true;
            this.gdown.Click += new System.EventHandler(this.edit_event);
            // 
            // member_new
            // 
            this.member_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.member_new.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.member_new.Location = new System.Drawing.Point(145, 140);
            this.member_new.Margin = new System.Windows.Forms.Padding(4);
            this.member_new.Name = "member_new";
            this.member_new.Size = new System.Drawing.Size(120, 54);
            this.member_new.TabIndex = 1;
            this.member_new.Text = "등록";
            this.member_new.UseVisualStyleBackColor = true;
            this.member_new.Click += new System.EventHandler(this.new_member);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 494);
            this.Controls.Add(this.member_new);
            this.Controls.Add(this.gdown);
            this.Controls.Add(this.check_member);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "포인트관리";
            this.ResumeLayout(false);

        }

        #endregion

        private Button check_member;
        private Button gdown;
        private Button member_new;
    }
}