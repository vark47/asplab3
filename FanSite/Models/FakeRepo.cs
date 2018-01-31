using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class FakeRepo : IRepository
    {
        private static FakeRepo sharedRepository = new FakeRepo();
        private Dictionary<string, Story> stories
            = new Dictionary<string, Story>();

        public static FakeRepo SharedRepository => sharedRepository;

        public FakeRepo()
        {
            var initialItems = new[] {
                new Story { Title = "A Thing", Date = new DateTime(2002, 10, 18), Body = "A Thing Happened"  },
                new Story { Title = "A Thing2", Date = new DateTime(2002, 10, 18), Body = "A Thing Happened"  },
                new Story { Title = "A Thing3", Date = new DateTime(2002, 10, 18), Body = "A Thing Happened"  },
                new Story { Title = "A Thing4", Date = new DateTime(2002, 10, 18), Body = "A Thing Happened"  },
                new Story { Title = "A Thing5", Date = new DateTime(2002, 10, 18), Body = "A Thing Happened"  }
            };
            foreach (var s in initialItems)
            {
                AddStory(s);
            }
            stories.Add("Error", null);
        }

        public IEnumerable<Story> Stories => stories.Values;

        public void AddStory(Story s) => stories.Add(s.Title, s);
    }
}

