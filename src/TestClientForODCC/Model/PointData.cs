using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    public class PointData
    {
        /// <summary>
        /// 点位对象 id。见点位对象定义。
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 测点的实时值。最大长度 64 字节。
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 测点的采集时间。UNIX 时间戳。
        /// </summary>
        public long timestamp { get; set; }
    }
}
