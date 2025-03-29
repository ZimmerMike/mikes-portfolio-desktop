namespace MyPortfolioDesktopApp
{
    partial class MainForm
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
            panel1 = new Panel();
            tabControlMain = new TabControl();
            AboutTab = new TabPage();
            aboutMe1 = new MyPortfolioDesktopApp.UserControls.AboutMe();
            ProyectsTab = new TabPage();
            ExperienceTab = new TabPage();
            experience1 = new MyPortfolioDesktopApp.UserControls.Experience();
            EducationTab = new TabPage();
            education1 = new MyPortfolioDesktopApp.UserControls.Education();
            CertificationsTab = new TabPage();
            certifications1 = new MyPortfolioDesktopApp.UserControls.Certifications();
            MessagesTab = new TabPage();
            messages1 = new MyPortfolioDesktopApp.UserControls.Messages();
            projects1 = new MyPortfolioDesktopApp.UserControls.Projects();
            tabControlMain.SuspendLayout();
            AboutTab.SuspendLayout();
            ProyectsTab.SuspendLayout();
            ExperienceTab.SuspendLayout();
            EducationTab.SuspendLayout();
            CertificationsTab.SuspendLayout();
            MessagesTab.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 694);
            panel1.TabIndex = 0;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(AboutTab);
            tabControlMain.Controls.Add(ProyectsTab);
            tabControlMain.Controls.Add(ExperienceTab);
            tabControlMain.Controls.Add(EducationTab);
            tabControlMain.Controls.Add(CertificationsTab);
            tabControlMain.Controls.Add(MessagesTab);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Multiline = true;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1009, 694);
            tabControlMain.TabIndex = 0;
            // 
            // AboutTab
            // 
            AboutTab.Controls.Add(aboutMe1);
            AboutTab.Location = new Point(4, 32);
            AboutTab.Name = "AboutTab";
            AboutTab.Padding = new Padding(3);
            AboutTab.Size = new Size(1001, 658);
            AboutTab.TabIndex = 0;
            AboutTab.Text = "👤 Sobre Mí";
            AboutTab.UseVisualStyleBackColor = true;
            // 
            // aboutMe1
            // 
            aboutMe1.Dock = DockStyle.Fill;
            aboutMe1.Location = new Point(3, 3);
            aboutMe1.Name = "aboutMe1";
            aboutMe1.Size = new Size(995, 652);
            aboutMe1.TabIndex = 0;
            // 
            // ProyectsTab
            // 
            ProyectsTab.Controls.Add(projects1);
            ProyectsTab.Location = new Point(4, 32);
            ProyectsTab.Name = "ProyectsTab";
            ProyectsTab.Padding = new Padding(3);
            ProyectsTab.Size = new Size(1001, 658);
            ProyectsTab.TabIndex = 1;
            ProyectsTab.Text = "\U0001f9e9 Proyectos";
            ProyectsTab.UseVisualStyleBackColor = true;
            // 
            // ExperienceTab
            // 
            ExperienceTab.Controls.Add(experience1);
            ExperienceTab.Location = new Point(4, 32);
            ExperienceTab.Name = "ExperienceTab";
            ExperienceTab.Size = new Size(1001, 658);
            ExperienceTab.TabIndex = 2;
            ExperienceTab.Text = "\U0001f9f3 Experiencia";
            ExperienceTab.UseVisualStyleBackColor = true;
            // 
            // experience1
            // 
            experience1.Dock = DockStyle.Fill;
            experience1.Location = new Point(0, 0);
            experience1.Name = "experience1";
            experience1.Size = new Size(1001, 658);
            experience1.TabIndex = 0;
            // 
            // EducationTab
            // 
            EducationTab.Controls.Add(education1);
            EducationTab.Location = new Point(4, 32);
            EducationTab.Name = "EducationTab";
            EducationTab.Size = new Size(1001, 658);
            EducationTab.TabIndex = 3;
            EducationTab.Text = "🎓 Educación";
            EducationTab.UseVisualStyleBackColor = true;
            // 
            // education1
            // 
            education1.Dock = DockStyle.Fill;
            education1.Location = new Point(0, 0);
            education1.Name = "education1";
            education1.Size = new Size(1001, 658);
            education1.TabIndex = 0;
            // 
            // CertificationsTab
            // 
            CertificationsTab.Controls.Add(certifications1);
            CertificationsTab.Location = new Point(4, 32);
            CertificationsTab.Name = "CertificationsTab";
            CertificationsTab.Size = new Size(1001, 658);
            CertificationsTab.TabIndex = 4;
            CertificationsTab.Text = "🏅 Cursos y Certificaciones";
            CertificationsTab.UseVisualStyleBackColor = true;
            // 
            // certifications1
            // 
            certifications1.Dock = DockStyle.Fill;
            certifications1.Location = new Point(0, 0);
            certifications1.Name = "certifications1";
            certifications1.Size = new Size(1001, 658);
            certifications1.TabIndex = 0;
            // 
            // MessagesTab
            // 
            MessagesTab.Controls.Add(messages1);
            MessagesTab.Location = new Point(4, 32);
            MessagesTab.Name = "MessagesTab";
            MessagesTab.Size = new Size(1001, 658);
            MessagesTab.TabIndex = 5;
            MessagesTab.Text = "📬Mensajes";
            MessagesTab.UseVisualStyleBackColor = true;
            // 
            // messages1
            // 
            messages1.Dock = DockStyle.Fill;
            messages1.Location = new Point(0, 0);
            messages1.Name = "messages1";
            messages1.Size = new Size(1001, 658);
            messages1.TabIndex = 0;
            // 
            // projects1
            // 
            projects1.Dock = DockStyle.Fill;
            projects1.Location = new Point(3, 3);
            projects1.Name = "projects1";
            projects1.Size = new Size(995, 652);
            projects1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 694);
            Controls.Add(tabControlMain);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor de Portafolio Laboral";
            tabControlMain.ResumeLayout(false);
            AboutTab.ResumeLayout(false);
            ProyectsTab.ResumeLayout(false);
            ExperienceTab.ResumeLayout(false);
            EducationTab.ResumeLayout(false);
            CertificationsTab.ResumeLayout(false);
            MessagesTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControlMain;
        private TabPage AboutTab;
        private TabPage ProyectsTab;
        private TabPage ExperienceTab;
        private TabPage EducationTab;
        private TabPage CertificationsTab;
        private TabPage MessagesTab;
        private UserControls.AboutMe aboutMe1;
        private UserControls.Experience experience1;
        private UserControls.Education education1;
        private UserControls.Certifications certifications1;
        private UserControls.Messages messages1;
        private UserControls.Projects projects1;
    }
}
