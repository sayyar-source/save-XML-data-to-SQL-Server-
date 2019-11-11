using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using WebAppXmlToDB.Models;
using WebAppXmlToDB.Services;

namespace WebAppXmlToDB.Controllers
{
    public class HomeController : Controller
    {
        IXmlService _xmlService;
        public HomeController(IXmlService xmlService)
        {
            _xmlService = xmlService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Postxml(IFormFile xmlfile)
        {
             string xmlUrl = "D:\\product3.xml";
            if(xmlfile.ContentType.Equals("application/xml") || xmlfile.ContentType.Equals("text/xml"))
            {
                //    try
                //    {

                var path = "D:\\My Work\\XmlToDB\\WebAppXmlToDB\\WebAppXmlToDB\\wwwroot\\product.xml";
                    //var path = Path.Combine(
                    //  Directory.GetCurrentDirectory(), "wwwroot",
                    //  xmlfile.FileName);
                    //var xmlpath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot");
                    //var filePath = Path.Combine(xmlpath, xmlfile.FileName).ToString();
                   XDocument xDoc = XDocument.Load(xmlUrl);
                    //FileStream fileStream = new FileStream(path, FileMode.Create);

                    //    xmlfile.CopyTo(fileStream);
                    //    XDocument xDoc = XDocument.Load(fileStream);

                        List<Product> productlist = xDoc.Descendants("product").Select
                        (product =>
                        new Product
                        {
                            id = product.Element("id").Value,
                            name = product.Element("name").Value,
                            Price = product.Element("id").Value,
                            quentity = product.Element("id").Value
                        }).ToList();
                    _xmlService.Insertxml(productlist);

                    return View("Success");

                //}
                //catch 
                //{
                //    ViewBag.Error = "Cant't import xml file";
                //    return View("index");
                //}

            }
            else
            {
                ViewBag.Error = "Cant't import xml file";
                return View("index");
            }
        }

      

     
    }
}
