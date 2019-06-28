using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;

namespace ConsolApp
{
    public class AzureStorage
    {
        // Parse the connection string and return a reference to the storage account.
        public CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
            CloudConfigurationManager.GetSetting("StorageConnectionString"));
        
        ////public CloudBlobClient blobClient = CloudStorageAccount.DevelopmentStorageAccount.CreateCloudBlobClient();
        ////// Retrieve a reference to a container.
        ////CloudBlobContainer container = blobClient.GetContainerReference("appimages");

        //////// Create the container if it doesn't already exist.
        ////Container.CreateIfNotExists();
    }
}
