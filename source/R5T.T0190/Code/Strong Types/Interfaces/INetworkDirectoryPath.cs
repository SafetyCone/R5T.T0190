using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0190
{
    /// <summary>
    /// Strongly-types a string as a network directory path.
    /// <para>Local directory paths point to locations on network drives.</para>
    /// Network drives may or may not be available.
    /// </summary>
    [StrongTypeMarker]
    public interface INetworkDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}
