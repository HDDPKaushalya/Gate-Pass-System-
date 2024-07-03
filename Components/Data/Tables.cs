using System.ComponentModel.DataAnnotations;

namespace Getpass.Components.Data
{
    public class Tables
    {
        [Key]
        public int VRn { get; set; }
        public DateOnly? DateOnly { get; set; }
        public TimeOnly? TimeRecived { get; set; }
        public string  DName { get; set; }
        public string  Reason { get; set; }
        public string Auth { get; set; }
        public string  VNumber { get; set; }
        public string Dest { get; set; }
        public string Sign { get; set; }

    }
    public class DriverPool
    {

        [Key]
        public int EPF { get; set; }
        public string  Name { get; set; }
        public string  IDNo { get; set; }
        public string  BDay { get; set; }
        public string  Address { get; set; }
        public int    landNo { get; set; }
        public int    cellNo { get; set; }
        public string DLNo { get; set; }

        internal static object AsNoTracking()
        {
            throw new NotImplementedException();
        }
    }
    public class Vnum
    {
        public string VehicleNumber { get; set; }
    }
}
