using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXmlToDB.Models;

namespace WebAppXmlToDB.Services
{
    public class XmlService : IXmlService
    {
        ProContext _context;
        public XmlService(ProContext context)
        {
            _context = context;
        }
        public void Insertxml(List<Product> list)
        {
            foreach (var item in list)
            {
                var v = _context.Products.Where(a => a.id.Equals(item.id)).FirstOrDefault();
                if(v!=null)
                {
                    v.id = item.id;
                    v.name = item.name;
                    v.name = item.Price;
                    v.quentity = item.quentity;
                    _context.Products.Add(v);
                }
                else
                {
                    _context.Products.Add(item);
                }
            }
            _context.SaveChanges();
        }
    }
}
