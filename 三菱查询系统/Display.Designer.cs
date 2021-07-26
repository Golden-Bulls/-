namespace 三菱查询系统
{
    partial class frm_Display
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_IMSI_Data = new System.Windows.Forms.DataGridView();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.通讯番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICCID番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMSI番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结果 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_IMSI_No = new System.Windows.Forms.TextBox();
            this.lbl_IMSI_No = new System.Windows.Forms.Label();
            this.grp_IMSI_Info = new System.Windows.Forms.GroupBox();
            this.txt_IMSI_Result = new System.Windows.Forms.TextBox();
            this.lbl_IMSI_Result = new System.Windows.Forms.Label();
            this.txt_IMSI_Time = new System.Windows.Forms.TextBox();
            this.lbl_IMSI_Time = new System.Windows.Forms.Label();
            this.grp_Execl_Info = new System.Windows.Forms.GroupBox();
            this.txt_Excel_Num = new System.Windows.Forms.TextBox();
            this.lbl_Excel_Num = new System.Windows.Forms.Label();
            this.txt_Excel_Time = new System.Windows.Forms.TextBox();
            this.lbl_Excel_Time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IMSI_Data)).BeginInit();
            this.grp_IMSI_Info.SuspendLayout();
            this.grp_Execl_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_IMSI_Data
            // 
            this.dgv_IMSI_Data.AllowUserToAddRows = false;
            this.dgv_IMSI_Data.AllowUserToDeleteRows = false;
            this.dgv_IMSI_Data.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_IMSI_Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_IMSI_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_IMSI_Data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_IMSI_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_IMSI_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IMSI_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.时间,
            this.通讯番号,
            this.电话番号,
            this.ICCID番号,
            this.IMSI番号,
            this.结果});
            this.dgv_IMSI_Data.GridColor = System.Drawing.Color.Black;
            this.dgv_IMSI_Data.Location = new System.Drawing.Point(41, 16);
            this.dgv_IMSI_Data.Name = "dgv_IMSI_Data";
            this.dgv_IMSI_Data.ReadOnly = true;
            this.dgv_IMSI_Data.RowTemplate.Height = 23;
            this.dgv_IMSI_Data.Size = new System.Drawing.Size(1150, 819);
            this.dgv_IMSI_Data.TabIndex = 0;
            // 
            // 时间
            // 
            this.时间.HeaderText = "时间";
            this.时间.Name = "时间";
            this.时间.ReadOnly = true;
            this.时间.Width = 150;
            // 
            // 通讯番号
            // 
            this.通讯番号.HeaderText = "通讯番号";
            this.通讯番号.Name = "通讯番号";
            this.通讯番号.ReadOnly = true;
            this.通讯番号.Width = 114;
            // 
            // 电话番号
            // 
            this.电话番号.HeaderText = "电话番号";
            this.电话番号.Name = "电话番号";
            this.电话番号.ReadOnly = true;
            this.电话番号.Width = 114;
            // 
            // ICCID番号
            // 
            this.ICCID番号.HeaderText = "ICCID番号";
            this.ICCID番号.Name = "ICCID番号";
            this.ICCID番号.ReadOnly = true;
            this.ICCID番号.Width = 124;
            // 
            // IMSI番号
            // 
            this.IMSI番号.HeaderText = "IMSI番号";
            this.IMSI番号.Name = "IMSI番号";
            this.IMSI番号.ReadOnly = true;
            this.IMSI番号.Width = 114;
            // 
            // 结果
            // 
            this.结果.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.结果.HeaderText = "结果";
            this.结果.Name = "结果";
            this.结果.ReadOnly = true;
            // 
            // txt_IMSI_No
            // 
            this.txt_IMSI_No.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_IMSI_No.Location = new System.Drawing.Point(172, 62);
            this.txt_IMSI_No.Name = "txt_IMSI_No";
            this.txt_IMSI_No.Size = new System.Drawing.Size(424, 38);
            this.txt_IMSI_No.TabIndex = 1;
            // 
            // lbl_IMSI_No
            // 
            this.lbl_IMSI_No.AutoSize = true;
            this.lbl_IMSI_No.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_IMSI_No.Location = new System.Drawing.Point(60, 67);
            this.lbl_IMSI_No.Name = "lbl_IMSI_No";
            this.lbl_IMSI_No.Size = new System.Drawing.Size(106, 24);
            this.lbl_IMSI_No.TabIndex = 2;
            this.lbl_IMSI_No.Text = "IMSI番号";
            // 
            // grp_IMSI_Info
            // 
            this.grp_IMSI_Info.Controls.Add(this.txt_IMSI_Result);
            this.grp_IMSI_Info.Controls.Add(this.lbl_IMSI_Result);
            this.grp_IMSI_Info.Controls.Add(this.txt_IMSI_Time);
            this.grp_IMSI_Info.Controls.Add(this.lbl_IMSI_Time);
            this.grp_IMSI_Info.Controls.Add(this.txt_IMSI_No);
            this.grp_IMSI_Info.Controls.Add(this.lbl_IMSI_No);
            this.grp_IMSI_Info.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grp_IMSI_Info.Location = new System.Drawing.Point(1236, 12);
            this.grp_IMSI_Info.Name = "grp_IMSI_Info";
            this.grp_IMSI_Info.Size = new System.Drawing.Size(635, 441);
            this.grp_IMSI_Info.TabIndex = 3;
            this.grp_IMSI_Info.TabStop = false;
            this.grp_IMSI_Info.Text = "IMSI信息";
            // 
            // txt_IMSI_Result
            // 
            this.txt_IMSI_Result.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_IMSI_Result.Location = new System.Drawing.Point(172, 398);
            this.txt_IMSI_Result.Name = "txt_IMSI_Result";
            this.txt_IMSI_Result.Size = new System.Drawing.Size(424, 38);
            this.txt_IMSI_Result.TabIndex = 1;
            // 
            // lbl_IMSI_Result
            // 
            this.lbl_IMSI_Result.AutoSize = true;
            this.lbl_IMSI_Result.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_IMSI_Result.Location = new System.Drawing.Point(60, 403);
            this.lbl_IMSI_Result.Name = "lbl_IMSI_Result";
            this.lbl_IMSI_Result.Size = new System.Drawing.Size(106, 24);
            this.lbl_IMSI_Result.TabIndex = 2;
            this.lbl_IMSI_Result.Text = "IMSI结果";
            // 
            // txt_IMSI_Time
            // 
            this.txt_IMSI_Time.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_IMSI_Time.Location = new System.Drawing.Point(172, 230);
            this.txt_IMSI_Time.Name = "txt_IMSI_Time";
            this.txt_IMSI_Time.Size = new System.Drawing.Size(424, 38);
            this.txt_IMSI_Time.TabIndex = 1;
            // 
            // lbl_IMSI_Time
            // 
            this.lbl_IMSI_Time.AutoSize = true;
            this.lbl_IMSI_Time.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_IMSI_Time.Location = new System.Drawing.Point(60, 235);
            this.lbl_IMSI_Time.Name = "lbl_IMSI_Time";
            this.lbl_IMSI_Time.Size = new System.Drawing.Size(106, 24);
            this.lbl_IMSI_Time.TabIndex = 2;
            this.lbl_IMSI_Time.Text = "IMSI时间";
            // 
            // grp_Execl_Info
            // 
            this.grp_Execl_Info.Controls.Add(this.txt_Excel_Num);
            this.grp_Execl_Info.Controls.Add(this.lbl_Excel_Num);
            this.grp_Execl_Info.Controls.Add(this.txt_Excel_Time);
            this.grp_Execl_Info.Controls.Add(this.lbl_Excel_Time);
            this.grp_Execl_Info.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grp_Execl_Info.Location = new System.Drawing.Point(1236, 479);
            this.grp_Execl_Info.Name = "grp_Execl_Info";
            this.grp_Execl_Info.Size = new System.Drawing.Size(635, 356);
            this.grp_Execl_Info.TabIndex = 4;
            this.grp_Execl_Info.TabStop = false;
            this.grp_Execl_Info.Text = "客户表单信息";
            // 
            // txt_Excel_Num
            // 
            this.txt_Excel_Num.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Excel_Num.Location = new System.Drawing.Point(38, 254);
            this.txt_Excel_Num.Name = "txt_Excel_Num";
            this.txt_Excel_Num.Size = new System.Drawing.Size(558, 38);
            this.txt_Excel_Num.TabIndex = 1;
            // 
            // lbl_Excel_Num
            // 
            this.lbl_Excel_Num.AutoSize = true;
            this.lbl_Excel_Num.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Excel_Num.Location = new System.Drawing.Point(34, 206);
            this.lbl_Excel_Num.Name = "lbl_Excel_Num";
            this.lbl_Excel_Num.Size = new System.Drawing.Size(154, 24);
            this.lbl_Excel_Num.TabIndex = 2;
            this.lbl_Excel_Num.Text = "表单剩余数量";
            // 
            // txt_Excel_Time
            // 
            this.txt_Excel_Time.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Excel_Time.Location = new System.Drawing.Point(38, 112);
            this.txt_Excel_Time.Name = "txt_Excel_Time";
            this.txt_Excel_Time.Size = new System.Drawing.Size(558, 38);
            this.txt_Excel_Time.TabIndex = 1;
            // 
            // lbl_Excel_Time
            // 
            this.lbl_Excel_Time.AutoSize = true;
            this.lbl_Excel_Time.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Excel_Time.Location = new System.Drawing.Point(34, 64);
            this.lbl_Excel_Time.Name = "lbl_Excel_Time";
            this.lbl_Excel_Time.Size = new System.Drawing.Size(202, 24);
            this.lbl_Excel_Time.TabIndex = 2;
            this.lbl_Excel_Time.Text = "上次读取表单时间";
            // 
            // frm_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1916, 847);
            this.Controls.Add(this.grp_Execl_Info);
            this.Controls.Add(this.grp_IMSI_Info);
            this.Controls.Add(this.dgv_IMSI_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.frm_Display_Load);
            this.DoubleClick += new System.EventHandler(this.frm_Display_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IMSI_Data)).EndInit();
            this.grp_IMSI_Info.ResumeLayout(false);
            this.grp_IMSI_Info.PerformLayout();
            this.grp_Execl_Info.ResumeLayout(false);
            this.grp_Execl_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_IMSI_No;
        private System.Windows.Forms.GroupBox grp_IMSI_Info;
        private System.Windows.Forms.Label lbl_IMSI_Result;
        private System.Windows.Forms.Label lbl_IMSI_Time;
        private System.Windows.Forms.GroupBox grp_Execl_Info;
        private System.Windows.Forms.Label lbl_Excel_Num;
        private System.Windows.Forms.Label lbl_Excel_Time;
        public System.Windows.Forms.DataGridView dgv_IMSI_Data;
        public System.Windows.Forms.TextBox txt_IMSI_No;
        public System.Windows.Forms.TextBox txt_IMSI_Result;
        public System.Windows.Forms.TextBox txt_IMSI_Time;
        public System.Windows.Forms.TextBox txt_Excel_Num;
        public System.Windows.Forms.TextBox txt_Excel_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 通讯番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICCID番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMSI番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结果;
    }
}