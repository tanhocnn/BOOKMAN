namespace Framework
{
    public static class Extension
    {
        /// <summary>
        /// bien doi tu chuoi sang so nguyen
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }
        /// <summary>
        /// bien doi tu chuoi sang so nguyen
        /// </summary>
        /// <param name="value"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool ToInt(this string value, out int i)
        {
            return int.TryParse(value, out i);
        }
        /// <summary>
        /// bien doi chuoi Y,y,True, true, sang true
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ToBool(this string value)
        {
            var v = value.ToLower();
            if (v=="y" || v=="true") return true;
            return false;
        }
        /// <summary>
        /// bien doi true/false thanh Yes/No hoac Co/Khong
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format">y/n hoac c/k</param>
        /// <returns></returns>
        public static string ToString(this bool value, string format)
        {
            if (format == "y/n")
                return value ? "Yes" : "No";
            if (format == "c/k")
                return value ? "Co" : "Khong";
            return value ? "True" : "False";
        }
    }
}