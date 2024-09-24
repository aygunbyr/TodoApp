using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ConsoleUI.Models
{
    public sealed class Todo : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate {  get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int UserId { get; set; }
        public bool IsCompleted { get; set; }
        public string Priority { get; set; }

        public Todo()
        {
            
        }

        public Todo(int id, string title, string description, DateTime createdDate, string startDate, string endDate, int userId, bool ısCompleted, string priority) : base(id)
        {
            Title = title;
            Description = description;
            CreatedDate = createdDate;
            StartDate = startDate;
            EndDate = endDate;
            UserId = userId;
            IsCompleted = ısCompleted;
            Priority = priority;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Description: {Description}, Created Date: {CreatedDate}, Start Date: {StartDate}, " +
                $"End Date: {EndDate}, UserId: {UserId}, Is Completed: {(IsCompleted ? "Completed" : "Not Completed")}, Priority: {Priority}";
        }
    }
}
