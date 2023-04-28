using System;


namespace R5T.T0190.Extensions
{
    public static class StringExtensions
    {
        public static ICloudDirectoryPath ToCloudDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToCloudDirectoryPath(value);
        }

        public static ILocalDirectoryPath ToLocalDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToLocalDirectoryPath(value);
        }

        public static INetworkDirectoryPath ToNetworkDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToNetworkDirectoryPath(value);
        }
    }
}
