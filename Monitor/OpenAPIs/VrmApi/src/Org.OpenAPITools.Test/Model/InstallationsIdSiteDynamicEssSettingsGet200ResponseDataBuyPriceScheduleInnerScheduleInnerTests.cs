/*
 * VRM API
 *
 * ## Introduction This document provides a brief overview of some of the available endpoints and their parameters. The API is a REST API, accepting JSON as request body. You can use the try-it tool to play around with it, or use software like Postman.  ## Authentication Most endpoints require authentication, using a JWT token. This token should be placed in the `x-authorization` field in the HTTP header. There are two types of tokens. - Bearer token. Uses the `Bearer <token_value>` format. This is used when logging in to VRM, for example. Can be retrieved from [/auth/login](/operations/auth/login) or [/auth/loginAsDemo](/operations/auth/loginAsDemo). - Access token. Uses the `Token <token_value>` format. This is commonly used for third party applications using the VRM API. Can be created using [/users/{idUser}/accesstokens/create](/operations/users/idUser/accesstokens/create).  ## Rate limiting Most endpoints are by default rate limited with a rolling window of max 200 requests, where every 0.33 seconds a request gets removed from the rolling window. (so on average maximum of 3 requests per second won't get rate limited). There are different types of ratelimiting in VRM. If you receive a 429 with a JSON response, you can check the Retry-After response header to check the amount of seconds you have to wait until retrying.  ## WARNING & DISCLAIMER Whilst publicly available, Victron Energy does not offer support to professional customers or end-users that implement features using the here documented functionality, except in really specific situations (i.e such as a special arrangement with a large OEM customer).  The recommended method for support on the VRM API is to use the Modifications section on Victron Community. This space is frequently visited by many people using the API, and other methods of integrating with Victron products. Direct company support is only offered on a limited basis via your Victron representative.
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using Xunit;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInner
        //private InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInner instance;

        public InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInnerTests()
        {
            // TODO uncomment below to create an instance of InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInner
            //instance = new InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInner
        /// </summary>
        [Fact]
        public void InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInner
            //Assert.IsType<InstallationsIdSiteDynamicEssSettingsGet200ResponseDataBuyPriceScheduleInnerScheduleInner>(instance);
        }

        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            // TODO unit test for the property 'From'
        }

        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            // TODO unit test for the property 'To'
        }

        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Fact]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }
    }
}
