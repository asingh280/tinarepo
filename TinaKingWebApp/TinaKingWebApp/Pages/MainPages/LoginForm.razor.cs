using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TinaKingSystem.ViewModels;
using TinaKingSystem.BLL;

namespace TinaKingWebApp.Pages.MainPages
{
    public partial class LoginForm
    {
        private string errorMessage;
        private LoginModel loginModel = new LoginModel();

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public AuthenticationService AuthenticationService { get; set; }

        private async Task HandleLogin()
        {
            var client = await AuthenticationService.ClientLogin(loginModel.Email, loginModel.Password);

            if (client != null)
            {
               
                NavigationManager.NavigateTo("/sexful");
            }
            else
            {
                errorMessage = "Login failed. Please check your credentials.";
            }
        }
        public void GoToClientInput()
        {
            NavigationManager.NavigateTo("/ClientInput");
        }
        public class LoginModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}
