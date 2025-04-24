namespace Gimmnasio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GymName = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.NameCollaborators = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GymName
            // 
            this.GymName.AutoSize = true;
            this.GymName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GymName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GymName.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GymName.ForeColor = System.Drawing.Color.White;
            this.GymName.Location = new System.Drawing.Point(102, 33);
            this.GymName.Name = "GymName";
            this.GymName.Size = new System.Drawing.Size(243, 66);
            this.GymName.TabIndex = 0;
            this.GymName.Text = "GymHub";
            this.GymName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GymName.Click += new System.EventHandler(this.label1_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.Gray;
            this.User.Location = new System.Drawing.Point(56, 278);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(53, 24);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            this.User.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.User.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameCollaborators
            // 
            this.NameCollaborators.AutoSize = true;
            this.NameCollaborators.BackColor = System.Drawing.Color.Transparent;
            this.NameCollaborators.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Italic);
            this.NameCollaborators.ForeColor = System.Drawing.Color.White;
            this.NameCollaborators.Location = new System.Drawing.Point(34, 458);
            this.NameCollaborators.Name = "NameCollaborators";
            this.NameCollaborators.Size = new System.Drawing.Size(128, 25);
            this.NameCollaborators.TabIndex = 0;
            this.NameCollaborators.Text = "Collaborators";
            this.NameCollaborators.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameCollaborators.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.BackColor = System.Drawing.Color.Transparent;
            this.TextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.ForeColor = System.Drawing.Color.Gray;
            this.TextPassword.Location = new System.Drawing.Point(36, 331);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(100, 24);
            this.TextPassword.TabIndex = 0;
            this.TextPassword.Text = "Password";
            this.TextPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(142, 325);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(213, 30);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LoginButton.FlatAppearance.BorderSize = 2;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.SeaShell;
            this.LoginButton.Location = new System.Drawing.Point(142, 400);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(142, 40);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.TextBoxUser.Location = new System.Drawing.Point(142, 276);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(215, 30);
            this.TextBoxUser.TabIndex = 0;
            this.TextBoxUser.TextChanged += new System.EventHandler(this.TextBoxUser_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "https://github.com/josedavd-07";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Gimmnasio.Properties.Resources.githublogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(40, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "https://github.com/Joelanaya";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Gimmnasio.Properties.Resources.githublogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(40, 526);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 27);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Gimmnasio.Properties.Resources.gymr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(424, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.NameCollaborators);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.User);
            this.Controls.Add(this.GymName);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GymHub Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GymName;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label NameCollaborators;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

