
namespace WeatherApplication
{
    partial class Form1
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
            this.textBoxSearchLocation = new System.Windows.Forms.TextBox();
            this.labelWeatherForecast = new System.Windows.Forms.Label();
            this.labelIntroduction = new System.Windows.Forms.Label();
            this.labelLocationDescription = new System.Windows.Forms.Label();
            this.weatherHistoryButton = new System.Windows.Forms.Button();
            this.listViewOfLocations = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ForecastTab = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.tabPagelable0 = new System.Windows.Forms.Label();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPagelable1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPagelable2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPagelable3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPagelable4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPagelable5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ForecastTab.SuspendLayout();
            this.tabPage0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearchLocation
            // 
            this.textBoxSearchLocation.Location = new System.Drawing.Point(20, 31);
            this.textBoxSearchLocation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchLocation.Name = "textBoxSearchLocation";
            this.textBoxSearchLocation.Size = new System.Drawing.Size(141, 20);
            this.textBoxSearchLocation.TabIndex = 1;
            this.textBoxSearchLocation.TextChanged += new System.EventHandler(this.textBoxSearchChanged);
            // 
            // labelWeatherForecast
            // 
            this.labelWeatherForecast.AutoSize = true;
            this.labelWeatherForecast.Location = new System.Drawing.Point(185, 139);
            this.labelWeatherForecast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeatherForecast.Name = "labelWeatherForecast";
            this.labelWeatherForecast.Size = new System.Drawing.Size(95, 13);
            this.labelWeatherForecast.TabIndex = 6;
            this.labelWeatherForecast.Text = "Weather Forecast:";
            // 
            // labelIntroduction
            // 
            this.labelIntroduction.AutoSize = true;
            this.labelIntroduction.Location = new System.Drawing.Point(17, 7);
            this.labelIntroduction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIntroduction.Name = "labelIntroduction";
            this.labelIntroduction.Size = new System.Drawing.Size(98, 13);
            this.labelIntroduction.TabIndex = 10;
            this.labelIntroduction.Text = "Enter the city name";
            // 
            // labelLocationDescription
            // 
            this.labelLocationDescription.AutoSize = true;
            this.labelLocationDescription.Location = new System.Drawing.Point(204, 11);
            this.labelLocationDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocationDescription.Name = "labelLocationDescription";
            this.labelLocationDescription.Size = new System.Drawing.Size(0, 13);
            this.labelLocationDescription.TabIndex = 13;
            // 
            // weatherHistoryButton
            // 
            this.weatherHistoryButton.Location = new System.Drawing.Point(425, 309);
            this.weatherHistoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.weatherHistoryButton.Name = "weatherHistoryButton";
            this.weatherHistoryButton.Size = new System.Drawing.Size(106, 20);
            this.weatherHistoryButton.TabIndex = 14;
            this.weatherHistoryButton.Text = "Weather History";
            this.weatherHistoryButton.UseVisualStyleBackColor = true;
            this.weatherHistoryButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // listViewOfLocations
            // 
            this.listViewOfLocations.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewOfLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewOfLocations.FullRowSelect = true;
            this.listViewOfLocations.HideSelection = false;
            this.listViewOfLocations.Location = new System.Drawing.Point(20, 80);
            this.listViewOfLocations.Margin = new System.Windows.Forms.Padding(2);
            this.listViewOfLocations.Name = "listViewOfLocations";
            this.listViewOfLocations.Size = new System.Drawing.Size(141, 249);
            this.listViewOfLocations.TabIndex = 15;
            this.listViewOfLocations.UseCompatibleStateImageBehavior = false;
            this.listViewOfLocations.View = System.Windows.Forms.View.Details;
            this.listViewOfLocations.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "City";
            this.columnHeader3.Width = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // ForecastTab
            // 
            this.ForecastTab.Controls.Add(this.tabPage0);
            this.ForecastTab.Controls.Add(this.tabPage1);
            this.ForecastTab.Controls.Add(this.tabPage2);
            this.ForecastTab.Controls.Add(this.tabPage3);
            this.ForecastTab.Controls.Add(this.tabPage4);
            this.ForecastTab.Controls.Add(this.tabPage5);
            this.ForecastTab.Location = new System.Drawing.Point(184, 155);
            this.ForecastTab.Name = "ForecastTab";
            this.ForecastTab.SelectedIndex = 0;
            this.ForecastTab.Size = new System.Drawing.Size(351, 148);
            this.ForecastTab.TabIndex = 21;
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.tabPagelable0);
            this.tabPage0.Controls.Add(this.pictureBox0);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage0.Size = new System.Drawing.Size(343, 122);
            this.tabPage0.TabIndex = 0;
            this.tabPage0.Text = "tabPage0";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // tabPagelable0
            // 
            this.tabPagelable0.AutoSize = true;
            this.tabPagelable0.Location = new System.Drawing.Point(120, 6);
            this.tabPagelable0.Name = "tabPagelable0";
            this.tabPagelable0.Size = new System.Drawing.Size(75, 13);
            this.tabPagelable0.TabIndex = 21;
            this.tabPagelable0.Text = "tabPagelable0";
            // 
            // pictureBox0
            // 
            this.pictureBox0.Location = new System.Drawing.Point(6, 6);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(108, 98);
            this.pictureBox0.TabIndex = 20;
            this.pictureBox0.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabPagelable1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 122);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPagelable1
            // 
            this.tabPagelable1.AutoSize = true;
            this.tabPagelable1.Location = new System.Drawing.Point(121, 6);
            this.tabPagelable1.Name = "tabPagelable1";
            this.tabPagelable1.Size = new System.Drawing.Size(75, 13);
            this.tabPagelable1.TabIndex = 2;
            this.tabPagelable1.Text = "tabPagelable1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 99);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabPagelable2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 122);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPagelable2
            // 
            this.tabPagelable2.AutoSize = true;
            this.tabPagelable2.Location = new System.Drawing.Point(122, 7);
            this.tabPagelable2.Name = "tabPagelable2";
            this.tabPagelable2.Size = new System.Drawing.Size(75, 13);
            this.tabPagelable2.TabIndex = 24;
            this.tabPagelable2.Text = "tabPagelable2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 98);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabPagelable3);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(391, 122);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPagelable3
            // 
            this.tabPagelable3.AutoSize = true;
            this.tabPagelable3.Location = new System.Drawing.Point(121, 6);
            this.tabPagelable3.Name = "tabPagelable3";
            this.tabPagelable3.Size = new System.Drawing.Size(75, 13);
            this.tabPagelable3.TabIndex = 24;
            this.tabPagelable3.Text = "tabPagelable3";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(7, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 98);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabPagelable4);
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(391, 122);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPagelable4
            // 
            this.tabPagelable4.AutoSize = true;
            this.tabPagelable4.Location = new System.Drawing.Point(121, 6);
            this.tabPagelable4.Name = "tabPagelable4";
            this.tabPagelable4.Size = new System.Drawing.Size(75, 13);
            this.tabPagelable4.TabIndex = 24;
            this.tabPagelable4.Text = "tabPagelable4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(7, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 98);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabPagelable5);
            this.tabPage5.Controls.Add(this.pictureBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(391, 122);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPagelable5
            // 
            this.tabPagelable5.AutoSize = true;
            this.tabPagelable5.Location = new System.Drawing.Point(121, 6);
            this.tabPagelable5.Name = "tabPagelable5";
            this.tabPagelable5.Size = new System.Drawing.Size(75, 13);
            this.tabPagelable5.TabIndex = 24;
            this.tabPagelable5.Text = "tabPagelable5";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(7, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 98);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 360);
            this.Controls.Add(this.ForecastTab);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSearchLocation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listViewOfLocations);
            this.Controls.Add(this.weatherHistoryButton);
            this.Controls.Add(this.labelLocationDescription);
            this.Controls.Add(this.labelIntroduction);
            this.Controls.Add(this.labelWeatherForecast);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Weather Forecast";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ForecastTab.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabPage0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearchLocation;
        private System.Windows.Forms.Label labelWeatherForecast;
        private System.Windows.Forms.Label labelIntroduction;
        private System.Windows.Forms.Label labelLocationDescription;
        private System.Windows.Forms.Button weatherHistoryButton;
        private System.Windows.Forms.ListView listViewOfLocations;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.TabControl ForecastTab;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label tabPagelable0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tabPagelable1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label tabPagelable2;
        private System.Windows.Forms.Label tabPagelable3;
        private System.Windows.Forms.Label tabPagelable4;
        private System.Windows.Forms.Label tabPagelable5;
    }
}

