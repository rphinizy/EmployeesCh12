namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        //Composit Primary Ket and foreign key for Department
        public int DepartmentID { get; set; }
        //composite primary key and foreign key for location
        public int LocationID { get; set; }

        //nagivation properties
        public Department Department { get; set; }
        public Location Location { get; set; }
    }
}
