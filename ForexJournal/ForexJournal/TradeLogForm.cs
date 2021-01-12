using CsvHelper;
using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace ForexJournal
{
    public partial class TradeLogForm : Form
    {
        public TradeLogForm()
        {
            InitializeComponent();
            List<Trades> trades;
            using (var reader = new StreamReader(@".\CSV\tradelog.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.MissingFieldFound = null;
                trades = csv.GetRecords<Trades>().ToList();
            }
            dataGridView1.DataSource = trades;
        }
    }
}
