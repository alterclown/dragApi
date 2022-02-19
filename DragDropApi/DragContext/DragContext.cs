using DragDropApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DragDropApi.DragDropContext
{
    public class DragContext : DbContext
    {
        public DragContext(DbContextOptions<DragContext> options) : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}

        //Add Db set Class Here
        public DbSet<MoveItem> MoveItems { get; set; }
        public DbSet<TransferItem> TransferItems { get; set; }
    }
}
