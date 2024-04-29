using Microsoft.EntityFrameworkCore;
using Module9_1302220064;

class MahasiswaDB : DbContext
{
    public MahasiswaDB (DbContextOptions<MahasiswaDB> options)
        : base(options) { }

    public DbSet<Mahasiswa> Todos => Set<Mahasiswa>();
}
