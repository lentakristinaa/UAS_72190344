using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor344.Models;
using Blazor344.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor344.Pages
{
    public partial class EditStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Id { get; set; }

       protected async override Task OnInitializedAsync()
        {
            Student  = await StudentService.GetById(int.Parse(Id));
        }

        protected async Task HandleValidSubmit(){
            Student result = await StudentService.Update(int.Parse(Id),Student);
            NavigationManager.NavigateTo("studentpage");
        }
    }
}
