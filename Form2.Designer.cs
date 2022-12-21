namespace test
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.member_view = new System.Windows.Forms.DataGridView();
            this.stack_color_btn = new System.Windows.Forms.Button();
            this.stack_perm_btn = new System.Windows.Forms.Button();
            this.stack_cut_btn = new System.Windows.Forms.Button();
            this.earings_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.use_color_btn = new System.Windows.Forms.Button();
            this.use_perm_btn = new System.Windows.Forms.Button();
            this.use_cut_btn = new System.Windows.Forms.Button();
            this.use_point_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.db_refresh_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.member_view)).BeginInit();
            this.SuspendLayout();
            // 
            // member_view
            // 
            this.member_view.AllowUserToAddRows = false;
            this.member_view.AllowUserToDeleteRows = false;
            this.member_view.AllowUserToResizeColumns = false;
            this.member_view.AllowUserToResizeRows = false;
            this.member_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.member_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.member_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.member_view.DefaultCellStyle = dataGridViewCellStyle6;
            this.member_view.Location = new System.Drawing.Point(13, 345);
            this.member_view.Margin = new System.Windows.Forms.Padding(4);
            this.member_view.Name = "member_view";
            this.member_view.ReadOnly = true;
            this.member_view.RowHeadersWidth = 51;
            this.member_view.RowTemplate.Height = 40;
            this.member_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.member_view.Size = new System.Drawing.Size(1013, 228);
            this.member_view.TabIndex = 0;
            this.member_view.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.user_delete_event);
            // 
            // stack_color_btn
            // 
            this.stack_color_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stack_color_btn.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stack_color_btn.Location = new System.Drawing.Point(263, 203);
            this.stack_color_btn.Name = "stack_color_btn";
            this.stack_color_btn.Size = new System.Drawing.Size(99, 46);
            this.stack_color_btn.TabIndex = 9;
            this.stack_color_btn.Text = "염색";
            this.stack_color_btn.UseVisualStyleBackColor = true;
            this.stack_color_btn.Click += new System.EventHandler(this.stack_color_event);
            // 
            // stack_perm_btn
            // 
            this.stack_perm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stack_perm_btn.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stack_perm_btn.Location = new System.Drawing.Point(263, 151);
            this.stack_perm_btn.Name = "stack_perm_btn";
            this.stack_perm_btn.Size = new System.Drawing.Size(99, 46);
            this.stack_perm_btn.TabIndex = 8;
            this.stack_perm_btn.Text = "펌";
            this.stack_perm_btn.UseVisualStyleBackColor = true;
            this.stack_perm_btn.Click += new System.EventHandler(this.stack_perm_event);
            // 
            // stack_cut_btn
            // 
            this.stack_cut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stack_cut_btn.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stack_cut_btn.Location = new System.Drawing.Point(263, 99);
            this.stack_cut_btn.Name = "stack_cut_btn";
            this.stack_cut_btn.Size = new System.Drawing.Size(99, 46);
            this.stack_cut_btn.TabIndex = 7;
            this.stack_cut_btn.Text = "커트";
            this.stack_cut_btn.UseVisualStyleBackColor = true;
            this.stack_cut_btn.Click += new System.EventHandler(this.stack_cut);
            // 
            // earings_textbox
            // 
            this.earings_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.earings_textbox.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.earings_textbox.Location = new System.Drawing.Point(210, 44);
            this.earings_textbox.MaxLength = 10;
            this.earings_textbox.Name = "earings_textbox";
            this.earings_textbox.Size = new System.Drawing.Size(152, 43);
            this.earings_textbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "매출액";
            // 
            // use_color_btn
            // 
            this.use_color_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.use_color_btn.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.use_color_btn.Location = new System.Drawing.Point(830, 203);
            this.use_color_btn.Name = "use_color_btn";
            this.use_color_btn.Size = new System.Drawing.Size(99, 46);
            this.use_color_btn.TabIndex = 14;
            this.use_color_btn.Text = "염색";
            this.use_color_btn.UseVisualStyleBackColor = true;
            this.use_color_btn.Click += new System.EventHandler(this.use_color_event);
            // 
            // use_perm_btn
            // 
            this.use_perm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.use_perm_btn.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.use_perm_btn.Location = new System.Drawing.Point(830, 151);
            this.use_perm_btn.Name = "use_perm_btn";
            this.use_perm_btn.Size = new System.Drawing.Size(99, 46);
            this.use_perm_btn.TabIndex = 13;
            this.use_perm_btn.Text = "펌";
            this.use_perm_btn.UseVisualStyleBackColor = true;
            this.use_perm_btn.Click += new System.EventHandler(this.use_perm_event);
            // 
            // use_cut_btn
            // 
            this.use_cut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.use_cut_btn.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.use_cut_btn.Location = new System.Drawing.Point(830, 99);
            this.use_cut_btn.Name = "use_cut_btn";
            this.use_cut_btn.Size = new System.Drawing.Size(99, 46);
            this.use_cut_btn.TabIndex = 12;
            this.use_cut_btn.Text = "커트";
            this.use_cut_btn.UseVisualStyleBackColor = true;
            this.use_cut_btn.Click += new System.EventHandler(this.use_cut_event);
            // 
            // use_point_textbox
            // 
            this.use_point_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.use_point_textbox.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.use_point_textbox.Location = new System.Drawing.Point(777, 44);
            this.use_point_textbox.MaxLength = 10;
            this.use_point_textbox.Name = "use_point_textbox";
            this.use_point_textbox.Size = new System.Drawing.Size(152, 43);
            this.use_point_textbox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(616, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "사용액";
            // 
            // db_refresh_btn
            // 
            this.db_refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.db_refresh_btn.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.db_refresh_btn.Location = new System.Drawing.Point(889, 292);
            this.db_refresh_btn.Name = "db_refresh_btn";
            this.db_refresh_btn.Size = new System.Drawing.Size(137, 46);
            this.db_refresh_btn.TabIndex = 18;
            this.db_refresh_btn.Text = "새로고침";
            this.db_refresh_btn.UseVisualStyleBackColor = true;
            this.db_refresh_btn.Click += new System.EventHandler(this.db_refresh);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(501, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 220);
            this.label4.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(784, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "수정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.edit_event);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.db_refresh_btn);
            this.Controls.Add(this.use_color_btn);
            this.Controls.Add(this.use_perm_btn);
            this.Controls.Add(this.use_cut_btn);
            this.Controls.Add(this.use_point_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stack_color_btn);
            this.Controls.Add(this.stack_perm_btn);
            this.Controls.Add(this.stack_cut_btn);
            this.Controls.Add(this.earings_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.member_view);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "조회 및 적립";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.member_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button stack_color_btn;
        private Button stack_perm_btn;
        private Button stack_cut_btn;
        private TextBox earings_textbox;
        private Label label1;
        private Button use_color_btn;
        private Button use_perm_btn;
        private Button use_cut_btn;
        private TextBox use_point_textbox;
        private Label label2;
        private Button db_refresh_btn;
        private Label label4;
        public DataGridView member_view;
        private Button button1;
    }
}