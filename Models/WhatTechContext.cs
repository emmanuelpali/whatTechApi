using Microsoft.EntityFrameworkCore;

namespace whatTechAPI.Models;

public class WhatTechContext : DbContext
{
    public WhatTechContext(DbContextOptions<WhatTechContext> options) : base(options){}

    public DbSet<BlogPost> BlogPosts {get; set;} = null!;
}