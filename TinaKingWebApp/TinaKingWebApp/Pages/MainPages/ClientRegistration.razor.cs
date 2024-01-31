using Microsoft.AspNetCore.Components;
<<<<<<< HEAD
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

        private async Task FetchClientInfo()
        {
            clientView = await RegistrationService.GetClientDetailsByEmailAndPassword(email, password);
        }
    }

}



=======
using TinaKingSystem.ViewModels;

namespace TinaKingWebApp.Pages.MainPages
{
    public partial class ClientRegistration
    {
       

        }
    }
}
>>>>>>> bba3c92af4bd29fcb204c691b5cd02c1e3d93e01
