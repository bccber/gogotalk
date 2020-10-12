// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetFileList.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GoGoTalk.ProtoBuf {

  /// <summary>Holder for reflection information generated from GetFileList.proto</summary>
  public static partial class GetFileListReflection {

    #region Descriptor
    /// <summary>File descriptor for GetFileList.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetFileListReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHZXRGaWxlTGlzdC5wcm90bxIRR29Hb1RhbGsuUHJvdG9CdWYaDFJlc3Vs",
            "dC5wcm90byJTCgxEb3duRmlsZUluZm8SDgoGVXNlcklEGAEgASgJEhAKCEZp",
            "bGVTaXplGAIgASgDEhAKCEZpbGVOYW1lGAMgASgJEg8KB0Rvd25VcmwYBCAB",
            "KAkiNgoSR2V0RmlsZUxpc3RSZXF1ZXN0Eg4KBlVzZXJJRBgBIAEoCRIQCghV",
            "c2VyVHlwZRgCIAEoBSJzChNHZXRGaWxlTGlzdFJlc3BvbnNlEikKBlJlc3Vs",
            "dBgBIAEoCzIZLkdvR29UYWxrLlByb3RvQnVmLlJlc3VsdBIxCghGaWxlTGlz",
            "dBgCIAMoCzIfLkdvR29UYWxrLlByb3RvQnVmLkRvd25GaWxlSW5mb2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::GoGoTalk.ProtoBuf.ResultReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GoGoTalk.ProtoBuf.DownFileInfo), global::GoGoTalk.ProtoBuf.DownFileInfo.Parser, new[]{ "UserID", "FileSize", "FileName", "DownUrl" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GoGoTalk.ProtoBuf.GetFileListRequest), global::GoGoTalk.ProtoBuf.GetFileListRequest.Parser, new[]{ "UserID", "UserType" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GoGoTalk.ProtoBuf.GetFileListResponse), global::GoGoTalk.ProtoBuf.GetFileListResponse.Parser, new[]{ "Result", "FileList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DownFileInfo : pb::IMessage<DownFileInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DownFileInfo> _parser = new pb::MessageParser<DownFileInfo>(() => new DownFileInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DownFileInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GoGoTalk.ProtoBuf.GetFileListReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownFileInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownFileInfo(DownFileInfo other) : this() {
      userID_ = other.userID_;
      fileSize_ = other.fileSize_;
      fileName_ = other.fileName_;
      downUrl_ = other.downUrl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownFileInfo Clone() {
      return new DownFileInfo(this);
    }

    /// <summary>Field number for the "UserID" field.</summary>
    public const int UserIDFieldNumber = 1;
    private string userID_ = "";
    /// <summary>
    /// �ϴ���
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserID {
      get { return userID_; }
      set {
        userID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "FileSize" field.</summary>
    public const int FileSizeFieldNumber = 2;
    private long fileSize_;
    /// <summary>
    /// �ļ���С
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long FileSize {
      get { return fileSize_; }
      set {
        fileSize_ = value;
      }
    }

    /// <summary>Field number for the "FileName" field.</summary>
    public const int FileNameFieldNumber = 3;
    private string fileName_ = "";
    /// <summary>
    /// �ļ���
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FileName {
      get { return fileName_; }
      set {
        fileName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DownUrl" field.</summary>
    public const int DownUrlFieldNumber = 4;
    private string downUrl_ = "";
    /// <summary>
    /// ���ص�ַ
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DownUrl {
      get { return downUrl_; }
      set {
        downUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DownFileInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DownFileInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserID != other.UserID) return false;
      if (FileSize != other.FileSize) return false;
      if (FileName != other.FileName) return false;
      if (DownUrl != other.DownUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserID.Length != 0) hash ^= UserID.GetHashCode();
      if (FileSize != 0L) hash ^= FileSize.GetHashCode();
      if (FileName.Length != 0) hash ^= FileName.GetHashCode();
      if (DownUrl.Length != 0) hash ^= DownUrl.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (UserID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserID);
      }
      if (FileSize != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(FileSize);
      }
      if (FileName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FileName);
      }
      if (DownUrl.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DownUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (UserID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserID);
      }
      if (FileSize != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(FileSize);
      }
      if (FileName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FileName);
      }
      if (DownUrl.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DownUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserID);
      }
      if (FileSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FileSize);
      }
      if (FileName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileName);
      }
      if (DownUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DownUrl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DownFileInfo other) {
      if (other == null) {
        return;
      }
      if (other.UserID.Length != 0) {
        UserID = other.UserID;
      }
      if (other.FileSize != 0L) {
        FileSize = other.FileSize;
      }
      if (other.FileName.Length != 0) {
        FileName = other.FileName;
      }
      if (other.DownUrl.Length != 0) {
        DownUrl = other.DownUrl;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            UserID = input.ReadString();
            break;
          }
          case 16: {
            FileSize = input.ReadInt64();
            break;
          }
          case 26: {
            FileName = input.ReadString();
            break;
          }
          case 34: {
            DownUrl = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            UserID = input.ReadString();
            break;
          }
          case 16: {
            FileSize = input.ReadInt64();
            break;
          }
          case 26: {
            FileName = input.ReadString();
            break;
          }
          case 34: {
            DownUrl = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GetFileListRequest : pb::IMessage<GetFileListRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetFileListRequest> _parser = new pb::MessageParser<GetFileListRequest>(() => new GetFileListRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetFileListRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GoGoTalk.ProtoBuf.GetFileListReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFileListRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFileListRequest(GetFileListRequest other) : this() {
      userID_ = other.userID_;
      userType_ = other.userType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFileListRequest Clone() {
      return new GetFileListRequest(this);
    }

    /// <summary>Field number for the "UserID" field.</summary>
    public const int UserIDFieldNumber = 1;
    private string userID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserID {
      get { return userID_; }
      set {
        userID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UserType" field.</summary>
    public const int UserTypeFieldNumber = 2;
    private int userType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UserType {
      get { return userType_; }
      set {
        userType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetFileListRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetFileListRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserID != other.UserID) return false;
      if (UserType != other.UserType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserID.Length != 0) hash ^= UserID.GetHashCode();
      if (UserType != 0) hash ^= UserType.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (UserID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserID);
      }
      if (UserType != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(UserType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (UserID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserID);
      }
      if (UserType != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(UserType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserID);
      }
      if (UserType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetFileListRequest other) {
      if (other == null) {
        return;
      }
      if (other.UserID.Length != 0) {
        UserID = other.UserID;
      }
      if (other.UserType != 0) {
        UserType = other.UserType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            UserID = input.ReadString();
            break;
          }
          case 16: {
            UserType = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            UserID = input.ReadString();
            break;
          }
          case 16: {
            UserType = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GetFileListResponse : pb::IMessage<GetFileListResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetFileListResponse> _parser = new pb::MessageParser<GetFileListResponse>(() => new GetFileListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetFileListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GoGoTalk.ProtoBuf.GetFileListReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFileListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFileListResponse(GetFileListResponse other) : this() {
      result_ = other.result_ != null ? other.result_.Clone() : null;
      fileList_ = other.fileList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFileListResponse Clone() {
      return new GetFileListResponse(this);
    }

    /// <summary>Field number for the "Result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::GoGoTalk.ProtoBuf.Result result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GoGoTalk.ProtoBuf.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "FileList" field.</summary>
    public const int FileListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::GoGoTalk.ProtoBuf.DownFileInfo> _repeated_fileList_codec
        = pb::FieldCodec.ForMessage(18, global::GoGoTalk.ProtoBuf.DownFileInfo.Parser);
    private readonly pbc::RepeatedField<global::GoGoTalk.ProtoBuf.DownFileInfo> fileList_ = new pbc::RepeatedField<global::GoGoTalk.ProtoBuf.DownFileInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GoGoTalk.ProtoBuf.DownFileInfo> FileList {
      get { return fileList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetFileListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetFileListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Result, other.Result)) return false;
      if(!fileList_.Equals(other.fileList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (result_ != null) hash ^= Result.GetHashCode();
      hash ^= fileList_.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (result_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Result);
      }
      fileList_.WriteTo(output, _repeated_fileList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (result_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Result);
      }
      fileList_.WriteTo(ref output, _repeated_fileList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (result_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Result);
      }
      size += fileList_.CalculateSize(_repeated_fileList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetFileListResponse other) {
      if (other == null) {
        return;
      }
      if (other.result_ != null) {
        if (result_ == null) {
          Result = new global::GoGoTalk.ProtoBuf.Result();
        }
        Result.MergeFrom(other.Result);
      }
      fileList_.Add(other.fileList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (result_ == null) {
              Result = new global::GoGoTalk.ProtoBuf.Result();
            }
            input.ReadMessage(Result);
            break;
          }
          case 18: {
            fileList_.AddEntriesFrom(input, _repeated_fileList_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (result_ == null) {
              Result = new global::GoGoTalk.ProtoBuf.Result();
            }
            input.ReadMessage(Result);
            break;
          }
          case 18: {
            fileList_.AddEntriesFrom(ref input, _repeated_fileList_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code