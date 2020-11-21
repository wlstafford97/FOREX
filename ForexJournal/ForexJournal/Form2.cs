using CsvHelper;
using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace ForexJournal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            List<Trades> trades;
            using (var reader = new StreamReader(@"C:\Users\Lucas\Downloads\tradelog.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                trades = csv.GetRecords<Trades>().ToList();
            }
            dataGridView1.DataSource = trades;
        }
    }
}
