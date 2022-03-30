using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopicDay.Models
{
    public class SQLTopicRepo : ITopicsRepository
    {
        private readonly AppDbContext context;
        public SQLTopicRepo(AppDbContext context)
        {
            this.context = context;
        }

        public Topics Add(Topics Topic)
        {
            context.Topic.Add(Topic);
            context.SaveChanges();
            return Topic;
        }

        public Topics Delete(int id)
        {
            Topics Topic = context.Topic.Find(id);
            if (Topic != null)
            {
                context.Topic.Remove(Topic);
                context.SaveChanges();
            }
            return Topic;
        }

        public IEnumerable<Topics> GetAllTopics()
        {
            return context.Topic;
        }

        public Topics GetTopics(int Id)
        {
            return context.Topic.Find(Id);
        }

        public Topics UpdateTopics(Topics Topic)
        {
            var TopicChanges = context.Topic.Attach(Topic);
            TopicChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Topic;
        }
    }
}