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
    /// >> Path: pallet_society.Error
    /// Errors for this module.
    /// </summary>
    public enum PalletSociety
    {
        
        /// <summary>
        /// >> Event: BadPosition
        /// An incorrect position was provided.
        /// </summary>
        BadPosition,
        
        /// <summary>
        /// >> Event: NotMember
        /// User is not a member.
        /// </summary>
        NotMember,
        
        /// <summary>
        /// >> Event: AlreadyMember
        /// User is already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> Event: Suspended
        /// User is suspended.
        /// </summary>
        Suspended,
        
        /// <summary>
        /// >> Event: NotSuspended
        /// User is not suspended.
        /// </summary>
        NotSuspended,
        
        /// <summary>
        /// >> Event: NoPayout
        /// Nothing to payout.
        /// </summary>
        NoPayout,
        
        /// <summary>
        /// >> Event: AlreadyFounded
        /// Society already founded.
        /// </summary>
        AlreadyFounded,
        
        /// <summary>
        /// >> Event: InsufficientPot
        /// Not enough in pot to accept candidate.
        /// </summary>
        InsufficientPot,
        
        /// <summary>
        /// >> Event: AlreadyVouching
        /// Member is already vouching or banned from vouching again.
        /// </summary>
        AlreadyVouching,
        
        /// <summary>
        /// >> Event: NotVouching
        /// Member is not vouching.
        /// </summary>
        NotVouching,
        
        /// <summary>
        /// >> Event: Head
        /// Cannot remove the head of the chain.
        /// </summary>
        Head,
        
        /// <summary>
        /// >> Event: Founder
        /// Cannot remove the founder.
        /// </summary>
        Founder,
        
        /// <summary>
        /// >> Event: AlreadyBid
        /// User has already made a bid.
        /// </summary>
        AlreadyBid,
        
        /// <summary>
        /// >> Event: AlreadyCandidate
        /// User is already a candidate.
        /// </summary>
        AlreadyCandidate,
        
        /// <summary>
        /// >> Event: NotCandidate
        /// User is not a candidate.
        /// </summary>
        NotCandidate,
        
        /// <summary>
        /// >> Event: MaxMembers
        /// Too many members in the society.
        /// </summary>
        MaxMembers,
        
        /// <summary>
        /// >> Event: NotFounder
        /// The caller is not the founder.
        /// </summary>
        NotFounder,
        
        /// <summary>
        /// >> Event: NotHead
        /// The caller is not the head.
        /// </summary>
        NotHead,
    }
}
