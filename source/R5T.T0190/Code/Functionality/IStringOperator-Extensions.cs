using System;

using R5T.T0132;


namespace R5T.T0190.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public ICloudDirectoryPath ToCloudDirectoryPath(string value)
        {
            var output = new CloudDirectoryPath(value);
            return output;
        }

        public ILocalDirectoryPath ToLocalDirectoryPath(string value)
        {
            var output = new LocalDirectoryPath(value);
            return output;
        }

        public INetworkDirectoryPath ToNetworkDirectoryPath(string value)
        {
            var output = new NetworkDirectoryPath(value);
            return output;
        }
    }
}
