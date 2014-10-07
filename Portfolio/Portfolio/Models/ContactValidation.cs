using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//set up dataannotations
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    //set up the meta type for annoations regarding this class
    [MetadataType(typeof(ContactValidation))]
    //create a public partial class for where we are linking to
    public partial class Contact
    {

    }
    public class ContactValidation
    {
        //all properties are reqired
        [Required, Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required, Display(Name="Last Name")]
        public string LastName { get; set; }
        [Required, EmailAddress, Display(Name="Email Address")]
        public string EmailAddress { get; set; }
        [Phone, Display(Name="Contact Number")]
        public string ContactNumber { get; set; }
        [Required, MaxLength(1000), Display(Name="Message")]
        public string Comment { get; set; }

    }
}