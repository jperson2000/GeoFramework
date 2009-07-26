using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace GeoFramework
{
    static class Xml
    {
        /// <summary>
        /// Returns the XML namespace for GML documents.
        /// </summary>
        public const string GmlXmlNamespace = "http://www.opengis.net/gml";
        /// <summary>
        /// Returns the prefix applied to all GML XML elements.
        /// </summary>
        public const string GmlXmlPrefix = "gml";
        /// <summary>
        /// Returns the XML namespace for GeoFramework documents.
        /// </summary>
        public const string GeoFrameworkXmlNamespace = "http://www.geoframeworks.com/gml";
        /// <summary>
        /// Returns the prefix applied to all GeoFramework XML elements.
        /// </summary>
        public const string GeoFrameworkXmlPrefix = "geoframework";
    }
}
