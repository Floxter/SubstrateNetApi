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


namespace SubstrateNetApi.Model.PalletVesting
{
    
    
    /// <summary>
    /// >> Path: pallet_vesting.vesting_info.VestingInfo
    /// </summary>
    public sealed class VestingInfo : BaseType
    {
        
        private SubstrateNetApi.Model.Types.Primitive.U128 _locked;
        
        private SubstrateNetApi.Model.Types.Primitive.U128 _perBlock;
        
        private SubstrateNetApi.Model.Types.Primitive.U32 _startingBlock;
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Locked
        {
            get
            {
                return this._locked;
            }
            set
            {
                this._locked = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U128 PerBlock
        {
            get
            {
                return this._perBlock;
            }
            set
            {
                this._perBlock = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U32 StartingBlock
        {
            get
            {
                return this._startingBlock;
            }
            set
            {
                this._startingBlock = value;
            }
        }
        
        public override string TypeName()
        {
            return "VestingInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Locked.Encode());
            result.AddRange(PerBlock.Encode());
            result.AddRange(StartingBlock.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Locked = new SubstrateNetApi.Model.Types.Primitive.U128();
            Locked.Decode(byteArray, ref p);
            PerBlock = new SubstrateNetApi.Model.Types.Primitive.U128();
            PerBlock.Decode(byteArray, ref p);
            StartingBlock = new SubstrateNetApi.Model.Types.Primitive.U32();
            StartingBlock.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}