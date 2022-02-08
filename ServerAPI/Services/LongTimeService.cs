using ServerAPI.IServices;

namespace ServerAPI.Services
{
    public class LongTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToLongTimeString();
    }
}
