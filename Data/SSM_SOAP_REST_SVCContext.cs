using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSM_SOAP_REST_SVC.Model;

namespace SSM_SOAP_REST_SVC.Models
{
    public class SSM_SOAP_REST_SVCContext : DbContext
    {
        public SSM_SOAP_REST_SVCContext (DbContextOptions<SSM_SOAP_REST_SVCContext> options)
            : base(options)
        {
        }

        public DbSet<SSM_SOAP_REST_SVC.Model.Ticket> Ticket { get; set; }
    }
}
