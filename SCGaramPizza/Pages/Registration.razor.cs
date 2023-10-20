using SCGaramPizza.Models;

namespace SCGaramPizza.Pages;

    public partial class Registration
    {
        public CustomerRecords Model{get; set;}=new CustomerRecords();
        public CustomerTable newRow{get; set;}=new CustomerTable();
            
        public void AddToRecord()
        {
            newRow.CusName=Model.Name;
            newRow.CusMobile=Model.MobileNumber;
            newRow.CusAddress=Model.Address;
            System.Console.WriteLine(newRow);
        }
    }
