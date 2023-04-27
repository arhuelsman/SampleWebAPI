using Core.Facade;
using Core.Facade.Interfaces;
using Implementation.Domain;

namespace Implementation.Facades
{
    public class ZipCodesFacade : Facade<ZipCodesResponse>
    {
        public ZipCodesFacade(IEnumerable<IAdapter<ZipCodesResponse>> adapters) : base(adapters)
        {
        }
    }
}
