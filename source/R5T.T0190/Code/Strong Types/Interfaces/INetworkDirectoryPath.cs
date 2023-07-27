using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0190
{
    /// <summary>
    /// Strongly-types a string as a network directory path.
    /// <para>
    /// Network directory paths point to locations on network drives.
    /// </para>
    /// Network drives may or may not be available since they are not physically located on the currently running machine.
    /// </summary>
    /// <remarks>
    /// The <see cref="ILocalDirectoryPath"/>, <see cref="INetworkDirectoryPath"/> and <see cref="IRemoteDirectoryPath"/> types are all siblings.
    /// </remarks>
    [StrongTypeMarker]
    public interface INetworkDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}
