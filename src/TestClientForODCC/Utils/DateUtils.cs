namespace TestClientForODCC.Utils
{
    public class DateUtils
    {
        private static DateTime unixTimestampBaseTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        /// <summary>
        /// 时间对象转换为Unix时间戳
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long ToUnixTimestamp(DateTime time)
        {
            if (time.Kind != DateTimeKind.Utc)
                time = time.ToUniversalTime();
            return Convert.ToInt64((time - unixTimestampBaseTime).TotalSeconds);
        }

        /// <summary>
        /// Unix时间戳转换为时间对象
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static DateTime FromUnixTimestamp(long time)
        {
            var rtn = unixTimestampBaseTime.AddSeconds(time);
            return rtn.ToLocalTime();
        }
    }
}
