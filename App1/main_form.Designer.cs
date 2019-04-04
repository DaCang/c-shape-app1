namespace App1
{
    partial class main_from
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
            this.test_mysql_db_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test_mysql_db_btn
            // 
            this.test_mysql_db_btn.Location = new System.Drawing.Point(84, 65);
            this.test_mysql_db_btn.Name = "test_mysql_db_btn";
            this.test_mysql_db_btn.Size = new System.Drawing.Size(262, 37);
            this.test_mysql_db_btn.TabIndex = 0;
            this.test_mysql_db_btn.Text = "test_mysql_db";
            this.test_mysql_db_btn.UseVisualStyleBackColor = true;
            this.test_mysql_db_btn.Click += new System.EventHandler(this.test_mysql_db_btn_Click);
            // 
            // main_from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test_mysql_db_btn);
            this.Name = "main_from";
            this.Text = "main_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test_mysql_db_btn;
    }
}