using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapitanTioApp.DataModel
{
    [DataContract]
    public class clsTwitterJson
    {
        [DataMember]
        public List<resultObject> results { get; set; }
    }

    [DataContract]
    public class resultObject
    {
        [DataMember]
        public string from_user { get; set; }
        [DataMember]
        public string from_user_name { get; set; }
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public string to_user { get; set; }
        [DataMember]
        public string to_user_name { get; set; }
    }

}
