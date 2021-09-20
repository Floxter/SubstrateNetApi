//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> Path: pallet_staking.Nominations
    /// </summary>
    public sealed class Nominations : BaseType
    {
        
        private BaseVec<SubstrateNetApi.Model.SpCore.AccountId32> _targets;
        
        private SubstrateNetApi.Model.Types.Primitive.U32 _submittedIn;
        
        private SubstrateNetApi.Model.Types.Primitive.Bool _suppressed;
        
        public BaseVec<SubstrateNetApi.Model.SpCore.AccountId32> Targets
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
        
        public SubstrateNetApi.Model.Types.Primitive.U32 SubmittedIn
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
        
        public SubstrateNetApi.Model.Types.Primitive.Bool Suppressed
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
            Targets = new BaseVec<SubstrateNetApi.Model.SpCore.AccountId32>();
            Targets.Decode(byteArray, ref p);
            SubmittedIn = new SubstrateNetApi.Model.Types.Primitive.U32();
            SubmittedIn.Decode(byteArray, ref p);
            Suppressed = new SubstrateNetApi.Model.Types.Primitive.Bool();
            Suppressed.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}