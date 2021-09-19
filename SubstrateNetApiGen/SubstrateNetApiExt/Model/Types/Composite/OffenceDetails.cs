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
    /// >> Path: sp_staking.offence.OffenceDetails
    /// </summary>
    public sealed class OffenceDetails : BaseType
    {
        
        private BaseTuple<AccountId32,Exposure> _offender;
        
        private BaseVec<AccountId32> _reporters;
        
        public BaseTuple<AccountId32,Exposure> Offender
        {
            get
            {
                return this._offender;
            }
            set
            {
                this._offender = value;
            }
        }
        
        public BaseVec<AccountId32> Reporters
        {
            get
            {
                return this._reporters;
            }
            set
            {
                this._reporters = value;
            }
        }
        
        public override string TypeName()
        {
            return "OffenceDetails";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Offender.Encode());
            result.AddRange(Reporters.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Offender = new BaseTuple<AccountId32,Exposure>();
            Offender.Decode(byteArray, ref p);
            Reporters = new BaseVec<AccountId32>();
            Reporters.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
