using System;


namespace R5T.T0190.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToCloudDirectoryPath(string)"/>
        public static ICloudDirectoryPath ToCloudDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToCloudDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToLocalDirectoryPath(string)"/>
        public static ILocalDirectoryPath ToLocalDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToLocalDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToNetworkDirectoryPath(string)"/>
        public static INetworkDirectoryPath ToNetworkDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToNetworkDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToSharedDirectoryPath(string)"/>
        public static ISharedDirectoryPath ToSharedDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToSharedDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToRemoteDirectoryPath(string)"/>
        public static IRemoteDirectoryPath ToRemoteDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToRemoteDirectoryPath(value);
        }
    }
}
