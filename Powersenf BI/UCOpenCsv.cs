using System;
using System.Collections.Generic;
using System.Data;

using System.Windows.Forms;
using System.IO;
using System.Linq;


namespace PowerSenfBiApp
{
    public partial class UCOpen : UserControl
    {
        public event Action<DataTable> DataLoaded;
        public UCOpen()
        {
            InitializeComponent();
        }

        private void UCOpen_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.gridData2 != null)
            {
                LoadDataTable(GlobalVariables.gridData2);
            }
        }
        private void loadCsvButton_Click(object sender, EventArgs e)
        {
            var data = new List<Dictionary<string,string>>();

            try
            {
                var lines = File.ReadAllLines(GlobalVariables.csvFilePath);
                if (lines.Length == 0)
                {
                    MessageBox.Show("Keine Daten vorhanden oder Daten fehlerhaft");
                    return;
                }
                
                var headers = lines[0].Split(',');
                // Ab 2. Spalte Liste füllen
                lines = lines.Skip(1).ToArray(); //exclude headers from display because the datagridview already has them
                foreach (var line in lines)
                {
                    var row = new Dictionary<string, string>();
                    
                    var values = line.Split(',');
                   
                    for (int j = 0; j < headers.Length; j++)
                    {
                        
                        if (values[j][0] == '"')
                        {
                            row[headers[j]] = values[j] + values[j + 1]; //Zelleninhalte zusammenfügen wenn erstes zeichen " ist
                            values = values.Where((val, index) => index != j + 1).ToArray(); // Zelle aus der entnommen wurde aus Array löschen
                        }
                        //Falls Spalten ungleich lang bzw. leere einträge vorhanden
                        else row[headers[j]] = values.Length > j ? values[j] : string.Empty;
                        
                    }

                    for (int i = 0; i< headers.Length; i++)
                    {
                        row[headers[i]] = row[headers[i]].Trim('"');
                    }
                    data.Add(row);
                }
                
                
                GlobalVariables.gridData2 = convertToDataTable(data);

                LoadDataTable(GlobalVariables.gridData2);
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void LoadDataTable(DataTable dataTable)
        {
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoResizeColumns();
        }
        private DataTable convertToDataTable(List<Dictionary<string, string>> data)
        {
            var dataTable = new DataTable();

            if (data.Count == 0)
                return dataTable;

            foreach (var key in data[0].Keys)
            {
                dataTable.Columns.Add(key);
            }
            foreach (var row in data)
            {
                var dataRow = dataTable.NewRow();
                foreach (var key in row.Keys)
                {
                    dataRow[key] = row[key];
                }
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        private void buttonOpenCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a CSV-file to open";
            ofd.Filter = "CSV-Datei (*.csv)|*.csv|Alle Dateien (*.*)|*.*";
            ofd.InitialDirectory = "..\\..\\downloads";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                labelOpenStatus.Text = "File opened: ";
                labelFilePath.Text = Path.GetFileName(filePath);
                GlobalVariables.csvFilePath = filePath;
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
                        selectedCellsTemp.Add(cell.Value.ToString());
                }
                GlobalVariables.selectedCells = selectedCellsTemp;
                GlobalVariables.selectedHeader = dataGridView1.CurrentCell.OwningColumn.Name;
                //zum benennen der Series im Diagramm
                //MessageBox.Show(GlobalVariables.selectedCells[0]);
        }

        private void columnLoadButton_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.columnChartDataCsv = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }
        

        private void pieLoadButton_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.pieChartDataCsv = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }

        private void lineLoadButton_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.lineChartDataCsv = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }

        private void barLoadButton_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCells != null)
                GlobalVariables.barChartDataCsv = GlobalVariables.selectedCells;
            MainForm.instance.UpdateChartStatusLabels();
        }

        private void clearChartDataButton_Click(object sender, EventArgs e)
        {
            GlobalVariables.columnChartDataCsv = null;
            GlobalVariables.pieChartDataCsv = null;
            GlobalVariables.lineChartDataCsv = null;
            GlobalVariables.barChartDataCsv = null;
            MainForm.instance.UpdateChartStatusLabels();
        }
    }
}