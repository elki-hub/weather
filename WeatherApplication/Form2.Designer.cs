
namespace WeatherApplication
{
    partial class Form2
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lable0 = new System.Windows.Forms.Label();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            this.SuspendLayout();
            // 
            // lable0
            // 
            this.lable0.AutoSize = true;
            this.lable0.Location = new System.Drawing.Point(136, 20);
            this.lable0.Name = "lable0";
            this.lable0.Size = new System.Drawing.Size(35, 13);
            this.lable0.TabIndex = 21;
            this.lable0.Text = "lable0";
            // 
            // pictureBox0
            // 
            this.pictureBox0.Location = new System.Drawing.Point(22, 20);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(108, 98);
            this.pictureBox0.TabIndex = 20;
            this.pictureBox0.TabStop = false;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(300, 18);
            this.calendar.MaxDate = new System.DateTime(2021, 12, 15, 21, 41, 17, 78);
            this.calendar.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 25;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 203);
            this.Controls.Add(this.lable0);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.pictureBox0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Weather History";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lable0;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.MonthCalendar calendar;
    }
}