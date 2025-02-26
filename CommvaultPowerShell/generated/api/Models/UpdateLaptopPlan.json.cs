// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class UpdateLaptopPlan
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Commvault.Powershell.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Commvault.Powershell.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Commvault.Powershell.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IUpdateLaptopPlan.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IUpdateLaptopPlan.</returns>
        public static Commvault.Powershell.Models.IUpdateLaptopPlan FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new UpdateLaptopPlan(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UpdateLaptopPlan" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UpdateLaptopPlan" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._general ? (Commvault.Powershell.Runtime.Json.JsonNode) this._general.ToJson(null,serializationMode) : null, "general" ,container.Add );
            AddIf( null != this._rpo ? (Commvault.Powershell.Runtime.Json.JsonNode) this._rpo.ToJson(null,serializationMode) : null, "rpo" ,container.Add );
            AddIf( null != this._backupContent ? (Commvault.Powershell.Runtime.Json.JsonNode) this._backupContent.ToJson(null,serializationMode) : null, "backupContent" ,container.Add );
            AddIf( null != this._retention ? (Commvault.Powershell.Runtime.Json.JsonNode) this._retention.ToJson(null,serializationMode) : null, "retention" ,container.Add );
            AddIf( null != this._regionToConfigure ? (Commvault.Powershell.Runtime.Json.JsonNode) this._regionToConfigure.ToJson(null,serializationMode) : null, "regionToConfigure" ,container.Add );
            AddIf( null != this._overrideRestrictions ? (Commvault.Powershell.Runtime.Json.JsonNode) this._overrideRestrictions.ToJson(null,serializationMode) : null, "overrideRestrictions" ,container.Add );
            AddIf( null != this._networkResources ? (Commvault.Powershell.Runtime.Json.JsonNode) this._networkResources.ToJson(null,serializationMode) : null, "networkResources" ,container.Add );
            AddIf( null != this._offlineLaptops ? (Commvault.Powershell.Runtime.Json.JsonNode) this._offlineLaptops.ToJson(null,serializationMode) : null, "offlineLaptops" ,container.Add );
            AddIf( null != (((object)this._newName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._newName.ToString()) : null, "newName" ,container.Add );
            if (null != this._associatedUsersAndUserGroups)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._associatedUsersAndUserGroups )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("associatedUsersAndUserGroups",__w);
            }
            if (null != this._alerts)
            {
                var __r = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __s in this._alerts )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("alerts",__r);
            }
            AddIf( null != this._allowPlanOverride ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._allowPlanOverride) : null, "allowPlanOverride" ,container.Add );
            AddIf( null != this._allowedFeatures ? (Commvault.Powershell.Runtime.Json.JsonNode) this._allowedFeatures.ToJson(null,serializationMode) : null, "allowedFeatures" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="UpdateLaptopPlan" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UpdateLaptopPlan(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_general = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("general"), out var __jsonGeneral) ? Commvault.Powershell.Models.LaptopPlanUpdateGeneralInfo.FromJson(__jsonGeneral) : _general;}
            {_rpo = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("rpo"), out var __jsonRpo) ? Commvault.Powershell.Models.LaptopPlanUpdateRpo.FromJson(__jsonRpo) : _rpo;}
            {_backupContent = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("backupContent"), out var __jsonBackupContent) ? Commvault.Powershell.Models.LaptopPlanBackupContent.FromJson(__jsonBackupContent) : _backupContent;}
            {_retention = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("retention"), out var __jsonRetention) ? Commvault.Powershell.Models.LaptopPlanRetention.FromJson(__jsonRetention) : _retention;}
            {_regionToConfigure = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("regionToConfigure"), out var __jsonRegionToConfigure) ? Commvault.Powershell.Models.IdName.FromJson(__jsonRegionToConfigure) : _regionToConfigure;}
            {_overrideRestrictions = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("overrideRestrictions"), out var __jsonOverrideRestrictions) ? Commvault.Powershell.Models.LaptopPlanOverrideSettings.FromJson(__jsonOverrideRestrictions) : _overrideRestrictions;}
            {_networkResources = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("networkResources"), out var __jsonNetworkResources) ? Commvault.Powershell.Models.LaptopPlanNetworkResources.FromJson(__jsonNetworkResources) : _networkResources;}
            {_offlineLaptops = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("offlineLaptops"), out var __jsonOfflineLaptops) ? Commvault.Powershell.Models.AutoRetireDevices.FromJson(__jsonOfflineLaptops) : _offlineLaptops;}
            {_newName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("newName"), out var __jsonNewName) ? (string)__jsonNewName : (string)_newName;}
            {_associatedUsersAndUserGroups = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("associatedUsersAndUserGroups"), out var __jsonAssociatedUsersAndUserGroups) ? If( __jsonAssociatedUsersAndUserGroups as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Commvault.Powershell.Models.IPlanUserOrGroups>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.IPlanUserOrGroups) (Commvault.Powershell.Models.PlanUserOrGroups.FromJson(__u) )) ))() : null : _associatedUsersAndUserGroups;}
            {_alerts = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("alerts"), out var __jsonAlerts) ? If( __jsonAlerts as Commvault.Powershell.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Commvault.Powershell.Models.IIdName) (Commvault.Powershell.Models.IdName.FromJson(__p) )) ))() : null : _alerts;}
            {_allowPlanOverride = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("allowPlanOverride"), out var __jsonAllowPlanOverride) ? (bool?)__jsonAllowPlanOverride : _allowPlanOverride;}
            {_allowedFeatures = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("allowedFeatures"), out var __jsonAllowedFeatures) ? Commvault.Powershell.Models.LaptopPlanAllowedFeatures.FromJson(__jsonAllowedFeatures) : _allowedFeatures;}
            AfterFromJson(json);
        }
    }
}