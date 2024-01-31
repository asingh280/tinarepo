using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinaKingSystem.ViewModels
{
    public class PackageView
    {
        public int packageID { get; set; }
        public int ClientID { get; set; }
        public int PackageNumber { get; set; }
        public string TypeOfRequest { get; set; }
        public List<DocumentView> DocumentDetails { get; set; }
        public string Priority { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int FollowUpPackage { get; set; }
    }
}
