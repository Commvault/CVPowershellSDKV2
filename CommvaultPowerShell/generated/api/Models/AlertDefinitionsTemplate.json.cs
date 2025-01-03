// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>AlertDefinitionsTemplate</summary>
    public partial class AlertDefinitionsTemplate
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
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="AlertDefinitionsTemplate" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AlertDefinitionsTemplate(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_locale = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("locale"), out var __jsonLocale) ? Commvault.Powershell.Models.IdName.FromJson(__jsonLocale) : _locale;}
            {_workflow = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("workflow"), out var __jsonWorkflow) ? Commvault.Powershell.Models.WorkflowEntity.FromJson(__jsonWorkflow) : _workflow;}
            {_email = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("email"), out var __jsonEmail) ? (string)__jsonEmail : (string)_email;}
            {_console = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("console"), out var __jsonConsole) ? (string)__jsonConsole : (string)_console;}
            {_eventViewer = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("eventViewer"), out var __jsonEventViewer) ? (string)__jsonEventViewer : (string)_eventViewer;}
            {_webhook = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("webhook"), out var __jsonWebhook) ? (string)__jsonWebhook : (string)_webhook;}
            {_workflowInputDetails = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("workflowInputDetails"), out var __jsonWorkflowInputDetails) ? (string)__jsonWorkflowInputDetails : (string)_workflowInputDetails;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IAlertDefinitionsTemplate.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IAlertDefinitionsTemplate.</returns>
        public static Commvault.Powershell.Models.IAlertDefinitionsTemplate FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new AlertDefinitionsTemplate(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AlertDefinitionsTemplate" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AlertDefinitionsTemplate" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._locale ? (Commvault.Powershell.Runtime.Json.JsonNode) this._locale.ToJson(null,serializationMode) : null, "locale" ,container.Add );
            AddIf( null != this._workflow ? (Commvault.Powershell.Runtime.Json.JsonNode) this._workflow.ToJson(null,serializationMode) : null, "workflow" ,container.Add );
            AddIf( null != (((object)this._email)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._email.ToString()) : null, "email" ,container.Add );
            AddIf( null != (((object)this._console)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._console.ToString()) : null, "console" ,container.Add );
            AddIf( null != (((object)this._eventViewer)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._eventViewer.ToString()) : null, "eventViewer" ,container.Add );
            AddIf( null != (((object)this._webhook)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._webhook.ToString()) : null, "webhook" ,container.Add );
            AddIf( null != (((object)this._workflowInputDetails)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._workflowInputDetails.ToString()) : null, "workflowInputDetails" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}