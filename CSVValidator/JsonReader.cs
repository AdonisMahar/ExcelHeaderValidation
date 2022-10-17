﻿using System.Text.Json;
using System.Text.Json.Serialization;
namespace CSVValidator;

internal class JsonReader : IReader
{
    public ValidatorConfiguration Read(string json)
    {
        ValidatorConfiguration configuration = new ValidatorConfiguration();
      
        if (!string.IsNullOrEmpty(json))
        {
            configuration = Newtonsoft.Json.JsonConvert.DeserializeObject<ValidatorConfiguration>(json);
        }

        return configuration;
    }
}
