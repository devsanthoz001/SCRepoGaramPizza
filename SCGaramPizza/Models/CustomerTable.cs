using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCGaramPizza.Models
{

    public partial class CustomerTable
    {
        [Required]
        [Column("CusName")]
        public string CusName { get; set; }
        [Column("CusMobile")]
        public string CusMobile { get; set; }
        [Column("CusAddress")]
        public string CusAddress { get; set; }

        public string Columns()
        {
            return $"|CusName|CusMobile|CusAddress|";
        }

        public override string ToString()
        {
            return $"{CusName}|{CusMobile}|{CusAddress}";
        }
        public CustomerTable()
        {

        }
        public CustomerTable(string lineRead)
        {
            string[] lineReadArray = lineRead.Split("|");
            CusName = lineReadArray[0];
            CusMobile = lineReadArray[1];
            CusAddress = lineReadArray[2];
        }
    }
}

