namespace Services
{
    using System;
    using System.Xml;
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Xml to json service
    /// </summary>
    public class XmlToJsonService : AbstractService
    {
    
    /// <summary>
    /// Bad format string
    /// </summary>
    private const string BADXMLFORMATERROR = "Bad Xml format";

    /// <summary>
    /// Error string
    /// </summary>
    private const string PROCESSINGERROR = "An error occured while processing the input value.. ";

    /// <summary>
    /// Converts the input value (xml) to json format
    /// </summary>
    /// <param name="XmlValue">Xml value</param>
    /// <returns>Json  value</returns>
    public static string GetJson(string XmlValue)
    {
            string json = string.Empty;
            try
            {
                XDocument xdoc =   XDocument.Parse(XmlValue);
                RemoveAttributesAndEmptyNodes(xdoc);
                XmlDocument document = getXmlDocument(xdoc);  
                json = JsonConvert.SerializeXmlNode(document);
            }
            catch(XmlException ex)
            {
                json = BADXMLFORMATERROR;
                logger.Error(ex);
            }
            catch(Exception ex)
            {
                json = PROCESSINGERROR;
                logger.Error(ex);
            }   
                
            return json;
    }
        
    /// <summary>
    /// Convert Xdocument to XmlDocument
    /// </summary>
    /// <param name="xdoc">Xdocument</param>
    /// <returns>XmlDocument</returns>
    private static XmlDocument getXmlDocument(XDocument xdoc)
    {
            var xmlDocument = new XmlDocument();            
            using (var xmlReader = xdoc.CreateReader())                
            {              
               xmlDocument.Load(xmlReader);               
               return xmlDocument;              
            }
   }

   /// <summary>
   /// Remove empty nodes and attributes 
   /// </summary>
   /// <param name="doc"></param>
   private static void RemoveAttributesAndEmptyNodes(XDocument doc)
        {            
            doc.Descendants().Where(e => !e.HasElements && string.IsNullOrEmpty(e.Value)).Remove();
            doc.Descendants().Where(e => e.HasAttributes).ToList().ForEach(e => e.RemoveAttributes());
        }   
    }
}
