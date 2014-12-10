namespace ZanKan2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.zangyoDataGrid = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zangyoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptBreakZangyoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgtDateLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.totalZangyoLbl = new System.Windows.Forms.Label();
            this.totalZangyoNakanukiLbl = new System.Windows.Forms.Label();
            this.totalZangyoNum = new System.Windows.Forms.Label();
            this.totalZangyoNakanukiNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zangyoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // zangyoDataGrid
            // 
            this.zangyoDataGrid.AllowUserToAddRows = false;
            this.zangyoDataGrid.AllowUserToDeleteRows = false;
            this.zangyoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zangyoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.clockColumn,
            this.zangyoColumn,
            this.exceptBreakZangyoColumn});
            this.zangyoDataGrid.Location = new System.Drawing.Point(12, 59);
            this.zangyoDataGrid.Name = "zangyoDataGrid";
            this.zangyoDataGrid.ReadOnly = true;
            this.zangyoDataGrid.RowTemplate.Height = 21;
            this.zangyoDataGrid.Size = new System.Drawing.Size(485, 210);
            this.zangyoDataGrid.TabIndex = 0;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "日付";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // clockColumn
            // 
            this.clockColumn.HeaderText = "シャットダウン時間";
            this.clockColumn.Name = "clockColumn";
            this.clockColumn.ReadOnly = true;
            this.clockColumn.Width = 120;
            // 
            // zangyoColumn
            // 
            this.zangyoColumn.HeaderText = "残業時間";
            this.zangyoColumn.Name = "zangyoColumn";
            this.zangyoColumn.ReadOnly = true;
            // 
            // exceptBreakZangyoColumn
            // 
            this.exceptBreakZangyoColumn.HeaderText = "中抜き残業時間";
            this.exceptBreakZangyoColumn.Name = "exceptBreakZangyoColumn";
            this.exceptBreakZangyoColumn.ReadOnly = true;
            this.exceptBreakZangyoColumn.Width = 120;
            // 
            // tgtDateLbl
            // 
            this.tgtDateLbl.AutoSize = true;
            this.tgtDateLbl.Location = new System.Drawing.Point(10, 19);
            this.tgtDateLbl.Name = "tgtDateLbl";
            this.tgtDateLbl.Size = new System.Drawing.Size(65, 12);
            this.tgtDateLbl.TabIndex = 1;
            this.tgtDateLbl.Text = "対象年月日";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // totalZangyoLbl
            // 
            this.totalZangyoLbl.AutoSize = true;
            this.totalZangyoLbl.Location = new System.Drawing.Point(12, 310);
            this.totalZangyoLbl.Name = "totalZangyoLbl";
            this.totalZangyoLbl.Size = new System.Drawing.Size(77, 12);
            this.totalZangyoLbl.TabIndex = 6;
            this.totalZangyoLbl.Text = "累計残業時間";
            // 
            // totalZangyoNakanukiLbl
            // 
            this.totalZangyoNakanukiLbl.AutoSize = true;
            this.totalZangyoNakanukiLbl.Location = new System.Drawing.Point(274, 310);
            this.totalZangyoNakanukiLbl.Name = "totalZangyoNakanukiLbl";
            this.totalZangyoNakanukiLbl.Size = new System.Drawing.Size(138, 12);
            this.totalZangyoNakanukiLbl.TabIndex = 7;
            this.totalZangyoNakanukiLbl.Text = "累計残業時間(中抜き有り)";
            // 
            // totalZangyoNum
            // 
            this.totalZangyoNum.AutoSize = true;
            this.totalZangyoNum.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.totalZangyoNum.ForeColor = System.Drawing.Color.Red;
            this.totalZangyoNum.Location = new System.Drawing.Point(12, 331);
            this.totalZangyoNum.Name = "totalZangyoNum";
            this.totalZangyoNum.Size = new System.Drawing.Size(63, 67);
            this.totalZangyoNum.TabIndex = 8;
            this.totalZangyoNum.Text = "0";
            // 
            // totalZangyoNakanukiNum
            // 
            this.totalZangyoNakanukiNum.AutoSize = true;
            this.totalZangyoNakanukiNum.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.totalZangyoNakanukiNum.ForeColor = System.Drawing.Color.Red;
            this.totalZangyoNakanukiNum.Location = new System.Drawing.Point(280, 331);
            this.totalZangyoNakanukiNum.Name = "totalZangyoNakanukiNum";
            this.totalZangyoNakanukiNum.Size = new System.Drawing.Size(63, 67);
            this.totalZangyoNakanukiNum.TabIndex = 9;
            this.totalZangyoNakanukiNum.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 437);
            this.Controls.Add(this.totalZangyoNakanukiNum);
            this.Controls.Add(this.totalZangyoNum);
            this.Controls.Add(this.totalZangyoNakanukiLbl);
            this.Controls.Add(this.totalZangyoLbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tgtDateLbl);
            this.Controls.Add(this.zangyoDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.zangyoDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView zangyoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zangyoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptBreakZangyoColumn;
        private System.Windows.Forms.Label tgtDateLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label totalZangyoLbl;
        private System.Windows.Forms.Label totalZangyoNakanukiLbl;
        private System.Windows.Forms.Label totalZangyoNum;
        private System.Windows.Forms.Label totalZangyoNakanukiNum;
    }
}

