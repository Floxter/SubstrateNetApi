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


namespace SubstrateNetApi.Model.PalletAssets
{
    
    
    /// <summary>
    /// >> Path: pallet_assets.pallet.Error
    /// 
    ///			Custom [dispatch errors](https://substrate.dev/docs/en/knowledgebase/runtime/errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum PalletAssetsError
    {
        
        /// <summary>
        /// >> Event: BalanceLow
        /// Account balance must be greater than or equal to the transfer amount.
        /// </summary>
        BalanceLow,
        
        /// <summary>
        /// >> Event: BalanceZero
        /// Balance should be non-zero.
        /// </summary>
        BalanceZero,
        
        /// <summary>
        /// >> Event: NoPermission
        /// The signing account has no permission to do the operation.
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> Event: Unknown
        /// The given asset ID is unknown.
        /// </summary>
        Unknown,
        
        /// <summary>
        /// >> Event: Frozen
        /// The origin account is frozen.
        /// </summary>
        Frozen,
        
        /// <summary>
        /// >> Event: InUse
        /// The asset ID is already taken.
        /// </summary>
        InUse,
        
        /// <summary>
        /// >> Event: BadWitness
        /// Invalid witness data given.
        /// </summary>
        BadWitness,
        
        /// <summary>
        /// >> Event: MinBalanceZero
        /// Minimum balance should be non-zero.
        /// </summary>
        MinBalanceZero,
        
        /// <summary>
        /// >> Event: NoProvider
        /// No provider reference exists to allow a non-zero balance of a non-self-sufficient
        /// asset.
        /// </summary>
        NoProvider,
        
        /// <summary>
        /// >> Event: BadMetadata
        /// Invalid metadata given.
        /// </summary>
        BadMetadata,
        
        /// <summary>
        /// >> Event: Unapproved
        /// No approval exists that would allow the transfer.
        /// </summary>
        Unapproved,
        
        /// <summary>
        /// >> Event: WouldDie
        /// The source account would not survive the transfer and it needs to stay alive.
        /// </summary>
        WouldDie,
    }
}