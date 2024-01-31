/*using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using TinaKingWebApp;

namespace TinaKingWebApp.Pages.MainPages
{
    public partial class ClientInput
    {

        [Inject]
        private NavigationManager NavigationManager { get; set; }
        private void HandleFileUpload(InputFileChangeEventArgs e)
        {
            const long maxFileSize = 2L * 1024 * 1024 * 1024; // 2 GB in bytes
            long totalSize = 0;

            foreach (var file in e.GetMultipleFiles())
            {
                totalSize += file.Size;
                if (totalSize > maxFileSize)
                {
                    // Handle the case where total file size exceeds 2 GB
                    // You can show an error message to the user
                    return;
                }

                selectedFiles.Clear(); // Clear the current file list
                selectedFiles.AddRange(e.GetMultipleFiles());

                // Process each file here
            }

            // Continue with the upload logic if the size is within the limit
        }

        private List<IBrowserFile> selectedFiles = new List<IBrowserFile>();

        private RequestModel requestModel = new RequestModel();

        public class RequestModel
        {
            public string TypeOfRequest { get; set; }
            public DateTime StartDate { get; set; } = DateTime.Now;
            public DateTime? DueDate { get; set; }
            public string PriorityLevel { get; set; }
            public string Description { get; set; }
            public string PackageNumber { get; set; }
            public IBrowserFile FileAttachment { get; set; }
            public IEnumerable<IBrowserFile> FileAttachments { get; set; }

        }
        private void Btn()
        {
            NavigationManager.NavigateTo("/client", forceLoad: true);
        }
    }
}
*/

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using TinaKingWebApp;

namespace TinaKingWebApp.Pages.MainPages
{
    public partial class ClientInput
    {
          [Inject]
        private NavigationManager NavigationManager { get; set; }

        private List<IBrowserFile> selectedFiles = new List<IBrowserFile>();
        private RequestModel requestModel = new RequestModel();

        // Dummy data for dropdowns

        /*  private List<dynamic> requestTypes = new List<dynamic>
          {
              new { Name = "Request for information", Value = "Info" },
              new { Name = "Document Review", Value = "Desc" }
          };

          private List<dynamic> priorityLevels = new List<dynamic>
          {
              new { Name = "Low", Value = "Low" },
              new { Name = "Med", Value = "Med" },
              new { Name = "High", Value = "High" }
          };*/

        private void HandleFileUpload(InputFileChangeEventArgs e)
        {
            const long maxFileSize = 2L * 1024 * 1024 * 1024; // 2 GB in bytes
            long totalSize = 0;

            foreach (var file in e.GetMultipleFiles())
            {
                totalSize += file.Size;
                if (totalSize > maxFileSize)
                {
                    // Handle the case where total file size exceeds 2 GB
                    // You can show an error message to the user
                    return;
                }

                selectedFiles.Clear(); // Clear the current file list
                selectedFiles.AddRange(e.GetMultipleFiles());

            }

        }

        private void Btn()
        {
            NavigationManager.NavigateTo("/client", forceLoad: true);
        }
    
        private void GoToClientInput()
        {
            NavigationManager.NavigateTo("/ClientRegistration");
        }

        public class RequestModel
        {
            public string TypeOfRequest { get; set; }
            public DateTime StartDate { get; set; } = DateTime.Now;
            public DateTime? DueDate { get; set; }
            public string PriorityLevel { get; set; }
            public string Description { get; set; }
            public string PackageNumber { get; set; }
            public IBrowserFile FileAttachment { get; set; }
            public IEnumerable<IBrowserFile> FileAttachments { get; set; }

        }
    }
}


