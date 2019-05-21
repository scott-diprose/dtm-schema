﻿using System.Collections.Generic;
using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMetaLib
{
  /*
  Interface: ModelMapping
  Purpose:
  */
  public class ModelMapping : IDataModelMapping
  {
    [YamlMember]
    [JsonProperty]
    public string MappingTitle => throw new System.NotImplementedException();

    [YamlMember]
    [JsonProperty]
    public string MappingDescription => throw new System.NotImplementedException();

    [YamlMember]
    [JsonProperty]
    public IDataStore SourceModel => throw new System.NotImplementedException();

    [YamlMember]
    [JsonProperty]
    public IDataStore TargetModel => throw new System.NotImplementedException();

    [YamlMember]
    [JsonProperty]
    public List<IDataObjectMapping> MappedObjects => throw new System.NotImplementedException();

    [YamlMember]
    [JsonProperty]
    public List<IDataObjectMapping> IgnoredObjects { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    string IDataModelMapping.MappingTitle => throw new System.NotImplementedException();

    string IDataModelMapping.MappingDescription => throw new System.NotImplementedException();

    IDataStore IDataModelMapping.SourceModel => throw new System.NotImplementedException();

    IDataStore IDataModelMapping.TargetModel => throw new System.NotImplementedException();

    List<IDataObjectMapping> IDataModelMapping.MappedObjects { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    List<IDataObjectMapping> IDataModelMapping.IgnoredObjects { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public IDataModelMapping NewModelMapping(string name, string description, IDataStore SourceModel, IDataStore TargetModel)
    {
      throw new System.NotImplementedException();
    }

    IDataModelMapping IDataModelMapping.NewModelMapping(string name, string description, IDataStore SourceModel, IDataStore TargetModel)
    {
      throw new System.NotImplementedException();
    }
  }
}
