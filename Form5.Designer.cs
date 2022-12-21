namespace test
{
    partial class telenum_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telenum_form));
            this.telenum_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // telenum_box
            // 
            this.telenum_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.telenum_box, "telenum_box");
            this.telenum_box.Name = "telenum_box";
            this.telenum_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tele_num_entered);
            // 
            // telenum_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.telenum_box);
            this.Name = "telenum_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox telenum_box;
    }
}