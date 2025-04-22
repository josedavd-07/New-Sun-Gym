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
            this.GymName = new System.Windows.Forms.Label();
            this.NameStudent = new System.Windows.Forms.Label();
            this.NameDeveloper = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GymName
            // 
            this.GymName.AutoSize = true;
            this.GymName.BackColor = System.Drawing.Color.Transparent;
            this.GymName.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GymName.ForeColor = System.Drawing.Color.White;
            this.GymName.Location = new System.Drawing.Point(222, 9);
            this.GymName.Name = "GymName";
            this.GymName.Size = new System.Drawing.Size(424, 48);
            this.GymName.TabIndex = 0;
            this.GymName.Text = "☀️New Sun Gym☀️";
            this.GymName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GymName.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameStudent
            // 
            this.NameStudent.AutoSize = true;
            this.NameStudent.BackColor = System.Drawing.Color.Transparent;
            this.NameStudent.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameStudent.ForeColor = System.Drawing.Color.Gray;
            this.NameStudent.Location = new System.Drawing.Point(32, 179);
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.Size = new System.Drawing.Size(371, 25);
            this.NameStudent.TabIndex = 0;
            this.NameStudent.Text = "Jose David Carranza Angarita";
            this.NameStudent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameStudent.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameDeveloper
            // 
            this.NameDeveloper.AutoSize = true;
            this.NameDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.NameDeveloper.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameDeveloper.ForeColor = System.Drawing.Color.Yellow;
            this.NameDeveloper.Location = new System.Drawing.Point(614, 415);
            this.NameDeveloper.Name = "NameDeveloper";
            this.NameDeveloper.Size = new System.Drawing.Size(264, 31);
            this.NameDeveloper.TabIndex = 0;
            this.NameDeveloper.Text = "JoseDavdMast3r";
            this.NameDeveloper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameDeveloper.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.BackColor = System.Drawing.Color.Transparent;
            this.TextPassword.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.ForeColor = System.Drawing.Color.Gray;
            this.TextPassword.Location = new System.Drawing.Point(32, 271);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(125, 25);
            this.TextPassword.TabIndex = 0;
            this.TextPassword.Text = "Password";
            this.TextPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(163, 271);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(213, 30);
            this.TextBoxPassword.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DimGray;
            this.LoginButton.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(363, 339);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(142, 40);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gimmnasio.Properties.Resources.Background_Gym;
            this.ClientSize = new System.Drawing.Size(890, 455);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.NameDeveloper);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.NameStudent);
            this.Controls.Add(this.GymName);
            this.Name = "Form1";
            this.Text = "New Sun Gym";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GymName;
        private System.Windows.Forms.Label NameStudent;
        private System.Windows.Forms.Label NameDeveloper;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button LoginButton;
    }
}

