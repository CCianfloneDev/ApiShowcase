using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WeatherFormsApp
{
    public class Utils
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        public void ActAsFormBorder(Control sender)
        {
            ReleaseCapture();
            SendMessage(sender.Handle, 0x112, 0xf012, 0);
        }



        public string  LoadApiKey(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlNode appSettingsNode = xmlDoc.SelectSingleNode("configuration/appSettings");
            if (appSettingsNode != null)
            {
                foreach (XmlNode node in appSettingsNode.ChildNodes)
                {
                    if (node.Attributes["key"].Value == "WeatherbitApiKey")
                    {
                        return node.Attributes["value"].Value;
                    }
                }
            }

            throw new Exception("API key not found in the configuration file.");
        }


        public DataTable GetCitiesData()
        {
            DataTable dataTable = new DataTable();
            string[] lines = File.ReadAllLines("cities_20000.csv");

            if (lines.Length > 0)
            {
                // Create columns
                string[] headers = lines[0].Split('\t');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                // Add rows
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split('\t');
                    dataTable.Rows.Add(data);
                }
            }

            return dataTable;
        }

        public void LoadComboBox(ComboBox comboBox, string columnName, DataTable dataTable)
        {
            comboBox.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                comboBox.Items.Add(row[columnName].ToString());
            }
        }
    }
}
