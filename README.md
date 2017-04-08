# GeoFramework is now DotSpatial

GeoFramework and GPS.Net are now part of the larger [DotSpatial](https://github.com/DotSpatial/DotSpatial) project.  All classes and libraries have been migrated from GeoFramework 2.0 and [GPS.Net 3.0](https://github.com/BigstickCarpet/GPS.Net) to the DotSpatial project, under the _DotSpatial.Positioning_ namespace.  We've taken great care to ensure backward compatibility during this transition, so other than the new namespace, there should be little or no changes needed for your applications that were previously using GeoFramework and GPS.Net.

The existing GeoFramework 2.0 and GPS.Net 3.0 projects will remain here for legacy purposes, but all future development will take place within the DotSpatial project.  For this reason, we strongly encourage you to migrate your applications to DotSpatial.

As DotSpatial doesn’t currently support the compact framework (and there is quite a bit of uncertainty about its future) we have included a refactored but still working version in the folder `DotSpatial\DotSpatial.Positioning\DotSpatial.Positioning.Compact` this folder will be retained for the purpose of providing compact framework developers a place to keep this platforms version alive.


----

## ![Geoframework Logo](Docs/logo.png) Geographic Framework for .NET

#### Related Projects:
- [GeoFramework 1.0](http://geoframework1.codeplex.com)
- [GPS.NET 3.0](https://github.com/BigstickCarpet/GPS.Net)

This project was formerly a commercial library maintained by the company "GeoFrameworks" for two components it sold (GPS.NET and GIS.NET) from 2004 to 2009.  In 2009, Jon Person decided to release the source code for this library in order to assist the open source community.  This project contains classes designed to simplify the task of writing Location-Based Services as well as mapping applications.  The most frequently used classes in this project are **Angle**, **Latitude**, **Longitude**, and **Position**.  These classes represent coordinates on Earth's surface and provide functions for calculating distance and bearing to other points on Earth.  Other classes such as **Speed** and **Distance** encapsulate measurements as well as conversions to other unit types.  

The entire library is globalized, supporting multiple numeric formats and cultures, and includes design-time type converters to add support for Windows Forms designers.  Most classes also support conversion of values to and from string values.  For example, the **Position** class can output values in a specific format and parse formatted values back into an object.  This project has no dependency on specific UI platforms, allowing it to be used in both GDI+ and WPF applications.

This is the second major release of the framework.  ([GeoFramework 1.0](http://geoframework1.codeplex.com) is on CodePlex.)  This version eliminates GDI+ dependencies such as **System.Drawing** to enable the framework to be compatible with newer Windows Presentation Foundation applications.  Unlike version 1.0, this version does not support Visual Studio 2003, but (as a result) supports newer .NET features such as generics.  Some types such as **Position** were changed from classes to structures to improve performance.  Lastly, a lot of the code was cleaned up and analyzed with the help of [FxCop](http://www.microsoft.com/downloads/details.aspx?FamilyID=9aeaa970-f281-4fb0-aba1-d59d7ed09772&displaylang=en).

## Included Features

* Supports any culture in any numeric format.
* Supports formatting of objects to string values and vice-versa.
* Supports geodetic equations such as calculating distance, bearing, travel time, and minimum travel speed.
* Supports distance and speed measurements and conversions in Imperical and Metric systems.
* Supports PROJ4-compliant datum and ellipsoids, referenced by EPSG number.
* Supports XML serialization (and deserialization) to Geographic Markup Language (GML).
* Thorough use in a commercial, production environment.
* Full IntelliSense documentation including remarks and examples.

## Supported Frameworks

This library supports all .NET Frameworks from version 2.0 through 4.0 as well as .NET Compact Framework versions 2.0, and 3.5.   The compiler directive **PocketPC** is used to target the compact framework.  
