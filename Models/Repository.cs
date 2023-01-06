using System.Collections.Generic;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> _response = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses => _response;

        public static void AddResponse(GuestResponse response)
        {
            _response.Add(response);
        }
    }
}
