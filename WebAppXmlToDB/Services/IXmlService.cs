using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXmlToDB.Models;

namespace WebAppXmlToDB.Services
{
   public interface IXmlService
    {
        void Insertxml(List<Product> list);
    }
}
