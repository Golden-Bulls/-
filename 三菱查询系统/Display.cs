using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

namespace 三菱查询系统
{
    public partial class frm_Display : Form
    {
        public static frm_Display _Display;
        private delegate void InvokeHandler();
        public frm_Display()
        {
            InitializeComponent();


            #region DataGridView 打开双缓冲
            Type dgvType = this.dgv_IMSI_Data.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dgv_IMSI_Data, true, null);
            #endregion

            this.dgv_IMSI_Data.BackgroundColor = Color.White;

            _Display = this;
            CheckForIllegalCrossThreadCalls = false;
            this.dgv_IMSI_Data.RowHeadersVisible = false;




        }

        private void frm_Display_DoubleClick(object sender, EventArgs e)
        {
            Auto_Read auto_Read = new Auto_Read();
            Thread thread = new Thread(auto_Read.thread_Auto);
            if (Auto_Read.Auto_Stop)
            {
                Auto_Read.Auto_Stop = !Auto_Read.Auto_Stop;
            }
            else
            {

                Auto_Read.Auto_Stop = !Auto_Read.Auto_Stop;
                thread.Start();

            }



        }

        private void frm_Display_Load(object sender, EventArgs e)
        {

        }


    }


}
