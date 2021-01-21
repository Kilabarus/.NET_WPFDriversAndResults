using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace WPFDriversAndResults.Models
{
    public static class Enums
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public enum Country
        {
            [Description("Россия")]
            Russia,
            [Description("Великобритания")]
            UK,
            [Description("Монако")]
            Monaco,
            [Description("Нидерланды")]
            Netherlands,
            [Description("Франция")]
            France,
            [Description("Дания")]
            Denmark,
            [Description("Испания")]
            Spain,
            [Description("Германия")]
            Germany,
        }

        public enum Team
        {            
            [Description("Скудерия Феррари")]
            Ferrari,            
            [Description("Мерседес")]
            Mercedes,            
            [Description("Ред Булл")]
            RedBull,            
            [Description("Альфа Таури")]
            AlphaTauri,            
            [Description("Уильямс")]
            Williams,            
            [Description("ХААС")]
            HAAS,            
            [Description("Рейсинг Поинт")]
            RacingPoint,            
            [Description("Рено")]
            Renault,            
            [Description("Макларен")]
            McLaren,            
            [Description("Према")]
            Prema,
        }

        public enum RacingSeries
        {            
            [Description("Формула-1")]
            F1,
            [Description("Формула-2")]
            F2,
            [Description("Индикар")]
            IndyCar
        }
    }
}
