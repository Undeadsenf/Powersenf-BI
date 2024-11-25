using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace PowerSenfBiApp
{
    public class GlobalVariables
    {
        public static List<string> selectedCells;
        public static string selectedHeader;
        public static DataTable gridData1;
        public static DataTable gridData2;
        public static string csvFilePath;
        public static MySqlConnection dbVerbindung;
        public static List<string> columnChartDataX;
        public static List<string> columnChartDataY;
        public static List<string> columnChartDataCsv; 
        public static List<string> pieChartDataX;
        public static List<string> pieChartDataY;
        public static List<string> pieChartDataCsv;
        public static List<string> barChartDataX;
        public static List<string> barChartDataY;
        public static List<string> barChartDataCsv;
        public static List<string> lineChartDataX;
        public static List<string> lineChartDataY;
        public static List<string> lineChartDataCsv;
        public static DataSet dbQueryDataset;
    }
}