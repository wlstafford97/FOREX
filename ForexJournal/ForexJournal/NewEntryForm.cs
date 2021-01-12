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
            double accTtl = double.Parse(lLArray[10]);
            double entryP = double.Parse(textBox6.Text);
            double exitP = double.Parse(textBox7.Text);
            int tradeCount = int.Parse(lLArray[0]);
            using (var reader = new StreamReader(@"C:.\CSV\tradelog.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.MissingFieldFound = null;
                trades = csv.GetRecords<Trades>().ToList();
            }
            if (comboBox1.SelectedItem.Equals("SELL"))
            {
                profitLoss = Math.Round(((entryP - exitP) * (double.Parse(comboBox2.SelectedItem.ToString()) * 100)), 2);
                if (comboBox2.SelectedItem.ToString().Equals("0.10")){
                    pips = Math.Round((profitLoss / (double.Parse(comboBox2.SelectedItem.ToString()) * 100)), 2);
                } else
                {
                    pips = Math.Round((profitLoss / (double.Parse(comboBox2.SelectedItem.ToString()) * 10)), 2);
                }
                nAccTtl = accTtl + profitLoss;
            }
            else if (comboBox1.SelectedItem.Equals("BUY"))
            {
                profitLoss = Math.Round(((exitP-entryP) * (double.Parse(comboBox2.SelectedItem.ToString()) * 100)), 2);
                if (comboBox2.SelectedItem.ToString().Equals("0.10")){
                    pips = Math.Round((profitLoss / (double.Parse(comboBox2.SelectedItem.ToString()) * 100)), 2);
                }
                else
                {
                    pips = Math.Round((profitLoss / (double.Parse(comboBox2.SelectedItem.ToString()) * 10)), 2);
                }
                nAccTtl = accTtl + profitLoss;
            } else
            {
                profitLoss = 0;
                pips = 0;
                nAccTtl = entryP + accTtl;
            }

            if(MessageBox.Show("Profit/Loss: " + profitLoss.ToString() + "  Is this correct?", "Message Box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                File.AppendAllText(@".\CSV\tradelog.csv", $"{tradeCount + 1},{dateTimePicker1.Text},{timePicker1.Text},{timePicker2.Text}," +
                $"{comboBox1.Text},{comboBox2.Text},{textBox6.Text},{textBox7.Text},{profitLoss.ToString()},{pips.ToString()},{nAccTtl.ToString()}\n");
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                {
                    textBox.Text = "";
                }
            } else
            {
            }
        }
    }
}
