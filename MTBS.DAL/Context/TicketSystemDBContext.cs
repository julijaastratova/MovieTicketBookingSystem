using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTBS.Library;
using Microsoft.EntityFrameworkCore;




namespace MTBS.DAL.Context : DbContext
 {
    public class TicketSystemDBContext
{
    public DbSet<Ticket> Car { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-HOMTD73\SQLEXPRESS02;Database=MovieTicketBookingSystemDB;Integrated Security=true; ");
}
}
