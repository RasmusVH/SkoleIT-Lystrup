namespace APBLauncherRemake
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.selectFolder = new System.Windows.Forms.Button();
            this.folderPath = new System.Windows.Forms.Label();
            this.startAPB = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Button();
            this.entraveText = new System.Windows.Forms.Label();
            this.apbPOP = new System.Windows.Forms.Button();
            this.contactLabel = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.browseConfigsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clockMainTimer = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.weekdayLabel = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.contactText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.applyConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectFolder
            // 
            this.selectFolder.AutoSize = true;
            this.selectFolder.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.selectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectFolder.Location = new System.Drawing.Point(387, 597);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(249, 37);
            this.selectFolder.TabIndex = 0;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = false;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // folderPath
            // 
            this.folderPath.AutoSize = true;
            this.folderPath.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.folderPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.folderPath.Location = new System.Drawing.Point(387, 637);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(0, 15);
            this.folderPath.TabIndex = 1;
            // 
            // startAPB
            // 
            this.startAPB.AutoSize = true;
            this.startAPB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.startAPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startAPB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startAPB.Location = new System.Drawing.Point(642, 597);
            this.startAPB.Name = "startAPB";
            this.startAPB.Size = new System.Drawing.Size(73, 37);
            this.startAPB.TabIndex = 2;
            this.startAPB.Text = "Start APB";
            this.startAPB.UseVisualStyleBackColor = false;
            this.startAPB.Click += new System.EventHandler(this.startAPB_Click);
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.information.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.information.Location = new System.Drawing.Point(308, 597);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(73, 37);
            this.information.TabIndex = 3;
            this.information.Text = "?";
            this.information.UseVisualStyleBackColor = false;
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // entraveText
            // 
            this.entraveText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.entraveText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.entraveText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.entraveText.Location = new System.Drawing.Point(387, 9);
            this.entraveText.Name = "entraveText";
            this.entraveText.Size = new System.Drawing.Size(249, 35);
            this.entraveText.TabIndex = 4;
            this.entraveText.Text = "Entrave";
            this.entraveText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // apbPOP
            // 
            this.apbPOP.AutoSize = true;
            this.apbPOP.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.apbPOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apbPOP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.apbPOP.Location = new System.Drawing.Point(12, 392);
            this.apbPOP.Name = "apbPOP";
            this.apbPOP.Size = new System.Drawing.Size(131, 37);
            this.apbPOP.TabIndex = 5;
            this.apbPOP.Text = "Check Population";
            this.apbPOP.UseVisualStyleBackColor = false;
            this.apbPOP.Click += new System.EventHandler(this.apbPOP_Click);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.contactLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactLabel.Location = new System.Drawing.Point(12, 149);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(131, 37);
            this.contactLabel.TabIndex = 6;
            this.contactLabel.Text = "Contact";
            this.contactLabel.UseVisualStyleBackColor = false;
            this.contactLabel.Click += new System.EventHandler(this.contactLabel_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.AutoSize = true;
            this.downloadButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.downloadButton.Location = new System.Drawing.Point(12, 316);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(131, 37);
            this.downloadButton.TabIndex = 8;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // browseConfigsButton
            // 
            this.browseConfigsButton.AutoSize = true;
            this.browseConfigsButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.browseConfigsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseConfigsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseConfigsButton.Location = new System.Drawing.Point(12, 225);
            this.browseConfigsButton.Name = "browseConfigsButton";
            this.browseConfigsButton.Size = new System.Drawing.Size(131, 37);
            this.browseConfigsButton.TabIndex = 7;
            this.browseConfigsButton.Text = "Browse Configs";
            this.browseConfigsButton.UseVisualStyleBackColor = false;
            this.browseConfigsButton.Click += new System.EventHandler(this.browseConfigsButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(387, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "APB Launcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clockMainTimer
            // 
            this.clockMainTimer.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockMainTimer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clockMainTimer.Location = new System.Drawing.Point(853, 236);
            this.clockMainTimer.Name = "clockMainTimer";
            this.clockMainTimer.Size = new System.Drawing.Size(143, 33);
            this.clockMainTimer.TabIndex = 10;
            this.clockMainTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DayLabel
            // 
            this.DayLabel.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DayLabel.Location = new System.Drawing.Point(853, 271);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(143, 33);
            this.DayLabel.TabIndex = 11;
            this.DayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weekdayLabel
            // 
            this.weekdayLabel.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weekdayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.weekdayLabel.Location = new System.Drawing.Point(853, 306);
            this.weekdayLabel.Name = "weekdayLabel";
            this.weekdayLabel.Size = new System.Drawing.Size(143, 33);
            this.weekdayLabel.TabIndex = 12;
            this.weekdayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // contactText
            // 
            this.contactText.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contactText.Location = new System.Drawing.Point(12, 113);
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(131, 33);
            this.contactText.TabIndex = 13;
            this.contactText.Text = "Contact";
            this.contactText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Configs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Misc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(1, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 48);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adv Launcher";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applyConfig
            // 
            this.applyConfig.AutoSize = true;
            this.applyConfig.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.applyConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applyConfig.Location = new System.Drawing.Point(444, 554);
            this.applyConfig.Name = "applyConfig";
            this.applyConfig.Size = new System.Drawing.Size(131, 37);
            this.applyConfig.TabIndex = 17;
            this.applyConfig.Text = "Apply Config";
            this.applyConfig.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.applyConfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contactText);
            this.Controls.Add(this.weekdayLabel);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.clockMainTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.browseConfigsButton);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.apbPOP);
            this.Controls.Add(this.entraveText);
            this.Controls.Add(this.information);
            this.Controls.Add(this.startAPB);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.selectFolder);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainWindow";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button selectFolder;
        private Label folderPath;
        private Button startAPB;
        private Button information;
        private Label entraveText;
        private Button apbPOP;
        private Button contactLabel;
        private Button downloadButton;
        private Button browseConfigsButton;
        private Label label1;
        private Label clockMainTimer;
        private Label DayLabel;
        private Label weekdayLabel;
        private System.Windows.Forms.Timer Clock;
        private Label contactText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button applyConfig;
    }
}