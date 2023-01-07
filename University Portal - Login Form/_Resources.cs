using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace University_Portal___Login_Form
{
    class _Resources
    {
        private static ResourceManager Manager = new ResourceManager("University_Portal___Login_Form.Resource1",
            Assembly.GetExecutingAssembly());

        public static string Get(string key)
        {
            return Manager.GetString(key);
        }
    }
}
