﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niunan.CaiPiao.BLL.WanFa
{
    /// <summary>
    /// 银河国际：单
    /// </summary>
    public class Dan : IWanFaBLL
    {
        /// <summary>
        /// 单数，特殊号码13
        /// </summary>
        /// <param name="buycode"></param>
        /// <param name="kjcode"></param>
        /// <returns></returns>
        public bool IsZJ(string buycode, string kjcode)
        {
            bool b = false;
            int x = int.Parse(kjcode);
            if (x%2!=0 && x!=13)
            {
                b = true;
            }
            return b;
        }
    }
}
