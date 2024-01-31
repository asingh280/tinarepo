using Microsoft.AspNetCore.Components;
using TinaKingSystem.BLL;
using TinaKingSystem.ViewModels;


namespace TinaKingWebApp.Pages
{
    public partial class ClientRegistration
    {

        [Inject]
        public RegistrationService RegistrationService { get; set; }

        private string email;
        private string password;
        private ClientView clientView;

        private async Task FetchClientInfoAsync()
        {
            clientView = await RegistrationService.GetClientDetailsByEmailAndPassword(email, password);
        }

        private async void Fetch()
        {
            await FetchClientInfoAsync();
        }

    

     

    }

}

