namespace ForexJournal
{
    partial class JournalForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.tradeSumBtn = new System.Windows.Forms.Button();
            this.tradeLogBtn = new System.Windows.Forms.Button();
            this.newEntryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(46, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(265, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Forex Journal";
            // 
            // tradeSumBtn
            // 
            this.tradeSumBtn.Location = new System.Drawing.Point(118, 67);
            this.tradeSumBtn.Name = "tradeSumBtn";
            this.tradeSumBtn.Size = new System.Drawing.Size(108, 23);
            this.tradeSumBtn.TabIndex = 1;
            this.tradeSumBtn.Text = "Trade Summary";
            this.tradeSumBtn.UseVisualStyleBackColor = true;
            // 
            // tradeLogBtn
            // 
            this.tradeLogBtn.Location = new System.Drawing.Point(118, 96);
            this.tradeLogBtn.Name = "tradeLogBtn";
            this.tradeLogBtn.Size = new System.Drawing.Size(108, 23);
            this.tradeLogBtn.TabIndex = 2;
            this.tradeLogBtn.Text = "Trade Log";
            this.tradeLogBtn.UseVisualStyleBackColor = true;
            this.tradeLogBtn.Click += new System.EventHandler(this.tradeLogBtn_Click);
            // 
            // newEntryBtn
            // 
            this.newEntryBtn.Location = new System.Drawing.Point(118, 125);
            this.newEntryBtn.Name = "newEntryBtn";
            this.newEntryBtn.Size = new System.Drawing.Size(108, 23);
            this.newEntryBtn.TabIndex = 5;
            this.newEntryBtn.Text = "New entry";
            this.newEntryBtn.UseVisualStyleBackColor = true;
            this.newEntryBtn.Click += new System.EventHandler(this.newEntryBtn_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 168);
            this.Controls.Add(this.newEntryBtn);
            this.Controls.Add(this.tradeLogBtn);
            this.Controls.Add(this.tradeSumBtn);
            this.Controls.Add(this.titleLabel);
            this.Name = "JournalForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button tradeSumBtn;
        private System.Windows.Forms.Button tradeLogBtn;
        private System.Windows.Forms.Button newEntryBtn;
    }
}

