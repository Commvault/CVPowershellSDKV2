// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Recovery options to be specified for a continuous replication group</summary>
    public partial class RecoveryOptions
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Commvault.Powershell.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Commvault.Powershell.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Commvault.Powershell.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IRecoveryOptions.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IRecoveryOptions.</returns>
        public static Commvault.Powershell.Models.IRecoveryOptions FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new RecoveryOptions(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="RecoveryOptions" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RecoveryOptions(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_recoveryType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("recoveryType"), out var __jsonRecoveryType) ? (string)__jsonRecoveryType : (string)RecoveryType;}
            {_recoveryPointStore = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("recoveryPointStore"), out var __jsonRecoveryPointStore) ? (string)__jsonRecoveryPointStore : (string)RecoveryPointStore;}
            {_crashConsistentRpInterval = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("crashConsistentRpInterval"), out var __jsonCrashConsistentRpInterval) ? (long?)__jsonCrashConsistentRpInterval : CrashConsistentRpInterval;}
            {_mergeRecoveryPointsOlderThan = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("mergeRecoveryPointsOlderThan"), out var __jsonMergeRecoveryPointsOlderThan) ? (long?)__jsonMergeRecoveryPointsOlderThan : MergeRecoveryPointsOlderThan;}
            {_retainRecoveryPointsFor = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("retainRecoveryPointsFor"), out var __jsonRetainRecoveryPointsFor) ? (long?)__jsonRetainRecoveryPointsFor : RetainRecoveryPointsFor;}
            {_recoveryPointInterval = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("recoveryPointInterval"), out var __jsonRecoveryPointInterval) ? (long?)__jsonRecoveryPointInterval : RecoveryPointInterval;}
            {_pruneAndMergeRecoveryPoints = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("pruneAndMergeRecoveryPoints"), out var __jsonPruneAndMergeRecoveryPoints) ? (bool?)__jsonPruneAndMergeRecoveryPoints : PruneAndMergeRecoveryPoints;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RecoveryOptions" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RecoveryOptions" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </returns>
        public Commvault.Powershell.Runtime.Json.JsonNode ToJson(Commvault.Powershell.Runtime.Json.JsonObject container, Commvault.Powershell.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Commvault.Powershell.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._recoveryType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._recoveryType.ToString()) : null, "recoveryType" ,container.Add );
            AddIf( null != (((object)this._recoveryPointStore)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._recoveryPointStore.ToString()) : null, "recoveryPointStore" ,container.Add );
            AddIf( null != this._crashConsistentRpInterval ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._crashConsistentRpInterval) : null, "crashConsistentRpInterval" ,container.Add );
            AddIf( null != this._mergeRecoveryPointsOlderThan ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._mergeRecoveryPointsOlderThan) : null, "mergeRecoveryPointsOlderThan" ,container.Add );
            AddIf( null != this._retainRecoveryPointsFor ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._retainRecoveryPointsFor) : null, "retainRecoveryPointsFor" ,container.Add );
            AddIf( null != this._recoveryPointInterval ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._recoveryPointInterval) : null, "recoveryPointInterval" ,container.Add );
            AddIf( null != this._pruneAndMergeRecoveryPoints ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._pruneAndMergeRecoveryPoints) : null, "pruneAndMergeRecoveryPoints" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}