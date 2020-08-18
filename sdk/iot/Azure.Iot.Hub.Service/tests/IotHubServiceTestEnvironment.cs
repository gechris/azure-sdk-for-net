// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Iot.Hub.Service.Tests
{
    // This class contains the configurations required to be set to run tests against the CI pipeline.
    public class IotHubServiceTestEnvironment : TestEnvironment
    {
        public IotHubServiceTestEnvironment()
            : base(TestSettings.IotHubEnvironmentVariablesPrefix.ToLower())
        {
        }

        public string IotHubConnectionString => GetRecordedVariable(TestSettings.IotHubConnectionString, options => options
            .HasSecretConnectionStringParameter("SharedAccessKey")
            .HasSecretConnectionStringParameter("HostName", CustomRequestSanitizer.FAKE_HOST));

        public string StorageConnectionString => GetRecordedVariable(TestSettings.StorageConnectionString, options => options
            .HasSecretConnectionStringParameter("AccountKey")
            .HasSecretConnectionStringParameter("AccountName", CustomRequestSanitizer.FAKE_STORAGE_ACCOUNT_NAME));
    }
}
