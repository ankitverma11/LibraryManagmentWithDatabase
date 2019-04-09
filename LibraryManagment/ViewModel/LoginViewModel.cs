using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.ViewModel
{
    /// <summary>
    /// The above piece of code is my view model class which will be attached to the target view in order to process user inputs.
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>  
        /// Gets or sets to username address.  
        /// </summary> 
        [Required(ErrorMessage = "Plese enter User Name.")]
        [StringLength(20, ErrorMessage = "Only 20 character are allowed")]
        public string UserName { get; set; }

        /// <summary>  
        /// Gets or sets to password address.  
        /// </summary>  
        [Required(ErrorMessage = "Please enter password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


    }
}
