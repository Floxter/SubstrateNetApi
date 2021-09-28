//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Extrinsics;
using SubstrateNetApi.Model.FrameSupport;
using SubstrateNetApi.Model.Meta;
using SubstrateNetApi.Model.PalletTreasury;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.SpRuntime;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletTreasury
{
    
    
    public sealed class TreasuryStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public TreasuryStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        public static string ProposalCountParams()
        {
            var parameters = RequestGenerator.GetStorage("Treasury", "ProposalCount", Storage.Type.Plain);
            return parameters;
        }
        
        /// <summary>
        /// >> ProposalCount
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> ProposalCount(CancellationToken token)
        {
            string parameters = TreasuryStorage.ProposalCountParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        public static string ProposalsParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            var keyParams = new IType[] { key };
            var parameters = RequestGenerator.GetStorage("Treasury", "Proposals", Storage.Type.Map, new[] {Storage.Hasher.Twox64Concat}, keyParams);
            return parameters;
        }
        
        /// <summary>
        /// >> Proposals
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletTreasury.Proposal> Proposals(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = TreasuryStorage.ProposalsParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletTreasury.Proposal>(parameters, token);
        }
        
        public static string ApprovalsParams()
        {
            var parameters = RequestGenerator.GetStorage("Treasury", "Approvals", Storage.Type.Plain);
            return parameters;
        }
        
        /// <summary>
        /// >> Approvals
        /// </summary>
        public async Task<SubstrateNetApi.Model.FrameSupport.BoundedVec> Approvals(CancellationToken token)
        {
            string parameters = TreasuryStorage.ApprovalsParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.FrameSupport.BoundedVec>(parameters, token);
        }
    }
    
    public sealed class TreasuryCalls
    {
        
        /// <summary>
        /// >> propose_spend
        /// </summary>
        public static Method ProposeSpend(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> value, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress beneficiary)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(beneficiary.Encode());
            return new Method(17, "Treasury", 0, "propose_spend", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reject_proposal
        /// </summary>
        public static Method RejectProposal(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> proposal_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_id.Encode());
            return new Method(17, "Treasury", 1, "reject_proposal", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> approve_proposal
        /// </summary>
        public static Method ApproveProposal(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> proposal_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_id.Encode());
            return new Method(17, "Treasury", 2, "approve_proposal", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> Proposed
    /// </summary>
    public sealed class EventProposed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> Spending
    /// </summary>
    public sealed class EventSpending : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    /// <summary>
    /// >> Awarded
    /// </summary>
    public sealed class EventAwarded : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U128, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Rejected
    /// </summary>
    public sealed class EventRejected : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    /// <summary>
    /// >> Burnt
    /// </summary>
    public sealed class EventBurnt : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    /// <summary>
    /// >> Rollover
    /// </summary>
    public sealed class EventRollover : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    /// <summary>
    /// >> Deposit
    /// </summary>
    public sealed class EventDeposit : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    public enum TreasuryErrors
    {
        
        /// <summary>
        /// >> InsufficientProposersBalance
        /// </summary>
        InsufficientProposersBalance,
        
        /// <summary>
        /// >> InvalidIndex
        /// </summary>
        InvalidIndex,
        
        /// <summary>
        /// >> TooManyApprovals
        /// </summary>
        TooManyApprovals,
    }
}