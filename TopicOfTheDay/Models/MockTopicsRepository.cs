using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopicDay.Models
{
    public class MockTopicsRepository
    {
        private List<Topics> _topicsList;
        public MockTopicsRepository()
        {
            _topicsList = new List<Topics>()
            {
                new Topics() {id=1, name="Acedamics",  IsAvailable = Available.Yes, NumberOfTopicsAvailable=3},
                new Topics() {id=2, name="Adminstration",  IsAvailable = Available.Yes, NumberOfTopicsAvailable=2},
                new Topics() {id=1, name="Employeement",  IsAvailable = Available.No, NumberOfTopicsAvailable=5}

            };

        }
        public Topics Add(Topics topic)
        {
            topic.id = _topicsList.Max(e => e.id) + 1;
            _topicsList.Add(topic);
            return topic;
        }

        public Topics Delete(int id)
        {
            Topics topic = _topicsList.FirstOrDefault(e => e.id == id);
            if (topic != null)
            {
                _topicsList.Remove(topic);
            }
            return topic;
        }

        public IEnumerable<Topics> GetAllTopics()
        {
            return _topicsList;
        }

        public Topics GetTopics(int Id)
        {
            return _topicsList.FirstOrDefault(e => e.id == Id);
        }

        public Topics UpdateTopics(Topics topicChanges)
        {
            Topics topic = _topicsList.FirstOrDefault(e => e.id == topicChanges.id);
            if (topic != null)
            {
                topic.name = topicChanges.name;
                topic.NumberOfTopicsAvailable = topicChanges.NumberOfTopicsAvailable;
                topic.IsAvailable = topicChanges.IsAvailable;
            }
            return topic;
        }
    }
}
