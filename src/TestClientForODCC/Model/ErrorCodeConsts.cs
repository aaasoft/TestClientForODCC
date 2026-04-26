using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 错误码
    /// </summary>
    public class ErrorCodeConsts
    {
        /// <summary>
        /// 访问成功。
        /// </summary>
        public const int CODE_0 = 0;
        public const string CODE_0_MESSAGE = "ok";

        /// <summary>
        /// 参数异常。包括 JSON 无法解析；多、缺参数的情况。
        /// </summary>
        public const int CODE_1 = 1;
        public const string CODE_1_MESSAGE = "abnormal parameter";

        /// <summary>
        /// TOKEN 异常。
        /// </summary>
        public const int CODE_2 = 2;
        public const string CODE_2_MESSAGE = "abnormal TOKEN";

        /// <summary>
        /// 版本号异常。
        /// </summary>
        public const int CODE_3 = 3;
        public const string CODE_3_MESSAGE = "abnormal version";

        /// <summary>
        /// 其它错误（有 error_msg）。
        /// </summary>
        public const int CODE_4 = 4;
        public const string CODE_4_MESSAGE = "other error";

        /// <summary>
        /// 未知错误（无 error_msg）。
        /// </summary>
        public const int CODE_5 = 5;
        public const string CODE_5_MESSAGE = "unknown error";

        /// <summary>
        /// 用户名或密码错误。
        /// </summary>
        public const int CODE_100 = 100;
        public const string CODE_100_MESSAGE = "user name or password is wrong";

        /// <summary>
        /// 配置无需更新（版本号一致）。
        /// </summary>
        public const int CODE_101 = 101;
        public const string CODE_101_MESSAGE = "configuration does not need to beupdated";

        /// <summary>
        /// 请求的 guid 不存在（有一个不存在，其它的数据也将不返回）。
        /// </summary>
        public const int CODE_102 = 102;
        public const string CODE_102_MESSAGE = "the requested guid does not exist";

        /// <summary>
        /// 值异常。
        /// </summary>
        public const int CODE_103 = 103;
        public const string CODE_103_MESSAGE = "abnormal mode value Mode";

        /// <summary>
        /// 策略 ID 不存在。
        /// </summary>
        public const int CODE_104 = 104;
        public const string CODE_104_MESSAGE = "strategy ID does not exist";

        /// <summary>
        /// 开始时间晚于结束时间。
        /// </summary>
        public const int CODE_105 = 105;
        public const string CODE_105_MESSAGE = "the begin-time is later than the end-time";

        /// <summary>
        /// 时间格式不正确。
        /// </summary>
        public const int CODE_106 = 106;
        public const string CODE_106_MESSAGE = "time format is not correct";

        /// <summary>
        /// serial_no 不存在。
        /// </summary>
        public const int CODE_107 = 107;
        public const string CODE_107_MESSAGE = "serial_no does not exist";

        /// <summary>
        /// msg_type 不存在。
        /// </summary>
        public const int CODE_108 = 108;
        public const string CODE_108_MESSAGE = "msg_type does not exist";

        /// <summary>
        /// 重复告警操作。
        /// </summary>
        public const int CODE_109 = 109;
        public const string CODE_109_MESSAGE = "repetitive alarm operation";

        /// <summary>
        /// 值异常。
        /// </summary>
        public const int CODE_110 = 110;
        public const string CODE_110_MESSAGE = "abnormal value";

        /// <summary>
        /// 控制失败。
        /// </summary>
        public const int CODE_111 = 111;
        public const string CODE_111_MESSAGE = "control failure";

        /// <summary>
        /// 指定的控制点不可控。
        /// </summary>
        public const int CODE_112 = 112;
        public const string CODE_112_MESSAGE = "specified control point is not controllable.";
    }
}
