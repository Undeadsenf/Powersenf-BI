using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;


namespace PowerSenfBiApp
{
    public partial class UCDbQueryLoad : UserControl
    {
        public static UCDbQueryLoad instance { get; private set; }
        public MySqlCommand befehl;
        public MySqlDataAdapter adapter;
        public DataGridViewSelectedRowCollection SelectedRows
        
        {
            get { return dataGridView1.SelectedRows; }
        }
        
        public UCDbQueryLoad()
        {
            InitializeComponent();
            instance = this;
           
        }
        public void OnDbQueryLoaded(object sender, EventArgs e)
        {
            if (GlobalVariables.dbQueryDataset != null && GlobalVariables.dbQueryDataset.Tables != null)
            {
                dataGridView1.DataSource = GlobalVariables.dbQueryDataset.Tables[0];
                dataGridView1.Refresh();
                dataGridView1.AutoResizeColumns();
            }
        }
        
        public void ReadData()
        {
            try
            {
                if (GlobalVariables.dbVerbindung != null)
                {
                    string sql = dbQueryBox1.Text;
                    befehl = new MySqlCommand(sql, GlobalVariables.dbVerbindung);
                    adapter = new MySqlDataAdapter(befehl);
                    GlobalVariables.dbQueryDataset = new DataSet();
                    adapter.Fill(GlobalVariables.dbQueryDataset);
                    dataGridView1.DataSource = GlobalVariables.dbQueryDataset.Tables[0];
                    dataGridView1.Refresh();
                    dataGridView1.AutoResizeColumns();
                }
                else
                {
                    MessageBox.Show("Verbinden Sie erst mit der DB");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dataGridView1.Columns[e.ColumnIndex].Selected = true;
            List<string> selectedCellsTemp = new List<string>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                if (cell.Value != null)
                selectedCellsTemp.Add((cell.Value.ToString()));
            }

            GlobalVariables.selectedCells = selectedCellsTemp;
            GlobalVariables.selectedHeader = dataGridView1.CurrentCell.OwningColumn.Name;
            //zum benennen der Series im Diagramm
            //MessageBox.Show(GlobalVariables.selectedCells[0]);

        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Columns[e.ColumnIndex].Selected = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
        }

        private void loadTableButton1_Click(object sender, EventArgs e)
        { 
            ReadData();
        }

        private void columnLoadButtonX_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.columnChartDataX = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }
        private void columnLoadButtonY_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.columnChartDataY = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }
        private void pieLoadButtonX_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.pieChartDataX = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }
        private void pieLoadButtonY_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.pieChartDataY = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }
        private void lineLoadButtonX_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.lineChartDataX = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }
        private void lineLoadButtonY_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.lineChartDataY = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }
        private void barLoadButtonX_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.barChartDataX = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }
        private void barLoadButtonY_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.barChartDataY = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }

        private void clearChartDataButton_click(object sender, EventArgs e)
        {
            GlobalVariables.columnChartDataX = null;
            GlobalVariables.columnChartDataY = null;
            GlobalVariables.pieChartDataX = null;
            GlobalVariables.pieChartDataY = null;
            GlobalVariables.lineChartDataX = null;
            GlobalVariables.lineChartDataY = null;
            GlobalVariables.barChartDataX = null;
            GlobalVariables.barChartDataY = null;
            MainForm.instance.UpdateChartStatusLabels();
        }
    }
}