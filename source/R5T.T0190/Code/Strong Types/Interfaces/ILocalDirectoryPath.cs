using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0190
{
    /// <summary>
    /// Strongly-types a string as a local directory path.
    /// <para>Local directory paths point to locations on the local file-system.</para>
    /// </summary>
    [StrongTypeMarker]
    public interface ILocalDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}
