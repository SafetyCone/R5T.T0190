using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0190
{
    /// <inheritdoc cref="ILocalDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class LocalDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        ILocalDirectoryPath
    {
        public LocalDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
