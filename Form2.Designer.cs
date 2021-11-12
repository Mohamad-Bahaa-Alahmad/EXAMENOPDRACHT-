namespace News
{
    partial class FirstForm
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
            this.login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addnews = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.showsessies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(713, 12);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 27);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(611, 12);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 27);
            this.register.TabIndex = 1;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "All News";
            // 
            // addnews
            // 
            this.addnews.Location = new System.Drawing.Point(679, 67);
            this.addnews.Name = "addnews";
            this.addnews.Size = new System.Drawing.Size(109, 36);
            this.addnews.TabIndex = 3;
            this.addnews.Text = "Add News";
            this.addnews.UseVisualStyleBackColor = true;
            this.addnews.Visible = false;
            this.addnews.Click += new System.EventHandler(this.addnews_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(13, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(83, 27);
            this.logout.TabIndex = 4;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Visible = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // showsessies
            // 
            this.showsessies.Location = new System.Drawing.Point(13, 67);
            this.showsessies.Name = "showsessies";
            this.showsessies.Size = new System.Drawing.Size(101, 36);
            this.showsessies.TabIndex = 5;
            this.showsessies.Text = "All Sessies";
            this.showsessies.UseVisualStyleBackColor = true;
            this.showsessies.Click += new System.EventHandler(this.showsessies_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.showsessies);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.addnews);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.login);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnews;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button showsessies;
    }
}

