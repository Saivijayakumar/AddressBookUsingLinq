using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingLinq
{
    public class ContactDataManager
    {
        //Instilize object
        DataTable dataTable;
        public void CreateDataTable()
        {
            try
            {
                //Creating object for datatable
                dataTable = new DataTable();

                //Creating object for datacolumn
                DataColumn dtColumn = new DataColumn();

                //Create FirstName Column
                dtColumn.DataType = typeof(String);
                dtColumn.ColumnName = "FirstName";
                dtColumn.AutoIncrement = false;
                dataTable.Columns.Add(dtColumn);

                //Create LastName Column
                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(String);
                dtColumn.ColumnName = "LastName";
                dtColumn.AutoIncrement = false;
                dataTable.Columns.Add(dtColumn);

                //create Address Column
                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(String);
                dtColumn.ColumnName = "Address";
                dtColumn.AutoIncrement = false;
                dataTable.Columns.Add(dtColumn);

                //Create City Column
                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(String);
                dtColumn.ColumnName = "City";
                dtColumn.AutoIncrement = false;
                dataTable.Columns.Add(dtColumn);

                //Create State Column
                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(String);
                dtColumn.ColumnName = "State";
                dtColumn.AutoIncrement = false;
                dataTable.Columns.Add(dtColumn);

                //Create EmailId Column
                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(String);
                dtColumn.ColumnName = "Email";
                dtColumn.AutoIncrement = false;
                dataTable.Columns.Add(dtColumn);

                //Create Address column
                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(Int64);
                dtColumn.ColumnName = "PhoneNumber";
                dtColumn.AutoIncrement = false;
                dataTable.Columns.Add(dtColumn);

                //Create ZipCode Colum
                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(Int64);
                dtColumn.ColumnName = "Zip";
                dtColumn.AutoIncrement = false;
                dataTable.Columns.Add(dtColumn);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Add Values to datatable
        public int AddValues()
        {
            try
            {
                //Calling the createtable method
                CreateDataTable();
                //Create Object for DataTable for adding tow values in table
                ContactDetails contact = new ContactDetails();

                //adding values to varables
                contact.firstName = "Sai";
                contact.lastName = "B";
                contact.phoneNumber = 8848473983;
                contact.emailId = "Sai@yahoo.com";
                contact.address = "MK-Nagar";
                contact.city = "Chennai";
                contact.state = "TN";
                contact.zipCode = 600002;
                //insert these values to table
                InsertintoDataTable(contact);

                contact.firstName = "vijay";
                contact.lastName = "Bollu";
                contact.phoneNumber = 987833938;
                contact.emailId = "vijay2@gmail.com";
                contact.address = "Gandinagar";
                contact.city = "Nellore";
                contact.state = "Ap";
                contact.zipCode = 88494;
                InsertintoDataTable(contact);

                contact.firstName = "vijaya";
                contact.lastName = "A";
                contact.phoneNumber = 9873323938;
                contact.emailId = "vijaya@gmail.com";
                contact.address = "Gandinagar Road 2";
                contact.city = "Nellore";
                contact.state = "Ap";
                contact.zipCode = 88494;
                InsertintoDataTable(contact);

                //Return The count of Rows Effected
                return dataTable.Rows.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }
        //Insert values to DataTable
        public void InsertintoDataTable(ContactDetails contact)
        {
            try
            {
                DataRow dtRow = dataTable.NewRow();
                dtRow["FirstName"] = contact.firstName;
                dtRow["LastName"] = contact.lastName;
                dtRow["Address"] = contact.address;
                dtRow["City"] = contact.city;
                dtRow["State"] = contact.state;
                dtRow["Zip"] = contact.zipCode;
                dtRow["PhoneNumber"] = contact.phoneNumber;
                dtRow["Email"] = contact.emailId;
                dataTable.Rows.Add(dtRow);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Edit contact using name
        public bool EditDataTableUsingName(string FirstName, string ColumnName, string value)
        {
            try
            {
                AddValues();
                var result = (from Contact in dataTable.AsEnumerable() where Contact.Field<string>("FirstName") == FirstName select Contact).FirstOrDefault();
                if (result != null)
                {
                    result[ColumnName] = value;
                    Display();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }
        public bool DeleteContactUsingName(string FirstName)
        {
            try
            {
                AddValues();
                var result = (from Contact in dataTable.AsEnumerable() where Contact.Field<string>("FirstName") == FirstName select Contact).FirstOrDefault();
                if (result != null)
                {
                    Console.WriteLine("-------------------Before Delete-----------------------");
                    Display();
                    result.Delete();
                    Console.WriteLine("-------------------After Delete-----------------------");
                    Display();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }
        public void Display()
        {
            try
            {
                Console.WriteLine("\t\tDisplaying Data Table");
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (DataRow dtRows in dataTable.Rows)
                {
                    Console.WriteLine($"| {dtRows["FirstName"]} | {dtRows["LastName"]} | {dtRows["Address"]} | {dtRows["City"]} | {dtRows["State"]} | {dtRows["Zip"]} | {dtRows["PhoneNumber"]} | {dtRows["Email"]}|");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
