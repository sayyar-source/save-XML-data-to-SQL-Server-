using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebAppXmlToDB.Models
{
    [Serializable]
    [XmlRoot("product")]
    public class ProductImportMetaData
    {
        [XmlElement("id")]
        public int id { get; set; }
        [XmlElement("name")]
        public string name { get; set; }
        [XmlElement("Price")]
        public string Price { get; set; }
        [XmlElement("quentity")]
        public string quentity { get; set; }
    }
 
}
