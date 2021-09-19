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
    /// >> Path: finality_grandpa.Equivocation
    /// </summary>
    public sealed class Equivocation : BaseType
    {
        
        private U64 _roundNumber;
        
        private Public _identity;
        
        private BaseTuple<Precommit,Signature> _first;
        
        private BaseTuple<Precommit,Signature> _second;
        
        public U64 RoundNumber
        {
            get
            {
                return this._roundNumber;
            }
            set
            {
                this._roundNumber = value;
            }
        }
        
        public Public Identity
        {
            get
            {
                return this._identity;
            }
            set
            {
                this._identity = value;
            }
        }
        
        public BaseTuple<Precommit,Signature> First
        {
            get
            {
                return this._first;
            }
            set
            {
                this._first = value;
            }
        }
        
        public BaseTuple<Precommit,Signature> Second
        {
            get
            {
                return this._second;
            }
            set
            {
                this._second = value;
            }
        }
        
        public override string TypeName()
        {
            return "Equivocation";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(RoundNumber.Encode());
            result.AddRange(Identity.Encode());
            result.AddRange(First.Encode());
            result.AddRange(Second.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            RoundNumber = new U64();
            RoundNumber.Decode(byteArray, ref p);
            Identity = new Public();
            Identity.Decode(byteArray, ref p);
            First = new BaseTuple<Precommit,Signature>();
            First.Decode(byteArray, ref p);
            Second = new BaseTuple<Precommit,Signature>();
            Second.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
