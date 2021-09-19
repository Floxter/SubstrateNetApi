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
    /// >> Path: pallet_staking.Nominations
    /// </summary>
    public sealed class Nominations : BaseType
    {
        
        private BaseVec<AccountId32> _targets;
        
        private U32 _submittedIn;
        
        private Bool _suppressed;
        
        public BaseVec<AccountId32> Targets
        {
            get
            {
                return this._targets;
            }
            set
            {
                this._targets = value;
            }
        }
        
        public U32 SubmittedIn
        {
            get
            {
                return this._submittedIn;
            }
            set
            {
                this._submittedIn = value;
            }
        }
        
        public Bool Suppressed
        {
            get
            {
                return this._suppressed;
            }
            set
            {
                this._suppressed = value;
            }
        }
        
        public override string TypeName()
        {
            return "Nominations";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Targets.Encode());
            result.AddRange(SubmittedIn.Encode());
            result.AddRange(Suppressed.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Targets = new BaseVec<AccountId32>();
            Targets.Decode(byteArray, ref p);
            SubmittedIn = new U32();
            SubmittedIn.Decode(byteArray, ref p);
            Suppressed = new Bool();
            Suppressed.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
