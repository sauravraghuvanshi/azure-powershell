// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VolumeQuotaRulesOperations.
    /// </summary>
    public static partial class VolumeQuotaRulesOperationsExtensions
    {
            /// <summary>
            /// Get all quota rules for a volume
            /// </summary>
            /// <remarks>
            /// List all quota rules associated with the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            public static IEnumerable<VolumeQuotaRule> ListByVolume(this IVolumeQuotaRulesOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName)
            {
                return operations.ListByVolumeAsync(resourceGroupName, accountName, poolName, volumeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all quota rules for a volume
            /// </summary>
            /// <remarks>
            /// List all quota rules associated with the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<VolumeQuotaRule>> ListByVolumeAsync(this IVolumeQuotaRulesOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVolumeWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Describe a quota rule
            /// </summary>
            /// <remarks>
            /// Get details of the specified quota rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            public static VolumeQuotaRule Get(this IVolumeQuotaRulesOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName)
            {
                return operations.GetAsync(resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Describe a quota rule
            /// </summary>
            /// <remarks>
            /// Get details of the specified quota rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VolumeQuotaRule> GetAsync(this IVolumeQuotaRulesOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a quota rule
            /// </summary>
            /// <remarks>
            /// Create the specified quota rule within the given volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Quota rule object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            public static VolumeQuotaRule Create(this IVolumeQuotaRulesOperations operations, VolumeQuotaRule body, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName)
            {
                return operations.CreateAsync(body, resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a quota rule
            /// </summary>
            /// <remarks>
            /// Create the specified quota rule within the given volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Quota rule object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VolumeQuotaRule> CreateAsync(this IVolumeQuotaRulesOperations operations, VolumeQuotaRule body, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a quota rule
            /// </summary>
            /// <remarks>
            /// Patch a quota rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Quota rule object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            public static VolumeQuotaRule Update(this IVolumeQuotaRulesOperations operations, VolumeQuotaRulePatch body, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName)
            {
                return operations.UpdateAsync(body, resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a quota rule
            /// </summary>
            /// <remarks>
            /// Patch a quota rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Quota rule object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VolumeQuotaRule> UpdateAsync(this IVolumeQuotaRulesOperations operations, VolumeQuotaRulePatch body, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(body, resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a quota rule
            /// </summary>
            /// <remarks>
            /// Delete quota rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            public static void Delete(this IVolumeQuotaRulesOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a quota rule
            /// </summary>
            /// <remarks>
            /// Delete quota rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVolumeQuotaRulesOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create a quota rule
            /// </summary>
            /// <remarks>
            /// Create the specified quota rule within the given volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Quota rule object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            public static VolumeQuotaRule BeginCreate(this IVolumeQuotaRulesOperations operations, VolumeQuotaRule body, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName)
            {
                return operations.BeginCreateAsync(body, resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a quota rule
            /// </summary>
            /// <remarks>
            /// Create the specified quota rule within the given volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Quota rule object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VolumeQuotaRule> BeginCreateAsync(this IVolumeQuotaRulesOperations operations, VolumeQuotaRule body, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(body, resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a quota rule
            /// </summary>
            /// <remarks>
            /// Patch a quota rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Quota rule object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            public static VolumeQuotaRule BeginUpdate(this IVolumeQuotaRulesOperations operations, VolumeQuotaRulePatch body, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName)
            {
                return operations.BeginUpdateAsync(body, resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a quota rule
            /// </summary>
            /// <remarks>
            /// Patch a quota rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Quota rule object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VolumeQuotaRule> BeginUpdateAsync(this IVolumeQuotaRulesOperations operations, VolumeQuotaRulePatch body, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(body, resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a quota rule
            /// </summary>
            /// <remarks>
            /// Delete quota rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            public static void BeginDelete(this IVolumeQuotaRulesOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName)
            {
                operations.BeginDeleteAsync(resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a quota rule
            /// </summary>
            /// <remarks>
            /// Delete quota rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='volumeQuotaRuleName'>
            /// The name of volume quota rule
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVolumeQuotaRulesOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string volumeQuotaRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, volumeQuotaRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
