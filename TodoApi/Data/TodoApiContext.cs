using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models.Entities;

namespace TodoApi.Data
{
    public class TodoApiContext : DbContext
    {
        public TodoApiContext (DbContextOptions<TodoApiContext> options)
            : base(options)
        {
        }

        public DbSet<TodoApi.Models.Entities.Todo> Todo { get; set; } = default!;
    }
}
