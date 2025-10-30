using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Utilidades
{
    public static class EnumHelper
    {
        public static string GetDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? value.ToString();
        }

        public static List<KeyValuePair<Enum, string>> GetEnumValuesWithDescriptions<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                      .Cast<T>()
                      .Select(e => new KeyValuePair<Enum, string>(e, GetDescription(e)))
                      .ToList();
        }
    }
}
