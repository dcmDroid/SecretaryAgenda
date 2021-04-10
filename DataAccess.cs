using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        public void ModifyEmployee(string firstName, string lastName, string mail, string cell, string phone, decimal obligation, bool isDoc, string id )
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

                modifyEmployee.Add(new Employee {IDEmployee = id });


                connection.Execute("DeleteEmployee @IDEmployee", modifyEmployee);
            }
        }

    }
}
