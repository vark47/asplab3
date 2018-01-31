using System.Collections.Generic;
namespace FanSite.Models
{
    public static class Repository
    {
        private static List<StoryResponse> responses = new List<StoryResponse>();
        public static IEnumerable<StoryResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(StoryResponse response)
        {
            responses.Add(response);
        }
    }
}