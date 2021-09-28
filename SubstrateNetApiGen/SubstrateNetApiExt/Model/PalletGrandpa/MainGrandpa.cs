//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Extrinsics;
using SubstrateNetApi.Model.Meta;
using SubstrateNetApi.Model.PalletGrandpa;
using SubstrateNetApi.Model.SpFinalityGrandpa;
using SubstrateNetApi.Model.SpSession;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletGrandpa
{
    
    
    public sealed class GrandpaStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public GrandpaStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        public static string StateParams()
        {
            var parameters = RequestGenerator.GetStorage("Grandpa", "State", Storage.Type.Plain);
            return parameters;
        }
        
        /// <summary>
        /// >> State
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletGrandpa.EnumStoredState> State(CancellationToken token)
        {
            string parameters = GrandpaStorage.StateParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletGrandpa.EnumStoredState>(parameters, token);
        }
        
        public static string PendingChangeParams()
        {
            var parameters = RequestGenerator.GetStorage("Grandpa", "PendingChange", Storage.Type.Plain);
            return parameters;
        }
        
        /// <summary>
        /// >> PendingChange
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletGrandpa.StoredPendingChange> PendingChange(CancellationToken token)
        {
            string parameters = GrandpaStorage.PendingChangeParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletGrandpa.StoredPendingChange>(parameters, token);
        }
        
        public static string NextForcedParams()
        {
            var parameters = RequestGenerator.GetStorage("Grandpa", "NextForced", Storage.Type.Plain);
            return parameters;
        }
        
        /// <summary>
        /// >> NextForced
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> NextForced(CancellationToken token)
        {
            string parameters = GrandpaStorage.NextForcedParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        public static string StalledParams()
        {
            var parameters = RequestGenerator.GetStorage("Grandpa", "Stalled", Storage.Type.Plain);
            return parameters;
        }
        
        /// <summary>
        /// >> Stalled
        /// </summary>
        public async Task<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>> Stalled(CancellationToken token)
        {
            string parameters = GrandpaStorage.StalledParams();
            return await _client.GetStorageAsync<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>>(parameters, token);
        }
        
        public static string CurrentSetIdParams()
        {
            var parameters = RequestGenerator.GetStorage("Grandpa", "CurrentSetId", Storage.Type.Plain);
            return parameters;
        }
        
        /// <summary>
        /// >> CurrentSetId
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U64> CurrentSetId(CancellationToken token)
        {
            string parameters = GrandpaStorage.CurrentSetIdParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U64>(parameters, token);
        }
        
        public static string SetIdSessionParams(SubstrateNetApi.Model.Types.Primitive.U64 key)
        {
            var keyParams = new IType[] { key };
            var parameters = RequestGenerator.GetStorage("Grandpa", "SetIdSession", Storage.Type.Map, new[] {Storage.Hasher.Twox64Concat}, keyParams);
            return parameters;
        }
        
        /// <summary>
        /// >> SetIdSession
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> SetIdSession(SubstrateNetApi.Model.Types.Primitive.U64 key, CancellationToken token)
        {
            string parameters = GrandpaStorage.SetIdSessionParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
    }
    
    public sealed class GrandpaCalls
    {
        
        /// <summary>
        /// >> report_equivocation
        /// </summary>
        public static Method ReportEquivocation(SubstrateNetApi.Model.SpFinalityGrandpa.EquivocationProof equivocation_proof, SubstrateNetApi.Model.SpSession.MembershipProof key_owner_proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(equivocation_proof.Encode());
            byteArray.AddRange(key_owner_proof.Encode());
            return new Method(16, "Grandpa", 0, "report_equivocation", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> report_equivocation_unsigned
        /// </summary>
        public static Method ReportEquivocationUnsigned(SubstrateNetApi.Model.SpFinalityGrandpa.EquivocationProof equivocation_proof, SubstrateNetApi.Model.SpSession.MembershipProof key_owner_proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(equivocation_proof.Encode());
            byteArray.AddRange(key_owner_proof.Encode());
            return new Method(16, "Grandpa", 1, "report_equivocation_unsigned", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> note_stalled
        /// </summary>
        public static Method NoteStalled(SubstrateNetApi.Model.Types.Primitive.U32 delay, SubstrateNetApi.Model.Types.Primitive.U32 best_finalized_block_number)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(delay.Encode());
            byteArray.AddRange(best_finalized_block_number.Encode());
            return new Method(16, "Grandpa", 2, "note_stalled", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> NewAuthorities
    /// </summary>
    public sealed class EventNewAuthorities : BaseTuple<BaseVec<BaseTuple<SubstrateNetApi.Model.SpFinalityGrandpa.Public,SubstrateNetApi.Model.Types.Primitive.U64>>>
    {
    }
    
    /// <summary>
    /// >> Paused
    /// </summary>
    public sealed class EventPaused : BaseTuple
    {
    }
    
    /// <summary>
    /// >> Resumed
    /// </summary>
    public sealed class EventResumed : BaseTuple
    {
    }
    
    public enum GrandpaErrors
    {
        
        /// <summary>
        /// >> PauseFailed
        /// </summary>
        PauseFailed,
        
        /// <summary>
        /// >> ResumeFailed
        /// </summary>
        ResumeFailed,
        
        /// <summary>
        /// >> ChangePending
        /// </summary>
        ChangePending,
        
        /// <summary>
        /// >> TooSoon
        /// </summary>
        TooSoon,
        
        /// <summary>
        /// >> InvalidKeyOwnershipProof
        /// </summary>
        InvalidKeyOwnershipProof,
        
        /// <summary>
        /// >> InvalidEquivocationProof
        /// </summary>
        InvalidEquivocationProof,
        
        /// <summary>
        /// >> DuplicateOffenceReport
        /// </summary>
        DuplicateOffenceReport,
    }
}