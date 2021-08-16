namespace lab7
{
    partial class ComparisonForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_info = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_info = new System.Windows.Forms.DataGridView();
            this.numericUpDown_count = new System.Windows.Forms.NumericUpDown();
            this.label_count = new System.Windows.Forms.Label();
            this.button_compare = new System.Windows.Forms.Button();
            this.label_default = new System.Windows.Forms.Label();
            this.label_linq = new System.Windows.Forms.Label();
            this.label_paralel_linq = new System.Windows.Forms.Label();
            this.label_custom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_info
            // 
            this.chart_info.BackColor = System.Drawing.Color.MistyRose;
            this.chart_info.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chart_info.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart_info.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Name = "ChartArea1";
            this.chart_info.ChartAreas.Add(chartArea2);
            this.chart_info.Location = new System.Drawing.Point(12, 10);
            this.chart_info.Name = "chart_info";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart_info.Series.Add(series2);
            this.chart_info.Size = new System.Drawing.Size(300, 300);
            this.chart_info.TabIndex = 0;
            this.chart_info.Text = "ege";
            title2.Name = "Title1";
            this.chart_info.Titles.Add(title2);
            // 
            // dataGridView_info
            // 
            this.dataGridView_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_info.Location = new System.Drawing.Point(318, 12);
            this.dataGridView_info.Name = "dataGridView_info";
            this.dataGridView_info.Size = new System.Drawing.Size(200, 150);
            this.dataGridView_info.TabIndex = 1;
            // 
            // numericUpDown_count
            // 
            this.numericUpDown_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_count.Location = new System.Drawing.Point(380, 168);
            this.numericUpDown_count.Name = "numericUpDown_count";
            this.numericUpDown_count.Size = new System.Drawing.Size(64, 26);
            this.numericUpDown_count.TabIndex = 2;
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_count.Location = new System.Drawing.Point(318, 170);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(56, 20);
            this.label_count.TabIndex = 3;
            this.label_count.Text = "Count:";
            // 
            // button_compare
            // 
            this.button_compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_compare.Location = new System.Drawing.Point(322, 200);
            this.button_compare.Name = "button_compare";
            this.button_compare.Size = new System.Drawing.Size(105, 30);
            this.button_compare.TabIndex = 8;
            this.button_compare.Text = "Compare";
            this.button_compare.UseVisualStyleBackColor = true;
            this.button_compare.Click += new System.EventHandler(this.button_compare_Click);
            // 
            // label_default
            // 
            this.label_default.AutoSize = true;
            this.label_default.Location = new System.Drawing.Point(524, 12);
            this.label_default.Name = "label_default";
            this.label_default.Size = new System.Drawing.Size(44, 13);
            this.label_default.TabIndex = 9;
            this.label_default.Text = "Default:";
            // 
            // label_linq
            // 
            this.label_linq.AutoSize = true;
            this.label_linq.Location = new System.Drawing.Point(585, 12);
            this.label_linq.Name = "label_linq";
            this.label_linq.Size = new System.Drawing.Size(30, 13);
            this.label_linq.TabIndex = 10;
            this.label_linq.Text = "Linq:";
            // 
            // label_paralel_linq
            // 
            this.label_paralel_linq.AutoSize = true;
            this.label_paralel_linq.Location = new System.Drawing.Point(634, 12);
            this.label_paralel_linq.Name = "label_paralel_linq";
            this.label_paralel_linq.Size = new System.Drawing.Size(61, 13);
            this.label_paralel_linq.TabIndex = 11;
            this.label_paralel_linq.Text = "Paralel linq:";
            // 
            // label_custom
            // 
            this.label_custom.AutoSize = true;
            this.label_custom.Location = new System.Drawing.Point(716, 12);
            this.label_custom.Name = "label_custom";
            this.label_custom.Size = new System.Drawing.Size(45, 13);
            this.label_custom.TabIndex = 12;
            this.label_custom.Text = "Custom:";
            // 
            // ComparisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 322);
            this.Controls.Add(this.label_custom);
            this.Controls.Add(this.label_paralel_linq);
            this.Controls.Add(this.label_linq);
            this.Controls.Add(this.label_default);
            this.Controls.Add(this.button_compare);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.numericUpDown_count);
            this.Controls.Add(this.dataGridView_info);
            this.Controls.Add(this.chart_info);
            this.Name = "ComparisonForm";
            this.Text = "ComparisonForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_info;
        private System.Windows.Forms.DataGridView dataGridView_info;
        private System.Windows.Forms.NumericUpDown numericUpDown_count;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Button button_compare;
        private System.Windows.Forms.Label label_default;
        private System.Windows.Forms.Label label_linq;
        private System.Windows.Forms.Label label_paralel_linq;
        private System.Windows.Forms.Label label_custom;
    }
}