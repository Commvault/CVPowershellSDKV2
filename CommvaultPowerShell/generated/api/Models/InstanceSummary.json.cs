// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Gives the summary of each instance.</summary>
    public partial class InstanceSummary
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IInstanceSummary.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IInstanceSummary.</returns>
        public static Commvault.Powershell.Models.IInstanceSummary FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new InstanceSummary(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="InstanceSummary" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal InstanceSummary(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_client = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("client"), out var __jsonClient) ? Commvault.Powershell.Models.IdName.FromJson(__jsonClient) : Client;}
            {_lastBackup = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("lastBackup"), out var __jsonLastBackup) ? Commvault.Powershell.Models.LastBackupJobInfo.FromJson(__jsonLastBackup) : LastBackup;}
            {_plan = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("plan"), out var __jsonPlan) ? Commvault.Powershell.Models.IdName.FromJson(__jsonPlan) : Plan;}
            {_sla = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("SLA"), out var __jsonSla) ? Commvault.Powershell.Models.SlaDetails.FromJson(__jsonSla) : Sla;}
            {_company = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("company"), out var __jsonCompany) ? Commvault.Powershell.Models.IdName.FromJson(__jsonCompany) : Company;}
            {_commcell = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("commcell"), out var __jsonCommcell) ? Commvault.Powershell.Models.CommcellInfo.FromJson(__jsonCommcell) : Commcell;}
            {_id = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("id"), out var __jsonId) ? (long?)__jsonId : Id;}
            {_name = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_server = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("server"), out var __jsonServer) ? (string)__jsonServer : (string)Server;}
            {_vendor = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("vendor"), out var __jsonVendor) ? (string)__jsonVendor : (string)Vendor;}
            {_databaseEngine = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("databaseEngine"), out var __jsonDatabaseEngine) ? (string)__jsonDatabaseEngine : (string)DatabaseEngine;}
            {_status = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_notReadyReason = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("notReadyReason"), out var __jsonNotReadyReason) ? (string)__jsonNotReadyReason : (string)NotReadyReason;}
            {_applicationSize = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("applicationSize"), out var __jsonApplicationSize) ? (long?)__jsonApplicationSize : ApplicationSize;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="InstanceSummary" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="InstanceSummary" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._client ? (Commvault.Powershell.Runtime.Json.JsonNode) this._client.ToJson(null,serializationMode) : null, "client" ,container.Add );
            AddIf( null != this._lastBackup ? (Commvault.Powershell.Runtime.Json.JsonNode) this._lastBackup.ToJson(null,serializationMode) : null, "lastBackup" ,container.Add );
            AddIf( null != this._plan ? (Commvault.Powershell.Runtime.Json.JsonNode) this._plan.ToJson(null,serializationMode) : null, "plan" ,container.Add );
            AddIf( null != this._sla ? (Commvault.Powershell.Runtime.Json.JsonNode) this._sla.ToJson(null,serializationMode) : null, "SLA" ,container.Add );
            AddIf( null != this._company ? (Commvault.Powershell.Runtime.Json.JsonNode) this._company.ToJson(null,serializationMode) : null, "company" ,container.Add );
            AddIf( null != this._commcell ? (Commvault.Powershell.Runtime.Json.JsonNode) this._commcell.ToJson(null,serializationMode) : null, "commcell" ,container.Add );
            AddIf( null != this._id ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._id) : null, "id" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._server)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._server.ToString()) : null, "server" ,container.Add );
            AddIf( null != (((object)this._vendor)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._vendor.ToString()) : null, "vendor" ,container.Add );
            AddIf( null != (((object)this._databaseEngine)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._databaseEngine.ToString()) : null, "databaseEngine" ,container.Add );
            AddIf( null != (((object)this._status)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            AddIf( null != (((object)this._notReadyReason)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._notReadyReason.ToString()) : null, "notReadyReason" ,container.Add );
            AddIf( null != this._applicationSize ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._applicationSize) : null, "applicationSize" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}