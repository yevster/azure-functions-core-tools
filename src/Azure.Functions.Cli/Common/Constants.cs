using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Azure.Functions.Cli.Common
{
    internal static class Constants
    {
        public const string StorageConnectionStringTemplate = "DefaultEndpointsProtocol=https;AccountName={0};AccountKey={1}";
        public const string FunctionsStorageAccountNamePrefix = "AzureFunctions";
        public const string StorageAccountArmType = "Microsoft.Storage/storageAccounts";
        public const string FunctionAppArmKind = "functionapp";
        public const string CliDebug = "CLI_DEBUG";
        public const string DefaultSqlProviderName = "System.Data.SqlClient";
        public const string WebsiteHostname = "WEBSITE_HOSTNAME";
        public const int NodeDebugPort = 5858;
        public const int JavaDebugPort = 5005;
        public const string DotNetClrProcessId = @"${command:pickProcess}";
        public const string FuncIgnoreFile = ".funcignore";
        public const string FunctionsWorkerRuntime = "FUNCTIONS_WORKER_RUNTIME";
        public const string RequirementsTxt = "requirements.txt";
        public const string FunctionJsonFileName = "function.json";
        public const string DefaultVEnvName = "worker_env";
        public const string ExternalPythonPackages = ".python_packages";
        public const string FunctionsExtensionVersion = "FUNCTIONS_EXTENSION_VERSION";
        public const string StorageEmulatorConnectionString = "UseDevelopmentStorage=true";
        public const string AzureWebJobsStorage = "AzureWebJobsStorage";

        public static string CliVersion => typeof(Constants).GetTypeInfo().Assembly.GetName().Version.ToString(3);
        public static string CliBetaRevision => typeof(Constants).GetTypeInfo().Assembly.GetName().Version.MinorRevision.ToString();

        public static string CliDisplayVersion => $"{Constants.CliVersion}-beta.{Constants.CliBetaRevision}";


        public static class Errors
        {
            public const string NoRunningInstances = "No running instances";
            public const string PidAndAllAreMutuallyExclusive = "-p/--processId and -a/--all are mutually exclusive";
            public const string EitherPidOrAllMustBeSpecified = "Must specify either -a/--all or -p/--processId <Pid>";
        }

        public static class ArmConstants
        {
            public const string AADAuthorityBase = "https://login.microsoftonline.com";
            public const string CommonAADAuthority = "https://login.microsoftonline.com/common";
            public const string ArmAudience = "https://management.core.windows.net/";
            public const string ArmDomain = "https://management.azure.com/";
            public const string AADClientId = "1950a258-227b-4e31-a9cf-717495945fc2";
        }

        public static class DockerImages
        {
            public const string LinuxPythonImageAmd64 = "mcr.microsoft.com/azure-functions/python:2.0";
        }

        public static class StaticResourcesNames
        {
            public const string PythonDockerBuild = "python_docker_build.sh";
        }

        public static ExtensionPackage ExtensionsMetadataGeneratorPackage => new ExtensionPackage { Name = "Microsoft.Azure.WebJobs.Script.ExtensionsMetadataGenerator", Version = "1.0.0" };

        public static IDictionary<string, ExtensionPackage> BindingPackageMap { get; } = new ReadOnlyDictionary<string, ExtensionPackage>(
                new Dictionary<string, ExtensionPackage> {
                    { "blobtrigger",
                        new ExtensionPackage() {
                        Name = "Microsoft.Azure.WebJobs.Extensions.Storage",
                        Version =  "3.0.0-rc1" }
                    },
                    { "blob",
                        new ExtensionPackage() {
                        Name = "Microsoft.Azure.WebJobs.Extensions.Storage",
                        Version =  "3.0.0-rc1" }
                    },
                    { "queue",
                        new ExtensionPackage() {
                        Name = "Microsoft.Azure.WebJobs.Extensions.Storage",
                        Version =  "3.0.0-rc1" }
                    },
                    { "queuetrigger",
                        new ExtensionPackage() {
                        Name = "Microsoft.Azure.WebJobs.Extensions.Storage",
                        Version =  "3.0.0-rc1" }
                    },
                    { "servicebustrigger",
                        new ExtensionPackage() {
                        Name = "Microsoft.Azure.WebJobs.ServiceBus",
                        Version =  "3.0.0-rc1" }
                    },
                    { "servicebus",
                        new ExtensionPackage() {
                        Name = "Microsoft.Azure.WebJobs.ServiceBus",
                        Version =  "3.0.0-rc1" }
                    },
                    { "eventhubtrigger",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.EventHubs",
                            Version =  "3.0.0-rc1"} },
                    { "eventhub",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.EventHubs",
                            Version =  "3.0.0-rc1"} },
                    { "sendgrid",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.SendGrid",
                            Version =  "3.0.0-rc1" } },
                    { "token",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.MicrosoftGraph",
                            Version =  "1.0.0-beta5"} },
                     { "excel",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.MicrosoftGraph",
                            Version =  "1.0.0-beta5"} },
                    { "outlook",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.MicrosoftGraph",
                            Version =  "1.0.0-beta5"} },
                    { "graphwebhooksubscription",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.MicrosoftGraph",
                            Version =  "1.0.0-beta5"} },
                    { "onedrive",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.MicrosoftGraph",
                            Version =  "1.0.0-beta5"} },
                    { "graphwebhooktrigger",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.MicrosoftGraph",
                            Version =  "1.0.0-beta5"} },
                    { "activitytrigger",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.DurableTask",
                            Version =  "1.6.1"} },
                    { "orchestrationtrigger",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.DurableTask",
                            Version =  "1.6.1"} },
                    { "orchestrationclient",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.DurableTask",
                            Version =  "1.6.1"} },
                    { "eventgridtrigger",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.EventGrid",
                            Version =  "2.0.0-rc1"} },
                    { "cosmosdbtrigger",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.CosmosDB",
                            Version =  "3.0.1-rc1"} },
                    { "cosmosdb",
                        new ExtensionPackage() {
                            Name = "Microsoft.Azure.WebJobs.Extensions.CosmosDB",
                            Version =  "3.0.1-rc1"} }
                });
    }
}