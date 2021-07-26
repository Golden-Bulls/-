using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 三菱查询系统
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            if (!HslCommunication.Authorization.SetAuthorizationCode("f44b3795-d88e-4d48-b7c9-d38e3c48441e"))
            {
                Console.WriteLine("Authorization failed!");
                return;
            }//Hsl注册
            //this.WindowState = FormWindowState.Maximized;
            load_Pnl(new frm_Display());

        }



        #region Funct


        /// <summary>
        /// 插入panel
        /// </summary>
        /// <param name="form"></param>
        public void load_Pnl(Form form)
        {
            form.TopLevel = false;
            foreach (var item in this.Pnl_Main.Controls)
            {
                if (item is Form)
                {
                    this.Pnl_Main.Controls.Clear();
                }
            }
            this.Pnl_Main.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// 更改标题
        /// </summary>
        /// <param name="name"></param>
        public void reName(string name)
        {
            this.lbl_Title.Text = name;
        }

        /// <summary>
        /// 面板内窗体的名称
        /// </summary>
        /// <returns></returns>
        public string Form_Name()
        {
            var item = this.Pnl_Main.Controls[0];
            return item.ToString().Split(':')[1];
        }



        #endregion

        /// <summary>
        /// 窗体加载中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 切换至主界面显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Display_Click(object sender, EventArgs e)
        {
            load_Pnl(new frm_Display());
            reName("主画面");
        }


        /// <summary>
        /// 切换至数据画面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Data_Click(object sender, EventArgs e)
        {
            load_Pnl(new frm_Data());
            reName("数据查询");
        }

        private void pic_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_Max_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ucBtnImg1_BtnClick(object sender, EventArgs e)
        {

        }
    }
}
