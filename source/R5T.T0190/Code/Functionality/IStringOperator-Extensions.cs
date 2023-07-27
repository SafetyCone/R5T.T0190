using System;

using R5T.T0132;


namespace R5T.T0190.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ICloudDirectoryPath"/>
        public ICloudDirectoryPath ToCloudDirectoryPath(string value)
        {
            var output = new CloudDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="ILocalDirectoryPath"/>
        public ILocalDirectoryPath ToLocalDirectoryPath(string value)
        {
            var output = new LocalDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="INetworkDirectoryPath"/>
        public INetworkDirectoryPath ToNetworkDirectoryPath(string value)
        {
            var output = new NetworkDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="ISharedDirectoryPath"/>
        public ISharedDirectoryPath ToSharedDirectoryPath(string value)
        {
            var output = new SharedDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IRemoteDirectoryPath"/>
        public IRemoteDirectoryPath ToRemoteDirectoryPath(string value)
        {
            var output = new RemoteDirectoryPath(value);
            return output;
        }
    }
}
