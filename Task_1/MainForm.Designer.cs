namespace Task_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FunctionsGroupBox = new System.Windows.Forms.GroupBox();
            this.PlanetsInfoButton = new System.Windows.Forms.Button();
            this.AddStarButton = new System.Windows.Forms.Button();
            this.NameStarButton = new System.Windows.Forms.Button();
            this.CountPlanetButton = new System.Windows.Forms.Button();
            this.AddPlanetButton = new System.Windows.Forms.Button();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.FunctionsGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.30879F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.69121F));
            this.MainTableLayoutPanel.Controls.Add(this.FunctionsGroupBox, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.InfoGroupBox, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(842, 566);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // FunctionsGroupBox
            // 
            this.FunctionsGroupBox.Controls.Add(this.PlanetsInfoButton);
            this.FunctionsGroupBox.Controls.Add(this.AddStarButton);
            this.FunctionsGroupBox.Controls.Add(this.NameStarButton);
            this.FunctionsGroupBox.Controls.Add(this.CountPlanetButton);
            this.FunctionsGroupBox.Controls.Add(this.AddPlanetButton);
            this.FunctionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.FunctionsGroupBox.Name = "FunctionsGroupBox";
            this.FunctionsGroupBox.Size = new System.Drawing.Size(165, 560);
            this.FunctionsGroupBox.TabIndex = 0;
            this.FunctionsGroupBox.TabStop = false;
            this.FunctionsGroupBox.Text = "Функции";
            // 
            // PlanetsInfoButton
            // 
            this.PlanetsInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlanetsInfoButton.Location = new System.Drawing.Point(28, 201);
            this.PlanetsInfoButton.Name = "PlanetsInfoButton";
            this.PlanetsInfoButton.Size = new System.Drawing.Size(118, 37);
            this.PlanetsInfoButton.TabIndex = 4;
            this.PlanetsInfoButton.Text = "Планеты";
            this.PlanetsInfoButton.UseVisualStyleBackColor = true;
            this.PlanetsInfoButton.Click += new System.EventHandler(this.PlanetsInfoButton_Click);
            // 
            // AddStarButton
            // 
            this.AddStarButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddStarButton.Location = new System.Drawing.Point(28, 75);
            this.AddStarButton.Name = "AddStarButton";
            this.AddStarButton.Size = new System.Drawing.Size(118, 36);
            this.AddStarButton.TabIndex = 1;
            this.AddStarButton.Text = "Добавить звезду";
            this.AddStarButton.UseVisualStyleBackColor = true;
            this.AddStarButton.Click += new System.EventHandler(this.AddStarButton_Click);
            // 
            // NameStarButton
            // 
            this.NameStarButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameStarButton.Location = new System.Drawing.Point(28, 159);
            this.NameStarButton.Name = "NameStarButton";
            this.NameStarButton.Size = new System.Drawing.Size(118, 36);
            this.NameStarButton.TabIndex = 3;
            this.NameStarButton.Text = "Название звезды";
            this.NameStarButton.UseVisualStyleBackColor = true;
            this.NameStarButton.Click += new System.EventHandler(this.NameStarButton_Click);
            // 
            // CountPlanetButton
            // 
            this.CountPlanetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountPlanetButton.Location = new System.Drawing.Point(28, 117);
            this.CountPlanetButton.Name = "CountPlanetButton";
            this.CountPlanetButton.Size = new System.Drawing.Size(118, 36);
            this.CountPlanetButton.TabIndex = 2;
            this.CountPlanetButton.Text = "Кол-во планет";
            this.CountPlanetButton.UseVisualStyleBackColor = true;
            this.CountPlanetButton.Click += new System.EventHandler(this.CountPlanetButton_Click);
            // 
            // AddPlanetButton
            // 
            this.AddPlanetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPlanetButton.Location = new System.Drawing.Point(28, 33);
            this.AddPlanetButton.Name = "AddPlanetButton";
            this.AddPlanetButton.Size = new System.Drawing.Size(118, 36);
            this.AddPlanetButton.TabIndex = 0;
            this.AddPlanetButton.Text = "Добавить планету";
            this.AddPlanetButton.UseVisualStyleBackColor = true;
            this.AddPlanetButton.Click += new System.EventHandler(this.AddPlanetButton_Click);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.InfoTextBox);
            this.InfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoGroupBox.Location = new System.Drawing.Point(174, 3);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(665, 560);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Информация";
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTextBox.Location = new System.Drawing.Point(3, 16);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.Size = new System.Drawing.Size(659, 541);
            this.InfoTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 566);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Звездная система";
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.FunctionsGroupBox.ResumeLayout(false);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.GroupBox FunctionsGroupBox;
        private System.Windows.Forms.Button PlanetsInfoButton;
        private System.Windows.Forms.Button AddStarButton;
        private System.Windows.Forms.Button NameStarButton;
        private System.Windows.Forms.Button CountPlanetButton;
        private System.Windows.Forms.Button AddPlanetButton;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox InfoTextBox;
    }
}

