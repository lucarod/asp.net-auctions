﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
  public DbSet<Auction> Auctions { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite(@"Data Source=D:\code\courses\nlw-expert\RocketseatAuction\src\RocketseatAuction.API\leilaoDbNLW.db");
  }
}
