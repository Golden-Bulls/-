namespace 三菱查询系统
{
    partial class frm_Data
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
            this.dgv_IMSI_Data = new System.Windows.Forms.DataGridView();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.通讯番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICCID番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMSI番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结果 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Search_Info = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IMSI_Result = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.txt_IMSI_Time = new System.Windows.Forms.TextBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_IMSI_No = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_OK_List = new System.Windows.Forms.Button();
            this.btn_CM_List = new System.Windows.Forms.Button();
            this.btn_NG_List = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IMSI_Data)).BeginInit();
            this.grp_Search_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_IMSI_Data
            // 
            this.dgv_IMSI_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IMSI_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.时间,
            this.通讯番号,
            this.电话番号,
            this.ICCID番号,
            this.IMSI番号,
            this.结果});
            this.dgv_IMSI_Data.Location = new System.Drawing.Point(23, 109);
            this.dgv_IMSI_Data.Name = "dgv_IMSI_Data";
            this.dgv_IMSI_Data.RowTemplate.Height = 23;
            this.dgv_IMSI_Data.Size = new System.Drawing.Size(1171, 804);
            this.dgv_IMSI_Data.TabIndex = 1;
            // 
            // 时间
            // 
            this.时间.HeaderText = "时间";
            this.时间.Name = "时间";
            this.时间.Width = 200;
            // 
            // 通讯番号
            // 
            this.通讯番号.HeaderText = "通讯番号";
            this.通讯番号.Name = "通讯番号";
            // 
            // 电话番号
            // 
            this.电话番号.HeaderText = "电话番号";
            this.电话番号.Name = "电话番号";
            this.电话番号.Width = 200;
            // 
            // ICCID番号
            // 
            this.ICCID番号.HeaderText = "ICCID番号";
            this.ICCID番号.Name = "ICCID番号";
            this.ICCID番号.Width = 300;
            // 
            // IMSI番号
            // 
            this.IMSI番号.HeaderText = "IMSI番号";
            this.IMSI番号.Name = "IMSI番号";
            this.IMSI番号.Width = 200;
            // 
            // 结果
            // 
            this.结果.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.结果.HeaderText = "结果";
            this.结果.Name = "结果";
            // 
            // grp_Search_Info
            // 
            this.grp_Search_Info.Controls.Add(this.btn_Search);
            this.grp_Search_Info.Controls.Add(this.textBox2);
            this.grp_Search_Info.Controls.Add(this.label2);
            this.grp_Search_Info.Controls.Add(this.textBox1);
            this.grp_Search_Info.Controls.Add(this.label1);
            this.grp_Search_Info.Controls.Add(this.txt_IMSI_Result);
            this.grp_Search_Info.Controls.Add(this.lbl_3);
            this.grp_Search_Info.Controls.Add(this.txt_IMSI_Time);
            this.grp_Search_Info.Controls.Add(this.lbl_2);
            this.grp_Search_Info.Controls.Add(this.txt_IMSI_No);
            this.grp_Search_Info.Controls.Add(this.lbl_1);
            this.grp_Search_Info.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grp_Search_Info.Location = new System.Drawing.Point(1280, 25);
            this.grp_Search_Info.Name = "grp_Search_Info";
            this.grp_Search_Info.Size = new System.Drawing.Size(610, 810);
            this.grp_Search_Info.TabIndex = 4;
            this.grp_Search_Info.TabStop = false;
            this.grp_Search_Info.Text = "查询条件";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(474, 827);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 34);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(172, 510);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(424, 38);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(60, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "IMSI番号";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(172, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 38);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(60, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ICCID番号";
            // 
            // txt_IMSI_Result
            // 
            this.txt_IMSI_Result.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_IMSI_Result.Location = new System.Drawing.Point(172, 286);
            this.txt_IMSI_Result.Name = "txt_IMSI_Result";
            this.txt_IMSI_Result.Size = new System.Drawing.Size(424, 38);
            this.txt_IMSI_Result.TabIndex = 1;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_3.Location = new System.Drawing.Point(60, 291);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(106, 24);
            this.lbl_3.TabIndex = 2;
            this.lbl_3.Text = "电话番号";
            // 
            // txt_IMSI_Time
            // 
            this.txt_IMSI_Time.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_IMSI_Time.Location = new System.Drawing.Point(172, 174);
            this.txt_IMSI_Time.Name = "txt_IMSI_Time";
            this.txt_IMSI_Time.Size = new System.Drawing.Size(424, 38);
            this.txt_IMSI_Time.TabIndex = 1;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_2.Location = new System.Drawing.Point(60, 179);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(106, 24);
            this.lbl_2.TabIndex = 2;
            this.lbl_2.Text = "通讯番号";
            // 
            // txt_IMSI_No
            // 
            this.txt_IMSI_No.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_IMSI_No.Location = new System.Drawing.Point(172, 62);
            this.txt_IMSI_No.Name = "txt_IMSI_No";
            this.txt_IMSI_No.Size = new System.Drawing.Size(424, 38);
            this.txt_IMSI_No.TabIndex = 1;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_1.Location = new System.Drawing.Point(60, 67);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(106, 24);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "表单名称";
            // 
            // btn_OK_List
            // 
            this.btn_OK_List.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK_List.Location = new System.Drawing.Point(23, 25);
            this.btn_OK_List.Name = "btn_OK_List";
            this.btn_OK_List.Size = new System.Drawing.Size(158, 50);
            this.btn_OK_List.TabIndex = 5;
            this.btn_OK_List.Text = "OK_LIST";
            this.btn_OK_List.UseVisualStyleBackColor = true;
            // 
            // btn_CM_List
            // 
            this.btn_CM_List.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CM_List.Location = new System.Drawing.Point(1035, 25);
            this.btn_CM_List.Name = "btn_CM_List";
            this.btn_CM_List.Size = new System.Drawing.Size(158, 50);
            this.btn_CM_List.TabIndex = 5;
            this.btn_CM_List.Text = "CM_LIST";
            this.btn_CM_List.UseVisualStyleBackColor = true;
            // 
            // btn_NG_List
            // 
            this.btn_NG_List.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_NG_List.Location = new System.Drawing.Point(529, 25);
            this.btn_NG_List.Name = "btn_NG_List";
            this.btn_NG_List.Size = new System.Drawing.Size(158, 50);
            this.btn_NG_List.TabIndex = 5;
            this.btn_NG_List.Text = "NG_LIST";
            this.btn_NG_List.UseVisualStyleBackColor = true;
            // 
            // frm_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1916, 847);
            this.Controls.Add(this.btn_NG_List);
            this.Controls.Add(this.btn_CM_List);
            this.Controls.Add(this.btn_OK_List);
            this.Controls.Add(this.grp_Search_Info);
            this.Controls.Add(this.dgv_IMSI_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Data";
            this.Text = "Data";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IMSI_Data)).EndInit();
            this.grp_Search_Info.ResumeLayout(false);
            this.grp_Search_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_IMSI_Data;
        private System.Windows.Forms.GroupBox grp_Search_Info;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IMSI_Result;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.TextBox txt_IMSI_Time;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_IMSI_No;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_OK_List;
        private System.Windows.Forms.Button btn_CM_List;
        private System.Windows.Forms.Button btn_NG_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 通讯番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICCID番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMSI番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结果;
    }
}