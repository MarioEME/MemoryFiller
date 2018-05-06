using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryFiller
{
    public partial class MainForm : Form
    {
        private Dictionary<String, Int32> conversions = new Dictionary<string, int>
        {
            {"Bytes",0 },
            {"Kilobytes",1 },
            {"Megabytes",2 },
            {"Gigabytes",3 },
        };

        private List<long[]> array = new List<long[]>();
        private List<Tuple<DateTime, long>> dataSouce = new List<Tuple<DateTime, long>>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var numBytes = Convert.ToInt64(sizeNUD.Value * Convert.ToInt32(Math.Pow(1024, conversions[scaleDropDown.Text])));
                FillMemory(numBytes);
                this.dataSouce.Add(new Tuple<DateTime, long>(DateTime.Now, numBytes));
                this.RefreshGrid();
                this.RefreshTotal();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillMemory(Int64 numBytes)
        {
            var arraySize = numBytes / 8;
            var obj = new long[arraySize];

            for (var i = 0; i < obj.Length; i++)
                obj[i] = i;

            this.array.Add(obj);
        }
        

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.array.ForEach(a => Array.Clear(a, 0, a.Length));
            this.array.Clear();
            this.dataSouce.Clear();

            RefreshGrid();
            RefreshTotal();
        }

        private void RefreshTotal()
        {
            var total = this.dataSouce.Sum(t => t.Item2) / Math.Pow(1024, conversions[scaleDropDown.Text]);
            lblTotal.Text = $"{total:N2} {scaleDropDown.Text}";
        }

        private void RefreshGrid()
        {
            this.historyDataGrid.DataSource = null;
            this.historyDataGrid.DataSource = this.dataSouce;
            this.historyDataGrid.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            scaleDropDown.SelectedIndex = 0;
            historyDataGrid.AutoGenerateColumns = false;
        }

        private void scaleDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTotal();
        }
    }
}
