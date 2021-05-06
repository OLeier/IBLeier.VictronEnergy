﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Monitor.SampleAPI
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;

    /// <summary>
    /// Extension methods for SampleAPIClient.
    /// </summary>
    public static partial class SampleAPIClientExtensions
    {
            /// <summary>
            /// Returns a list of users.
            /// </summary>
            /// Optional extended description in Markdown.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetUsers(this ISampleAPIClient operations)
            {
                Task.Factory.StartNew(s => ((ISampleAPIClient)s).GetUsersAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of users.
            /// </summary>
            /// Optional extended description in Markdown.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetUsersAsync(this ISampleAPIClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetUsersWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

    }
}
