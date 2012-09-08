using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapitanTioApp.Data.DataModel
{
    [DataContract]
    public class clsTwitterJson
    {
        [DataMember]
        public List<Tweet> results { get; set; }
    }

    [DataContract]
    public class Tweet
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
