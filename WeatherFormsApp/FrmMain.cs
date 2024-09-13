using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeatherFormsApp
{
    /// <summary>
    /// Represents the Main form.
    /// </summary>
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Represents a class with various functions.
        /// </summary>
        private static readonly Utils utils = new Utils();

        private CsvSearcher citiesCsv = new CsvSearcher("cities_20000.csv");

        /// <summary>
        /// Instantiates the main form.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            utils.LoadComboBox(cboCities, "city_name", citiesCsv.getDataTable());
        }

        /// <summary>
        /// Handles the Form Border mouse down event.
        /// </summary>
        private void PnlFormBorder_MouseDown(object sender, MouseEventArgs e) 
        {
          // just so i can have a nice custom fancy border cuz the default border style is poopy
          utils.ActAsFormBorder(this);
        }

        /// <summary>
        /// Handles the close button click event.
        /// </summary>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Handles the maximize button click event.
        /// </summary>
        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState is FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;     
            } else {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// Handles the minimize button click event.
        /// </summary>
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTEST_Click(object sender, EventArgs e)
        {
            //  WeatherDataApi weatherDataApi = new WeatherDataApi();

            // TODO: We are getting weather back from the API.
            // TODO: My computer is not seeming to work with the lat/lon functions, so I will have to add a way to select a city.
            //CurrentWeather currentWeather = weatherDataApi.GetCurrentWeather();

            //searcher.Search("Winnipeg");
            //cityData.LoadComboBox(cboCities, "city_name");
        }

    }
}
