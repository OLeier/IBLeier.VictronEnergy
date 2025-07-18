/*
 * VRM API
 *
 * ## Introduction This document provides a brief overview of some of the available endpoints and their parameters. The API is a REST API, accepting JSON as request body. You can use the try-it tool to play around with it, or use software like Postman.  ## Authentication Most endpoints require authentication, using a JWT token. This token should be placed in the `x-authorization` field in the HTTP header. There are two types of tokens. - Bearer token. Uses the `Bearer <token_value>` format. This is used when logging in to VRM, for example. Can be retrieved from [/auth/login](/operations/auth/login) or [/auth/loginAsDemo](/operations/auth/loginAsDemo). - Access token. Uses the `Token <token_value>` format. This is commonly used for third party applications using the VRM API. Can be created using [/users/{idUser}/accesstokens/create](/operations/users/idUser/accesstokens/create).  ## Rate limiting Most endpoints are by default rate limited with a rolling window of max 200 requests, where every 0.33 seconds a request gets removed from the rolling window. (so on average maximum of 3 requests per second won't get rate limited). There are different types of ratelimiting in VRM. If you receive a 429 with a JSON response, you can check the Retry-After response header to check the amount of seconds you have to wait until retrying.  ## WARNING & DISCLAIMER Whilst publicly available, Victron Energy does not offer support to professional customers or end-users that implement features using the here documented functionality, except in really specific situations (i.e such as a special arrangement with a large OEM customer).  The recommended method for support on the VRM API is to use the Modifications section on Victron Community. This space is frequently visited by many people using the API, and other methods of integrating with Victron products. Direct company support is only offered on a limited basis via your Victron representative.
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Extensions;
using Xunit;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Tests the dependency injection.
    /// </summary>
    public class DependencyInjectionTest
    {
        private readonly IHost _hostUsingConfigureWithoutAClient =
            Host.CreateDefaultBuilder([]).ConfigureApi((context, services, options) =>
            {

            })
            .Build();

        private readonly IHost _hostUsingConfigureWithAClient =
            Host.CreateDefaultBuilder([]).ConfigureApi((context, services, options) =>
            {

                options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
            })
            .Build();

        private readonly IHost _hostUsingAddWithoutAClient =
            Host.CreateDefaultBuilder([]).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {

                });
            })
            .Build();

        private readonly IHost _hostUsingAddWithAClient =
            Host.CreateDefaultBuilder([]).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {

                    options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
                });
            })
            .Build();

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithAClientTest()
        {
            var defaultApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IDefaultApi>();
            Assert.True(defaultApi.HttpClient.BaseAddress != null);

            var generalWidgetsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IGeneralWidgetsApi>();
            Assert.True(generalWidgetsApi.HttpClient.BaseAddress != null);

            var installationsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IInstallationsApi>();
            Assert.True(installationsApi.HttpClient.BaseAddress != null);

            var stateWidgetsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IStateWidgetsApi>();
            Assert.True(stateWidgetsApi.HttpClient.BaseAddress != null);

            var summaryWidgetsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<ISummaryWidgetsApi>();
            Assert.True(summaryWidgetsApi.HttpClient.BaseAddress != null);

            var usersApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IUsersApi>();
            Assert.True(usersApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithoutAClientTest()
        {
            var defaultApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IDefaultApi>();
            Assert.True(defaultApi.HttpClient.BaseAddress != null);

            var generalWidgetsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IGeneralWidgetsApi>();
            Assert.True(generalWidgetsApi.HttpClient.BaseAddress != null);

            var installationsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IInstallationsApi>();
            Assert.True(installationsApi.HttpClient.BaseAddress != null);

            var stateWidgetsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IStateWidgetsApi>();
            Assert.True(stateWidgetsApi.HttpClient.BaseAddress != null);

            var summaryWidgetsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<ISummaryWidgetsApi>();
            Assert.True(summaryWidgetsApi.HttpClient.BaseAddress != null);

            var usersApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IUsersApi>();
            Assert.True(usersApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithAClientTest()
        {
            var defaultApi = _hostUsingAddWithAClient.Services.GetRequiredService<IDefaultApi>();
            Assert.True(defaultApi.HttpClient.BaseAddress != null);

            var generalWidgetsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IGeneralWidgetsApi>();
            Assert.True(generalWidgetsApi.HttpClient.BaseAddress != null);

            var installationsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IInstallationsApi>();
            Assert.True(installationsApi.HttpClient.BaseAddress != null);

            var stateWidgetsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IStateWidgetsApi>();
            Assert.True(stateWidgetsApi.HttpClient.BaseAddress != null);

            var summaryWidgetsApi = _hostUsingAddWithAClient.Services.GetRequiredService<ISummaryWidgetsApi>();
            Assert.True(summaryWidgetsApi.HttpClient.BaseAddress != null);

            var usersApi = _hostUsingAddWithAClient.Services.GetRequiredService<IUsersApi>();
            Assert.True(usersApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithoutAClientTest()
        {
            var defaultApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IDefaultApi>();
            Assert.True(defaultApi.HttpClient.BaseAddress != null);

            var generalWidgetsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IGeneralWidgetsApi>();
            Assert.True(generalWidgetsApi.HttpClient.BaseAddress != null);

            var installationsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IInstallationsApi>();
            Assert.True(installationsApi.HttpClient.BaseAddress != null);

            var stateWidgetsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IStateWidgetsApi>();
            Assert.True(stateWidgetsApi.HttpClient.BaseAddress != null);

            var summaryWidgetsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<ISummaryWidgetsApi>();
            Assert.True(summaryWidgetsApi.HttpClient.BaseAddress != null);

            var usersApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IUsersApi>();
            Assert.True(usersApi.HttpClient.BaseAddress != null);
        }
    }
}
