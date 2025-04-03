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
            DashboardTab = new TabPage();
            dashboard2 = new MyPortfolioDesktopApp.UserControls.Dashboard();
            AboutTab = new TabPage();
            aboutMeControl1 = new MyPortfolioDesktopApp.UserControls.AboutMeControl();
            ProyectsTab = new TabPage();
            projects1 = new MyPortfolioDesktopApp.UserControls.Projects();
            ExperienceTab = new TabPage();
            experience1 = new MyPortfolioDesktopApp.UserControls.Experience();
            EducationTab = new TabPage();
            education1 = new MyPortfolioDesktopApp.UserControls.Education();
            CertificationsTab = new TabPage();
            certifications1 = new MyPortfolioDesktopApp.UserControls.Certifications();
            tabControlMain.SuspendLayout();
            DashboardTab.SuspendLayout();
            AboutTab.SuspendLayout();
            ProyectsTab.SuspendLayout();
            ExperienceTab.SuspendLayout();
            EducationTab.SuspendLayout();
            CertificationsTab.SuspendLayout();
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
            tabControlMain.Controls.Add(DashboardTab);
            tabControlMain.Controls.Add(AboutTab);
            tabControlMain.Controls.Add(ProyectsTab);
            tabControlMain.Controls.Add(ExperienceTab);
            tabControlMain.Controls.Add(EducationTab);
            tabControlMain.Controls.Add(CertificationsTab);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Multiline = true;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1009, 694);
            tabControlMain.TabIndex = 0;
            // 
            // DashboardTab
            // 
            DashboardTab.Controls.Add(dashboard2);
            DashboardTab.Location = new Point(4, 32);
            DashboardTab.Name = "DashboardTab";
            DashboardTab.Size = new Size(1001, 658);
            DashboardTab.TabIndex = 5;
            DashboardTab.Text = "📊 Dashboard";
            DashboardTab.UseVisualStyleBackColor = true;
            // 
            // dashboard2
            // 
            dashboard2.Dock = DockStyle.Fill;
            dashboard2.Location = new Point(0, 0);
            dashboard2.Name = "dashboard2";
            dashboard2.Size = new Size(1001, 658);
            dashboard2.TabIndex = 0;
            // 
            // AboutTab
            // 
            AboutTab.Controls.Add(aboutMeControl1);
            AboutTab.Location = new Point(4, 32);
            AboutTab.Name = "AboutTab";
            AboutTab.Padding = new Padding(3);
            AboutTab.Size = new Size(1001, 658);
            AboutTab.TabIndex = 0;
            AboutTab.Text = "👤 Sobre Mí";
            AboutTab.UseVisualStyleBackColor = true;
            // 
            // aboutMeControl1
            // 
            aboutMeControl1.Dock = DockStyle.Fill;
            aboutMeControl1.Location = new Point(3, 3);
            aboutMeControl1.Name = "aboutMeControl1";
            aboutMeControl1.Size = new Size(995, 652);
            aboutMeControl1.TabIndex = 0;
            // 
            // ProyectsTab
            // 
            ProyectsTab.Controls.Add(projects1);
            ProyectsTab.Location = new Point(4, 88);
            ProyectsTab.Name = "ProyectsTab";
            ProyectsTab.Padding = new Padding(3);
            ProyectsTab.Size = new Size(192, 8);
            ProyectsTab.TabIndex = 1;
            ProyectsTab.Text = "\U0001f9e9 Proyectos";
            ProyectsTab.UseVisualStyleBackColor = true;
            // 
            // projects1
            // 
            projects1.Dock = DockStyle.Fill;
            projects1.Location = new Point(3, 3);
            projects1.Name = "projects1";
            projects1.Size = new Size(186, 2);
            projects1.TabIndex = 0;
            // 
            // ExperienceTab
            // 
            ExperienceTab.Controls.Add(experience1);
            ExperienceTab.Location = new Point(4, 116);
            ExperienceTab.Name = "ExperienceTab";
            ExperienceTab.Size = new Size(192, 0);
            ExperienceTab.TabIndex = 2;
            ExperienceTab.Text = "\U0001f9f3 Experiencia";
            ExperienceTab.UseVisualStyleBackColor = true;
            // 
            // experience1
            // 
            experience1.Dock = DockStyle.Fill;
            experience1.Location = new Point(0, 0);
            experience1.Name = "experience1";
            experience1.Size = new Size(192, 0);
            experience1.TabIndex = 0;
            // 
            // EducationTab
            // 
            EducationTab.Controls.Add(education1);
            EducationTab.Location = new Point(4, 144);
            EducationTab.Name = "EducationTab";
            EducationTab.Size = new Size(192, 0);
            EducationTab.TabIndex = 3;
            EducationTab.Text = "🎓 Educación";
            EducationTab.UseVisualStyleBackColor = true;
            // 
            // education1
            // 
            education1.Dock = DockStyle.Fill;
            education1.Location = new Point(0, 0);
            education1.Name = "education1";
            education1.Size = new Size(192, 0);
            education1.TabIndex = 0;
            // 
            // CertificationsTab
            // 
            CertificationsTab.Controls.Add(certifications1);
            CertificationsTab.Location = new Point(4, 172);
            CertificationsTab.Name = "CertificationsTab";
            CertificationsTab.Size = new Size(192, 0);
            CertificationsTab.TabIndex = 4;
            CertificationsTab.Text = "🏅 Cursos y Certificaciones";
            CertificationsTab.UseVisualStyleBackColor = true;
            // 
            // certifications1
            // 
            certifications1.Dock = DockStyle.Fill;
            certifications1.Location = new Point(0, 0);
            certifications1.Name = "certifications1";
            certifications1.Size = new Size(192, 0);
            certifications1.TabIndex = 0;
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
            DashboardTab.ResumeLayout(false);
            AboutTab.ResumeLayout(false);
            ProyectsTab.ResumeLayout(false);
            ExperienceTab.ResumeLayout(false);
            EducationTab.ResumeLayout(false);
            CertificationsTab.ResumeLayout(false);
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
        private TabPage DashboardTab;
        private UserControls.AboutMeControl aboutMe1;
        private UserControls.Experience experience1;
        private UserControls.Education education1;
        private UserControls.Certifications certifications1;
        private UserControls.Dashboard dashboard1;
        private UserControls.Projects projects1;
        private UserControls.Dashboard dashboard2;
        private UserControls.AboutMeControl aboutMeControl1;
    }
}
