﻿using Newtonsoft.Json;

namespace Bolgrot.Core.Common.Entity.Data
{
    public class ServerGameTypes
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nameId")]
        public string NameId { get; set; }
    }
}