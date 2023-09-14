using System;
using System.Collections.Generic;
using System.Text;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class ContactPersonCreateModel
    {
        #region Mendatory Fields
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        /// /// <value>
        /// The first name
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        /// /// <value>
        /// The last name
        /// </value>
        public string LastName { get; set; }

        #endregion

        #region Optional

        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        /// <value>
        /// The customer ID.
        /// </value>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the job title 
        /// </summary>
        /// <value>
        /// The job title
        /// </value>
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets the owner initial
        /// </summary>
        /// <value>
        /// The owner initial
        /// </value>
        public int OwnerID { get; set; }

        /// <summary>
        /// Gets or sets the reports to
        /// </summary>
        /// <value>
        /// The reports to
        /// </value>
        public string ReportsTo { get; set; }

        /// <summary>
        /// Gets or sets the department 
        /// </summary>
        /// <value>
        /// The department
        /// </value>
        public int DepartmentID { get; set; }

        /// <summary>
        /// Gets or sets the date the birth day
        /// </summary>
        /// <value>
        /// The start date of the birth day
        /// </value>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Gets or sets the phone number 
        /// </summary>
        /// <value>
        /// The phone number
        /// </value>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the mobile phone number 
        /// </summary>
        /// <value>
        /// The mobile phone number
        /// </value>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Gets or sets the home phone number 
        /// </summary>
        /// <value>
        /// The home phone number
        /// </value>
        public string HomePhone { get; set; }

        /// <summary>
        /// Gets or sets the fax number
        /// </summary>
        /// <value>
        /// The fax number
        /// </value>
        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        /// <value>
        /// The email
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the customers website
        /// </summary>
        /// <value>
        /// The website address
        /// </value>
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the customer address
        /// </summary>
        /// <value>
        /// The address
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the customer address
        /// </summary>
        /// <value>
        /// The address
        /// </value>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the customer address
        /// </summary>
        /// <value>
        /// The address
        /// </value>
        public string Address3 { get; set; }

        /// <summary>
        /// Gets or sets the customer address zip code
        /// </summary>
        /// <value>
        /// The address zip code
        /// </value>
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the customer address city
        /// </summary>
        /// <value>
        /// The address city
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the customer address state
        /// </summary>
        /// <value>
        /// The address state
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the customer address country 
        /// </summary>
        /// <value>
        /// The customer address country ID
        /// </value>
        public int CountryID { get; set; }

        #endregion
    }
}