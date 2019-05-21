﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;
using System.Data.Odbc;
using System.Collections.Generic;

namespace DPMetadata
{
  /*
  Purpose:

  TODO: Different classes (specifically named) to elegantly handle different connection types.
  TODO: Review if should support model mapping without connections specified?
  */
  public class Model : IDataModel
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

    public IDataModel NewOdbcConnection(string name, string description, string odbcConnString)
    {
      throw new System.NotImplementedException();
    }

    public OdbcConnection Connection { get; private set; }

    string IDataModel.Name => throw new System.NotImplementedException();

    string IDataModel.Description => throw new System.NotImplementedException();

    string IDataModel.SchemaLocation => throw new System.NotImplementedException();

    IDataStore IDataModel.PhysicalStore => throw new System.NotImplementedException();

    List<IDataObject> IDataModel.DataObjects => throw new System.NotImplementedException();

    public OdbcConnection Connect()
    {
      Connection = new OdbcConnection(OdbcConnString);
      return Connection;
    }

    IDataStore IDataModel.NewModel(string name, string description, string schemaLocation, string odbcConnString)
    {
      throw new System.NotImplementedException();
    }
  }
}
