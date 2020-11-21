using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ForexJournal
{
    public partial class NewEntryForm : Form
    {
        public NewEntryForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            List<Trades> trades;
            using (var reader = new StreamReader(@"C:\Users\Lucas\Downloads\tradelog.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                trades = csv.GetRecords<Trades>().ToList();
            }
            File.AppendAllText(@"C:\Users\Lucas\Downloads\tradelog.csv", $"{textBox1.Text}, {textBox2.Text}, {textBox3.Text}, " +
                $"{textBox4.Text}, {textBox5.Text}, {textBox6.Text}, {textBox7.Text}, {textBox8.Text}, {textBox9.Text}, {textBox10.Text}\n");
            if(MessageBox.Show("Entry successfully submitted. Do you have another entry?", "Message Box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBox1.Clear();

            }
        }
    }
}
