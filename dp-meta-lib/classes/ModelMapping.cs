﻿using System.Collections.Generic;
using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMetadata
{
  /*
  Interface: ModelMapping
  Purpose:
  */
  public class ModelMapping : IModelMapping
  {
    [YamlMember]
    [JsonProperty]
    public string MappingTitle => throw new System.NotImplementedException();

    [YamlMember]
    [JsonProperty]
    public string MappingDescription => throw new System.NotImplementedException();

    [YamlMember]
    [JsonProperty]
    public IModelConnection SourceModel => throw new System.NotImplementedException();

    [YamlMember]
    [JsonProperty]
    public IModelConnection TargetModel => throw new System.NotImplementedException();

    [YamlMember]
    [JsonProperty]
    public List<IDataObjectMapping> MappedObjects => throw new System.NotImplementedException();

    [YamlMember]
    [JsonProperty]
    public List<IDataObjectMapping> IgnoredObjects { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public IModelMapping NewModelMapping(string name, string description, IModelConnection SourceModel, IModelConnection TargetModel)
    {
      throw new System.NotImplementedException();
    }
  }
}
