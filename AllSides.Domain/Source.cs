using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllSides.Domain.Enums;
using System.ComponentModel;
using System.Reflection;

namespace AllSides.Domain
{
    public class Source
    {
        public Viewpoint Viewpoint { get; set; }
        public Outlet Outlet { get; set; }
        public string OutletName { get { return GetEnumDescription(Outlet); } }
        public Category Category { get; set; }
        public string Uri { get; set; }

        private string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
