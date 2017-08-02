/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Test
{
    /// <summary>
    ///  Class for testing LabelsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LabelsApiTests
    {
        private LabelsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LabelsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LabelsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LabelsApi
            //Assert.IsInstanceOfType(typeof(LabelsApi), instance, "instance is a LabelsApi");
        }

        
        /// <summary>
        /// Test LabelsGet
        /// </summary>
        [Test]
        public void LabelsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string labelId = null;
            //string apiKey = null;
            //var response = instance.LabelsGet(labelId, apiKey);
            //Assert.IsInstanceOf<Label> (response, "response is Label");
        }
        
        /// <summary>
        /// Test LabelsList
        /// </summary>
        [Test]
        public void LabelsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKey = null;
            //string batchId = null;
            //string labelStatus = null;
            //string carrierId = null;
            //string serviceCode = null;
            //string trackingNumber = null;
            //string warehouseId = null;
            //DateTime? createdAtStart = null;
            //DateTime? createdAtEnd = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortDir = null;
            //string sortBy = null;
            //var response = instance.LabelsList(apiKey, batchId, labelStatus, carrierId, serviceCode, trackingNumber, warehouseId, createdAtStart, createdAtEnd, page, pageSize, sortDir, sortBy);
            //Assert.IsInstanceOf<ListLabelResponse> (response, "response is ListLabelResponse");
        }
        
        /// <summary>
        /// Test LabelsPurchaseLabel
        /// </summary>
        [Test]
        public void LabelsPurchaseLabelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PurchaseLabelRequest request = null;
            //string apiKey = null;
            //var response = instance.LabelsPurchaseLabel(request, apiKey);
            //Assert.IsInstanceOf<Label> (response, "response is Label");
        }
        
        /// <summary>
        /// Test LabelsPurchaseLabelWithRate
        /// </summary>
        [Test]
        public void LabelsPurchaseLabelWithRateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rateId = null;
            //PurchaseLabelWithoutShipmentRequest request = null;
            //string apiKey = null;
            //var response = instance.LabelsPurchaseLabelWithRate(rateId, request, apiKey);
            //Assert.IsInstanceOf<Label> (response, "response is Label");
        }
        
        /// <summary>
        /// Test LabelsPurchaseLabelWithShipment
        /// </summary>
        [Test]
        public void LabelsPurchaseLabelWithShipmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string shipmentId = null;
            //PurchaseLabelWithoutShipmentRequest request = null;
            //string apiKey = null;
            //var response = instance.LabelsPurchaseLabelWithShipment(shipmentId, request, apiKey);
            //Assert.IsInstanceOf<Label> (response, "response is Label");
        }
        
        /// <summary>
        /// Test LabelsTrack
        /// </summary>
        [Test]
        public void LabelsTrackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string labelId = null;
            //string apiKey = null;
            //var response = instance.LabelsTrack(labelId, apiKey);
            //Assert.IsInstanceOf<TrackingInformation> (response, "response is TrackingInformation");
        }
        
        /// <summary>
        /// Test LabelsVoidLabel
        /// </summary>
        [Test]
        public void LabelsVoidLabelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string labelId = null;
            //string apiKey = null;
            //var response = instance.LabelsVoidLabel(labelId, apiKey);
            //Assert.IsInstanceOf<VoidLabelResponse> (response, "response is VoidLabelResponse");
        }
        
    }

}
