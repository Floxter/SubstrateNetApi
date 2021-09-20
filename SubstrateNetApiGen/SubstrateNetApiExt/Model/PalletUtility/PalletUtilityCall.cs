//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Calls;
using SubstrateNetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletUtility
{
    
    
    /// <summary>
    /// >> Path: pallet_utility.pallet.Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletUtilityCall
    {
        
        /// <summary>
        /// >> Extrinsic: batch
        /// Send a batch of dispatch calls.
        /// 
        /// May be called from any origin.
        /// 
        /// - `calls`: The calls to be dispatched from the same origin. The number of call must not
        ///   exceed the constant: `batched_calls_limit` (available in constant metadata).
        /// 
        /// If origin is root then call are dispatch without checking origin filter. (This includes
        /// bypassing `frame_system::Config::BaseCallFilter`).
        /// 
        /// # <weight>
        /// - Complexity: O(C) where C is the number of calls to be batched.
        /// # </weight>
        /// 
        /// This will return `Ok` in all circumstances. To determine the success of the batch, an
        /// event is deposited. If a call failed and the batch was interrupted, then the
        /// `BatchInterrupted` event is deposited, along with the number of successful calls made
        /// and the error of the failed call. If all were successful, then the `BatchCompleted`
        /// event is deposited.
        /// </summary>
        public GenericExtrinsicCall Batch(BaseVec<SubstrateNetApi.Model.NodeRuntime.EnumNodeCall> calls)
        {
            return new GenericExtrinsicCall("Utility", "batch", calls);
        }
        
        /// <summary>
        /// >> Extrinsic: as_derivative
        /// Send a call through an indexed pseudonym of the sender.
        /// 
        /// Filter from origin are passed along. The call will be dispatched with an origin which
        /// use the same filter as the origin of this call.
        /// 
        /// NOTE: If you need to ensure that any account-based filtering is not honored (i.e.
        /// because you expect `proxy` to have been used prior in the call stack and you do not want
        /// the call restrictions to apply to any sub-accounts), then use `as_multi_threshold_1`
        /// in the Multisig pallet instead.
        /// 
        /// NOTE: Prior to version *12, this was called `as_limited_sub`.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// </summary>
        public GenericExtrinsicCall AsDerivative(SubstrateNetApi.Model.Types.Primitive.U16 index, SubstrateNetApi.Model.NodeRuntime.EnumNodeCall call)
        {
            return new GenericExtrinsicCall("Utility", "as_derivative", index, call);
        }
        
        /// <summary>
        /// >> Extrinsic: batch_all
        /// Send a batch of dispatch calls and atomically execute them.
        /// The whole transaction will rollback and fail if any of the calls failed.
        /// 
        /// May be called from any origin.
        /// 
        /// - `calls`: The calls to be dispatched from the same origin. The number of call must not
        ///   exceed the constant: `batched_calls_limit` (available in constant metadata).
        /// 
        /// If origin is root then call are dispatch without checking origin filter. (This includes
        /// bypassing `frame_system::Config::BaseCallFilter`).
        /// 
        /// # <weight>
        /// - Complexity: O(C) where C is the number of calls to be batched.
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall BatchAll(BaseVec<SubstrateNetApi.Model.NodeRuntime.EnumNodeCall> calls)
        {
            return new GenericExtrinsicCall("Utility", "batch_all", calls);
        }
    }
}