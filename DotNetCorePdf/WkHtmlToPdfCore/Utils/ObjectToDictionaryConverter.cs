/*
MIT License

Copyright (c) 2017 WriteLinez L.L.C.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
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
