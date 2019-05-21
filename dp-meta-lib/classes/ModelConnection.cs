﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;
using System.Data.Odbc;

namespace DPMetadata
{
  /*
  Purpose:

  TODO: Different classes (specifically named) to elegantly handle different connection types.
  TODO: Review if should support model mapping without connections specified?
  */
  public class ModelConnection : IModelConnection
  {
    [YamlMember]
    [JsonProperty]
    public string Name { get; private set; }

    [YamlMember]
    [JsonProperty]
    public string Description { get; private set; }

    [YamlMember]
    [JsonProperty]
    public string OdbcConnString { get; private set; }

    public IModelConnection NewOdbcConnection(string name, string description, string odbcConnString)
    {
      throw new System.NotImplementedException();
    }

    public OdbcConnection Connection { get; private set; }
    public OdbcConnection Connect()
    {
      Connection = new OdbcConnection(OdbcConnString);
      return Connection;
    }
  }
}
