using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopicDay.Models
{
    public interface ITopicsRepository
    {
        Topics GetTopics(int Id);
        IEnumerable<Topics> GetAllTopics();
        Topics Add(Topics topic);   
        Topics UpdateTopics(Topics topic);
        Topics Delete(int id);
    }
}
