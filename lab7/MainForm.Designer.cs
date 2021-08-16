namespace lab7
{
    partial class MainForm
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
            this.button_info = new System.Windows.Forms.Button();
            this.button_op = new System.Windows.Forms.Button();
            this.dataGridView_info = new System.Windows.Forms.DataGridView();
            this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
            this.label_size = new System.Windows.Forms.Label();
            this.button_generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
            this.SuspendLayout();
            // 
            // button_info
            // 
            this.button_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_info.Location = new System.Drawing.Point(604, 232);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(105, 30);
            this.button_info.TabIndex = 0;
            this.button_info.Text = "Information";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // button_op
            // 
            this.button_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_op.Location = new System.Drawing.Point(604, 196);
            this.button_op.Name = "button_op";
            this.button_op.Size = new System.Drawing.Size(105, 30);
            this.button_op.TabIndex = 1;
            this.button_op.Text = "Operations";
            this.button_op.UseVisualStyleBackColor = true;
            this.button_op.Click += new System.EventHandler(this.button_op_Click);
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
            this.dataGridView_info.TabIndex = 2;
            // 
            // numericUpDown_size
            // 
            this.numericUpDown_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_size.Location = new System.Drawing.Point(635, 14);
            this.numericUpDown_size.Name = "numericUpDown_size";
            this.numericUpDown_size.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown_size.TabIndex = 3;
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_size.Location = new System.Drawing.Point(585, 16);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(44, 20);
            this.label_size.TabIndex = 4;
            this.label_size.Text = "Size:";
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_generate.Location = new System.Drawing.Point(604, 46);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(105, 30);
            this.button_generate.TabIndex = 5;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 274);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.numericUpDown_size);
            this.Controls.Add(this.dataGridView_info);
            this.Controls.Add(this.button_op);
            this.Controls.Add(this.button_info);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание и редактироваие последовательности";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.Button button_op;
        private System.Windows.Forms.DataGridView dataGridView_info;
        private System.Windows.Forms.NumericUpDown numericUpDown_size;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Button button_generate;
    }
}

