using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public static class Enums
    {
        public static T GetEnumFromName<T>(string name, bool ignoreCase = false)
        {
            try
            {
                return (T)Enum.Parse(typeof(T), name, ignoreCase);
            }
            catch (ArgumentException)
            {
                throw;
            }
        }
    }
}
