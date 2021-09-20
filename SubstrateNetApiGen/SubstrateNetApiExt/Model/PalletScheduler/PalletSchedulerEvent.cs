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


namespace SubstrateNetApi.Model.PalletScheduler
{
    
    
    /// <summary>
    /// >> Path: pallet_scheduler.pallet.Event
    /// Events type.
    /// </summary>
    public sealed class PalletSchedulerEvent
    {
        
        /// <summary>
        /// >> Event: Scheduled
        /// Scheduled some task. \[when, index\]
        /// </summary>
        public sealed class Scheduled : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
        
        /// <summary>
        /// >> Event: Canceled
        /// Canceled some task. \[when, index\]
        /// </summary>
        public sealed class Canceled : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
        
        /// <summary>
        /// >> Event: Dispatched
        /// Dispatched some task. \[task, id, result\]
        /// </summary>
        public sealed class Dispatched : BaseTuple<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>, BaseOpt<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>>, BaseTuple<BaseTuple,  SubstrateNetApi.Model.SpRuntime.EnumDispatchError>>
        {
        }
    }
}