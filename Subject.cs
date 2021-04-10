namespace SecretaryAgenda
{
    public class Subject
    {
        public string IDSubject { get; set; }
        public string SubjectCode { get; set; }
        public string WeeksCount { get; set; }
        public string Semester { get; set; }
        public string SemesterID { get; set; }
        public string StudyDegree { get; set; }
        public string StudyDegreeID { get; set; }
        public decimal HoursLecture { get; set; }
       
        public decimal HoursSeminar { get; set; }
       
        public decimal HoursExcercise { get; set; }
        
        public string FinalType { get; set; }
        public string FinalTypeID { get; set; }
        public string Language { get; set; }
        public string LanguageID { get; set; }
    }
}
