namespace 三菱查询系统
{
    partial class frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_Main = new System.Windows.Forms.Panel();
            this.Btn_Display = new System.Windows.Forms.Button();
            this.Btn_Data = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pic_Max = new System.Windows.Forms.PictureBox();
            this.pic_Min = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Main
            // 
            this.Pnl_Main.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Main.Location = new System.Drawing.Point(2, 162);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(1916, 847);
            this.Pnl_Main.TabIndex = 0;
            // 
            // Btn_Display
            // 
            this.Btn_Display.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Display.Location = new System.Drawing.Point(12, 12);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(190, 44);
            this.Btn_Display.TabIndex = 1;
            this.Btn_Display.Text = "主画面";
            this.Btn_Display.UseVisualStyleBackColor = true;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // Btn_Data
            // 
            this.Btn_Data.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Data.Location = new System.Drawing.Point(241, 12);
            this.Btn_Data.Name = "Btn_Data";
            this.Btn_Data.Size = new System.Drawing.Size(190, 44);
            this.Btn_Data.TabIndex = 1;
            this.Btn_Data.Text = "数据查询";
            this.Btn_Data.UseVisualStyleBackColor = true;
            this.Btn_Data.Click += new System.EventHandler(this.Btn_Data_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.Location = new System.Drawing.Point(948, 86);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(161, 47);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "主画面";
            // 
            // pic_Max
            // 
            this.pic_Max.BackColor = System.Drawing.Color.Transparent;
            this.pic_Max.Location = new System.Drawing.Point(1859, 10);
            this.pic_Max.Name = "pic_Max";
            this.pic_Max.Size = new System.Drawing.Size(40, 40);
            this.pic_Max.TabIndex = 3;
            this.pic_Max.TabStop = false;
            this.pic_Max.Click += new System.EventHandler(this.pic_Max_Click);
            // 
            // pic_Min
            // 
            this.pic_Min.BackColor = System.Drawing.Color.Transparent;
            this.pic_Min.Location = new System.Drawing.Point(1800, 10);
            this.pic_Min.Name = "pic_Min";
            this.pic_Min.Size = new System.Drawing.Size(40, 40);
            this.pic_Min.TabIndex = 3;
            this.pic_Min.TabStop = false;
            this.pic_Min.Click += new System.EventHandler(this.pic_Min_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::三菱查询系统.Properties.Resources.三菱上位机_主画面;
            this.ClientSize = new System.Drawing.Size(1920, 1040);
            this.Controls.Add(this.pic_Min);
            this.Controls.Add(this.pic_Max);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.Btn_Data);
            this.Controls.Add(this.Btn_Display);
            this.Controls.Add(this.Pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三菱查询系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Main;
        private System.Windows.Forms.Button Btn_Display;
        private System.Windows.Forms.Button Btn_Data;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_Max;
        private System.Windows.Forms.PictureBox pic_Min;
    }
}

