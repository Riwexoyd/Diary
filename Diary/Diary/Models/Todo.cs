﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Diary.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Notes { get; set; }

        public bool Completed { get; set; }

        public List<TodoTag> TodoTags { get; set; }

        public Todo()
        {
            TodoTags = new List<TodoTag>();
        }
    }

    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Title).IsRequired(true);
        }
    }
}
