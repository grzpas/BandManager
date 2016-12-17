using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Band.Model.Exceptions;

namespace Band.Model.Google
{
    public class GoogleDistanceMatrixResponseParser
    {
        private const string ROOT = "/DistanceMatrixResponse/";
        private const string STATUS = "status";
        private const string OriginAddress = "origin_address";
        private const string DestinationAddress = "destination_address";
        private const string DistanceInMeters = @"element/distance/value";
        private const string ROW = "row";
        readonly XmlElement _xmlElement;
        
        public GoogleDistanceMatrixResponseParser(XmlDocument xmlDocument)
        {
            _xmlElement = xmlDocument.DocumentElement;
        }

        public long GetDistance()
        {
            long result = 0;
            XmlNodeList nodeList = _xmlElement.SelectNodes(ROOT + ROW);
            if (nodeList != null)
            {
                for (int i = 0; i < nodeList.Count; ++i)
                {
                    XmlNode node = nodeList[i];
                    XmlNodeList elementNodes = node.SelectNodes(DistanceInMeters);
                    if (elementNodes != null)
                    {
                        XmlNode properNode = elementNodes[i];
                        string textResult = properNode.InnerText;
                        result += Convert.ToInt64(textResult);
                    }
                }
            }
            return result;
        }

        public bool IsStatusOK()
        {
            return GetStatus() == "OK";
        }

        public string GetStatus()
        {
            
            XmlNode node = _xmlElement.SelectSingleNode(ROOT + STATUS);
            if (node != null)
            {
                string textResult = node.InnerText.Trim();
                return textResult;
            }
            return null;
        }

        private static string Utf8ToUnicode(string utf8)
        {
            return
                Encoding.Unicode.GetString(Encoding.Convert(Encoding.UTF8, Encoding.Unicode,
                                                            Encoding.UTF8.GetBytes(utf8)));
        }


        public List<KeyValuePair<string, string>> GetDestinations()
        {
            var result = new List<KeyValuePair<string, string>>();
            XmlNodeList nodeListOrigins = _xmlElement.SelectNodes(ROOT + OriginAddress);
            XmlNodeList nodeListDest = _xmlElement.SelectNodes(ROOT + DestinationAddress);
            if (nodeListOrigins != null && nodeListDest != null)
            {
                if (nodeListOrigins.Count != nodeListDest.Count)
                    throw new GoogleResponseParsingException("Different origin and destination count");
                for (int i = 0; i < nodeListOrigins.Count; ++i)
                {
                    string origin = Utf8ToUnicode(nodeListOrigins[i].InnerText);
                    string dest = Utf8ToUnicode(nodeListDest[i].InnerText);               
                    result.Add(new KeyValuePair<string, string>(origin, dest));
                }
                return result;
            }
            return null;
        }
    }
}
