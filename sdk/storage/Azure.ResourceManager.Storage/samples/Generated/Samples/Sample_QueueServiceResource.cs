// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Storage.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Storage.Samples
{
    public partial class Sample_QueueServiceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QueueServicesGet()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2024-01-01/examples/QueueServicesGet.json
            // this example is just showing the usage of "QueueServices_GetServiceProperties" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QueueServiceResource created on azure
            // for more information of creating QueueServiceResource, please refer to the document of QueueServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res4410";
            string accountName = "sto8607";
            ResourceIdentifier queueServiceResourceId = QueueServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            QueueServiceResource queueService = client.GetQueueServiceResource(queueServiceResourceId);

            // invoke the operation
            QueueServiceResource result = await queueService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QueueServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_QueueServicesPut()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2024-01-01/examples/QueueServicesPut.json
            // this example is just showing the usage of "QueueServices_SetServiceProperties" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QueueServiceResource created on azure
            // for more information of creating QueueServiceResource, please refer to the document of QueueServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res4410";
            string accountName = "sto8607";
            ResourceIdentifier queueServiceResourceId = QueueServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            QueueServiceResource queueService = client.GetQueueServiceResource(queueServiceResourceId);

            // invoke the operation
            QueueServiceData data = new QueueServiceData
            {
                CorsRules = { new StorageCorsRule(new string[] { "http://www.contoso.com", "http://www.fabrikam.com" }, new CorsRuleAllowedMethod[] { CorsRuleAllowedMethod.Get, CorsRuleAllowedMethod.Head, CorsRuleAllowedMethod.Post, CorsRuleAllowedMethod.Options, CorsRuleAllowedMethod.Merge, CorsRuleAllowedMethod.Put }, 100, new string[] { "x-ms-meta-*" }, new string[] { "x-ms-meta-abc", "x-ms-meta-data*", "x-ms-meta-target*" }), new StorageCorsRule(new string[] { "*" }, new CorsRuleAllowedMethod[] { CorsRuleAllowedMethod.Get }, 2, new string[] { "*" }, new string[] { "*" }), new StorageCorsRule(new string[] { "http://www.abc23.com", "https://www.fabrikam.com/*" }, new CorsRuleAllowedMethod[] { CorsRuleAllowedMethod.Get, CorsRuleAllowedMethod.Put }, 2000, new string[] { "x-ms-meta-abc", "x-ms-meta-data*", "x-ms-meta-target*" }, new string[] { "x-ms-meta-12345675754564*" }) },
            };
            ArmOperation<QueueServiceResource> lro = await queueService.CreateOrUpdateAsync(WaitUntil.Completed, data);
            QueueServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QueueServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
