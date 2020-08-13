using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public static class Enums
    {
        public static T GetEnumFromName<T>(string name)
        {
            try
            {
                return (T)Enum.Parse(typeof(T), name);
            }
            catch (ArgumentException)
            {
                throw;
            }
        }
    }
}
