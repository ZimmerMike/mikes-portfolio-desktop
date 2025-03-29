namespace MyPortfolioDesktopApp.UserControls
{
    partial class AboutMe
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            SaveButton = new Button();
            dataGridView2 = new DataGridView();
            LanguageColumn = new DataGridViewTextBoxColumn();
            LevelColumn = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            TechColumn = new DataGridViewTextBoxColumn();
            ExperienceColumn = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(971, 40);
            label1.TabIndex = 0;
            label1.Text = "Sobre Mí";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 98);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 81);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 75);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 2;
            label2.Text = "Resumen de Trayectoria";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 24);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Agrega un interes";
            textBox2.Size = new Size(347, 27);
            textBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 57);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(390, 84);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(359, 24);
            button1.Name = "button1";
            button1.Size = new Size(40, 27);
            button1.TabIndex = 6;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(801, 616);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(167, 42);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Guardar cambios";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { LanguageColumn, LevelColumn });
            dataGridView2.Location = new Point(6, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(412, 172);
            dataGridView2.TabIndex = 11;
            // 
            // LanguageColumn
            // 
            LanguageColumn.HeaderText = "Idioma";
            LanguageColumn.MinimumWidth = 6;
            LanguageColumn.Name = "LanguageColumn";
            // 
            // LevelColumn
            // 
            LevelColumn.HeaderText = "Nivel";
            LevelColumn.MinimumWidth = 6;
            LevelColumn.Name = "LevelColumn";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(108, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(287, 27);
            textBox3.TabIndex = 13;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(41, 127);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 16;
            label9.Text = "Agenda";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(35, 85);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 15;
            label8.Text = "Teléfono";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(56, 44);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(520, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 181);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Contacto";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(108, 124);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(287, 27);
            textBox5.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(108, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(287, 27);
            textBox4.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(28, 361);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 204);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tecnologías";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TechColumn, ExperienceColumn });
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(390, 172);
            dataGridView1.TabIndex = 0;
            // 
            // TechColumn
            // 
            TechColumn.HeaderText = "Tecnología";
            TechColumn.MinimumWidth = 6;
            TechColumn.Name = "TechColumn";
            // 
            // ExperienceColumn
            // 
            ExperienceColumn.HeaderText = "Años de Experiencia";
            ExperienceColumn.MinimumWidth = 6;
            ExperienceColumn.Name = "ExperienceColumn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(28, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(405, 164);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Intereses";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(520, 75);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(424, 204);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Idiomas";
            // 
            // AboutMe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(SaveButton);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AboutMe";
            Size = new Size(971, 661);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
        private Button SaveButton;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn LanguageColumn;
        private DataGridViewTextBoxColumn LevelColumn;
        private TextBox textBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TechColumn;
        private DataGridViewTextBoxColumn ExperienceColumn;
    }
}
