namespace Random_Numbers_Generator
{
    partial class mainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftSidePanel = new System.Windows.Forms.Panel();
            this.generatorButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.upSidePanel = new System.Windows.Forms.Panel();
            this.minimalizedLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.currentPanelLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboardUC = new Random_Numbers_Generator.dashboard();
            this.generatorUC = new Random_Numbers_Generator.generator();
            this.leftSidePanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.upSidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftSidePanel
            // 
            this.leftSidePanel.BackColor = System.Drawing.Color.Gray;
            this.leftSidePanel.Controls.Add(this.generatorButton);
            this.leftSidePanel.Controls.Add(this.dashboardButton);
            this.leftSidePanel.Controls.Add(this.footerPanel);
            this.leftSidePanel.Controls.Add(this.logoPanel);
            this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.leftSidePanel.Name = "leftSidePanel";
            this.leftSidePanel.Size = new System.Drawing.Size(200, 500);
            this.leftSidePanel.TabIndex = 0;
            // 
            // generatorButton
            // 
            this.generatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generatorButton.ForeColor = System.Drawing.Color.Lime;
            this.generatorButton.Location = new System.Drawing.Point(3, 162);
            this.generatorButton.Name = "generatorButton";
            this.generatorButton.Size = new System.Drawing.Size(194, 50);
            this.generatorButton.TabIndex = 3;
            this.generatorButton.Text = "Generator";
            this.generatorButton.UseVisualStyleBackColor = true;
            this.generatorButton.Click += new System.EventHandler(this.generatorButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dashboardButton.ForeColor = System.Drawing.Color.Blue;
            this.dashboardButton.Location = new System.Drawing.Point(3, 106);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(194, 50);
            this.dashboardButton.TabIndex = 2;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.footerPanel.Controls.Add(this.label2);
            this.footerPanel.Controls.Add(this.label1);
            this.footerPanel.Location = new System.Drawing.Point(0, 449);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(200, 50);
            this.footerPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last updated 2018-11-12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created by Norbert Lubaszka";
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Silver;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // upSidePanel
            // 
            this.upSidePanel.BackColor = System.Drawing.Color.Gray;
            this.upSidePanel.Controls.Add(this.minimalizedLabel);
            this.upSidePanel.Controls.Add(this.exitLabel);
            this.upSidePanel.Controls.Add(this.currentPanelLabel);
            this.upSidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upSidePanel.Location = new System.Drawing.Point(200, 0);
            this.upSidePanel.Name = "upSidePanel";
            this.upSidePanel.Size = new System.Drawing.Size(600, 100);
            this.upSidePanel.TabIndex = 1;
            // 
            // minimalizedLabel
            // 
            this.minimalizedLabel.AutoSize = true;
            this.minimalizedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimalizedLabel.Location = new System.Drawing.Point(538, 6);
            this.minimalizedLabel.Name = "minimalizedLabel";
            this.minimalizedLabel.Size = new System.Drawing.Size(20, 24);
            this.minimalizedLabel.TabIndex = 2;
            this.minimalizedLabel.Text = "_";
            this.minimalizedLabel.Click += new System.EventHandler(this.minimalizedLabel_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitLabel.Location = new System.Drawing.Point(564, 9);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(24, 24);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // currentPanelLabel
            // 
            this.currentPanelLabel.AutoSize = true;
            this.currentPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentPanelLabel.ForeColor = System.Drawing.Color.Lime;
            this.currentPanelLabel.Location = new System.Drawing.Point(6, 22);
            this.currentPanelLabel.Name = "currentPanelLabel";
            this.currentPanelLabel.Size = new System.Drawing.Size(261, 55);
            this.currentPanelLabel.TabIndex = 0;
            this.currentPanelLabel.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dashboardUC);
            this.panel1.Controls.Add(this.generatorUC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 2;
            // 
            // dashboardUC
            // 
            this.dashboardUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUC.Location = new System.Drawing.Point(0, 0);
            this.dashboardUC.Name = "dashboardUC";
            this.dashboardUC.Size = new System.Drawing.Size(600, 400);
            this.dashboardUC.TabIndex = 0;
            // 
            // generatorUC
            // 
            this.generatorUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.generatorUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generatorUC.Location = new System.Drawing.Point(0, 0);
            this.generatorUC.Name = "generatorUC";
            this.generatorUC.Size = new System.Drawing.Size(600, 400);
            this.generatorUC.TabIndex = 1;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.upSidePanel);
            this.Controls.Add(this.leftSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Numbers Generator";
            this.leftSidePanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.upSidePanel.ResumeLayout(false);
            this.upSidePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel upSidePanel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button generatorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentPanelLabel;
        private System.Windows.Forms.Label minimalizedLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Panel panel1;
        private dashboard dashboardUC;
        private generator generatorUC;
    }
}

