// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Light.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Unity.Reflect.Model {

  /// <summary>Holder for reflection information generated from Light.proto</summary>
  public static partial class LightReflection {

    #region Descriptor
    /// <summary>File descriptor for Light.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LightReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtMaWdodC5wcm90bxIHUmVmbGVjdBoLQ29sb3IucHJvdG8aEU1hdGhlbWF0",
            "aWNzLnByb3RvIooFCglTeW5jTGlnaHQSDAoEbmFtZRgBIAEoCRIpCgl0cmFu",
            "c2Zvcm0YAiABKAsyFi5SZWZsZWN0LlN5bmNUcmFuc2Zvcm0SJQoEdHlwZRgD",
            "IAEoDjIXLlJlZmxlY3QuU3luY0xpZ2h0LlR5cGUSIQoFY29sb3IYBCABKAsy",
            "Ei5SZWZsZWN0LlN5bmNDb2xvchITCgt0ZW1wZXJhdHVyZRgFIAEoAhIRCglp",
            "bnRlbnNpdHkYBiABKAISNwoNaW50ZW5zaXR5VW5pdBgHIAEoDjIgLlJlZmxl",
            "Y3QuU3luY0xpZ2h0LkludGVuc2l0eVVuaXQSDQoFcmFuZ2UYCCABKAISJwoF",
            "c2hhcGUYCSABKA4yGC5SZWZsZWN0LlN5bmNMaWdodC5TaGFwZRIVCg1zaGFw",
            "ZURpYW1ldGVyGAogASgCEhIKCnNoYXBlV2lkdGgYCyABKAISEwoLc2hhcGVM",
            "ZW5ndGgYDCABKAISFAoMc2hhcGVWaXNpYmxlGA0gASgIEhEKCXNwb3RBbmds",
            "ZRgOIAEoAhIRCgliZWFtQW5nbGUYDyABKAISEgoKaWVzUHJvZmlsZRgQIAEo",
            "CSIxCgRUeXBlEggKBFNQT1QQABIPCgtESVJFQ1RJT05BTBABEg4KClBPSU5U",
            "X1RZUEUQAiJlCg1JbnRlbnNpdHlVbml0EgsKB0NBTkRFTEEQABIJCgVMVU1F",
            "ThABEgcKA0xVWBACEggKBFdBVFQQAxIcChhDQU5ERUxBX1BFUl9TUVVBUkVf",
            "TUVURVIQBBILCgdVTktOT1dOEAUiNwoFU2hhcGUSCQoFUE9JTlQQABIICgRM",
            "SU5FEAESDQoJUkVDVEFOR0xFEAISCgoGQ0lSQ0xFEANCFqoCE1VuaXR5LlJl",
            "ZmxlY3QuTW9kZWxiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Unity.Reflect.Model.ColorReflection.Descriptor, global::Unity.Reflect.Model.MathematicsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Unity.Reflect.Model.SyncLight), global::Unity.Reflect.Model.SyncLight.Parser, new[]{ "Name", "Transform", "Type", "Color", "Temperature", "Intensity", "IntensityUnit", "Range", "Shape", "ShapeDiameter", "ShapeWidth", "ShapeLength", "ShapeVisible", "SpotAngle", "BeamAngle", "IesProfile" }, null, new[]{ typeof(global::Unity.Reflect.Model.SyncLight.Types.Type), typeof(global::Unity.Reflect.Model.SyncLight.Types.IntensityUnit), typeof(global::Unity.Reflect.Model.SyncLight.Types.Shape) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SyncLight : pb::IMessage<SyncLight> {
    private static readonly pb::MessageParser<SyncLight> _parser = new pb::MessageParser<SyncLight>(() => new SyncLight());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SyncLight> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Unity.Reflect.Model.LightReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SyncLight() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SyncLight(SyncLight other) : this() {
      name_ = other.name_;
      transform_ = other.transform_ != null ? other.transform_.Clone() : null;
      type_ = other.type_;
      color_ = other.color_ != null ? other.color_.Clone() : null;
      temperature_ = other.temperature_;
      intensity_ = other.intensity_;
      intensityUnit_ = other.intensityUnit_;
      range_ = other.range_;
      shape_ = other.shape_;
      shapeDiameter_ = other.shapeDiameter_;
      shapeWidth_ = other.shapeWidth_;
      shapeLength_ = other.shapeLength_;
      shapeVisible_ = other.shapeVisible_;
      spotAngle_ = other.spotAngle_;
      beamAngle_ = other.beamAngle_;
      iesProfile_ = other.iesProfile_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SyncLight Clone() {
      return new SyncLight(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "transform" field.</summary>
    public const int TransformFieldNumber = 2;
    private global::Unity.Reflect.Model.SyncTransform transform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Unity.Reflect.Model.SyncTransform Transform {
      get { return transform_; }
      set {
        transform_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Unity.Reflect.Model.SyncLight.Types.Type type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Unity.Reflect.Model.SyncLight.Types.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 4;
    private global::Unity.Reflect.Model.SyncColor color_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Unity.Reflect.Model.SyncColor Color {
      get { return color_; }
      set {
        color_ = value;
      }
    }

    /// <summary>Field number for the "temperature" field.</summary>
    public const int TemperatureFieldNumber = 5;
    private float temperature_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Temperature {
      get { return temperature_; }
      set {
        temperature_ = value;
      }
    }

    /// <summary>Field number for the "intensity" field.</summary>
    public const int IntensityFieldNumber = 6;
    private float intensity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Intensity {
      get { return intensity_; }
      set {
        intensity_ = value;
      }
    }

    /// <summary>Field number for the "intensityUnit" field.</summary>
    public const int IntensityUnitFieldNumber = 7;
    private global::Unity.Reflect.Model.SyncLight.Types.IntensityUnit intensityUnit_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Unity.Reflect.Model.SyncLight.Types.IntensityUnit IntensityUnit {
      get { return intensityUnit_; }
      set {
        intensityUnit_ = value;
      }
    }

    /// <summary>Field number for the "range" field.</summary>
    public const int RangeFieldNumber = 8;
    private float range_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Range {
      get { return range_; }
      set {
        range_ = value;
      }
    }

    /// <summary>Field number for the "shape" field.</summary>
    public const int ShapeFieldNumber = 9;
    private global::Unity.Reflect.Model.SyncLight.Types.Shape shape_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Unity.Reflect.Model.SyncLight.Types.Shape Shape {
      get { return shape_; }
      set {
        shape_ = value;
      }
    }

    /// <summary>Field number for the "shapeDiameter" field.</summary>
    public const int ShapeDiameterFieldNumber = 10;
    private float shapeDiameter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ShapeDiameter {
      get { return shapeDiameter_; }
      set {
        shapeDiameter_ = value;
      }
    }

    /// <summary>Field number for the "shapeWidth" field.</summary>
    public const int ShapeWidthFieldNumber = 11;
    private float shapeWidth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ShapeWidth {
      get { return shapeWidth_; }
      set {
        shapeWidth_ = value;
      }
    }

    /// <summary>Field number for the "shapeLength" field.</summary>
    public const int ShapeLengthFieldNumber = 12;
    private float shapeLength_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ShapeLength {
      get { return shapeLength_; }
      set {
        shapeLength_ = value;
      }
    }

    /// <summary>Field number for the "shapeVisible" field.</summary>
    public const int ShapeVisibleFieldNumber = 13;
    private bool shapeVisible_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ShapeVisible {
      get { return shapeVisible_; }
      set {
        shapeVisible_ = value;
      }
    }

    /// <summary>Field number for the "spotAngle" field.</summary>
    public const int SpotAngleFieldNumber = 14;
    private float spotAngle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float SpotAngle {
      get { return spotAngle_; }
      set {
        spotAngle_ = value;
      }
    }

    /// <summary>Field number for the "beamAngle" field.</summary>
    public const int BeamAngleFieldNumber = 15;
    private float beamAngle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float BeamAngle {
      get { return beamAngle_; }
      set {
        beamAngle_ = value;
      }
    }

    /// <summary>Field number for the "iesProfile" field.</summary>
    public const int IesProfileFieldNumber = 16;
    private string iesProfile_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IesProfile {
      get { return iesProfile_; }
      set {
        iesProfile_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SyncLight);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SyncLight other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Transform, other.Transform)) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(Color, other.Color)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Temperature, other.Temperature)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Intensity, other.Intensity)) return false;
      if (IntensityUnit != other.IntensityUnit) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Range, other.Range)) return false;
      if (Shape != other.Shape) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ShapeDiameter, other.ShapeDiameter)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ShapeWidth, other.ShapeWidth)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ShapeLength, other.ShapeLength)) return false;
      if (ShapeVisible != other.ShapeVisible) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SpotAngle, other.SpotAngle)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BeamAngle, other.BeamAngle)) return false;
      if (IesProfile != other.IesProfile) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (transform_ != null) hash ^= Transform.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (color_ != null) hash ^= Color.GetHashCode();
      if (Temperature != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Temperature);
      if (Intensity != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Intensity);
      if (IntensityUnit != 0) hash ^= IntensityUnit.GetHashCode();
      if (Range != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Range);
      if (Shape != 0) hash ^= Shape.GetHashCode();
      if (ShapeDiameter != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ShapeDiameter);
      if (ShapeWidth != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ShapeWidth);
      if (ShapeLength != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ShapeLength);
      if (ShapeVisible != false) hash ^= ShapeVisible.GetHashCode();
      if (SpotAngle != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SpotAngle);
      if (BeamAngle != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BeamAngle);
      if (IesProfile.Length != 0) hash ^= IesProfile.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (transform_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Transform);
      }
      if (Type != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (color_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Color);
      }
      if (Temperature != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Temperature);
      }
      if (Intensity != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(Intensity);
      }
      if (IntensityUnit != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) IntensityUnit);
      }
      if (Range != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(Range);
      }
      if (Shape != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Shape);
      }
      if (ShapeDiameter != 0F) {
        output.WriteRawTag(85);
        output.WriteFloat(ShapeDiameter);
      }
      if (ShapeWidth != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(ShapeWidth);
      }
      if (ShapeLength != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(ShapeLength);
      }
      if (ShapeVisible != false) {
        output.WriteRawTag(104);
        output.WriteBool(ShapeVisible);
      }
      if (SpotAngle != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(SpotAngle);
      }
      if (BeamAngle != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(BeamAngle);
      }
      if (IesProfile.Length != 0) {
        output.WriteRawTag(130, 1);
        output.WriteString(IesProfile);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (transform_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transform);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (color_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Color);
      }
      if (Temperature != 0F) {
        size += 1 + 4;
      }
      if (Intensity != 0F) {
        size += 1 + 4;
      }
      if (IntensityUnit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) IntensityUnit);
      }
      if (Range != 0F) {
        size += 1 + 4;
      }
      if (Shape != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Shape);
      }
      if (ShapeDiameter != 0F) {
        size += 1 + 4;
      }
      if (ShapeWidth != 0F) {
        size += 1 + 4;
      }
      if (ShapeLength != 0F) {
        size += 1 + 4;
      }
      if (ShapeVisible != false) {
        size += 1 + 1;
      }
      if (SpotAngle != 0F) {
        size += 1 + 4;
      }
      if (BeamAngle != 0F) {
        size += 1 + 4;
      }
      if (IesProfile.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(IesProfile);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SyncLight other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.transform_ != null) {
        if (transform_ == null) {
          Transform = new global::Unity.Reflect.Model.SyncTransform();
        }
        Transform.MergeFrom(other.Transform);
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.color_ != null) {
        if (color_ == null) {
          Color = new global::Unity.Reflect.Model.SyncColor();
        }
        Color.MergeFrom(other.Color);
      }
      if (other.Temperature != 0F) {
        Temperature = other.Temperature;
      }
      if (other.Intensity != 0F) {
        Intensity = other.Intensity;
      }
      if (other.IntensityUnit != 0) {
        IntensityUnit = other.IntensityUnit;
      }
      if (other.Range != 0F) {
        Range = other.Range;
      }
      if (other.Shape != 0) {
        Shape = other.Shape;
      }
      if (other.ShapeDiameter != 0F) {
        ShapeDiameter = other.ShapeDiameter;
      }
      if (other.ShapeWidth != 0F) {
        ShapeWidth = other.ShapeWidth;
      }
      if (other.ShapeLength != 0F) {
        ShapeLength = other.ShapeLength;
      }
      if (other.ShapeVisible != false) {
        ShapeVisible = other.ShapeVisible;
      }
      if (other.SpotAngle != 0F) {
        SpotAngle = other.SpotAngle;
      }
      if (other.BeamAngle != 0F) {
        BeamAngle = other.BeamAngle;
      }
      if (other.IesProfile.Length != 0) {
        IesProfile = other.IesProfile;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (transform_ == null) {
              Transform = new global::Unity.Reflect.Model.SyncTransform();
            }
            input.ReadMessage(Transform);
            break;
          }
          case 24: {
            Type = (global::Unity.Reflect.Model.SyncLight.Types.Type) input.ReadEnum();
            break;
          }
          case 34: {
            if (color_ == null) {
              Color = new global::Unity.Reflect.Model.SyncColor();
            }
            input.ReadMessage(Color);
            break;
          }
          case 45: {
            Temperature = input.ReadFloat();
            break;
          }
          case 53: {
            Intensity = input.ReadFloat();
            break;
          }
          case 56: {
            IntensityUnit = (global::Unity.Reflect.Model.SyncLight.Types.IntensityUnit) input.ReadEnum();
            break;
          }
          case 69: {
            Range = input.ReadFloat();
            break;
          }
          case 72: {
            Shape = (global::Unity.Reflect.Model.SyncLight.Types.Shape) input.ReadEnum();
            break;
          }
          case 85: {
            ShapeDiameter = input.ReadFloat();
            break;
          }
          case 93: {
            ShapeWidth = input.ReadFloat();
            break;
          }
          case 101: {
            ShapeLength = input.ReadFloat();
            break;
          }
          case 104: {
            ShapeVisible = input.ReadBool();
            break;
          }
          case 117: {
            SpotAngle = input.ReadFloat();
            break;
          }
          case 125: {
            BeamAngle = input.ReadFloat();
            break;
          }
          case 130: {
            IesProfile = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SyncLight message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Type {
        [pbr::OriginalName("SPOT")] Spot = 0,
        [pbr::OriginalName("DIRECTIONAL")] Directional = 1,
        [pbr::OriginalName("POINT_TYPE")] PointType = 2,
      }

      public enum IntensityUnit {
        [pbr::OriginalName("CANDELA")] Candela = 0,
        [pbr::OriginalName("LUMEN")] Lumen = 1,
        [pbr::OriginalName("LUX")] Lux = 2,
        [pbr::OriginalName("WATT")] Watt = 3,
        [pbr::OriginalName("CANDELA_PER_SQUARE_METER")] CandelaPerSquareMeter = 4,
        [pbr::OriginalName("UNKNOWN")] Unknown = 5,
      }

      public enum Shape {
        [pbr::OriginalName("POINT")] Point = 0,
        [pbr::OriginalName("LINE")] Line = 1,
        [pbr::OriginalName("RECTANGLE")] Rectangle = 2,
        [pbr::OriginalName("CIRCLE")] Circle = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code