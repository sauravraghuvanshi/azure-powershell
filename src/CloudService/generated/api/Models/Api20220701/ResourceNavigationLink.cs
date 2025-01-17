// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>ResourceNavigationLink resource.</summary>
    public partial class ResourceNavigationLink :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLink,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated __subResourceAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated();

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)__subResourceAutoGenerated).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)__subResourceAutoGenerated).Id = value ?? null; }

        /// <summary>Link to the external resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string Link { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormatInternal)Property).Link; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormatInternal)Property).Link = value ?? null; }

        /// <summary>Resource type of the linked resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string LinkedResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormatInternal)Property).LinkedResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormatInternal)Property).LinkedResourceType = value ?? null; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormat Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ResourceNavigationLinkFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormatInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormatInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// Name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormat _property;

        /// <summary>Resource navigation link properties format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ResourceNavigationLinkFormat()); set => this._property = value; }

        /// <summary>The provisioning state of the resource navigation link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormatInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="ResourceNavigationLink" /> instance.</summary>
        public ResourceNavigationLink()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__subResourceAutoGenerated), __subResourceAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__subResourceAutoGenerated), __subResourceAutoGenerated);
        }
    }
    /// ResourceNavigationLink resource.
    public partial interface IResourceNavigationLink :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated
    {
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>Link to the external resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the external resource.",
        SerializedName = @"link",
        PossibleTypes = new [] { typeof(string) })]
        string Link { get; set; }
        /// <summary>Resource type of the linked resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource type of the linked resource.",
        SerializedName = @"linkedResourceType",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedResourceType { get; set; }
        /// <summary>
        /// Name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource that is unique within a resource group. This name can be used to access the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The provisioning state of the resource navigation link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the resource navigation link resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// ResourceNavigationLink resource.
    internal partial interface IResourceNavigationLinkInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal
    {
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string Etag { get; set; }
        /// <summary>Link to the external resource.</summary>
        string Link { get; set; }
        /// <summary>Resource type of the linked resource.</summary>
        string LinkedResourceType { get; set; }
        /// <summary>
        /// Name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        string Name { get; set; }
        /// <summary>Resource navigation link properties format.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceNavigationLinkFormat Property { get; set; }
        /// <summary>The provisioning state of the resource navigation link resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Resource type.</summary>
        string Type { get; set; }

    }
}