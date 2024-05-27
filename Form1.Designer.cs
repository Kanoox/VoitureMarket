namespace Bibliotheque_cars
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
            loginBtn = new Button();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(172, 289);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(258, 55);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Connexion";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += button1_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(90, 156);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(422, 23);
            usernameBox.TabIndex = 1;
            usernameBox.TextChanged += textBox1_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(90, 218);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(422, 23);
            passwordBox.TabIndex = 2;
            passwordBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 38);
            label1.Name = "label1";
            label1.Size = new Size(474, 35);
            label1.TabIndex = 3;
            label1.Text = "Projet - Base de données de voiture";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 131);
            label2.Name = "label2";
            label2.Size = new Size(130, 22);
            label2.TabIndex = 4;
            label2.Text = "Nom d'utilisateur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 193);
            label3.Name = "label3";
            label3.Size = new Size(101, 22);
            label3.TabIndex = 5;
            label3.Text = "Mot de Passe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 420);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(loginBtn);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
