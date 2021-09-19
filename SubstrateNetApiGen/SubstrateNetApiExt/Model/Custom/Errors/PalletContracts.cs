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


namespace SubstrateNetApi.Model.Custom.Errors
{
    
    
    /// <summary>
    /// >> Path: pallet_contracts.pallet.Error
    /// 
    ///			Custom [dispatch errors](https://substrate.dev/docs/en/knowledgebase/runtime/errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum PalletContracts
    {
        
        /// <summary>
        /// >> Event: InvalidScheduleVersion
        /// A new schedule must have a greater version than the current one.
        /// </summary>
        InvalidScheduleVersion,
        
        /// <summary>
        /// >> Event: OutOfGas
        /// The executed contract exhausted its gas limit.
        /// </summary>
        OutOfGas,
        
        /// <summary>
        /// >> Event: OutputBufferTooSmall
        /// The output buffer supplied to a contract API call was too small.
        /// </summary>
        OutputBufferTooSmall,
        
        /// <summary>
        /// >> Event: BelowSubsistenceThreshold
        /// Performing the requested transfer would have brought the contract below
        /// the subsistence threshold. No transfer is allowed to do this. Use `seal_terminate`
        /// to recover a deposit.
        /// </summary>
        BelowSubsistenceThreshold,
        
        /// <summary>
        /// >> Event: NewContractNotFunded
        /// The newly created contract is below the subsistence threshold after executing
        /// its contructor. No contracts are allowed to exist below that threshold.
        /// </summary>
        NewContractNotFunded,
        
        /// <summary>
        /// >> Event: TransferFailed
        /// Performing the requested transfer failed for a reason originating in the
        /// chosen currency implementation of the runtime. Most probably the balance is
        /// too low or locks are placed on it.
        /// </summary>
        TransferFailed,
        
        /// <summary>
        /// >> Event: MaxCallDepthReached
        /// Performing a call was denied because the calling depth reached the limit
        /// of what is specified in the schedule.
        /// </summary>
        MaxCallDepthReached,
        
        /// <summary>
        /// >> Event: ContractNotFound
        /// No contract was found at the specified address.
        /// </summary>
        ContractNotFound,
        
        /// <summary>
        /// >> Event: CodeTooLarge
        /// The code supplied to `instantiate_with_code` exceeds the limit specified in the
        /// current schedule.
        /// </summary>
        CodeTooLarge,
        
        /// <summary>
        /// >> Event: CodeNotFound
        /// No code could be found at the supplied code hash.
        /// </summary>
        CodeNotFound,
        
        /// <summary>
        /// >> Event: OutOfBounds
        /// A buffer outside of sandbox memory was passed to a contract API function.
        /// </summary>
        OutOfBounds,
        
        /// <summary>
        /// >> Event: DecodingFailed
        /// Input passed to a contract API function failed to decode as expected type.
        /// </summary>
        DecodingFailed,
        
        /// <summary>
        /// >> Event: ContractTrapped
        /// Contract trapped during execution.
        /// </summary>
        ContractTrapped,
        
        /// <summary>
        /// >> Event: ValueTooLarge
        /// The size defined in `T::MaxValueSize` was exceeded.
        /// </summary>
        ValueTooLarge,
        
        /// <summary>
        /// >> Event: TerminatedWhileReentrant
        /// Termination of a contract is not allowed while the contract is already
        /// on the call stack. Can be triggered by `seal_terminate`.
        /// </summary>
        TerminatedWhileReentrant,
        
        /// <summary>
        /// >> Event: InputForwarded
        /// `seal_call` forwarded this contracts input. It therefore is no longer available.
        /// </summary>
        InputForwarded,
        
        /// <summary>
        /// >> Event: RandomSubjectTooLong
        /// The subject passed to `seal_random` exceeds the limit.
        /// </summary>
        RandomSubjectTooLong,
        
        /// <summary>
        /// >> Event: TooManyTopics
        /// The amount of topics passed to `seal_deposit_events` exceeds the limit.
        /// </summary>
        TooManyTopics,
        
        /// <summary>
        /// >> Event: DuplicateTopics
        /// The topics passed to `seal_deposit_events` contains at least one duplicate.
        /// </summary>
        DuplicateTopics,
        
        /// <summary>
        /// >> Event: NoChainExtension
        /// The chain does not provide a chain extension. Calling the chain extension results
        /// in this error. Note that this usually  shouldn't happen as deploying such contracts
        /// is rejected.
        /// </summary>
        NoChainExtension,
        
        /// <summary>
        /// >> Event: DeletionQueueFull
        /// Removal of a contract failed because the deletion queue is full.
        /// 
        /// This can happen when calling `seal_terminate`.
        /// The queue is filled by deleting contracts and emptied by a fixed amount each block.
        /// Trying again during another block is the only way to resolve this issue.
        /// </summary>
        DeletionQueueFull,
        
        /// <summary>
        /// >> Event: StorageExhausted
        /// A storage modification exhausted the 32bit type that holds the storage size.
        /// 
        /// This can either happen when the accumulated storage in bytes is too large or
        /// when number of storage items is too large.
        /// </summary>
        StorageExhausted,
        
        /// <summary>
        /// >> Event: DuplicateContract
        /// A contract with the same AccountId already exists.
        /// </summary>
        DuplicateContract,
        
        /// <summary>
        /// >> Event: TerminatedInConstructor
        /// A contract self destructed in its constructor.
        /// 
        /// This can be triggered by a call to `seal_terminate`.
        /// </summary>
        TerminatedInConstructor,
        
        /// <summary>
        /// >> Event: DebugMessageInvalidUTF8
        /// The debug message specified to `seal_debug_message` does contain invalid UTF-8.
        /// </summary>
        DebugMessageInvalidUTF8,
        
        /// <summary>
        /// >> Event: ReentranceDenied
        /// A call tried to invoke a contract that is flagged as non-reentrant.
        /// </summary>
        ReentranceDenied,
    }
}
