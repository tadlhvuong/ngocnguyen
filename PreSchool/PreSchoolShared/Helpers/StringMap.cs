using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace PreSchoolShared.Helpers
{
    public class StringMap<T> : SortedList<string, T>
    {
        public new T this[string key]
        {
            get
            {
                if (key != null && ContainsKey(key))
                    return base[key];
                else
                    return default(T);
            }
            set
            {
                base[key] = value;
            }
        }
    }

    public class StringMap : StringMap<string>
    {
        public string BuildQueryString(string path)
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append(path);

            bool isFirst = true;
            foreach (var item in this)
            {
                if (isFirst)
                {
                    strBuilder.Append("?");
                    isFirst = false;
                }
                else
                    strBuilder.Append("&");

                strBuilder.Append($"{item.Key}={HttpUtility.UrlEncode(item.Value)}");
            }

            return strBuilder.ToString();
        }
    }

    public class NumberMap<T> : SortedList<int, T>
    {
        public new T this[int key]
        {
            get
            {
                if (ContainsKey(key))
                    return base[key];
                else
                    return default(T);
            }
            set
            {
                base[key] = value;
            }
        }
    }

    public class NumberMap : NumberMap<string>
    {
    }
}
