// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/planning/proto/dp_st_speed_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Planning {

  /// <summary>Holder for reflection information generated from modules/planning/proto/dp_st_speed_config.proto</summary>
  public static partial class DpStSpeedConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/planning/proto/dp_st_speed_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DpStSpeedConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9tb2R1bGVzL3BsYW5uaW5nL3Byb3RvL2RwX3N0X3NwZWVkX2NvbmZpZy5w",
            "cm90bxIPYXBvbGxvLnBsYW5uaW5nGi9tb2R1bGVzL3BsYW5uaW5nL3Byb3Rv",
            "L3N0X2JvdW5kYXJ5X2NvbmZpZy5wcm90byKPBQoPRHBTdFNwZWVkQ29uZmln",
            "EhkKEXRvdGFsX3BhdGhfbGVuZ3RoGAEgASgBEhIKCnRvdGFsX3RpbWUYAiAB",
            "KAESGgoSbWF0cml4X2RpbWVuc2lvbl9zGAMgASgFEhoKEm1hdHJpeF9kaW1l",
            "bnNpb25fdBgEIAEoBRIUCgxzcGVlZF93ZWlnaHQYBSABKAESFAoMYWNjZWxf",
            "d2VpZ2h0GAYgASgBEhMKC2plcmtfd2VpZ2h0GAcgASgBEhcKD29ic3RhY2xl",
            "X3dlaWdodBgIIAEoARIYChByZWZlcmVuY2Vfd2VpZ2h0GAkgASgBEhYKDmdv",
            "X2Rvd25fYnVmZmVyGAogASgBEhQKDGdvX3VwX2J1ZmZlchgLIAEoARIdChVk",
            "ZWZhdWx0X29ic3RhY2xlX2Nvc3QYDCABKAESGgoSZGVmYXVsdF9zcGVlZF9j",
            "b3N0GA0gASgBEhwKFGV4Y2VlZF9zcGVlZF9wZW5hbHR5GA4gASgBEhkKEWxv",
            "d19zcGVlZF9wZW5hbHR5GA8gASgBEiQKHGtlZXBfY2xlYXJfbG93X3NwZWVk",
            "X3BlbmFsdHkYECABKAESFQoNYWNjZWxfcGVuYWx0eRgUIAEoARIVCg1kZWNl",
            "bF9wZW5hbHR5GBUgASgBEhsKE3Bvc2l0aXZlX2plcmtfY29lZmYYHiABKAES",
            "GwoTbmVnYXRpdmVfamVya19jb2VmZhgfIAEoARIYChBtYXhfYWNjZWxlcmF0",
            "aW9uGCggASgBEhgKEG1heF9kZWNlbGVyYXRpb24YKSABKAESPQoSc3RfYm91",
            "bmRhcnlfY29uZmlnGDIgASgLMiEuYXBvbGxvLnBsYW5uaW5nLlN0Qm91bmRh",
            "cnlDb25maWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Planning.StBoundaryConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Planning.DpStSpeedConfig), global::Apollo.Planning.DpStSpeedConfig.Parser, new[]{ "TotalPathLength", "TotalTime", "MatrixDimensionS", "MatrixDimensionT", "SpeedWeight", "AccelWeight", "JerkWeight", "ObstacleWeight", "ReferenceWeight", "GoDownBuffer", "GoUpBuffer", "DefaultObstacleCost", "DefaultSpeedCost", "ExceedSpeedPenalty", "LowSpeedPenalty", "KeepClearLowSpeedPenalty", "AccelPenalty", "DecelPenalty", "PositiveJerkCoeff", "NegativeJerkCoeff", "MaxAcceleration", "MaxDeceleration", "StBoundaryConfig" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DpStSpeedConfig : pb::IMessage<DpStSpeedConfig> {
    private static readonly pb::MessageParser<DpStSpeedConfig> _parser = new pb::MessageParser<DpStSpeedConfig>(() => new DpStSpeedConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DpStSpeedConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Planning.DpStSpeedConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DpStSpeedConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DpStSpeedConfig(DpStSpeedConfig other) : this() {
      totalPathLength_ = other.totalPathLength_;
      totalTime_ = other.totalTime_;
      matrixDimensionS_ = other.matrixDimensionS_;
      matrixDimensionT_ = other.matrixDimensionT_;
      speedWeight_ = other.speedWeight_;
      accelWeight_ = other.accelWeight_;
      jerkWeight_ = other.jerkWeight_;
      obstacleWeight_ = other.obstacleWeight_;
      referenceWeight_ = other.referenceWeight_;
      goDownBuffer_ = other.goDownBuffer_;
      goUpBuffer_ = other.goUpBuffer_;
      defaultObstacleCost_ = other.defaultObstacleCost_;
      defaultSpeedCost_ = other.defaultSpeedCost_;
      exceedSpeedPenalty_ = other.exceedSpeedPenalty_;
      lowSpeedPenalty_ = other.lowSpeedPenalty_;
      keepClearLowSpeedPenalty_ = other.keepClearLowSpeedPenalty_;
      accelPenalty_ = other.accelPenalty_;
      decelPenalty_ = other.decelPenalty_;
      positiveJerkCoeff_ = other.positiveJerkCoeff_;
      negativeJerkCoeff_ = other.negativeJerkCoeff_;
      maxAcceleration_ = other.maxAcceleration_;
      maxDeceleration_ = other.maxDeceleration_;
      StBoundaryConfig = other.stBoundaryConfig_ != null ? other.StBoundaryConfig.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DpStSpeedConfig Clone() {
      return new DpStSpeedConfig(this);
    }

    /// <summary>Field number for the "total_path_length" field.</summary>
    public const int TotalPathLengthFieldNumber = 1;
    private double totalPathLength_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double TotalPathLength {
      get { return totalPathLength_; }
      set {
        totalPathLength_ = value;
      }
    }

    /// <summary>Field number for the "total_time" field.</summary>
    public const int TotalTimeFieldNumber = 2;
    private double totalTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double TotalTime {
      get { return totalTime_; }
      set {
        totalTime_ = value;
      }
    }

    /// <summary>Field number for the "matrix_dimension_s" field.</summary>
    public const int MatrixDimensionSFieldNumber = 3;
    private int matrixDimensionS_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MatrixDimensionS {
      get { return matrixDimensionS_; }
      set {
        matrixDimensionS_ = value;
      }
    }

    /// <summary>Field number for the "matrix_dimension_t" field.</summary>
    public const int MatrixDimensionTFieldNumber = 4;
    private int matrixDimensionT_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MatrixDimensionT {
      get { return matrixDimensionT_; }
      set {
        matrixDimensionT_ = value;
      }
    }

    /// <summary>Field number for the "speed_weight" field.</summary>
    public const int SpeedWeightFieldNumber = 5;
    private double speedWeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double SpeedWeight {
      get { return speedWeight_; }
      set {
        speedWeight_ = value;
      }
    }

    /// <summary>Field number for the "accel_weight" field.</summary>
    public const int AccelWeightFieldNumber = 6;
    private double accelWeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double AccelWeight {
      get { return accelWeight_; }
      set {
        accelWeight_ = value;
      }
    }

    /// <summary>Field number for the "jerk_weight" field.</summary>
    public const int JerkWeightFieldNumber = 7;
    private double jerkWeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double JerkWeight {
      get { return jerkWeight_; }
      set {
        jerkWeight_ = value;
      }
    }

    /// <summary>Field number for the "obstacle_weight" field.</summary>
    public const int ObstacleWeightFieldNumber = 8;
    private double obstacleWeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ObstacleWeight {
      get { return obstacleWeight_; }
      set {
        obstacleWeight_ = value;
      }
    }

    /// <summary>Field number for the "reference_weight" field.</summary>
    public const int ReferenceWeightFieldNumber = 9;
    private double referenceWeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ReferenceWeight {
      get { return referenceWeight_; }
      set {
        referenceWeight_ = value;
      }
    }

    /// <summary>Field number for the "go_down_buffer" field.</summary>
    public const int GoDownBufferFieldNumber = 10;
    private double goDownBuffer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double GoDownBuffer {
      get { return goDownBuffer_; }
      set {
        goDownBuffer_ = value;
      }
    }

    /// <summary>Field number for the "go_up_buffer" field.</summary>
    public const int GoUpBufferFieldNumber = 11;
    private double goUpBuffer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double GoUpBuffer {
      get { return goUpBuffer_; }
      set {
        goUpBuffer_ = value;
      }
    }

    /// <summary>Field number for the "default_obstacle_cost" field.</summary>
    public const int DefaultObstacleCostFieldNumber = 12;
    private double defaultObstacleCost_;
    /// <summary>
    /// obstacle cost config
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double DefaultObstacleCost {
      get { return defaultObstacleCost_; }
      set {
        defaultObstacleCost_ = value;
      }
    }

    /// <summary>Field number for the "default_speed_cost" field.</summary>
    public const int DefaultSpeedCostFieldNumber = 13;
    private double defaultSpeedCost_;
    /// <summary>
    /// speed cost config
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double DefaultSpeedCost {
      get { return defaultSpeedCost_; }
      set {
        defaultSpeedCost_ = value;
      }
    }

    /// <summary>Field number for the "exceed_speed_penalty" field.</summary>
    public const int ExceedSpeedPenaltyFieldNumber = 14;
    private double exceedSpeedPenalty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ExceedSpeedPenalty {
      get { return exceedSpeedPenalty_; }
      set {
        exceedSpeedPenalty_ = value;
      }
    }

    /// <summary>Field number for the "low_speed_penalty" field.</summary>
    public const int LowSpeedPenaltyFieldNumber = 15;
    private double lowSpeedPenalty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LowSpeedPenalty {
      get { return lowSpeedPenalty_; }
      set {
        lowSpeedPenalty_ = value;
      }
    }

    /// <summary>Field number for the "keep_clear_low_speed_penalty" field.</summary>
    public const int KeepClearLowSpeedPenaltyFieldNumber = 16;
    private double keepClearLowSpeedPenalty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double KeepClearLowSpeedPenalty {
      get { return keepClearLowSpeedPenalty_; }
      set {
        keepClearLowSpeedPenalty_ = value;
      }
    }

    /// <summary>Field number for the "accel_penalty" field.</summary>
    public const int AccelPenaltyFieldNumber = 20;
    private double accelPenalty_;
    /// <summary>
    /// accel cost config
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double AccelPenalty {
      get { return accelPenalty_; }
      set {
        accelPenalty_ = value;
      }
    }

    /// <summary>Field number for the "decel_penalty" field.</summary>
    public const int DecelPenaltyFieldNumber = 21;
    private double decelPenalty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double DecelPenalty {
      get { return decelPenalty_; }
      set {
        decelPenalty_ = value;
      }
    }

    /// <summary>Field number for the "positive_jerk_coeff" field.</summary>
    public const int PositiveJerkCoeffFieldNumber = 30;
    private double positiveJerkCoeff_;
    /// <summary>
    /// jerk cost config
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PositiveJerkCoeff {
      get { return positiveJerkCoeff_; }
      set {
        positiveJerkCoeff_ = value;
      }
    }

    /// <summary>Field number for the "negative_jerk_coeff" field.</summary>
    public const int NegativeJerkCoeffFieldNumber = 31;
    private double negativeJerkCoeff_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double NegativeJerkCoeff {
      get { return negativeJerkCoeff_; }
      set {
        negativeJerkCoeff_ = value;
      }
    }

    /// <summary>Field number for the "max_acceleration" field.</summary>
    public const int MaxAccelerationFieldNumber = 40;
    private double maxAcceleration_;
    /// <summary>
    /// other constraint
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MaxAcceleration {
      get { return maxAcceleration_; }
      set {
        maxAcceleration_ = value;
      }
    }

    /// <summary>Field number for the "max_deceleration" field.</summary>
    public const int MaxDecelerationFieldNumber = 41;
    private double maxDeceleration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MaxDeceleration {
      get { return maxDeceleration_; }
      set {
        maxDeceleration_ = value;
      }
    }

    /// <summary>Field number for the "st_boundary_config" field.</summary>
    public const int StBoundaryConfigFieldNumber = 50;
    private global::Apollo.Planning.StBoundaryConfig stBoundaryConfig_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Planning.StBoundaryConfig StBoundaryConfig {
      get { return stBoundaryConfig_; }
      set {
        stBoundaryConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DpStSpeedConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DpStSpeedConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TotalPathLength != other.TotalPathLength) return false;
      if (TotalTime != other.TotalTime) return false;
      if (MatrixDimensionS != other.MatrixDimensionS) return false;
      if (MatrixDimensionT != other.MatrixDimensionT) return false;
      if (SpeedWeight != other.SpeedWeight) return false;
      if (AccelWeight != other.AccelWeight) return false;
      if (JerkWeight != other.JerkWeight) return false;
      if (ObstacleWeight != other.ObstacleWeight) return false;
      if (ReferenceWeight != other.ReferenceWeight) return false;
      if (GoDownBuffer != other.GoDownBuffer) return false;
      if (GoUpBuffer != other.GoUpBuffer) return false;
      if (DefaultObstacleCost != other.DefaultObstacleCost) return false;
      if (DefaultSpeedCost != other.DefaultSpeedCost) return false;
      if (ExceedSpeedPenalty != other.ExceedSpeedPenalty) return false;
      if (LowSpeedPenalty != other.LowSpeedPenalty) return false;
      if (KeepClearLowSpeedPenalty != other.KeepClearLowSpeedPenalty) return false;
      if (AccelPenalty != other.AccelPenalty) return false;
      if (DecelPenalty != other.DecelPenalty) return false;
      if (PositiveJerkCoeff != other.PositiveJerkCoeff) return false;
      if (NegativeJerkCoeff != other.NegativeJerkCoeff) return false;
      if (MaxAcceleration != other.MaxAcceleration) return false;
      if (MaxDeceleration != other.MaxDeceleration) return false;
      if (!object.Equals(StBoundaryConfig, other.StBoundaryConfig)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TotalPathLength != 0D) hash ^= TotalPathLength.GetHashCode();
      if (TotalTime != 0D) hash ^= TotalTime.GetHashCode();
      if (MatrixDimensionS != 0) hash ^= MatrixDimensionS.GetHashCode();
      if (MatrixDimensionT != 0) hash ^= MatrixDimensionT.GetHashCode();
      if (SpeedWeight != 0D) hash ^= SpeedWeight.GetHashCode();
      if (AccelWeight != 0D) hash ^= AccelWeight.GetHashCode();
      if (JerkWeight != 0D) hash ^= JerkWeight.GetHashCode();
      if (ObstacleWeight != 0D) hash ^= ObstacleWeight.GetHashCode();
      if (ReferenceWeight != 0D) hash ^= ReferenceWeight.GetHashCode();
      if (GoDownBuffer != 0D) hash ^= GoDownBuffer.GetHashCode();
      if (GoUpBuffer != 0D) hash ^= GoUpBuffer.GetHashCode();
      if (DefaultObstacleCost != 0D) hash ^= DefaultObstacleCost.GetHashCode();
      if (DefaultSpeedCost != 0D) hash ^= DefaultSpeedCost.GetHashCode();
      if (ExceedSpeedPenalty != 0D) hash ^= ExceedSpeedPenalty.GetHashCode();
      if (LowSpeedPenalty != 0D) hash ^= LowSpeedPenalty.GetHashCode();
      if (KeepClearLowSpeedPenalty != 0D) hash ^= KeepClearLowSpeedPenalty.GetHashCode();
      if (AccelPenalty != 0D) hash ^= AccelPenalty.GetHashCode();
      if (DecelPenalty != 0D) hash ^= DecelPenalty.GetHashCode();
      if (PositiveJerkCoeff != 0D) hash ^= PositiveJerkCoeff.GetHashCode();
      if (NegativeJerkCoeff != 0D) hash ^= NegativeJerkCoeff.GetHashCode();
      if (MaxAcceleration != 0D) hash ^= MaxAcceleration.GetHashCode();
      if (MaxDeceleration != 0D) hash ^= MaxDeceleration.GetHashCode();
      if (stBoundaryConfig_ != null) hash ^= StBoundaryConfig.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (TotalPathLength != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(TotalPathLength);
      }
      if (TotalTime != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(TotalTime);
      }
      if (MatrixDimensionS != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MatrixDimensionS);
      }
      if (MatrixDimensionT != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(MatrixDimensionT);
      }
      if (SpeedWeight != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(SpeedWeight);
      }
      if (AccelWeight != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(AccelWeight);
      }
      if (JerkWeight != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(JerkWeight);
      }
      if (ObstacleWeight != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(ObstacleWeight);
      }
      if (ReferenceWeight != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(ReferenceWeight);
      }
      if (GoDownBuffer != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(GoDownBuffer);
      }
      if (GoUpBuffer != 0D) {
        output.WriteRawTag(89);
        output.WriteDouble(GoUpBuffer);
      }
      if (DefaultObstacleCost != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(DefaultObstacleCost);
      }
      if (DefaultSpeedCost != 0D) {
        output.WriteRawTag(105);
        output.WriteDouble(DefaultSpeedCost);
      }
      if (ExceedSpeedPenalty != 0D) {
        output.WriteRawTag(113);
        output.WriteDouble(ExceedSpeedPenalty);
      }
      if (LowSpeedPenalty != 0D) {
        output.WriteRawTag(121);
        output.WriteDouble(LowSpeedPenalty);
      }
      if (KeepClearLowSpeedPenalty != 0D) {
        output.WriteRawTag(129, 1);
        output.WriteDouble(KeepClearLowSpeedPenalty);
      }
      if (AccelPenalty != 0D) {
        output.WriteRawTag(161, 1);
        output.WriteDouble(AccelPenalty);
      }
      if (DecelPenalty != 0D) {
        output.WriteRawTag(169, 1);
        output.WriteDouble(DecelPenalty);
      }
      if (PositiveJerkCoeff != 0D) {
        output.WriteRawTag(241, 1);
        output.WriteDouble(PositiveJerkCoeff);
      }
      if (NegativeJerkCoeff != 0D) {
        output.WriteRawTag(249, 1);
        output.WriteDouble(NegativeJerkCoeff);
      }
      if (MaxAcceleration != 0D) {
        output.WriteRawTag(193, 2);
        output.WriteDouble(MaxAcceleration);
      }
      if (MaxDeceleration != 0D) {
        output.WriteRawTag(201, 2);
        output.WriteDouble(MaxDeceleration);
      }
      if (stBoundaryConfig_ != null) {
        output.WriteRawTag(146, 3);
        output.WriteMessage(StBoundaryConfig);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TotalPathLength != 0D) {
        size += 1 + 8;
      }
      if (TotalTime != 0D) {
        size += 1 + 8;
      }
      if (MatrixDimensionS != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MatrixDimensionS);
      }
      if (MatrixDimensionT != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MatrixDimensionT);
      }
      if (SpeedWeight != 0D) {
        size += 1 + 8;
      }
      if (AccelWeight != 0D) {
        size += 1 + 8;
      }
      if (JerkWeight != 0D) {
        size += 1 + 8;
      }
      if (ObstacleWeight != 0D) {
        size += 1 + 8;
      }
      if (ReferenceWeight != 0D) {
        size += 1 + 8;
      }
      if (GoDownBuffer != 0D) {
        size += 1 + 8;
      }
      if (GoUpBuffer != 0D) {
        size += 1 + 8;
      }
      if (DefaultObstacleCost != 0D) {
        size += 1 + 8;
      }
      if (DefaultSpeedCost != 0D) {
        size += 1 + 8;
      }
      if (ExceedSpeedPenalty != 0D) {
        size += 1 + 8;
      }
      if (LowSpeedPenalty != 0D) {
        size += 1 + 8;
      }
      if (KeepClearLowSpeedPenalty != 0D) {
        size += 2 + 8;
      }
      if (AccelPenalty != 0D) {
        size += 2 + 8;
      }
      if (DecelPenalty != 0D) {
        size += 2 + 8;
      }
      if (PositiveJerkCoeff != 0D) {
        size += 2 + 8;
      }
      if (NegativeJerkCoeff != 0D) {
        size += 2 + 8;
      }
      if (MaxAcceleration != 0D) {
        size += 2 + 8;
      }
      if (MaxDeceleration != 0D) {
        size += 2 + 8;
      }
      if (stBoundaryConfig_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(StBoundaryConfig);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DpStSpeedConfig other) {
      if (other == null) {
        return;
      }
      if (other.TotalPathLength != 0D) {
        TotalPathLength = other.TotalPathLength;
      }
      if (other.TotalTime != 0D) {
        TotalTime = other.TotalTime;
      }
      if (other.MatrixDimensionS != 0) {
        MatrixDimensionS = other.MatrixDimensionS;
      }
      if (other.MatrixDimensionT != 0) {
        MatrixDimensionT = other.MatrixDimensionT;
      }
      if (other.SpeedWeight != 0D) {
        SpeedWeight = other.SpeedWeight;
      }
      if (other.AccelWeight != 0D) {
        AccelWeight = other.AccelWeight;
      }
      if (other.JerkWeight != 0D) {
        JerkWeight = other.JerkWeight;
      }
      if (other.ObstacleWeight != 0D) {
        ObstacleWeight = other.ObstacleWeight;
      }
      if (other.ReferenceWeight != 0D) {
        ReferenceWeight = other.ReferenceWeight;
      }
      if (other.GoDownBuffer != 0D) {
        GoDownBuffer = other.GoDownBuffer;
      }
      if (other.GoUpBuffer != 0D) {
        GoUpBuffer = other.GoUpBuffer;
      }
      if (other.DefaultObstacleCost != 0D) {
        DefaultObstacleCost = other.DefaultObstacleCost;
      }
      if (other.DefaultSpeedCost != 0D) {
        DefaultSpeedCost = other.DefaultSpeedCost;
      }
      if (other.ExceedSpeedPenalty != 0D) {
        ExceedSpeedPenalty = other.ExceedSpeedPenalty;
      }
      if (other.LowSpeedPenalty != 0D) {
        LowSpeedPenalty = other.LowSpeedPenalty;
      }
      if (other.KeepClearLowSpeedPenalty != 0D) {
        KeepClearLowSpeedPenalty = other.KeepClearLowSpeedPenalty;
      }
      if (other.AccelPenalty != 0D) {
        AccelPenalty = other.AccelPenalty;
      }
      if (other.DecelPenalty != 0D) {
        DecelPenalty = other.DecelPenalty;
      }
      if (other.PositiveJerkCoeff != 0D) {
        PositiveJerkCoeff = other.PositiveJerkCoeff;
      }
      if (other.NegativeJerkCoeff != 0D) {
        NegativeJerkCoeff = other.NegativeJerkCoeff;
      }
      if (other.MaxAcceleration != 0D) {
        MaxAcceleration = other.MaxAcceleration;
      }
      if (other.MaxDeceleration != 0D) {
        MaxDeceleration = other.MaxDeceleration;
      }
      if (other.stBoundaryConfig_ != null) {
        if (stBoundaryConfig_ == null) {
          stBoundaryConfig_ = new global::Apollo.Planning.StBoundaryConfig();
        }
        StBoundaryConfig.MergeFrom(other.StBoundaryConfig);
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
          case 9: {
            TotalPathLength = input.ReadDouble();
            break;
          }
          case 17: {
            TotalTime = input.ReadDouble();
            break;
          }
          case 24: {
            MatrixDimensionS = input.ReadInt32();
            break;
          }
          case 32: {
            MatrixDimensionT = input.ReadInt32();
            break;
          }
          case 41: {
            SpeedWeight = input.ReadDouble();
            break;
          }
          case 49: {
            AccelWeight = input.ReadDouble();
            break;
          }
          case 57: {
            JerkWeight = input.ReadDouble();
            break;
          }
          case 65: {
            ObstacleWeight = input.ReadDouble();
            break;
          }
          case 73: {
            ReferenceWeight = input.ReadDouble();
            break;
          }
          case 81: {
            GoDownBuffer = input.ReadDouble();
            break;
          }
          case 89: {
            GoUpBuffer = input.ReadDouble();
            break;
          }
          case 97: {
            DefaultObstacleCost = input.ReadDouble();
            break;
          }
          case 105: {
            DefaultSpeedCost = input.ReadDouble();
            break;
          }
          case 113: {
            ExceedSpeedPenalty = input.ReadDouble();
            break;
          }
          case 121: {
            LowSpeedPenalty = input.ReadDouble();
            break;
          }
          case 129: {
            KeepClearLowSpeedPenalty = input.ReadDouble();
            break;
          }
          case 161: {
            AccelPenalty = input.ReadDouble();
            break;
          }
          case 169: {
            DecelPenalty = input.ReadDouble();
            break;
          }
          case 241: {
            PositiveJerkCoeff = input.ReadDouble();
            break;
          }
          case 249: {
            NegativeJerkCoeff = input.ReadDouble();
            break;
          }
          case 321: {
            MaxAcceleration = input.ReadDouble();
            break;
          }
          case 329: {
            MaxDeceleration = input.ReadDouble();
            break;
          }
          case 402: {
            if (stBoundaryConfig_ == null) {
              stBoundaryConfig_ = new global::Apollo.Planning.StBoundaryConfig();
            }
            input.ReadMessage(stBoundaryConfig_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
