using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Helper
{
    class Enums
    {
        public static string GetFieldErrorId(string field)
        {
            switch (field)
            {
                case "First Name":
                    return "[id = 'customer.firstName.errors']";
                case "Last Name":
                    return "[id = 'customer.lastName.errors']";
                case "Address":
                    return "[id = 'customer.address.street.errors']";
                case "City":
                    return "[id = 'customer.address.city.errors']";
                case "State":
                    return "[id = 'customer.address.state.errors']";
                case "Zip Code":
                    return "[id = 'customer.address.zipCode.errors']";
                case "Phone":
                    return "";
                case "SSN":
                    return "[id = 'customer.ssn.errors']";
                case "Username":
                    return "[id = 'customer.username.errors']";
                case "Password":
                    return "[id = 'customer.password.errors']";
                case "Confirm":
                    return "[id = 'repeatedPassword.errors']";
                default:
                    throw new InvalidOperationException($"Invalid game name {field}");
            }
        }
        public static string GetInputFieldId(string field)
        {
            switch (field)
            {
                case "First Name":
                    return "[id = 'customer.firstName']";
                case "Last Name":
                    return "[id = 'customer.lastName']";
                case "Address":
                    return "[id = 'customer.address.street']";
                case "City":
                    return "[id = 'customer.address.city']";
                case "State":
                    return "[id = 'customer.address.state']";
                case "Zip Code":
                    return "[id = 'customer.address.zipCode']";
                case "Phone":
                    return "[id = 'customer.phoneNumber']";
                case "SSN":
                    return "[id = 'customer.ssn']";
                case "Username":
                    return "[id = 'customer.username']";
                case "Password":
                    return "[id = 'customer.password']";
                case "Confirm":
                    return "[id = 'repeatedPassword']";
                default:
                    throw new InvalidOperationException($"Invalid game name {field}");
            }

        }
    }
}
