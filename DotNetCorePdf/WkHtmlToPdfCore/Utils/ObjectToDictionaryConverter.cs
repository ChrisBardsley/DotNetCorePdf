using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using DotNetCorePdf.WkHtmlToPdfCore.Attributes;

namespace DotNetCorePdf.WkHtmlToPdfCore.Utils
{
    public static class ObjectToDictionaryConverter
    {
        public static Dictionary<string, string> Convert(object obj)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            Type objType = obj.GetType();

            var objectProperties = objType.GetProperties()
                .Where(t => t.GetCustomAttribute<WkHtmlToPdfResolveToAttribute>() != null)
                .Select(t => new
                {
                    PropertyInfo = t,
                    ResolvesTo = t.GetCustomAttribute<WkHtmlToPdfResolveToAttribute>().Name,
                    NavigateChildren = t.GetCustomAttribute<WkHtmlToPdfResolveToAttribute>().NavigateToChildren
                });

            foreach (var objectProperty in objectProperties)
            {
                Type objectPropertyType = objectProperty.PropertyInfo.PropertyType;
                if (objectPropertyType.Equals(typeof(string)))
                {
                    string value = (string)objectProperty.PropertyInfo.GetValue(obj);
                    if (!string.IsNullOrEmpty(value))
                    {
                        string key = objectProperty.ResolvesTo;

                        values.Add(key, value);
                    }
                }
                else if (objectPropertyType.GetTypeInfo().BaseType != null && objectPropertyType.GetTypeInfo().BaseType.Equals(typeof(Enum)))
                {
                    string enumStringValue = objectProperty.PropertyInfo.GetValue(obj).ToString();
                    var valueAttribute = objectPropertyType.GetMembers().FirstOrDefault(t => t.Name.Equals(enumStringValue))
                        ?.GetCustomAttribute<WkHtmlToPdfResolveToAttribute>();
                    if (valueAttribute != null)
                    {
                        string value = valueAttribute.Name;
                        string key = objectProperty.ResolvesTo;

                        values.Add(key, value);
                    }
                }
                else if (objectProperty.NavigateChildren)
                {
                    object propertyValue = objectProperty.PropertyInfo.GetValue(obj);
                    if (propertyValue != null)
                    {
                        Dictionary<string, string> child = Convert(propertyValue);
                        foreach (var c in child)
                        {
                            string key = $"{objectProperty.ResolvesTo}.{c.Key}";
                            string value = c.Value;
                            values.Add(key, value);
                        }
                    }
                }
                else
                {
                    object propertyValue = objectProperty.PropertyInfo.GetValue(obj);
                    if (propertyValue != null)
                    {
                        string key = objectProperty.ResolvesTo;
                        string value = System.Convert.ToString(propertyValue);
                        bool bResult = false;
                        if (bool.TryParse(value, out bResult))
                        {
                            value = value.ToLower();
                        }
                        values.Add(key, value);
                    }
                }
            }

            return values;
        }        
    }
}
