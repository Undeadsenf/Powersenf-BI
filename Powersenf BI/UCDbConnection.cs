using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace PowerSenfBiApp
{
    public partial class UCDbConnection : UserControl
    {
        string verbindungsstring = "datasource=localhost;port=3306;username=root;password=;database=nordwind";
        
        public UCDbConnection()
        {
            InitializeComponent();
        }
        public void Verbinden()
        {
            try
            {
                GlobalVariables.dbVerbindung = new MySqlConnection(verbindungsstring);
                GlobalVariables.dbVerbindung.Open();
                dbStatusLabel1.Text = "Connected to Nordwind-DB";
                //MessageBox.Show("Verbindung erfolgreich hergestellt");
                // TO DO Sound abspielen wenn erfolgreich
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dBConnectionButton1_Click(object sender, EventArgs e)
        {
            Verbinden();
        }

        private void closeconnectionButton1_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.dbVerbindung != null)
            {
                GlobalVariables.dbVerbindung.Close();
                GlobalVariables.dbVerbindung = null;
                GlobalVariables.dbQueryDataset = null;
                dbStatusLabel1.Text = "DB disconnected";
            }

            //TO DO sound abspielen
        }
    }
}