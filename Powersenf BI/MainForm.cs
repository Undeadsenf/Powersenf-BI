using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace PowerSenfBiApp
{
    public partial class MainForm : MaterialForm
    {
        //Singleton - statisches Objekt 
        public static MainForm instance;
        private readonly MaterialSkinManager materialSkinManager;
        
        public MainForm()
        {
            InitializeComponent();
            
            //Singleton
            instance = this;
            
            /*materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple700,
                Primary.Purple800,
                Primary.Purple900, Accent.DeepPurple700,
                TextShade.WHITE);*/
            buttonHome_Click(null, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        public void UpdateChartStatusLabels()
        {
            //Columnchart
            if ((GlobalVariables.columnChartDataX != null && GlobalVariables.columnChartDataY == null) ||
                (GlobalVariables.columnChartDataX == null && GlobalVariables.columnChartDataY != null))
                instance.chartStatusLabel1.BackColor = Color.Yellow;
            else if (GlobalVariables.columnChartDataX != null && GlobalVariables.columnChartDataY != null || GlobalVariables.columnChartDataCsv != null)
                instance.chartStatusLabel1.BackColor = Color.Green;
            else
                instance.chartStatusLabel1.BackColor = Color.Red;
            //Piechart
            if ((GlobalVariables.pieChartDataX != null && GlobalVariables.pieChartDataY == null) ||
                (GlobalVariables.pieChartDataX == null && GlobalVariables.pieChartDataY != null))
                instance.chartStatusLabel2.BackColor = Color.Yellow;
            else if (GlobalVariables.pieChartDataX != null && GlobalVariables.pieChartDataY != null || GlobalVariables.pieChartDataCsv != null)
                instance.chartStatusLabel2.BackColor = Color.Green;
            else
                instance.chartStatusLabel2.BackColor = Color.Red;
            //Linechart
            if ((GlobalVariables.lineChartDataX != null && GlobalVariables.lineChartDataY == null) ||
                (GlobalVariables.lineChartDataX == null && GlobalVariables.lineChartDataY != null))
                instance.chartStatusLabel3.BackColor = Color.Yellow;
            else if (GlobalVariables.lineChartDataX != null && GlobalVariables.lineChartDataY != null || GlobalVariables.lineChartDataCsv != null)
                instance.chartStatusLabel3.BackColor = Color.Green;
            else
                instance.chartStatusLabel3.BackColor = Color.Red;
            //Barchart
            if ((GlobalVariables.barChartDataX != null && GlobalVariables.barChartDataY == null) ||
                (GlobalVariables.barChartDataX == null && GlobalVariables.barChartDataY != null))
                instance.chartStatusLabel4.BackColor = Color.Yellow;
            else if (GlobalVariables.barChartDataX != null && GlobalVariables.barChartDataY != null || GlobalVariables.barChartDataCsv != null)
                instance.chartStatusLabel4.BackColor = Color.Green;
            else
                instance.chartStatusLabel4.BackColor = Color.Red;
        }
        public Panel PanelContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            UCHome ucHome = new UCHome();
            PanelContainer.Controls.Clear();
            ucHome.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(ucHome);
        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            UCAbout ucAbout = new UCAbout();
            PanelContainer.Controls.Clear();
            ucAbout.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(ucAbout);
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            UCOpen ucOpen = new UCOpen();
            PanelContainer.Controls.Clear();
            ucOpen.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(ucOpen);
        }
        private void buttonChart_Click(object sender, EventArgs e)
        {
            UCChart ucChart = new UCChart();
            PanelContainer.Controls.Clear();
            ucChart.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(ucChart);
            
        }
        private void buttonDbConnection_Click(object sender, EventArgs e)
        {
            UCDbConnection ucDbConnection = new UCDbConnection();
            PanelContainer.Controls.Clear();
            ucDbConnection.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(ucDbConnection);
        }
        private void buttonDbQuery_Click(object sender, EventArgs e)
        {
            UCDbQueryLoad ucDbQueryLoad = new UCDbQueryLoad();
            PanelContainer.Controls.Clear();
            ucDbQueryLoad.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(ucDbQueryLoad);
        }
    }
}