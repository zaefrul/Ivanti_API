using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_SOAP_REST_SVC.Model
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TicketID { get; set; }
        public string IncidentNumber { get; set; }
        public string ServiceType { get; set; }
        public string Description { get; set; }
        public string Severity { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerMailID { get; set; }
        public string IncidentStatus { get; set; }
        public string CRMID { get; set; }
        public string SSMSPOC { get; set; }
    }
}
