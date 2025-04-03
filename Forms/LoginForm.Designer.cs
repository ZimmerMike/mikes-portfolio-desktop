namespace MyPortfolioDesktopApp
{
    partial class LoginForm
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
            tabControl = new TabControl();
            tabLogin = new TabPage();
            label1 = new Label();
            txtLoginEmail = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            tabRegister = new TabPage();
            btnRegister = new Button();
            cmbModality = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            cmbJobType = new ComboBox();
            dtpStartWorkingDate = new DateTimePicker();
            label10 = new Label();
            txtCurrentResidence = new TextBox();
            label9 = new Label();
            dtpBirthDate = new DateTimePicker();
            label8 = new Label();
            txtMaternalSurname = new TextBox();
            label7 = new Label();
            txtPaternalSurname = new TextBox();
            label6 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtRegisterPassword = new TextBox();
            label4 = new Label();
            txtRegisterEmail = new TextBox();
            label3 = new Label();
            tabControl.SuspendLayout();
            tabLogin.SuspendLayout();
            tabRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabLogin);
            tabControl.Controls.Add(tabRegister);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(457, 641);
            tabControl.TabIndex = 0;
            // 
            // tabLogin
            // 
            tabLogin.Controls.Add(label1);
            tabLogin.Controls.Add(txtLoginEmail);
            tabLogin.Controls.Add(label2);
            tabLogin.Controls.Add(btnLogin);
            tabLogin.Controls.Add(txtLoginPassword);
            tabLogin.Location = new Point(4, 29);
            tabLogin.Name = "tabLogin";
            tabLogin.Padding = new Padding(3);
            tabLogin.Size = new Size(449, 608);
            tabLogin.TabIndex = 0;
            tabLogin.Text = "Iniciar sesión";
            tabLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 189);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 6;
            label1.Text = "Correo electrónico:";
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLoginEmail.Location = new Point(74, 212);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.PlaceholderText = "Correo electrónico";
            txtLoginEmail.Size = new Size(300, 27);
            txtLoginEmail.TabIndex = 5;
            txtLoginEmail.KeyDown += txtLoginEmail_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 262);
            label2.Margin = new Padding(3, 20, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 7;
            label2.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(149, 335);
            btnLogin.Margin = new Padding(3, 20, 3, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 29);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLoginPassword.Location = new Point(74, 285);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PlaceholderText = "Contraseña";
            txtLoginPassword.Size = new Size(300, 27);
            txtLoginPassword.TabIndex = 8;
            txtLoginPassword.UseSystemPasswordChar = true;
            txtLoginPassword.KeyDown += txtLoginPassword_KeyDown;
            // 
            // tabRegister
            // 
            tabRegister.Controls.Add(btnRegister);
            tabRegister.Controls.Add(cmbModality);
            tabRegister.Controls.Add(label12);
            tabRegister.Controls.Add(label11);
            tabRegister.Controls.Add(cmbJobType);
            tabRegister.Controls.Add(dtpStartWorkingDate);
            tabRegister.Controls.Add(label10);
            tabRegister.Controls.Add(txtCurrentResidence);
            tabRegister.Controls.Add(label9);
            tabRegister.Controls.Add(dtpBirthDate);
            tabRegister.Controls.Add(label8);
            tabRegister.Controls.Add(txtMaternalSurname);
            tabRegister.Controls.Add(label7);
            tabRegister.Controls.Add(txtPaternalSurname);
            tabRegister.Controls.Add(label6);
            tabRegister.Controls.Add(txtName);
            tabRegister.Controls.Add(label5);
            tabRegister.Controls.Add(txtRegisterPassword);
            tabRegister.Controls.Add(label4);
            tabRegister.Controls.Add(txtRegisterEmail);
            tabRegister.Controls.Add(label3);
            tabRegister.Location = new Point(4, 29);
            tabRegister.Name = "tabRegister";
            tabRegister.Padding = new Padding(3);
            tabRegister.Size = new Size(449, 608);
            tabRegister.TabIndex = 1;
            tabRegister.Text = "Registrarse";
            tabRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(149, 548);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 29);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // cmbModality
            // 
            cmbModality.FormattingEnabled = true;
            cmbModality.Items.AddRange(new object[] { "Remoto", "Presencial", "Híbrido" });
            cmbModality.Location = new Point(229, 502);
            cmbModality.Margin = new Padding(3, 3, 3, 15);
            cmbModality.Name = "cmbModality";
            cmbModality.Size = new Size(145, 28);
            cmbModality.TabIndex = 19;
            cmbModality.Text = "Modalidad";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(229, 479);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 18;
            label12.Text = "Modalidad";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(74, 479);
            label11.Name = "label11";
            label11.Size = new Size(115, 20);
            label11.TabIndex = 17;
            label11.Text = "Tipo de empleo";
            // 
            // cmbJobType
            // 
            cmbJobType.FormattingEnabled = true;
            cmbJobType.Items.AddRange(new object[] { "Medio tiempo", "Tiempo completo" });
            cmbJobType.Location = new Point(74, 502);
            cmbJobType.Margin = new Padding(3, 3, 3, 15);
            cmbJobType.Name = "cmbJobType";
            cmbJobType.Size = new Size(145, 28);
            cmbJobType.TabIndex = 16;
            cmbJobType.Text = "Tipo de empleo";
            // 
            // dtpStartWorkingDate
            // 
            dtpStartWorkingDate.Location = new Point(74, 437);
            dtpStartWorkingDate.Margin = new Padding(3, 3, 3, 15);
            dtpStartWorkingDate.Name = "dtpStartWorkingDate";
            dtpStartWorkingDate.Size = new Size(300, 27);
            dtpStartWorkingDate.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(75, 414);
            label10.Name = "label10";
            label10.Size = new Size(159, 20);
            label10.TabIndex = 14;
            label10.Text = "Fecha de inicio laboral";
            // 
            // txtCurrentResidence
            // 
            txtCurrentResidence.Location = new Point(74, 372);
            txtCurrentResidence.Margin = new Padding(3, 3, 3, 15);
            txtCurrentResidence.Name = "txtCurrentResidence";
            txtCurrentResidence.PlaceholderText = "Lugar de residencia";
            txtCurrentResidence.Size = new Size(300, 27);
            txtCurrentResidence.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(74, 349);
            label9.Name = "label9";
            label9.Size = new Size(138, 20);
            label9.TabIndex = 12;
            label9.Text = "Lugar de residencia";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(74, 307);
            dtpBirthDate.Margin = new Padding(3, 3, 3, 15);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(300, 27);
            dtpBirthDate.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 284);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 10;
            label8.Text = "Fecha de nacimiento";
            // 
            // txtMaternalSurname
            // 
            txtMaternalSurname.Location = new Point(229, 242);
            txtMaternalSurname.Margin = new Padding(3, 3, 3, 15);
            txtMaternalSurname.Name = "txtMaternalSurname";
            txtMaternalSurname.PlaceholderText = "Apellido materno";
            txtMaternalSurname.Size = new Size(145, 27);
            txtMaternalSurname.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 219);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 8;
            label7.Text = "Apellido materno";
            // 
            // txtPaternalSurname
            // 
            txtPaternalSurname.Location = new Point(74, 242);
            txtPaternalSurname.Margin = new Padding(3, 3, 3, 15);
            txtPaternalSurname.Name = "txtPaternalSurname";
            txtPaternalSurname.PlaceholderText = "Apellido paterno";
            txtPaternalSurname.Size = new Size(145, 27);
            txtPaternalSurname.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 219);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 6;
            label6.Text = "Apellido paterno";
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 177);
            txtName.Margin = new Padding(3, 3, 3, 15);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre(s)";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 154);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Nombre(s)";
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(74, 112);
            txtRegisterPassword.Margin = new Padding(3, 3, 3, 15);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.PlaceholderText = "Contraseña";
            txtRegisterPassword.Size = new Size(300, 27);
            txtRegisterPassword.TabIndex = 3;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 89);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 2;
            label4.Text = "Contraseña";
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.Location = new Point(74, 47);
            txtRegisterEmail.Margin = new Padding(3, 3, 3, 15);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.PlaceholderText = "Correo electrónico";
            txtRegisterEmail.Size = new Size(300, 27);
            txtRegisterEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 24);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 0;
            label3.Text = "Correo electrónico";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 641);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            tabControl.ResumeLayout(false);
            tabLogin.ResumeLayout(false);
            tabLogin.PerformLayout();
            tabRegister.ResumeLayout(false);
            tabRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabRegister;
        private TabPage tabLogin;
        private Label label1;
        private TextBox txtLoginEmail;
        private Label label2;
        private Button btnLogin;
        private TextBox txtLoginPassword;
        private Label label5;
        private TextBox txtRegisterPassword;
        private Label label4;
        private TextBox txtRegisterEmail;
        private Label label3;
        private Label label11;
        private ComboBox cmbJobType;
        private DateTimePicker dtpStartWorkingDate;
        private Label label10;
        private TextBox txtCurrentResidence;
        private Label label9;
        private DateTimePicker dtpBirthDate;
        private Label label8;
        private TextBox txtMaternalSurname;
        private Label label7;
        private TextBox txtPaternalSurname;
        private Label label6;
        private TextBox txtName;
        private Button btnRegister;
        private ComboBox cmbModality;
        private Label label12;
    }
}