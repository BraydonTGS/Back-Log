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
        public static string GetEnumMemberValue(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field != null)
            {
                var enumMemberAttribute = (EnumMemberAttribute)Attribute.GetCustomAttribute(field, typeof(EnumMemberAttribute));
                if (enumMemberAttribute != null)
                {
                    return enumMemberAttribute.Value;
                }
            }

            return value.ToString();
        }
    }
}
