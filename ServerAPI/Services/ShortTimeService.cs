using ServerAPI.IServices;

namespace ServerAPI.Services
{
    public class ShortTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToShortTimeString();
    }
}
