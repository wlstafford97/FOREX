namespace ForexJournal
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pipsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitLostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.entryTimeDataGridViewTextBoxColumn,
            this.exitTimeDataGridViewTextBoxColumn,
            this.tradeTypeDataGridViewTextBoxColumn,
            this.lotSizeDataGridViewTextBoxColumn,
            this.entryPriceDataGridViewTextBoxColumn,
            this.exitPriceDataGridViewTextBoxColumn,
            this.pipsDataGridViewTextBoxColumn,
            this.profitLostDataGridViewTextBoxColumn,
            this.accountTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tradesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1046, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // tradesBindingSource
            // 
            this.tradesBindingSource.DataSource = typeof(ForexJournal.Trades);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // entryTimeDataGridViewTextBoxColumn
            // 
            this.entryTimeDataGridViewTextBoxColumn.DataPropertyName = "entryTime";
            this.entryTimeDataGridViewTextBoxColumn.HeaderText = "entryTime";
            this.entryTimeDataGridViewTextBoxColumn.Name = "entryTimeDataGridViewTextBoxColumn";
            // 
            // exitTimeDataGridViewTextBoxColumn
            // 
            this.exitTimeDataGridViewTextBoxColumn.DataPropertyName = "exitTime";
            this.exitTimeDataGridViewTextBoxColumn.HeaderText = "exitTime";
            this.exitTimeDataGridViewTextBoxColumn.Name = "exitTimeDataGridViewTextBoxColumn";
            // 
            // tradeTypeDataGridViewTextBoxColumn
            // 
            this.tradeTypeDataGridViewTextBoxColumn.DataPropertyName = "tradeType";
            this.tradeTypeDataGridViewTextBoxColumn.HeaderText = "tradeType";
            this.tradeTypeDataGridViewTextBoxColumn.Name = "tradeTypeDataGridViewTextBoxColumn";
            // 
            // lotSizeDataGridViewTextBoxColumn
            // 
            this.lotSizeDataGridViewTextBoxColumn.DataPropertyName = "lotSize";
            this.lotSizeDataGridViewTextBoxColumn.HeaderText = "lotSize";
            this.lotSizeDataGridViewTextBoxColumn.Name = "lotSizeDataGridViewTextBoxColumn";
            // 
            // entryPriceDataGridViewTextBoxColumn
            // 
            this.entryPriceDataGridViewTextBoxColumn.DataPropertyName = "entryPrice";
            this.entryPriceDataGridViewTextBoxColumn.HeaderText = "entryPrice";
            this.entryPriceDataGridViewTextBoxColumn.Name = "entryPriceDataGridViewTextBoxColumn";
            // 
            // exitPriceDataGridViewTextBoxColumn
            // 
            this.exitPriceDataGridViewTextBoxColumn.DataPropertyName = "exitPrice";
            this.exitPriceDataGridViewTextBoxColumn.HeaderText = "exitPrice";
            this.exitPriceDataGridViewTextBoxColumn.Name = "exitPriceDataGridViewTextBoxColumn";
            // 
            // pipsDataGridViewTextBoxColumn
            // 
            this.pipsDataGridViewTextBoxColumn.DataPropertyName = "pips";
            this.pipsDataGridViewTextBoxColumn.HeaderText = "pips";
            this.pipsDataGridViewTextBoxColumn.Name = "pipsDataGridViewTextBoxColumn";
            // 
            // profitLostDataGridViewTextBoxColumn
            // 
            this.profitLostDataGridViewTextBoxColumn.DataPropertyName = "profitLost";
            this.profitLostDataGridViewTextBoxColumn.HeaderText = "profitLost";
            this.profitLostDataGridViewTextBoxColumn.Name = "profitLostDataGridViewTextBoxColumn";
            // 
            // accountTotalDataGridViewTextBoxColumn
            // 
            this.accountTotalDataGridViewTextBoxColumn.DataPropertyName = "accountTotal";
            this.accountTotalDataGridViewTextBoxColumn.HeaderText = "accountTotal";
            this.accountTotalDataGridViewTextBoxColumn.Name = "accountTotalDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pipsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitLostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tradesBindingSource;
    }
}