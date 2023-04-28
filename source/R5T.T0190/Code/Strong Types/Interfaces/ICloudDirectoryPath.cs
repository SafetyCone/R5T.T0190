using System;

using R5T.T0178;


namespace R5T.T0190
{
    /// <summary>
    /// Strongly-types a string as a cloud directory path.
    /// <para>Cloud directory paths point to local directories that are backed up to the cloud (like a Dropbox directory).</para>
    /// </summary>
    [StrongTypeMarker]
    public interface ICloudDirectoryPath : IStrongTypeMarker,
        ILocalDirectoryPath
    {
    }
}
