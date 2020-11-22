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
            double nAccTtl;
            double profitLoss;
            double pips;
            string lastLine = File.ReadLines(@".\CSV\tradelog.csv").Last();
            string[] lLArray = lastLine.Split(',');
            double accTtl = double.Parse(lLArray[9]);
            double entryP = double.Parse(textBox6.Text);
            double exitP = double.Parse(textBox7.Text);
            using (var reader = new StreamReader(@"C:.\CSV\tradelog.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                trades = csv.GetRecords<Trades>().ToList();
            }
            if (comboBox1.SelectedItem.Equals("SELL"))
            {
                profitLoss = entryP - exitP;
                pips = profitLoss / (double.Parse(comboBox2.SelectedItem.ToString())*10);
                nAccTtl = accTtl + profitLoss;
            }
            else
            {
                profitLoss = entryP + exitP;
                pips = profitLoss / (double.Parse(comboBox2.SelectedItem.ToString()) * 10)
                nAccTtl = accTtl + profitLoss;
            }
            File.AppendAllText(@".\CSV\tradelog.csv", $"{dateTimePicker1.Text},{textBox2.Text},{textBox3.Text}," +
                $"{comboBox1.Text},{comboBox2.Text},{textBox6.Text},{textBox7.Text},{profitLoss.ToString()},{pips.ToString()},{nAccTtl.ToString()}\n");

            if(MessageBox.Show("Entry successfully submitted. Do you have another entry?", "Message Box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                {
                    textBox.Text = "";
                }
            } else
            {
                this.Close();
            }
        }
    }
}
