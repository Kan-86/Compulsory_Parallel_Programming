using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Threading;

namespace PrimeGenerator
{
    public partial class PrimeNumbersGenerator : Form
    {
        private readonly Program _program = new Program();

        public PrimeNumbersGenerator()
        {
            InitializeComponent();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            clearAll();
            endRangeBox.Value = 1;
            startRangeBox.Value = 1;
        }

        private void clearAll()
        {
            primeNumbersListBox.DataSource = null;
            timeUsedLabel.Visible = false;
        }

        private void parallelButton_Click(object sender, EventArgs e)
        {
            if (startRangeBox.Value >= 0 && endRangeBox.Value > startRangeBox.Value)
            {
                clearAll();
                var startRange = Convert.ToInt64(startRangeBox.Value);
                var endRange = Convert.ToInt64(endRangeBox.Value);
                GetBigListAsync(startRange, endRange, "parallel").ContinueWith(r => {
                    PopulateListBox(r.Result);
                },
                    TaskScheduler.FromCurrentSynchronizationContext());
            }
        }
        private void sequentialButton_Click(object sender, EventArgs e)
        {
            if (startRangeBox.Value >= 0 && endRangeBox.Value > startRangeBox.Value)
            {
                clearAll();
                var startRange = Convert.ToInt64(startRangeBox.Value);
                var endRange = Convert.ToInt64(endRangeBox.Value);
                GetBigListAsync(startRange, endRange, "sequential").ContinueWith(r => {
                    PopulateListBox(r.Result);
                },
                    TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        private async Task<List<long>> GetBigListAsync(long startRange, long endRange, string method)
        {
            if (method == "sequential")
            {
                Stopwatch sw = Stopwatch.StartNew();
                var myTask = Task.Run(() => _program.GetPrimesSequential(endRange));
                List<long> result = await myTask;
                sw.Stop();
                timeUsedLabel.Text = (sw.ElapsedMilliseconds / 1000.0 + " secs");
                return result;
            }
            else if (method == "parallel")
            {
                Stopwatch sw = Stopwatch.StartNew();
                var myTask = Task.Run(() => _program.GetPrimeParallel(startRange, endRange));
                List<long> result = await myTask;
                sw.Stop();
                timeUsedLabel.Text = (sw.ElapsedMilliseconds / 1000.0 + " secs");
                return result;
            }
            return null;
        }

        private void PopulateListBox(List<long> list)
        {
            timeUsedLabel.Visible = true;
            primeNumbersListBox.DataSource = list;
        }

        private void startRangeBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startRangeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
