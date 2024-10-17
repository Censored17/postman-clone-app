namespace PostmanCloneUI
{
    partial class Dashboard
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
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            resultsText = new TextBox();
            callApiButton = new Button();
            resultsLabel = new Label();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(11, 19);
            formHeader.Margin = new Padding(2, 0, 2, 0);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(282, 86);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apiLabel.Location = new Point(11, 144);
            apiLabel.Margin = new Padding(2, 0, 2, 0);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(50, 30);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // apiText
            // 
            apiText.Font = new Font("Segoe UI", 15.75F);
            apiText.Location = new Point(11, 176);
            apiText.Margin = new Padding(2);
            apiText.Name = "apiText";
            apiText.Size = new Size(689, 35);
            apiText.TabIndex = 2;
            // 
            // resultsText
            // 
            resultsText.Font = new Font("Segoe UI", 15.75F);
            resultsText.Location = new Point(11, 273);
            resultsText.Margin = new Padding(2);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(777, 321);
            resultsText.TabIndex = 3;
            // 
            // callApiButton
            // 
            callApiButton.BackColor = Color.ForestGreen;
            callApiButton.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            callApiButton.ForeColor = Color.Snow;
            callApiButton.Location = new Point(704, 164);
            callApiButton.Margin = new Padding(2);
            callApiButton.Name = "callApiButton";
            callApiButton.Size = new Size(84, 84);
            callApiButton.TabIndex = 4;
            callApiButton.Text = "GO";
            callApiButton.UseVisualStyleBackColor = false;
            callApiButton.Click += callApiButton_Click;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultsLabel.Location = new Point(11, 241);
            resultsLabel.Margin = new Padding(2, 0, 2, 0);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(78, 30);
            resultsLabel.TabIndex = 5;
            resultsLabel.Text = "Results";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 603);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(799, 22);
            statusStrip.TabIndex = 6;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(39, 17);
            systemStatus.Text = "Status";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 625);
            Controls.Add(statusStrip);
            Controls.Add(resultsLabel);
            Controls.Add(callApiButton);
            Controls.Add(resultsText);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Postman Clone by JAM";
            Load += Dashboard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private TextBox resultsText;
        private Button callApiButton;
        private Label resultsLabel;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
    }
}
