using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OST.Utils.Numbers
{
    public class ConvertUtil
    {
        public static int UshortArrayToInt(ushort[] hexArray)
        {
            //ushort[] hexArray = { 0x0000, 0x64 }; // 替换为你的 ushort 数组

            // 将 ushort 数组转换为有符号整数
            int result = (short)((hexArray[0] << 16) | hexArray[1]);
            return result;
        }


    }
}
