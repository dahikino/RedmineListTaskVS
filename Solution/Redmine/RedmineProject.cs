using System;

namespace Redmine
{
    public class RedmineProject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public int ParentId { get; set; }
        public string ParentName { get; set; }
    }
}