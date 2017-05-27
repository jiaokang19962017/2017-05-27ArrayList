using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arraylist = new ArrayList();
            //arraylist.Add("张三");
            //arraylist.Add("哈哈");
            //arraylist.Add("王五");
            //arraylist.Add("招六");


            //foreach (var item in arraylist)//遍历集合
            //{
            //    Console.WriteLine(item);
            //}
            ////将集合转换成数组
            //string[] str = new string[arraylist.Count];
            //str = (string [])arraylist.ToArray(typeof(string));
            //foreach (string item in str)
            //{
            //    Console.WriteLine(item);
            //}
            ////将arraylist转换成array
            //Array array = arraylist.ToArray();

            ////插入`清空,修改,删除
            //ArrayList arraylist1 = new ArrayList();
            //int[] number = { 1, 2, 3 };
            //arraylist1.AddRange(number);//添加
            //arraylist1.Insert(3, 9);
            //foreach (var item in arraylist1)
            //{
            //    Console.WriteLine(item);
            //}
            //arraylist1.Clear();//清空
            //arraylist1.Sort();//排序
            //arraylist1.Remove(1);//根据内容删除
            //arraylist1.RemoveAt(1);//根据索引删除
            //arraylist1.Reverse();//反转
            //arraylist1.Contains(2);//查找,返回bool类型


            Queue queue = new Queue();//先进先出集合
            queue.Enqueue("张三");
            queue.Enqueue("李四");
            queue.Enqueue("王五");
            queue.Enqueue("赵六");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();

        }
    }
}
