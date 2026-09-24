namespace Proiect_PAW
{
    partial class GraficeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnPie = new System.Windows.Forms.Button();
            this.btnColumn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDate
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDate.Legends.Add(legend1);
            this.chartDate.Location = new System.Drawing.Point(28, 21);
            this.chartDate.Name = "chartDate";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDate.Series.Add(series1);
            this.chartDate.Size = new System.Drawing.Size(595, 300);
            this.chartDate.TabIndex = 0;
            this.chartDate.Text = "chart1";
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(49, 350);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(121, 28);
            this.cbDate.TabIndex = 1;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(197, 349);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(100, 49);
            this.btnBar.TabIndex = 2;
            this.btnBar.Text = "Bar Chart";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // btnPie
            // 
            this.btnPie.Location = new System.Drawing.Point(314, 351);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(109, 47);
            this.btnPie.TabIndex = 3;
            this.btnPie.Text = "Pie Chart";
            this.btnPie.UseVisualStyleBackColor = true;
            this.btnPie.Click += new System.EventHandler(this.btnPie_Click);
            // 
            // btnColumn
            // 
            this.btnColumn.Location = new System.Drawing.Point(444, 353);
            this.btnColumn.Name = "btnColumn";
            this.btnColumn.Size = new System.Drawing.Size(111, 45);
            this.btnColumn.TabIndex = 4;
            this.btnColumn.Text = "Column Chart";
            this.btnColumn.UseVisualStyleBackColor = true;
            this.btnColumn.Click += new System.EventHandler(this.btnColumn_Click);
            // 
            // GraficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColumn);
            this.Controls.Add(this.btnPie);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.chartDate);
            this.Name = "GraficeForm";
            this.Text = "GraficeForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDate;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnPie;
        private System.Windows.Forms.Button btnColumn;
    }
}