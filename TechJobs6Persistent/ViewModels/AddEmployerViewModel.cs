using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
public class AddEmployerViewModel
{
[Required(ErrorMessage ="Name is required")]
[StringLength(20, MinimumLength = 2, ErrorMessage = "what did you forget your name?")]
public string? Name {get;set;}

[Required(ErrorMessage ="plrease provide a location")]
[StringLength(20, MinimumLength = 2, ErrorMessage = "do you not know were you are?")]
public string? Location {get;set;}
}

}
//push to data base 

