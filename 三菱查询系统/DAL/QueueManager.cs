using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三菱查询系统
{
    /// <summary>
    /// 队列的泛型类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class QueueManager<T>
    {
        //<>括号内是队列中的 数据类型
        private Queue<T> queue = new Queue<T>();

        /// <summary>
        /// 在最后加入 队列
        /// </summary>
        /// <param name="analy"></param>
        public void Add(T analy)
        {
            queue.Enqueue(analy);
        }

        /// <summary>
        /// 获取队列中的数据
        /// </summary>
        /// <returns></returns>
        public T Get()
        {
            return queue.Dequeue();
        }


        /// <summary>
        /// 判断 数据analy 是否存在于队列中
        /// </summary>
        /// <param name="analy"></param>
        /// <returns></returns>
        public bool IsGet(T analy)
        {
            bool result = false;
            result = queue.Contains(analy);
            return result;
        }

        /// <summary>
        /// 判断队列中是否还有数据
        /// </summary>
        /// <returns></returns>
        public bool IsHaveElment()
        {
            if (queue.Count <= 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 获取队列中的 数量
        /// </summary>
        /// <returns></returns>
        public int GetQueueCount()
        {
            return queue.Count;
        }



    }
}
