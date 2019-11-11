using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebAppXmlToDB.Models
{
    [Serializable]
    [XmlRoot("product")]
    public class Product
    {
    
        [XmlElement("id")]
        public string id { get; set; }
        [XmlElement("name")]
        public string name { get; set; }
        [XmlElement("Price")]
        public string Price { get; set; }
        [XmlElement("quentity")]
        public string quentity { get; set; }
    }
}
