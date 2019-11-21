using Microsoft.Azure.Storage.Blob;

namespace NetCore.AzureBlobFileProvider
{
    public interface IBlobContainerFactory
    {
        CloudBlobContainer GetContainer(string subpath);
        string TransformPath(string subpath);
    }
}
