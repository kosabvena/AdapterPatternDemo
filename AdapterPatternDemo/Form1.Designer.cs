namespace AdapterPatternDemo
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
            lblInfo = new Label();
            btnReadLegacy = new Button();
            btnReadAdapted = new Button();
            lstResults = new ListBox();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(12, 5);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(349, 40);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Adapter: приводим старый датчик (Фаренгейты) \r\nк новому интерфейсу (Цельсий)";
            // 
            // btnReadLegacy
            // 
            btnReadLegacy.Location = new Point(12, 48);
            btnReadLegacy.Name = "btnReadLegacy";
            btnReadLegacy.Size = new Size(162, 65);
            btnReadLegacy.TabIndex = 1;
            btnReadLegacy.Text = "Читать LegacyFahrenheitSensor напрямую";
            btnReadLegacy.UseVisualStyleBackColor = true;
            btnReadLegacy.Click += btnReadLegacy_Click;
            // 
            // btnReadAdapted
            // 
            btnReadAdapted.Location = new Point(180, 48);
            btnReadAdapted.Name = "btnReadAdapted";
            btnReadAdapted.Size = new Size(181, 65);
            btnReadAdapted.TabIndex = 2;
            btnReadAdapted.Text = "Читать через SensorAdapter";
            btnReadAdapted.UseVisualStyleBackColor = true;
            btnReadAdapted.Click += btnReadAdapted_Click;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.Location = new Point(12, 119);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(349, 184);
            lstResults.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 334);
            Controls.Add(lstResults);
            Controls.Add(btnReadAdapted);
            Controls.Add(btnReadLegacy);
            Controls.Add(lblInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Button btnReadLegacy;
        private Button btnReadAdapted;
        private ListBox lstResults;
    }
}
