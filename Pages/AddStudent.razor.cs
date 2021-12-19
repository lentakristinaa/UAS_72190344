using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor344.Models;
using Blazor344.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor344.Pages
{
    public partial class AddStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Id { get; set; }

         protected async Task HandleValidSubmit(){
            Student result = await StudentService.Add(Student);
            NavigationManager.NavigateTo("studentpage");
        }
    }
}