using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Helpers
{
    public class ObjectClone
    {
        public static void CopyProperties(object source, object target)
        {
            PropertyInfo[] sourceProperties = source.GetType().GetProperties();
            foreach (var sourceProp in sourceProperties)
            {
                PropertyInfo targetProp = target.GetType().GetProperty(sourceProp.Name);
                if (targetProp != null && targetProp.CanWrite)
                {
                    targetProp.SetValue(target, sourceProp.GetValue(source));
                }
            }
        }
    }
}
