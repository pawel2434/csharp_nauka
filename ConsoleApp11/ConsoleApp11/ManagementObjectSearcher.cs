using System;
using System.Collections.Generic;

namespace WMISample
{
    internal class ManagementObjectSearcher
    {
        private string v1;
        private string v2;

        public ManagementObjectSearcher(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal IEnumerable<ManagementObject> Get()
        {
            throw new NotImplementedException();
        }
    }
}