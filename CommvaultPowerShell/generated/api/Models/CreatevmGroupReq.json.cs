// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>CreatevmGroupReq</summary>
    public partial class CreatevmGroupReq
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
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="CreatevmGroupReq" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CreatevmGroupReq(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_hypervisor = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("Hypervisor"), out var __jsonHypervisor) ? Commvault.Powershell.Models.IdName.FromJson(__jsonHypervisor) : _hypervisor;}
            {_content = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("content"), out var __jsonContent) ? Commvault.Powershell.Models.VMContent.FromJson(__jsonContent) : _content;}
            {_plan = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("plan"), out var __jsonPlan) ? Commvault.Powershell.Models.IdName.FromJson(__jsonPlan) : _plan;}
            {_storage = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("storage"), out var __jsonStorage) ? Commvault.Powershell.Models.IdName.FromJson(__jsonStorage) : _storage;}
            {_meditech = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("Meditech"), out var __jsonMeditech) ? Commvault.Powershell.Models.MeditechPropResp.FromJson(__jsonMeditech) : _meditech;}
            {_name = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)_name;}
            {_enableIntellisnap = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("enableIntellisnap"), out var __jsonEnableIntellisnap) ? (bool?)__jsonEnableIntellisnap : _enableIntellisnap;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.ICreatevmGroupReq.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.ICreatevmGroupReq.</returns>
        public static Commvault.Powershell.Models.ICreatevmGroupReq FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new CreatevmGroupReq(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CreatevmGroupReq" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CreatevmGroupReq" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._hypervisor ? (Commvault.Powershell.Runtime.Json.JsonNode) this._hypervisor.ToJson(null,serializationMode) : null, "Hypervisor" ,container.Add );
            AddIf( null != this._content ? (Commvault.Powershell.Runtime.Json.JsonNode) this._content.ToJson(null,serializationMode) : null, "content" ,container.Add );
            AddIf( null != this._plan ? (Commvault.Powershell.Runtime.Json.JsonNode) this._plan.ToJson(null,serializationMode) : null, "plan" ,container.Add );
            AddIf( null != this._storage ? (Commvault.Powershell.Runtime.Json.JsonNode) this._storage.ToJson(null,serializationMode) : null, "storage" ,container.Add );
            AddIf( null != this._meditech ? (Commvault.Powershell.Runtime.Json.JsonNode) this._meditech.ToJson(null,serializationMode) : null, "Meditech" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != this._enableIntellisnap ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._enableIntellisnap) : null, "enableIntellisnap" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}