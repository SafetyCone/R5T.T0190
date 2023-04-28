using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0190
{
    /// <inheritdoc cref="ICloudDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class CloudDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        ICloudDirectoryPath
    {
        public CloudDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
