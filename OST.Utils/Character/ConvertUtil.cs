using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OST.Utils.Character
{
    public class ConvertUtil
    {
        public static void Test()
        {
            string s = "我是一个2兵";
            int len = s.Length;//6个字符  
            byte[] sarr = System.Text.Encoding.Default.GetBytes(s);
            len = sarr.Length;//11个字节  

            //10进制转字符串，也没有意义，要转成对应的ascii码
            int t1 = 25105;
            string s1 = t1.ToString();
            //这个10进制转对应ASCII字符才有意义。
            s1 = ((char)t1).ToString();//我

            //16进制转字符串:这个没有意义。就是tostring了。
            int intAB = 0x16;
            s1 = intAB.ToString();
            //16进制转对应ASCII字符:
            byte babb = 0x11;
            string ass = ((char)babb).ToString();

            //ASCII字符串转10进制数
            string tr = "我";
            string d = "";
            for (int i = 0; i < tr.Length; i++)
            {
                int ii = (int)Convert.ToChar(tr.Substring(i, 1));
                d = d + " " + ii.ToString();
            }
            //ASCII字符串转16进制数
            string s2 = "我";
            byte[] ba = System.Text.ASCIIEncoding.Default.GetBytes(s2);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in ba)
            {
                sb.Append(b.ToString("x") + " ");
            }
            //16进制数转10进制
            int intA = 0x16;//定义的时候是必须带0x的  
            string strA = "6211";//字符串可以不带  
            int intA1 = Convert.ToInt32(intA);
            int intA2 = Convert.ToInt32(strA, 16);

            //10进制转16进制
            strA = Convert.ToString(intA2, 16);


            //10进制转2进制，16进制类似
            int int10 = 10;
            string str2 = Convert.ToString(int10, 2);

            //2进制转10进制
            int10 = Convert.ToInt32(str2, 2);

            string str = "我";

            //这里我们将采用2字节一个汉字的方法来取出汉字的16进制码

            byte[] textbuf = Encoding.Default.GetBytes(str);

            string textAscii = string.Empty;//用来存储转换过后的ASCII码

            for (int i = 0; i < textbuf.Length; i++)

            {

                textAscii += textbuf[i].ToString("X");

            }

            MessageBox.Show(textAscii);


            //将ASCII字符转换为汉字

            string textStr = string.Empty;

            int k = 0;//字节移动偏移量

            byte[] buffer = new byte[textAscii.Length / 2];//存储变量的字节

            for (int i = 0; i < textAscii.Length / 2; i++)

            {

                //每两位合并成为一个字节

                buffer[i] = byte.Parse(textAscii.Substring(k, 2), System.Globalization.NumberStyles.HexNumber);

                k = k + 2;

            }

            //将字节转化成汉字

            textStr = Encoding.Default.GetString(buffer);
        }
    }
}
