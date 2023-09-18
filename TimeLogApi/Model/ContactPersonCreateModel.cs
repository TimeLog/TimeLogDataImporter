using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class ContactPersonCreateModel
    {
        //Mandatory

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        /// /// <value>
        /// The Name
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Last Name
        /// </summary>
        /// /// <value>
        /// The Last Name
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the phone number 
        /// </summary>
        /// <value>
        /// The phone number
        /// </value>
        public string Phone { get; set; }

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
        /// Gets or sets the Department
        /// </summary>
        /// <value>
        /// The Department
        /// </value>
        public string Department { get; set; }

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

        /// <summary>
        /// Gets or sets the owner ID 
        /// </summary>
        /// <value>
        /// The  Owner ID
        /// </value>
        public int OwnerID { get; set; }

        /// <summary>
        /// Gets or sets the Customer ID 
        /// </summary>
        /// <value>
        /// The Customer ID
        /// </value>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the Salutation
        /// </summary>
        /// <value>
        /// The Salutation
        /// </value>
        public string Salutation { get; set; }

        /// <summary>
        /// Gets or sets the initials
        /// </summary>
        /// <value>
        /// The initials
        /// </value>
        public string Initials { get; set; }

        /// <summary>
        /// Gets or sets the job title 
        /// </summary>
        /// <value>
        /// The job title
        /// </value>
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets the mobile phone number
        /// </summary>
        /// <value>
        /// The mobile
        /// </value>
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or sets the private phone number
        /// </summary>
        /// <value>
        /// The private phone
        /// </value>
        public string PrivatePhone { get; set; }

        /// <summary>
        /// Gets or sets the mobile phone number
        /// </summary>
        /// <value>
        /// The mobile
        /// </value>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the Professional Title1
        /// </summary>
        /// <value>
        /// The Professional Title1
        /// </value>
        public string ProfessionalTitle1 { get; set; }

        /// <summary>
        /// Gets or sets the ProfessionalTitle2
        /// </summary>
        /// <value>
        /// The Professional Title2
        /// </value>
        public string ProfessionalTitle2 { get; set; }

        /// <summary>
        /// Gets or sets the Birthday
        /// </summary>
        /// <value>
        /// The Birthday
        /// </value>
        public DateTime? Birthday { get; set; }
    }
}