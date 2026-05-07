/*
 * Joseph Sutton 
 * Cs233n classes lab
 * 5/6/2026
 */

/*
 * Instrucitons:
 * Using the Visual Studio Solution provided in the starting files as a starting point and the 
 * Product class as a model, implement and test a class that represents a customer. 

 * A customer has the following attributes:  an integer id, first and last name, email address 
 * and phone number.  A customer must be able to report and update each of these attributes. 

 * A programmer must be able to create a customer without providing any of the attribute information 
 * and must be able to create a customer while providing all of the attribute information.

 * A customer must be able to convert its attributes to a string for displaying on the screen as well
 */
using System;

namespace CustomerProductClasses
{
    public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;

        public Customer() { }

        public Customer(int idNumber, string fName, string lName, string emailAddress, string phone)
        {
            id = idNumber;
            firstName = fName;
            lastName = lName;
            email = emailAddress;
            phoneNumber = phone;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string PhoneNumber
            {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
     
        public override string ToString()
        {
            return String.Format("Id: {0} FirstName: {1} LastName: {2} Email: {3} PhoneNumber: {4}", id, firstName, lastName, email, phoneNumber);
        }
        
    }
}
