// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>vmGroupDetailsSummary</summary>
    public partial class VMGroupDetailsSummary
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IVMGroupDetailsSummary.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IVMGroupDetailsSummary.</returns>
        public static Commvault.Powershell.Models.IVMGroupDetailsSummary FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new VMGroupDetailsSummary(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VMGroupDetailsSummary" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VMGroupDetailsSummary" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._plan ? (Commvault.Powershell.Runtime.Json.JsonNode) this._plan.ToJson(null,serializationMode) : null, "plan" ,container.Add );
            AddIf( null != this._region ? (Commvault.Powershell.Runtime.Json.JsonNode) this._region.ToJson(null,serializationMode) : null, "region" ,container.Add );
            AddIf( null != this._timeZone ? (Commvault.Powershell.Runtime.Json.JsonNode) this._timeZone.ToJson(null,serializationMode) : null, "timeZone" ,container.Add );
            AddIf( null != (((object)this._hypervisorName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._hypervisorName.ToString()) : null, "hypervisorName" ,container.Add );
            AddIf( null != this._lastBackupTime ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._lastBackupTime) : null, "lastBackupTime" ,container.Add );
            AddIf( null != this._lastBackupSize ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._lastBackupSize) : null, "lastBackupSize" ,container.Add );
            AddIf( null != this._nextBackupTime ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._nextBackupTime) : null, "nextBackupTime" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="VMGroupDetailsSummary" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VMGroupDetailsSummary(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_plan = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("plan"), out var __jsonPlan) ? Commvault.Powershell.Models.PlanIdNameType.FromJson(__jsonPlan) : Plan;}
            {_region = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("region"), out var __jsonRegion) ? Commvault.Powershell.Models.RegionInfo.FromJson(__jsonRegion) : Region;}
            {_timeZone = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("timeZone"), out var __jsonTimeZone) ? Commvault.Powershell.Models.IdName.FromJson(__jsonTimeZone) : TimeZone;}
            {_hypervisorName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("hypervisorName"), out var __jsonHypervisorName) ? (string)__jsonHypervisorName : (string)HypervisorName;}
            {_lastBackupTime = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("lastBackupTime"), out var __jsonLastBackupTime) ? (long?)__jsonLastBackupTime : LastBackupTime;}
            {_lastBackupSize = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("lastBackupSize"), out var __jsonLastBackupSize) ? (long?)__jsonLastBackupSize : LastBackupSize;}
            {_nextBackupTime = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("nextBackupTime"), out var __jsonNextBackupTime) ? (long?)__jsonNextBackupTime : NextBackupTime;}
            AfterFromJson(json);
        }
    }
}