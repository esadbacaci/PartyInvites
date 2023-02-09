using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class baglanti_context:DbContext
    {
        public baglanti_context(DbContextOptions<baglanti_context>options)
            : base(options) { }
        public DbSet<GuestResponse> guestResponses { get; set; }   
    }
}
