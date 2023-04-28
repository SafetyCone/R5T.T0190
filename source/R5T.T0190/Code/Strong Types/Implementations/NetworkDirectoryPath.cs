using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0190
{
    /// <inheritdoc cref="INetworkDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class NetworkDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        INetworkDirectoryPath
    {
        public NetworkDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
