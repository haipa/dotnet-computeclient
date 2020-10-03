// <auto-generated>
// MIT
// </auto-generated>

namespace Haipa.ComputeClient
{
    using Haipa.ClientRuntime;
    using Haipa.ClientRuntime.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for MachinesOperations.
    /// </summary>
    public static partial class MachinesOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static MachineList List(this IMachinesOperations operations, Haipa.ClientRuntime.OData.ODataQuery<Machine> odataQuery = default(Haipa.ClientRuntime.OData.ODataQuery<Machine>), string select = default(string), bool? count = false)
            {
                return operations.ListAsync(odataQuery, select, count).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MachineList> ListAsync(this IMachinesOperations operations, Haipa.ClientRuntime.OData.ODataQuery<Machine> odataQuery = default(Haipa.ClientRuntime.OData.ODataQuery<Machine>), string select = default(string), bool? count = false, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, select, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static Operation Create(this IMachinesOperations operations, MachineConfig body = default(MachineConfig))
            {
                return operations.CreateAsync(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Operation> CreateAsync(this IMachinesOperations operations, MachineConfig body = default(MachineConfig), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            public static Machine Get(this IMachinesOperations operations, System.Guid key, string select = default(string), string expand = default(string))
            {
                return operations.GetAsync(key, select, expand).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Machine> GetAsync(this IMachinesOperations operations, System.Guid key, string select = default(string), string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(key, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            public static Operation Delete(this IMachinesOperations operations, System.Guid key)
            {
                return operations.DeleteAsync(key).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Operation> DeleteAsync(this IMachinesOperations operations, System.Guid key, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(key, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static Operation Update(this IMachinesOperations operations, System.Guid key, MachineConfig body = default(MachineConfig))
            {
                return operations.UpdateAsync(key, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Operation> UpdateAsync(this IMachinesOperations operations, System.Guid key, MachineConfig body = default(MachineConfig), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            public static Operation Start(this IMachinesOperations operations, System.Guid key, string select = default(string), string expand = default(string))
            {
                return operations.StartAsync(key, select, expand).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Operation> StartAsync(this IMachinesOperations operations, System.Guid key, string select = default(string), string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StartWithHttpMessagesAsync(key, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            public static Operation Stop(this IMachinesOperations operations, System.Guid key, string select = default(string), string expand = default(string))
            {
                return operations.StopAsync(key, select, expand).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Operation> StopAsync(this IMachinesOperations operations, System.Guid key, string select = default(string), string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StopWithHttpMessagesAsync(key, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
