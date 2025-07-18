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
    ///  Class for testing InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValue
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValueTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValue
        //private InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValue instance;

        public InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValueTests()
        {
            // TODO uncomment below to create an instance of InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValue
            //instance = new InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValue();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValue
        /// </summary>
        [Fact]
        public void InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValueInstanceTest()
        {
            // TODO uncomment below to test "IsType" InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValue
            //Assert.IsType<InstallationsIdSiteWidgetsBatterySummary200ResponseRecordsDataValue>(instance);
        }

        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }

        /// <summary>
        /// Test the property 'DataAttributeName'
        /// </summary>
        [Fact]
        public void DataAttributeNameTest()
        {
            // TODO unit test for the property 'DataAttributeName'
        }

        /// <summary>
        /// Test the property 'DataType'
        /// </summary>
        [Fact]
        public void DataTypeTest()
        {
            // TODO unit test for the property 'DataType'
        }

        /// <summary>
        /// Test the property 'DbusPath'
        /// </summary>
        [Fact]
        public void DbusPathTest()
        {
            // TODO unit test for the property 'DbusPath'
        }

        /// <summary>
        /// Test the property 'DbusServiceType'
        /// </summary>
        [Fact]
        public void DbusServiceTypeTest()
        {
            // TODO unit test for the property 'DbusServiceType'
        }

        /// <summary>
        /// Test the property 'FormatValueOnly'
        /// </summary>
        [Fact]
        public void FormatValueOnlyTest()
        {
            // TODO unit test for the property 'FormatValueOnly'
        }

        /// <summary>
        /// Test the property 'FormatWithUnit'
        /// </summary>
        [Fact]
        public void FormatWithUnitTest()
        {
            // TODO unit test for the property 'FormatWithUnit'
        }

        /// <summary>
        /// Test the property 'FormattedValue'
        /// </summary>
        [Fact]
        public void FormattedValueTest()
        {
            // TODO unit test for the property 'FormattedValue'
        }

        /// <summary>
        /// Test the property 'HasOldData'
        /// </summary>
        [Fact]
        public void HasOldDataTest()
        {
            // TODO unit test for the property 'HasOldData'
        }

        /// <summary>
        /// Test the property 'IdDataAttribute'
        /// </summary>
        [Fact]
        public void IdDataAttributeTest()
        {
            // TODO unit test for the property 'IdDataAttribute'
        }

        /// <summary>
        /// Test the property 'Instance'
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO unit test for the property 'Instance'
        }

        /// <summary>
        /// Test the property 'IsKeyDataAttribute'
        /// </summary>
        [Fact]
        public void IsKeyDataAttributeTest()
        {
            // TODO unit test for the property 'IsKeyDataAttribute'
        }

        /// <summary>
        /// Test the property 'IsValid'
        /// </summary>
        [Fact]
        public void IsValidTest()
        {
            // TODO unit test for the property 'IsValid'
        }

        /// <summary>
        /// Test the property 'RawValue'
        /// </summary>
        [Fact]
        public void RawValueTest()
        {
            // TODO unit test for the property 'RawValue'
        }

        /// <summary>
        /// Test the property 'SecondsAgo'
        /// </summary>
        [Fact]
        public void SecondsAgoTest()
        {
            // TODO unit test for the property 'SecondsAgo'
        }

        /// <summary>
        /// Test the property 'SecondsToNextLog'
        /// </summary>
        [Fact]
        public void SecondsToNextLogTest()
        {
            // TODO unit test for the property 'SecondsToNextLog'
        }

        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }

        /// <summary>
        /// Test the property 'ValueFormattedWithUnit'
        /// </summary>
        [Fact]
        public void ValueFormattedWithUnitTest()
        {
            // TODO unit test for the property 'ValueFormattedWithUnit'
        }

        /// <summary>
        /// Test the property 'NameEnum'
        /// </summary>
        [Fact]
        public void NameEnumTest()
        {
            // TODO unit test for the property 'NameEnum'
        }

        /// <summary>
        /// Test the property 'ValueEnum'
        /// </summary>
        [Fact]
        public void ValueEnumTest()
        {
            // TODO unit test for the property 'ValueEnum'
        }

        /// <summary>
        /// Test the property 'ValueFloat'
        /// </summary>
        [Fact]
        public void ValueFloatTest()
        {
            // TODO unit test for the property 'ValueFloat'
        }

        /// <summary>
        /// Test the property 'ValueFormattedValueOnly'
        /// </summary>
        [Fact]
        public void ValueFormattedValueOnlyTest()
        {
            // TODO unit test for the property 'ValueFormattedValueOnly'
        }

        /// <summary>
        /// Test the property 'ValueString'
        /// </summary>
        [Fact]
        public void ValueStringTest()
        {
            // TODO unit test for the property 'ValueString'
        }

        /// <summary>
        /// Test the property 'DataAttributeEnumValues'
        /// </summary>
        [Fact]
        public void DataAttributeEnumValuesTest()
        {
            // TODO unit test for the property 'DataAttributeEnumValues'
        }
    }
}
