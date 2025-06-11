using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestGDTF
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(GDTF));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (GDTF)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "ActivationGroup")]
    public class ActivationGroup
    {

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "ActivationGroups")]
    public class ActivationGroups
    {

        [XmlElement(ElementName = "ActivationGroup")]
        public List<ActivationGroup> ActivationGroup { get; set; }
    }

    [XmlRoot(ElementName = "Feature")]
    public class Feature
    {

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "FeatureGroup")]
    public class FeatureGroup
    {

        [XmlElement(ElementName = "Feature")]
        public List<Feature> Feature { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Pretty")]
        public string Pretty { get; set; }
    }

    [XmlRoot(ElementName = "FeatureGroups")]
    public class FeatureGroups
    {

        [XmlElement(ElementName = "FeatureGroup")]
        public List<FeatureGroup> FeatureGroup { get; set; }
    }

    [XmlRoot(ElementName = "Attribute")]
    public class Attribute
    {

        [XmlAttribute(AttributeName = "ActivationGroup")]
        public string ActivationGroup { get; set; }

        [XmlAttribute(AttributeName = "Feature")]
        public string Feature { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "PhysicalUnit")]
        public string PhysicalUnit { get; set; }

        [XmlAttribute(AttributeName = "Pretty")]
        public string Pretty { get; set; }

        [XmlElement(ElementName = "SubPhysicalUnit")]
        public List<SubPhysicalUnit> SubPhysicalUnit { get; set; }

        [XmlAttribute(AttributeName = "MainAttribute")]
        public string MainAttribute { get; set; }

        [XmlAttribute(AttributeName = "Color")]
        public string Color { get; set; }
    }

    [XmlRoot(ElementName = "SubPhysicalUnit")]
    public class SubPhysicalUnit
    {

        [XmlAttribute(AttributeName = "PhysicalFrom")]
        public double PhysicalFrom { get; set; }

        [XmlAttribute(AttributeName = "PhysicalTo")]
        public double PhysicalTo { get; set; }

        [XmlAttribute(AttributeName = "PhysicalUnit")]
        public string PhysicalUnit { get; set; }

        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "Attributes")]
    public class Attributes
    {

        [XmlElement(ElementName = "Attribute")]
        public List<Attribute> Attribute { get; set; }
    }

    [XmlRoot(ElementName = "AttributeDefinitions")]
    public class AttributeDefinitions
    {

        [XmlElement(ElementName = "ActivationGroups")]
        public ActivationGroups ActivationGroups { get; set; }

        [XmlElement(ElementName = "FeatureGroups")]
        public FeatureGroups FeatureGroups { get; set; }

        [XmlElement(ElementName = "Attributes")]
        public Attributes Attributes { get; set; }
    }

    [XmlRoot(ElementName = "Slot")]
    public class Slot
    {

        [XmlAttribute(AttributeName = "Color")]
        public string Color { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "Wheel")]
    public class Wheel
    {

        [XmlElement(ElementName = "Slot")]
        public List<Slot> Slot { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "Wheels")]
    public class Wheels
    {

        [XmlElement(ElementName = "Wheel")]
        public Wheel Wheel { get; set; }
    }

    [XmlRoot(ElementName = "ColorSpace")]
    public class ColorSpace
    {

        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }

        [XmlElement(ElementName = "Name")]
        public object Name { get; set; }
    }

    [XmlRoot(ElementName = "MeasurementPoint")]
    public class MeasurementPoint
    {

        [XmlAttribute(AttributeName = "Energy")]
        public double Energy { get; set; }

        [XmlAttribute(AttributeName = "WaveLength")]
        public double WaveLength { get; set; }
    }

    [XmlRoot(ElementName = "Measurement")]
    public class Measurement
    {

        [XmlElement(ElementName = "MeasurementPoint")]
        public List<MeasurementPoint> MeasurementPoint { get; set; }

        [XmlAttribute(AttributeName = "InterpolationTo")]
        public string InterpolationTo { get; set; }

        [XmlAttribute(AttributeName = "LuminousIntensity")]
        public double LuminousIntensity { get; set; }

        [XmlAttribute(AttributeName = "Physical")]
        public double Physical { get; set; }
    }

    [XmlRoot(ElementName = "Emitter")]
    public class Emitter
    {

        [XmlElement(ElementName = "Measurement")]
        public Measurement Measurement { get; set; }

        [XmlAttribute(AttributeName = "Color")]
        public string Color { get; set; }

        [XmlElement(ElementName = "DiodePart")]
        public object DiodePart { get; set; }

        [XmlAttribute(AttributeName = "DominantWaveLength")]
        public double DominantWaveLength { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "Emitters")]
    public class Emitters
    {

        [XmlElement(ElementName = "Emitter")]
        public List<Emitter> Emitter { get; set; }
    }

    [XmlRoot(ElementName = "Connector")]
    public class Connector
    {

        [XmlAttribute(AttributeName = "DMXBreak")]
        public int DMXBreak { get; set; }

        [XmlAttribute(AttributeName = "Gender")]
        public int Gender { get; set; }

        [XmlAttribute(AttributeName = "Length")]
        public double Length { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "Connectors")]
    public class Connectors
    {

        [XmlElement(ElementName = "Connector")]
        public List<Connector> Connector { get; set; }
    }

    [XmlRoot(ElementName = "OperatingTemperature")]
    public class OperatingTemperature
    {

        [XmlAttribute(AttributeName = "High")]
        public double High { get; set; }

        [XmlAttribute(AttributeName = "Low")]
        public double Low { get; set; }
    }

    [XmlRoot(ElementName = "Weight")]
    public class Weight
    {

        [XmlAttribute(AttributeName = "Value")]
        public double Value { get; set; }
    }

    [XmlRoot(ElementName = "LegHeight")]
    public class LegHeight
    {

        [XmlAttribute(AttributeName = "Value")]
        public double Value { get; set; }
    }

    [XmlRoot(ElementName = "Properties")]
    public class Properties
    {

        [XmlElement(ElementName = "OperatingTemperature")]
        public OperatingTemperature OperatingTemperature { get; set; }

        [XmlElement(ElementName = "Weight")]
        public Weight Weight { get; set; }

        [XmlElement(ElementName = "LegHeight")]
        public LegHeight LegHeight { get; set; }
    }

    [XmlRoot(ElementName = "PhysicalDescriptions")]
    public class PhysicalDescriptions
    {

        [XmlElement(ElementName = "ColorSpace")]
        public ColorSpace ColorSpace { get; set; }

        [XmlElement(ElementName = "AdditionalColorSpaces")]
        public object AdditionalColorSpaces { get; set; }

        [XmlElement(ElementName = "Gamuts")]
        public object Gamuts { get; set; }

        [XmlElement(ElementName = "Filters")]
        public object Filters { get; set; }

        [XmlElement(ElementName = "Emitters")]
        public Emitters Emitters { get; set; }

        [XmlElement(ElementName = "DMXProfiles")]
        public object DMXProfiles { get; set; }

        [XmlElement(ElementName = "CRIs")]
        public object CRIs { get; set; }

        [XmlElement(ElementName = "Connectors")]
        public Connectors Connectors { get; set; }

        [XmlElement(ElementName = "Properties")]
        public Properties Properties { get; set; }
    }

    [XmlRoot(ElementName = "Model")]
    public class Model
    {

        [XmlAttribute(AttributeName = "File")]
        public string File { get; set; }

        [XmlAttribute(AttributeName = "Height")]
        public double Height { get; set; }

        [XmlAttribute(AttributeName = "Length")]
        public double Length { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "PrimitiveType")]
        public string PrimitiveType { get; set; }

        [XmlAttribute(AttributeName = "SVGFrontOffsetX")]
        public double SVGFrontOffsetX { get; set; }

        [XmlAttribute(AttributeName = "SVGFrontOffsetY")]
        public double SVGFrontOffsetY { get; set; }

        [XmlAttribute(AttributeName = "SVGOffsetX")]
        public double SVGOffsetX { get; set; }

        [XmlAttribute(AttributeName = "SVGOffsetY")]
        public double SVGOffsetY { get; set; }

        [XmlAttribute(AttributeName = "SVGSideOffsetX")]
        public double SVGSideOffsetX { get; set; }

        [XmlAttribute(AttributeName = "SVGSideOffsetY")]
        public double SVGSideOffsetY { get; set; }

        [XmlAttribute(AttributeName = "Width")]
        public double Width { get; set; }
    }

    [XmlRoot(ElementName = "Models")]
    public class Models
    {

        [XmlElement(ElementName = "Model")]
        public List<Model> Model { get; set; }
    }

    [XmlRoot(ElementName = "Beam")]
    public class Beam
    {

        [XmlAttribute(AttributeName = "BeamAngle")]
        public double BeamAngle { get; set; }

        [XmlAttribute(AttributeName = "BeamRadius")]
        public double BeamRadius { get; set; }

        [XmlAttribute(AttributeName = "BeamType")]
        public string BeamType { get; set; }

        [XmlAttribute(AttributeName = "ColorRenderingIndex")]
        public int ColorRenderingIndex { get; set; }

        [XmlAttribute(AttributeName = "ColorTemperature")]
        public double ColorTemperature { get; set; }

        [XmlAttribute(AttributeName = "FieldAngle")]
        public double FieldAngle { get; set; }

        [XmlAttribute(AttributeName = "LampType")]
        public string LampType { get; set; }

        [XmlAttribute(AttributeName = "LuminousFlux")]
        public double LuminousFlux { get; set; }

        [XmlAttribute(AttributeName = "Model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Position")]
        public string Position { get; set; }

        [XmlAttribute(AttributeName = "PowerConsumption")]
        public double PowerConsumption { get; set; }

        [XmlAttribute(AttributeName = "RectangleRatio")]
        public double RectangleRatio { get; set; }

        [XmlAttribute(AttributeName = "ThrowRatio")]
        public double ThrowRatio { get; set; }
    }

    [XmlRoot(ElementName = "Geometry")]
    public class Geometry
    {

        [XmlElement(ElementName = "Beam")]
        public List<Beam> Beam { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Position")]
        public string Position { get; set; }

        [XmlElement(ElementName = "Geometry")]
        public List<Geometry> GeometryChild { get; set; }

        [XmlAttribute(AttributeName = "Model")]
        public string Model { get; set; }

        [XmlElement(ElementName = "Axis")]
        public Axis Axis { get; set; }
    }

    [XmlRoot(ElementName = "Axis")]
    public class Axis
    {

        [XmlElement(ElementName = "Geometry")]
        public Geometry Geometry { get; set; }

        [XmlAttribute(AttributeName = "Model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Position")]
        public string Position { get; set; }

        [XmlElement(ElementName = "Axis")]
        public Axis AxisChild { get; set; }
    }

    [XmlRoot(ElementName = "Geometries")]
    public class Geometries
    {

        [XmlElement(ElementName = "Geometry")]
        public Geometry Geometry { get; set; }
    }

    [XmlRoot(ElementName = "ChannelSet")]
    public class ChannelSet
    {

        [XmlAttribute(AttributeName = "DMXFrom")]
        public string DMXFrom { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "WheelSlotIndex")]
        public int WheelSlotIndex { get; set; }

        [XmlAttribute(AttributeName = "PhysicalFrom")]
        public double PhysicalFrom { get; set; }

        [XmlAttribute(AttributeName = "PhysicalTo")]
        public double PhysicalTo { get; set; }
    }

    [XmlRoot(ElementName = "ChannelFunction")]
    public class ChannelFunction
    {

        [XmlElement(ElementName = "ChannelSet")]
        public List<ChannelSet> ChannelSet { get; set; }

        [XmlAttribute(AttributeName = "Attribute")]
        public string Attribute { get; set; }

        [XmlElement(ElementName = "CustomName")]
        public object CustomName { get; set; }

        [XmlElement(ElementName = "DMXFrom")]
        public string DMXFrom { get; set; }

        [XmlElement(ElementName = "Default")]
        public DateTime Default { get; set; }

        [XmlAttribute(AttributeName = "Emitter")]
        public string Emitter { get; set; }

        [XmlAttribute(AttributeName = "Max")]
        public double Max { get; set; }

        [XmlAttribute(AttributeName = "Min")]
        public double Min { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "OriginalAttribute")]
        public object OriginalAttribute { get; set; }

        [XmlAttribute(AttributeName = "PhysicalFrom")]
        public double PhysicalFrom { get; set; }

        [XmlAttribute(AttributeName = "PhysicalTo")]
        public double PhysicalTo { get; set; }

        [XmlAttribute(AttributeName = "RealAcceleration")]
        public double RealAcceleration { get; set; }

        [XmlAttribute(AttributeName = "RealFade")]
        public double RealFade { get; set; }

        [XmlAttribute(AttributeName = "Wheel")]
        public string Wheel { get; set; }
    }

    [XmlRoot(ElementName = "LogicalChannel")]
    public class LogicalChannel
    {

        [XmlElement(ElementName = "ChannelFunction")]
        public List<ChannelFunction> ChannelFunction { get; set; }

        [XmlAttribute(AttributeName = "Attribute")]
        public string Attribute { get; set; }

        [XmlAttribute(AttributeName = "DMXChangeTimeLimit")]
        public double DMXChangeTimeLimit { get; set; }

        [XmlAttribute(AttributeName = "Master")]
        public string Master { get; set; }

        [XmlAttribute(AttributeName = "MibFade")]
        public double MibFade { get; set; }

        [XmlAttribute(AttributeName = "Snap")]
        public string Snap { get; set; }
    }

    [XmlRoot(ElementName = "DMXChannel")]
    public class DMXChannel
    {

        [XmlElement(ElementName = "LogicalChannel")]
        public LogicalChannel LogicalChannel { get; set; }

        [XmlAttribute(AttributeName = "DMXBreak")]
        public int DMXBreak { get; set; }

        [XmlAttribute(AttributeName = "Geometry")]
        public string Geometry { get; set; }

        [XmlElement(ElementName = "Highlight")]
        public DateTime Highlight { get; set; }

        [XmlAttribute(AttributeName = "InitialFunction")]
        public string InitialFunction { get; set; }

        [XmlAttribute(AttributeName = "Offset")]
        public string Offset { get; set; }
    }

    [XmlRoot(ElementName = "DMXChannels")]
    public class DMXChannels
    {

        [XmlElement(ElementName = "DMXChannel")]
        public List<DMXChannel> DMXChannel { get; set; }
    }

    [XmlRoot(ElementName = "DMXMode")]
    public class DMXMode
    {

        [XmlElement(ElementName = "Relations")]
        public Relations Relations { get; set; }

        [XmlElement(ElementName = "FTMacros")]
        public object FTMacros { get; set; }

        [XmlElement(ElementName = "Description")]
        public object Description { get; set; }

        [XmlAttribute(AttributeName = "Geometry")]
        public string Geometry { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "DMXChannels")]
        public DMXChannels DMXChannels { get; set; }
    }

    [XmlRoot(ElementName = "Relation")]
    public class Relation
    {

        [XmlAttribute(AttributeName = "Follower")]
        public string Follower { get; set; }

        [XmlAttribute(AttributeName = "Master")]
        public string Master { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "Relations")]
    public class Relations
    {

        [XmlElement(ElementName = "Relation")]
        public List<Relation> Relation { get; set; }
    }

    [XmlRoot(ElementName = "DMXModes")]
    public class DMXModes
    {

        [XmlElement(ElementName = "DMXMode")]
        public List<DMXMode> DMXMode { get; set; }
    }

    [XmlRoot(ElementName = "Revision")]
    public class Revision
    {

        [XmlElement(ElementName = "Date")]
        public DateTime Date { get; set; }

        [XmlElement(ElementName = "ModifiedBy")]
        public object ModifiedBy { get; set; }

        [XmlAttribute(AttributeName = "Text")]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "UserID")]
        public int UserID { get; set; }
    }

    [XmlRoot(ElementName = "Revisions")]
    public class Revisions
    {

        [XmlElement(ElementName = "Revision")]
        public List<Revision> Revision { get; set; }
    }

    [XmlRoot(ElementName = "DMXPersonality")]
    public class DMXPersonality
    {

        [XmlAttribute(AttributeName = "DMXMode")]
        public string DMXMode { get; set; }

        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "SoftwareVersionID")]
    public class SoftwareVersionID
    {

        [XmlElement(ElementName = "DMXPersonality")]
        public List<DMXPersonality> DMXPersonality { get; set; }

        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "FTRDM")]
    public class FTRDM
    {

        [XmlElement(ElementName = "SoftwareVersionID")]
        public SoftwareVersionID SoftwareVersionID { get; set; }

        [XmlAttribute(AttributeName = "DeviceModelID")]
        public string DeviceModelID { get; set; }

        [XmlAttribute(AttributeName = "ManufacturerID")]
        public string ManufacturerID { get; set; }
    }

    [XmlRoot(ElementName = "Protocols")]
    public class Protocols
    {

        [XmlElement(ElementName = "FTRDM")]
        public FTRDM FTRDM { get; set; }
    }

    [XmlRoot(ElementName = "FixtureType")]
    public class FixtureType
    {

        [XmlElement(ElementName = "AttributeDefinitions")]
        public AttributeDefinitions AttributeDefinitions { get; set; }

        [XmlElement(ElementName = "Wheels")]
        public Wheels Wheels { get; set; }

        [XmlElement(ElementName = "PhysicalDescriptions")]
        public PhysicalDescriptions PhysicalDescriptions { get; set; }

        [XmlElement(ElementName = "Models")]
        public Models Models { get; set; }

        [XmlElement(ElementName = "Geometries")]
        public Geometries Geometries { get; set; }

        [XmlElement(ElementName = "DMXModes")]
        public DMXModes DMXModes { get; set; }

        [XmlElement(ElementName = "Revisions")]
        public Revisions Revisions { get; set; }

        [XmlElement(ElementName = "FTPresets")]
        public object FTPresets { get; set; }

        [XmlElement(ElementName = "Protocols")]
        public Protocols Protocols { get; set; }

        [XmlAttribute(AttributeName = "CanHaveChildren")]
        public string CanHaveChildren { get; set; }

        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }

        [XmlAttribute(AttributeName = "FixtureTypeID")]
        public string FixtureTypeID { get; set; }

        [XmlAttribute(AttributeName = "LongName")]
        public string LongName { get; set; }

        [XmlAttribute(AttributeName = "Manufacturer")]
        public string Manufacturer { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "RefFT")]
        public object RefFT { get; set; }

        [XmlAttribute(AttributeName = "ShortName")]
        public string ShortName { get; set; }

        [XmlAttribute(AttributeName = "Thumbnail")]
        public string Thumbnail { get; set; }

        [XmlAttribute(AttributeName = "ThumbnailOffsetX")]
        public int ThumbnailOffsetX { get; set; }

        [XmlAttribute(AttributeName = "ThumbnailOffsetY")]
        public int ThumbnailOffsetY { get; set; }
    }

    [XmlRoot(ElementName = "GDTF")]
    public class GDTF
    {

        [XmlElement(ElementName = "FixtureType")]
        public FixtureType FixtureType { get; set; }

        [XmlElement(ElementName = "DataVersion")]
        public DateTime DataVersion { get; set; }
    }


}
