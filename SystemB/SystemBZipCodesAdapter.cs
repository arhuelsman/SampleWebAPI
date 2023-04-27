using Core.Facade.Interfaces;
using Implementation.Domain;

namespace SystemB
{
    public class SystemBZipCodesAdapter : IAdapter<ZipCodesResponse>
    {
        public Task<ZipCodesResponse> Handle()
        {
            // Perform data retrieval in whatever way, and map the result to the response
            return Task.FromResult(new ZipCodesResponse
            {
                SupportedZipCodes = new[]
                {
                    98878,
                    78641,
                    31234,
                    77866
                }
            });
        }

        public bool HandlesSourceSystem(string? sourceSystem)
        {
            return sourceSystem == "SystemB";
        }
    }
}