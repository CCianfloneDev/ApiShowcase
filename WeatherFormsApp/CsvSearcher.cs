using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherFormsApp
{
    public class CsvSearcher
    {
        private DataTable dataTable;

        public DataTable getDataTable()          
        {
            return dataTable; 
        }

        public CsvSearcher(string csvFilePath)
        {
            LoadCsvData(csvFilePath);
        }

        /// <summary>
        /// Loads CSV data from the specified file path into a DataTable.
        /// </summary>
        /// <param name="csvFilePath">The path to the CSV file.</param>
        private void LoadCsvData(string csvFilePath)
        {
            dataTable = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(csvFilePath);

            if (lines.Length > 0)
            {

                /// <summary>
                /// Splits the header line using a regular expression to handle commas within quotes.
                /// </summary>
                /// <param name="lines[0]">The header line from the CSV file.</param>
                /// <returns>An array of header names.</returns>
                string[] headers = Regex.Split(lines[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header.Trim());
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    /// <summary>
                    /// Splits each data line using a regular expression to handle commas within quotes.
                    /// </summary>
                    /// <param name="lines[i]">A data line from the CSV file.</param>
                    /// <returns>An array of data fields.</returns>
                    string[] data = Regex.Split(lines[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                    if (data.Length == dataTable.Columns.Count)
                    {
                        DataRow row = dataTable.NewRow();
                        for (int j = 0; j < data.Length; j++)
                        {
                            row[j] = data[j].Trim().Replace("\"", "");
                        }
                        dataTable.Rows.Add(row);
                    }
                    else
                    {
                        Console.WriteLine($"Row {i} has an incorrect number of fields.");
                    }
                }
            }
        }

        //public DataTable Search(string keyword, int limit = 10)
        //{
        //    keyword = keyword.ToLower();
        //    var filteredRows = dataTable.AsEnumerable()
        //        .Where(row => row.ItemArray.Any(field => field.ToString().ToLower().Contains(keyword)))
        //        .Take(limit);

        //    if (filteredRows.Any())
        //    {
        //        return filteredRows.CopyToDataTable();
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}
