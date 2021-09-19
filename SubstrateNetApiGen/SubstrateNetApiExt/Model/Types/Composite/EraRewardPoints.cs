//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Composite;
using SubstrateNetApi.Model.Types.Enum;
using SubstrateNetApi.Model.Types.Primitive;
using SubstrateNetApi.Model.Types.Sequence;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.Types.Composite
{
    
    
    /// <summary>
    /// >> Path: pallet_staking.EraRewardPoints
    /// </summary>
    public sealed class EraRewardPoints : BaseType
    {
        
        private U32 _total;
        
        private BTreeMap _individual;
        
        public U32 Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
        
        public BTreeMap Individual
        {
            get
            {
                return this._individual;
            }
            set
            {
                this._individual = value;
            }
        }
        
        public override string TypeName()
        {
            return "EraRewardPoints";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Total.Encode());
            result.AddRange(Individual.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Total = new U32();
            Total.Decode(byteArray, ref p);
            Individual = new BTreeMap();
            Individual.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
