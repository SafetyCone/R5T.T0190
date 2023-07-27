using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0190
{
    /// <inheritdoc cref="IRemoteDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class RemoteDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IRemoteDirectoryPath
    {
        public RemoteDirectoryPath(string value)
            : base(value)
        {
        }
    }
}