using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public interface IRepository
    {

        IEnumerable<Story> Stories { get; }
       void AddStory(Story s);
    }
}

