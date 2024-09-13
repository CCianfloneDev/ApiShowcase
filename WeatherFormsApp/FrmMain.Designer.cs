namespace WeatherFormsApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tlpMainTable = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCurrentWeather = new System.Windows.Forms.Panel();
            this.lblCurrentCity = new System.Windows.Forms.Label();
            this.btnTEST = new System.Windows.Forms.Button();
            this.lblCurrentWeather = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCelsiusSwitch = new System.Windows.Forms.Button();
            this.pnlCurrentLocation = new System.Windows.Forms.Panel();
            this.lblCurrentWeatherTop = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.pnlLeftMargin = new System.Windows.Forms.Panel();
            this.cboCities = new System.Windows.Forms.ComboBox();
            this.pnlFormBorder.SuspendLayout();
            this.tlpMainTable.SuspendLayout();
            this.pnlCurrentWeather.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlCurrentLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormBorder
            // 
            this.pnlFormBorder.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlFormBorder.Controls.Add(this.btnMinimize);
            this.pnlFormBorder.Controls.Add(this.btnMaximize);
            this.pnlFormBorder.Controls.Add(this.btnClose);
            resources.ApplyResources(this.pnlFormBorder, "pnlFormBorder");
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlFormBorder_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnMaximize, "btnMaximize");
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tlpMainTable
            // 
            resources.ApplyResources(this.tlpMainTable, "tlpMainTable");
            this.tlpMainTable.Controls.Add(this.pnlCurrentWeather, 0, 0);
            this.tlpMainTable.Name = "tlpMainTable";
            // 
            // pnlCurrentWeather
            // 
            this.pnlCurrentWeather.Controls.Add(this.lblCurrentCity);
            this.pnlCurrentWeather.Controls.Add(this.btnTEST);
            this.pnlCurrentWeather.Controls.Add(this.lblCurrentWeather);
            resources.ApplyResources(this.pnlCurrentWeather, "pnlCurrentWeather");
            this.pnlCurrentWeather.Name = "pnlCurrentWeather";
            // 
            // lblCurrentCity
            // 
            resources.ApplyResources(this.lblCurrentCity, "lblCurrentCity");
            this.lblCurrentCity.Name = "lblCurrentCity";
            // 
            // btnTEST
            // 
            resources.ApplyResources(this.btnTEST, "btnTEST");
            this.btnTEST.Name = "btnTEST";
            this.btnTEST.UseVisualStyleBackColor = true;
            this.btnTEST.Click += new System.EventHandler(this.btnTEST_Click);
            // 
            // lblCurrentWeather
            // 
            resources.ApplyResources(this.lblCurrentWeather, "lblCurrentWeather");
            this.lblCurrentWeather.Name = "lblCurrentWeather";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.btnCelsiusSwitch);
            this.pnlTop.Controls.Add(this.pnlCurrentLocation);
            resources.ApplyResources(this.pnlTop, "pnlTop");
            this.pnlTop.Name = "pnlTop";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCelsiusSwitch
            // 
            this.btnCelsiusSwitch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.btnCelsiusSwitch, "btnCelsiusSwitch");
            this.btnCelsiusSwitch.Name = "btnCelsiusSwitch";
            this.btnCelsiusSwitch.UseVisualStyleBackColor = false;
            // 
            // pnlCurrentLocation
            // 
            this.pnlCurrentLocation.Controls.Add(this.cboCities);
            this.pnlCurrentLocation.Controls.Add(this.lblCurrentWeatherTop);
            this.pnlCurrentLocation.Controls.Add(this.lblCity);
            resources.ApplyResources(this.pnlCurrentLocation, "pnlCurrentLocation");
            this.pnlCurrentLocation.Name = "pnlCurrentLocation";
            // 
            // lblCurrentWeatherTop
            // 
            resources.ApplyResources(this.lblCurrentWeatherTop, "lblCurrentWeatherTop");
            this.lblCurrentWeatherTop.Name = "lblCurrentWeatherTop";
            // 
            // lblCity
            // 
            resources.ApplyResources(this.lblCity, "lblCity");
            this.lblCity.Name = "lblCity";
            // 
            // pnlLeftMargin
            // 
            resources.ApplyResources(this.pnlLeftMargin, "pnlLeftMargin");
            this.pnlLeftMargin.Name = "pnlLeftMargin";
            // 
            // cboCities
            // 
            this.cboCities.FormattingEnabled = true;
            resources.ApplyResources(this.cboCities, "cboCities");
            this.cboCities.Name = "cboCities";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.tlpMainTable);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeftMargin);
            this.Controls.Add(this.pnlFormBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.pnlFormBorder.ResumeLayout(false);
            this.tlpMainTable.ResumeLayout(false);
            this.pnlCurrentWeather.ResumeLayout(false);
            this.pnlCurrentWeather.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlCurrentLocation.ResumeLayout(false);
            this.pnlCurrentLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TableLayoutPanel tlpMainTable;
        private System.Windows.Forms.Panel pnlCurrentWeather;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlCurrentLocation;
        private System.Windows.Forms.Panel pnlLeftMargin;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCurrentCity;
        private System.Windows.Forms.Label lblCurrentWeather;
        private System.Windows.Forms.Button btnCelsiusSwitch;
        private System.Windows.Forms.Label lblCurrentWeatherTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTEST;
        private System.Windows.Forms.ComboBox cboCities;
    }
}

