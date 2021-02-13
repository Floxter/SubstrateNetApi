﻿using Newtonsoft.Json;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.TypeConverters;

namespace SubstrateNetApi.Model.Rpc
{
    public class Header
    {
        public Digest Digest { get; set; }

        [JsonConverter(typeof(HashTypeConverter))]
        public Hash ExtrinsicsRoot { get; set; }

        [JsonConverter(typeof(U32TypeConverter))]
        public uint Number { get; set; }

        [JsonConverter(typeof(HashTypeConverter))]
        public Hash ParentHash { get; set; }

        [JsonConverter(typeof(HashTypeConverter))]
        public Hash StateRoot { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
