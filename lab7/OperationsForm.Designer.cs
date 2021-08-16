namespace lab7
{
    partial class OperationsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_info = new System.Windows.Forms.DataGridView();
            this.comboBox_method = new System.Windows.Forms.ComboBox();
            this.comboBox_variant = new System.Windows.Forms.ComboBox();
            this.button_default = new System.Windows.Forms.Button();
            this.button_comparison = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_info
            // 
            this.dataGridView_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_info.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_info.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_info.Name = "dataGridView_info";
            this.dataGridView_info.ReadOnly = true;
            this.dataGridView_info.RowHeadersVisible = false;
            this.dataGridView_info.Size = new System.Drawing.Size(567, 249);
            this.dataGridView_info.TabIndex = 3;
            // 
            // comboBox_method
            // 
            this.comboBox_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_method.FormattingEnabled = true;
            this.comboBox_method.Items.AddRange(new object[] {
            "Сортировка",
            "Фильтрация",
            "Группировка"});
            this.comboBox_method.Location = new System.Drawing.Point(585, 12);
            this.comboBox_method.Name = "comboBox_method";
            this.comboBox_method.Size = new System.Drawing.Size(188, 28);
            this.comboBox_method.TabIndex = 4;
            this.comboBox_method.SelectedIndexChanged += new System.EventHandler(this.comboBox_method_SelectedIndexChanged);
            // 
            // comboBox_variant
            // 
            this.comboBox_variant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_variant.FormattingEnabled = true;
            this.comboBox_variant.Location = new System.Drawing.Point(585, 46);
            this.comboBox_variant.Name = "comboBox_variant";
            this.comboBox_variant.Size = new System.Drawing.Size(188, 28);
            this.comboBox_variant.TabIndex = 5;
            this.comboBox_variant.SelectedIndexChanged += new System.EventHandler(this.comboBox_variant_SelectedIndexChanged);
            // 
            // button_default
            // 
            this.button_default.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_default.Location = new System.Drawing.Point(585, 80);
            this.button_default.Name = "button_default";
            this.button_default.Size = new System.Drawing.Size(105, 30);
            this.button_default.TabIndex = 7;
            this.button_default.Text = "Default";
            this.button_default.UseVisualStyleBackColor = true;
            this.button_default.Click += new System.EventHandler(this.button_default_Click);
            // 
            // button_comparison
            // 
            this.button_comparison.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_comparison.Location = new System.Drawing.Point(585, 231);
            this.button_comparison.Name = "button_comparison";
            this.button_comparison.Size = new System.Drawing.Size(105, 30);
            this.button_comparison.TabIndex = 8;
            this.button_comparison.Text = "Comparison";
            this.button_comparison.UseVisualStyleBackColor = true;
            this.button_comparison.Click += new System.EventHandler(this.button_comparison_Click);
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 274);
            this.Controls.Add(this.button_comparison);
            this.Controls.Add(this.button_default);
            this.Controls.Add(this.comboBox_variant);
            this.Controls.Add(this.comboBox_method);
            this.Controls.Add(this.dataGridView_info);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обработка элементов последовательности";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_info;
        private System.Windows.Forms.ComboBox comboBox_method;
        private System.Windows.Forms.ComboBox comboBox_variant;
        private System.Windows.Forms.Button button_default;
        private System.Windows.Forms.Button button_comparison;
    }
}