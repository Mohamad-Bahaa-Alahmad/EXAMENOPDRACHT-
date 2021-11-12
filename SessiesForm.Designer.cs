namespace News
{
    partial class SessiesForm
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
            this.home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addsessies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(29, 2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(88, 33);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Sessies";
            // 
            // addsessies
            // 
            this.addsessies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsessies.Location = new System.Drawing.Point(724, 2);
            this.addsessies.Name = "addsessies";
            this.addsessies.Size = new System.Drawing.Size(159, 33);
            this.addsessies.TabIndex = 2;
            this.addsessies.Text = "Add Sessies";
            this.addsessies.UseVisualStyleBackColor = true;
            this.addsessies.Visible = false;
            this.addsessies.Click += new System.EventHandler(this.addsessies_Click);
            // 
            // SessiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(914, 456);
            this.Controls.Add(this.addsessies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home);
            this.Name = "SessiesForm";
            this.Text = "SessiesForm";
            this.Load += new System.EventHandler(this.SessiesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addsessies;
    }
}