namespace SecretaryAgenda
{
    public class Employee
    {
        public string IDEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhone { get; set; }
        public string Phone { get; set; }
        public bool IsDoc { get; set; }
        public decimal Obligation { get; set; }
        //public string LabelList { get; set; }
        //public string ScoreNoEng { get; set; }
        public decimal OverallScorePoints { get; set; }
        //public double Points { get; set; }
        //public double Hours { get; set; }
        //public double PointsHours

        public string EmployeeFullName { get; set; }

        // public string rudFirstName { get; set; }
        // public string rudLastName { get; set; }
        //public Guid rudGUID { get; set; }
    }
}
