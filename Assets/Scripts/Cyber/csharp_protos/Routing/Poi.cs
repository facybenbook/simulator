// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/routing/proto/poi.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Routing {

  /// <summary>Holder for reflection information generated from modules/routing/proto/poi.proto</summary>
  public static partial class PoiReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/routing/proto/poi.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PoiReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9tb2R1bGVzL3JvdXRpbmcvcHJvdG8vcG9pLnByb3RvEg5hcG9sbG8ucm91",
            "dGluZxojbW9kdWxlcy9yb3V0aW5nL3Byb3RvL3JvdXRpbmcucHJvdG8iYgoI",
            "TGFuZG1hcmsSDAoEbmFtZRgBIAEoCRIuCgh3YXlwb2ludBgCIAMoCzIcLmFw",
            "b2xsby5yb3V0aW5nLkxhbmVXYXlwb2ludBIYChBwYXJraW5nX3NwYWNlX2lk",
            "GAMgASgJIjEKA1BPSRIqCghsYW5kbWFyaxgBIAMoCzIYLmFwb2xsby5yb3V0",
            "aW5nLkxhbmRtYXJrYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Routing.RoutingReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Routing.Landmark), global::Apollo.Routing.Landmark.Parser, new[]{ "Name", "Waypoint", "ParkingSpaceId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Routing.POI), global::Apollo.Routing.POI.Parser, new[]{ "Landmark" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Landmark : pb::IMessage<Landmark> {
    private static readonly pb::MessageParser<Landmark> _parser = new pb::MessageParser<Landmark>(() => new Landmark());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Landmark> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Routing.PoiReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Landmark() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Landmark(Landmark other) : this() {
      name_ = other.name_;
      waypoint_ = other.waypoint_.Clone();
      parkingSpaceId_ = other.parkingSpaceId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Landmark Clone() {
      return new Landmark(this);
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

    /// <summary>Field number for the "waypoint" field.</summary>
    public const int WaypointFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Apollo.Routing.LaneWaypoint> _repeated_waypoint_codec
        = pb::FieldCodec.ForMessage(18, global::Apollo.Routing.LaneWaypoint.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Routing.LaneWaypoint> waypoint_ = new pbc::RepeatedField<global::Apollo.Routing.LaneWaypoint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Routing.LaneWaypoint> Waypoint {
      get { return waypoint_; }
    }

    /// <summary>Field number for the "parking_space_id" field.</summary>
    public const int ParkingSpaceIdFieldNumber = 3;
    private string parkingSpaceId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ParkingSpaceId {
      get { return parkingSpaceId_; }
      set {
        parkingSpaceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Landmark);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Landmark other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!waypoint_.Equals(other.waypoint_)) return false;
      if (ParkingSpaceId != other.ParkingSpaceId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= waypoint_.GetHashCode();
      if (ParkingSpaceId.Length != 0) hash ^= ParkingSpaceId.GetHashCode();
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
      waypoint_.WriteTo(output, _repeated_waypoint_codec);
      if (ParkingSpaceId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ParkingSpaceId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += waypoint_.CalculateSize(_repeated_waypoint_codec);
      if (ParkingSpaceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ParkingSpaceId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Landmark other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      waypoint_.Add(other.waypoint_);
      if (other.ParkingSpaceId.Length != 0) {
        ParkingSpaceId = other.ParkingSpaceId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            waypoint_.AddEntriesFrom(input, _repeated_waypoint_codec);
            break;
          }
          case 26: {
            ParkingSpaceId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class POI : pb::IMessage<POI> {
    private static readonly pb::MessageParser<POI> _parser = new pb::MessageParser<POI>(() => new POI());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<POI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Routing.PoiReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public POI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public POI(POI other) : this() {
      landmark_ = other.landmark_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public POI Clone() {
      return new POI(this);
    }

    /// <summary>Field number for the "landmark" field.</summary>
    public const int LandmarkFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Apollo.Routing.Landmark> _repeated_landmark_codec
        = pb::FieldCodec.ForMessage(10, global::Apollo.Routing.Landmark.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Routing.Landmark> landmark_ = new pbc::RepeatedField<global::Apollo.Routing.Landmark>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Routing.Landmark> Landmark {
      get { return landmark_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as POI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(POI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!landmark_.Equals(other.landmark_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= landmark_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      landmark_.WriteTo(output, _repeated_landmark_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += landmark_.CalculateSize(_repeated_landmark_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(POI other) {
      if (other == null) {
        return;
      }
      landmark_.Add(other.landmark_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            landmark_.AddEntriesFrom(input, _repeated_landmark_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
