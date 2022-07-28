using System;
using System.Collections.Generic;

namespace BlogManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
    class Blog
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public BlogStatus Status { get; set; }
        public string[] Tags { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        public Blog(string title, string description, BlogStatus status, params string[] tags)
        {
            Title = title;
            Description = description;
            Status = status;
            Tags = tags;
        }
    }
    enum BlogStatus
    {
        Sended = 0,
        Approved = 1,
        Rejected = 2,
    }
}
