using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace DTO.Utility
{
    public static class Converter
    {
        public static string XmlSerialize<T>(this T model)
        {
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (StringWriter textWriter = new StringWriter())
            {
                xs.Serialize(textWriter, model);
                return textWriter.ToString();
            }
        }

        public static T XmlDeserialize<T>(string xmlDoc)
        {
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (TextReader sr = new StringReader(xmlDoc))
            {
                return (T)xs.Deserialize(sr);
            }

        }

        /// <summary>
        /// Convert XML To JSON
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static string XmlToJson(this string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            return jsonText;


        }

        /// <summary>
        /// Convert JSON To XML Document
        /// </summary>
        /// <param name="jsonText"></param>
        /// <returns></returns>
        public static XmlDocument JsonToXml(this string jsonText)
        {
            // To convert JSON text contained in string json into an XML node
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonText);
            return doc;
        }

        /// <summary>
        /// Convert Json To XML String Format
        /// </summary>
        /// <param name="jsonText"></param>
        /// <returns></returns>
        public static string JsonToXmlString(this string jsonText)
        {
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonText);
            return doc.OuterXml;
        }
    }
}
