using libMBIN;
using libMBIN.NMS;
using System;
using System.Collections;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="Object"/>.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Will return this entire object as a string. If it is a class it will recursively search each field for it's values
        /// and return those as well.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static string AsString(this Object instance)
        {
            var objType = instance.GetType();
            if (!objType.IsClass || objType.IsPrimitive || objType == typeof(decimal) || objType == typeof(string))
                return PrintFields(objType.Name, objType, instance);

            string objectValues = "";
            foreach (var field in objType.GetFields())
            {
                objectValues += PrintFields(field.Name, field.FieldType, field.GetValue(instance));
            }
            return objectValues;
        }

        private static string PrintFields(string fieldName, Type fieldType, object fieldValue)
        {
            throw new NotImplementedException();
            /*if (fieldValue == null)
            {
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldName, "NULL");
                return msg += "\n";
            }
            else if (fieldType.Name == "Vector2f")
            {
                var value = (Vector2f)fieldValue;
                string vector = $"({value.x}, {value.y})";
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldName, vector);
                return msg += "\n";
            }
            else if (fieldType.Name == "Vector3f")
            {
                var value = (Vector3f)fieldValue;
                string vector = $"({value.x}, {value.y}, {value.z})";
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldName, vector);
                return msg += "\n";
            }
            else if (fieldType.Name == "Vector4f")
            {
                var value = (Vector4f)fieldValue;
                string vector = $"({value.x}, {value.y}, {value.z}, {value.t})";
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldName, vector);
                return msg += "\n";
            }
            else if (fieldType.Name == "Quaternion")
            {
                var value = (Quaternion)fieldValue;
                string quaternion = $"({value.w}, {value.x}, {value.y}, {value.z})";
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldName, quaternion);
                return msg += "\n";
            }
            else if (fieldType.IsPrimitive || fieldType == typeof(decimal))
            {
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldName, fieldValue);
                return msg += "\n";
            }
            else if (fieldType == typeof(string))
            {
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldName, fieldValue);
                return msg += "\n";
            }
            else if (fieldType.IsAssignableTo(typeof(INMSString)))
            {
                string value = ((INMSString)fieldValue).StringValue();
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldName, value);
                return msg += "\n";
            }
            else if (fieldType.IsArray)
            {
                string msg = "";
                Array array = (Array)fieldValue;
                foreach (var item in array)
                {
                    msg += PrintFields(fieldName, item.GetType(), item);
                }
                return msg;
            }
            else if (fieldType.IsAssignableTo(typeof(IList)))
            {
                string msg = "";
                IList list = (IList)fieldValue;
                foreach (var item in list)
                {
                    msg += PrintFields(fieldName, item.GetType(), item);
                }
                return msg;
            }
            else if (fieldType.IsAssignableTo(typeof(NMSTemplate)))
            {
                string msg = "";
                NMSTemplate template = (NMSTemplate)fieldValue;
                foreach (var field in template.GetType().GetFields())
                {
                    msg += PrintFields(field.Name, field.FieldType, field.GetValue(fieldValue));
                }
                return msg;
            }
            else
            {
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldName, fieldValue);
                return msg += "\n";
            }*/
        }
    }
}
