namespace MyPortfolioDesktopApp
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
            panelSidebar = new Panel();
            aboutButton = new Button();
            projectsButton = new Button();
            experienceButton = new Button();
            educationButton = new Button();
            certificationsButton = new Button();
            messagesButton = new Button();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Black;
            panelSidebar.Controls.Add(messagesButton);
            panelSidebar.Controls.Add(certificationsButton);
            panelSidebar.Controls.Add(educationButton);
            panelSidebar.Controls.Add(experienceButton);
            panelSidebar.Controls.Add(projectsButton);
            panelSidebar.Controls.Add(aboutButton);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 632);
            panelSidebar.TabIndex = 0;
            // 
            // aboutButton
            // 
            aboutButton.Location = new Point(0, 0);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(250, 50);
            aboutButton.TabIndex = 0;
            aboutButton.Text = "Sobre Mi";
            aboutButton.UseVisualStyleBackColor = true;
            // 
            // projectsButton
            // 
            projectsButton.Location = new Point(0, 56);
            projectsButton.Name = "projectsButton";
            projectsButton.Size = new Size(250, 50);
            projectsButton.TabIndex = 1;
            projectsButton.Text = "Proyectos";
            projectsButton.UseVisualStyleBackColor = true;
            // 
            // experienceButton
            // 
            experienceButton.Location = new Point(0, 112);
            experienceButton.Name = "experienceButton";
            experienceButton.Size = new Size(250, 50);
            experienceButton.TabIndex = 2;
            experienceButton.Text = "Experiencia";
            experienceButton.UseVisualStyleBackColor = true;
            // 
            // educationButton
            // 
            educationButton.Location = new Point(0, 168);
            educationButton.Name = "educationButton";
            educationButton.Size = new Size(250, 50);
            educationButton.TabIndex = 3;
            educationButton.Text = "Educacion";
            educationButton.UseVisualStyleBackColor = true;
            // 
            // certificationsButton
            // 
            certificationsButton.Location = new Point(0, 224);
            certificationsButton.Name = "certificationsButton";
            certificationsButton.Size = new Size(250, 50);
            certificationsButton.TabIndex = 4;
            certificationsButton.Text = "Cursos y Certificaciones";
            certificationsButton.UseVisualStyleBackColor = true;
            // 
            // messagesButton
            // 
            messagesButton.Location = new Point(0, 280);
            messagesButton.Name = "messagesButton";
            messagesButton.Size = new Size(250, 50);
            messagesButton.TabIndex = 5;
            messagesButton.Text = "Mensajes";
            messagesButton.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.SlateGray;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(250, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1095, 632);
            panelContent.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 632);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Name = "Form1";
            Text = "Form1";
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button messagesButton;
        private Button certificationsButton;
        private Button educationButton;
        private Button experienceButton;
        private Button projectsButton;
        private Button aboutButton;
        private Panel panelContent;
    }
}
