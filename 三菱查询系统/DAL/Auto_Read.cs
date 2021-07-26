using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HslCommunication.Profinet.Melsec;
using HslCommunication;
using System.Threading;


namespace 三菱查询系统
{
    class Auto_Read
    {
        public static bool Auto_Stop;
        //private MelsecMcNet mel = new MelsecMcNet("192.168.3.110", 5001);

        #region PLC 寄存器地址
        private static String PLC_Start_Read = "D100";
        private static String PLC_IMSI_Content = "D100";
        private static String PLC_IMSI_Result = "D100";
        private static String PLC_Read_Ending = "D100";


        #endregion

        public void thread_Auto()
        {
            


            while (Auto_Stop)
            {
                if (true)//mel.ReadInt16(PLC_Start_Read).Content.ToString()=="1"
                {
                    DateTime d1 = DateTime.Now;


                    //string IMSI_No = mel.ReadString("D1050", 15).Content.ToString();
                    string IMSI_No = "123";
                    string IMSI_Time= DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); 
                    frm_Display._Display.txt_IMSI_No.Text = IMSI_No;//显示番号
                    frm_Display._Display.txt_IMSI_Time.Text = IMSI_Time; //显示读取时间

                    SQL_Helper sql = new SQL_Helper();
                    string Commandstr = string.Format("select * from Mitsubishi_System.dbo.CM_LIST where IMSI番号='{0}'",IMSI_No);
                    bool result = sql.Result_Exist(Commandstr);//调用方法 去查询数据库是否有这个IMSI番号


                    frm_Display._Display.txt_IMSI_Result.Text = result.ToString();//返回结果，显示给界面
                    //mel.Write(PLC_IMSI_Result, result);// 返回结果给PLC

                     Data_Type data_Type = new Data_Type();
                    if (!result)
                    {
                        //返回查询结果，显示给列表
                        string[] data_ng = { IMSI_Time, "----", "------------", "---------------------", "---------------", "NG" };
                        frm_Display._Display.dgv_IMSI_Data.Rows.Insert(0,data_ng);
                        //frm_Display._Display.DataGridView1.Rows.Insert(0,data_ng);


                        


                        //将查询结果保存至数据库
                        string Commandstr_NG = string.Format("insert into Mitsubishi_System.dbo.NG_LIST (时间,通讯番号,电话番号,ICCID番号,IMSI番号,结果) values ('{0}','{1}','{2}','{3}','{4}','{5}')", data_ng[0], data_ng[1], data_ng[2], data_ng[3], data_ng[4], data_ng[5]);
                        sql.DataSet(Commandstr_NG);
                    }
                    else
                    {
                        //返回查询结果，显示给列表
                        DataSet dataSet= sql.DataSet(string.Format("select * from Mitsubishi_System.dbo.CM_LIST where IMSI番号='{0}'", IMSI_No));
                        string[] data_ok = data_Type.DatasetToList(dataSet)[0];
                        frm_Display._Display.dgv_IMSI_Data.Rows.Insert(0,data_ok);

                        //将查询结果保存至数据库
                        string Commandstr_NG = string.Format("insert into Mitsubishi_System.dbo.OK_LIST (时间,通讯番号,电话番号,ICCID番号,IMSI番号,结果) values ('{0}','{1}','{2}','{3}','{4}','OK')", IMSI_Time, data_ok[2], data_ok[3], data_ok[4], data_ok[5]);
                        sql.DataSet(Commandstr_NG);

                    }


                    DateTime d2 = DateTime.Now;
                    frm_Display._Display.txt_Excel_Time.Text = (d2 - d1).ToString();



                }
                Thread.Sleep(200);
                

            }
        }




    }
}
