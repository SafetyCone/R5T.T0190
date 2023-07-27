using System;

using R5T.T0178;


namespace R5T.T0190
{
    /// <summary>
    /// Strongly-types a string as a shared directory path.
    /// <para>
    /// Shared directories are local directories that are accessible to multiple users.
    /// </para>
    /// Note: not all shared directories are cloud directories!While cloud directories (like Dropbox) are generally the best way to share directories,
    /// there can be shared drives that are directly accessible by multiple people, but are not accessible from the internet.
    /// </summary>
    [StrongTypeMarker]
    public interface ISharedDirectoryPath : IStrongTypeMarker,
        ILocalDirectoryPath
    {
    }
}