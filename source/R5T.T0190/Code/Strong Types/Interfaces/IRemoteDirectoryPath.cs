using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0190
{
    /// <summary>
    /// Strongly-types a string as the path of a directory on a remote drive.
    /// <para>
    /// Remote remote drives are not directly accessible from the current machine (like network drives), but instead instead might require logins and specific file transfer protocols (like SFTP).
    /// </para>
    /// </summary>
    /// <inheritdoc cref="INetworkDirectoryPath" path="/remarks"/>
    [StrongTypeMarker]
    public interface IRemoteDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}