using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0190
{
    /// <inheritdoc cref="ISharedDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class SharedDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        ISharedDirectoryPath
    {
        public SharedDirectoryPath(string value)
            : base(value)
        {
        }
    }
}