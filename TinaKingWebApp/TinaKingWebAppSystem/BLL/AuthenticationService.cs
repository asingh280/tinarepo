/*using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinaKingSystem.DAL;
using TinaKingSystem.Entities;
using TinaKingSystem.ViewModels;

namespace TinaKingSystem.BLL
{
    public class AuthenticationService
    {
        private readonly WFS_2590Context _wFS_2590Context;

        internal AuthenticationService(WFS_2590Context wFS_2590Context)
        {
            _wFS_2590Context = wFS_2590Context;
        }
        public class ClientLoginException : Exception
        {
            public ClientLoginException(string message, Exception innerException)
                : base(message, innerException)
            {
            }
        }

        public async Task<Client> ClientLogin(string email, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentException("Email and password cannot be null or empty.");
                }

                var client = await _wFS_2590Context.Clients
                    .FirstOrDefaultAsync(x => x.Email == email && x.Password == password);

                if (client == null)
                {
                    // No client found with the given credentials
                    return null;
                }

                return client;
            }
            catch (Exception ex)
            {
                throw new ClientLoginException("An error occurred during the login process.", ex);
            }
        }


        public ClientPackageView GetClientPackageView(int ClientId)
        {
            // Assuming Clients is a DbSet in your DbContext and ClientInfo is another DbSet corresponding to additional client details
            var clientPackageView = _wFS_2590Context.Clients
                .Where(x => x.ClientID == ClientId)
                .Select(x => new ClientPackageView
                {
                    ClientID = x.ClientID,
                    FirstName = x.FirstName,
                    Email = x.Email,
                })
                .FirstOrDefault();
            return clientPackageView;
        }
       
    }
}*/