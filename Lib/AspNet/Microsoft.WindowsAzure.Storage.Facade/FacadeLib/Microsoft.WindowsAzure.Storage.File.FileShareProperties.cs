using Microsoft.WindowsAzure.Storage.Core.Util;
using System;
namespace Microsoft.WindowsAzure.Storage.File
{
public sealed class FileShareProperties
{

    public string ETag
    {
        get; internal set;
    }

    public DateTimeOffset? LastModified
    {
        get; internal set;
    }

    public int? Quota
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
            throw new System.NotImplementedException();
        }
    }
}

}