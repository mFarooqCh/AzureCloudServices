//using Azure.Identity;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;

string connectionString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING", EnvironmentVariableTarget.Machine);
if (string.IsNullOrWhiteSpace(connectionString))
{
    Console.WriteLine("Please enter a storage account connection string in Machine's environment variable 'AZURE_STORAGE_CONNECTION_STRING'");
}

BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
