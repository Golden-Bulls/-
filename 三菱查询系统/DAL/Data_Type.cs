using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三菱查询系统
{
    class Data_Type
    {

        /// <summary>
        /// DataSet 转成 List<String[]> 的数据转换
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<string[]> DatasetToList(DataSet data)
        {
            List<string[]> str = new List<string[]>();
            string[] str2 = new string[data.Tables[0].Columns.Count];
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {

                for (int j = 0; j < data.Tables[0].Columns.Count; j++)
                {
                    str2[j] = data.Tables[0].Rows[i][j].ToString();
                }
                str.Add(str2);
            }
            return str;
        }




    }
}
