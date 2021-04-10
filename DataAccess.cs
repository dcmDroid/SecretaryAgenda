using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SecretaryAgenda
{
    public class DataAccess
    {

        public List<Employee> FreeSearch_Employee(string freeSearch_Employee)
        {

            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
                {
                    var freeOutput = connection.Query<SecretaryAgenda.Employee>("FreeSearch_Employee @freeSearch_Employee", new { FreeSearch_Employee = freeSearch_Employee }).ToList();
                    return freeOutput;
                }
            }
        }

        public List<Subject> FreeSearch_Subject(string freeSearch_Subject)
        {

            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
                {
                    var freeOutput_Subject = connection.Query<SecretaryAgenda.Subject>("FreeSearch_Subject @freeSearch_Subject", new { FreeSearch_Subject = freeSearch_Subject }).ToList();
                    return freeOutput_Subject;
                }
            }
        }
        public List<Group> FreeSearch_Group(string freeSearch_Group)
        {

            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
                {
                    var freeOutput_Group = connection.Query<SecretaryAgenda.Group>("FreeSearch_Group @freeSearch_Group", new { FreeSearch_Group = freeSearch_Group }).ToList();
                    return freeOutput_Group;
                }
            }
        }

        public List<Label> FreeSearch_Label(string freeSearch_Label)
        {

            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
                {
                    var freeOutput_Label = connection.Query<SecretaryAgenda.Label>("FreeSearch_Label @freeSearch_Label", new { FreeSearch_Label = freeSearch_Label }).ToList();
                    return freeOutput_Label;
                }
            }
        }

        public List<Enums> Search_Semester()
        {
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
                {    
                    var semOutput = connection.Query<SecretaryAgenda.Enums>("Search_Enum_Semester").ToList();
                    return semOutput;         
                }
            }
        }
        public List<Enums> Search_Degree()
        {
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
                {
                    var degreeOutput = connection.Query<SecretaryAgenda.Enums>("Search_Enum_Degree").ToList();
                    return degreeOutput;
                }
            }
        }
        public List<Enums> Search_Final()
        {
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
                {
                    var finalOutput = connection.Query<SecretaryAgenda.Enums>("Search_Enum_Final").ToList();
                    return finalOutput;
                }
            }
        }
        public List<Enums> Search_Language()
        {
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
                {
                    var languageOutput = connection.Query<SecretaryAgenda.Enums>("Search_Enum_Language").ToList();
                    return languageOutput;
                }
            }
        }
        public List<Enums> Search_Form()
        {
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
                {
                    var formOutput = connection.Query<SecretaryAgenda.Enums>("Search_Enum_Form").ToList();
                    return formOutput;
                }
            }
        }

        


        public void ModifyEmployee(string firstName, string lastName, string mail, string cell, string phone, decimal obligation, bool isDoc, string id)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
            {


                List<Employee> modifyEmployee = new List<Employee>();

                modifyEmployee.Add(new Employee { FirstName = firstName, LastName = lastName, EmailAddress = mail, CellPhone = cell, Phone = phone, Obligation = obligation, IsDoc = isDoc, IDEmployee = id });


                connection.Execute("ModifyEmployee @FirstName, @LastName, @EmailAddress, @CellPhone, @Phone, @Obligation, @IsDoc, @IDEmployee", modifyEmployee);
            }
        }

        public void DeleteEmployee(string id)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
            {

                List<Employee> modifyEmployee = new List<Employee>();

                modifyEmployee.Add(new Employee { IDEmployee = id });


                connection.Execute("DeleteEmployee @IDEmployee", modifyEmployee);
            }
        }
        public void ModifySubject(string subjectCode, string weeksCount, string semesterID, string studyDegreeID, decimal hoursLecture,

            decimal hoursSeminar, decimal hoursExcercise, string finalTypeID, string languageID, string id)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
            {

                List<Subject> modifySubject = new List<Subject>();

                modifySubject.Add(new Subject
                {
                    SubjectCode = subjectCode,
                    WeeksCount = weeksCount,
                    SemesterID = semesterID,
                    StudyDegreeID = studyDegreeID,

                    HoursLecture = hoursLecture,
                    HoursSeminar = hoursSeminar,
                    HoursExcercise = hoursExcercise,
                    FinalTypeID = finalTypeID,
                    LanguageID = languageID,
                    IDSubject = id
                });


                connection.Execute("ModifySubject @SubjectCode, @WeeksCount, @SemesterID, @StudyDegreeID, @HoursLecture, @HoursSeminar, @HoursExcercise, @FinalTypeID, @LanguageID, @IDSubject", modifySubject);
            }
        }

        public void DeleteSubject(string id)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
            {

                List<Subject> modifySubject = new List<Subject>();

                modifySubject.Add(new Subject { IDSubject = id });


                connection.Execute("DeleteSubject @IDSubject", modifySubject);
            }
        }
        public void ModifyGroup(string groupCode, string studyYear, string studentsCount, string studyFormID, string id)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
            {

                List<Group> modifyGroup = new List<Group>();

                modifyGroup.Add(new Group
                {
                    GroupCode = groupCode,
                    StudyYear = studyYear,
                    StudentsCount = studentsCount,
                    StudyFormID = studyFormID,
                    IDGroup = id
                });


                connection.Execute("ModifyGroup @GroupCode, @StudyYear, @StudentsCount, @StudyFormID, @IDGroup", modifyGroup);
            }
        }

        public void DeleteGroup(string id)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
            {

                List<Group> modifyGroup = new List<Group>();

                modifyGroup.Add(new Group { IDGroup = id });


                connection.Execute("DeleteGroup @IDGroup", modifyGroup);
            }
        }
        public void ModifyLabel(string idSubject, string idGroup, string idEmployee, decimal HLA, decimal HSA, decimal HEA,  string id)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
            {

                List<Label> modifyLabel = new List<Label>();

                modifyLabel.Add(new Label
                {
                    IDSubject = idSubject,
                    IDGroup = idGroup,
                    IDEmployee = idEmployee,
                    HLA = HLA,
                    HSA = HSA,
                    HEA = HEA,
                   
                    IDLabel = id
                });


                connection.Execute("ModifyLabel @IDSubject, @IDGroup, @IDEmployee, @HLA, @HSA, @HEA, @IDLabel", modifyLabel);
            }
        }

        public void DeleteLabel(string id)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SecretaryAgenda")))
            {

                List<Label> modifyLabel = new List<Label>();

                modifyLabel.Add(new Label { IDLabel = id });


                connection.Execute("DeleteLabel @IDLabel", modifyLabel);
            }
        }
        

    }
}
