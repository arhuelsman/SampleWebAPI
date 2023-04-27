using Core.Facade.Interfaces;
using Implementation.Domain;

namespace SystemA
{
    public class SystemAZipCodesAdapter : IAdapter<ZipCodesResponse>
    {
        public Task<ZipCodesResponse> Handle()
        {
            // Perform data retrieval in whatever way, and map the result to the response
            return Task.FromResult(new ZipCodesResponse
            {
                SupportedZipCodes = new[]
                {
                    12345,
                    45235,
                    78564
                }
            });
        }

        public bool HandlesSourceSystem(string? sourceSystem)
        {
            return sourceSystem == "SystemA";
        }
    }
}