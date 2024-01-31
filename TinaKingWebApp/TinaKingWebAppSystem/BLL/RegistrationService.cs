using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinaKingSystem.DAL;
using TinaKingSystem.ViewModels;
using TinaKingSystem.Entities;

namespace TinaKingSystem.BLL
{

    public interface IRegistrationService
    {
        Task<ClientView> GetClientDetailsByEmailAndPassword(string email, string password);
    }
    public class RegistrationService

   
    {
        #region Fields

        private readonly WFS_2590Context _wfs_2590context;

        #endregion

        internal RegistrationService(WFS_2590Context wfs_2590context)
        {
            _wfs_2590context = wfs_2590context;
        }

        public async Task<ClientView> GetClientDetailsByEmailAndPassword(string email, string password)
        {
            var client = await _wfs_2590context.Clients
                .Where(c => c.Email == email && c.Password == password)
                .Select(c => new ClientView
                {
                    ClientID = c.ClientID,
                    FirstName = c.FirstName,
                    City = c.City,
                    Province = c.Province,
                    PostalCode = c.PostalCode
                })
                .FirstOrDefaultAsync();

            return client;
        }

    }
}

