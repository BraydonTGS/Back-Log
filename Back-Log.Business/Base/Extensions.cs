using System.ComponentModel;
using System.Runtime.Serialization;

namespace Back_Log.Business.Base
{
    public static class Extensions
    {
        /// <summary>
        /// Get the Enum Value from the Description Data Annotation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumMemberValue(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field != null)
            {
                var description = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
                if (description != null)
                {
                    return description.Description;
                }
            }

            return value.ToString();
        }
    }
}
