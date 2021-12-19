using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor344.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Blazor344.Services
{
    public class StudentService : IStudentService
    {
        private HttpClient _httpClient;
        public StudentService (HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
       public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"api/Student/{id}");
        }
        public async Task <IEnumerable<Student>> GetAll()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Student>>("api/Student");
            return results;
        }
        public async Task<Student> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Student>($"api/Student/{id}");
            return result;
        }
        public async Task<Student> Update(int id, Student Student)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Student/{id}", Student);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Student>(await response.Content.ReadAsStreamAsync());
            }
            else{
                throw new Exception("Gagal Update Data Student");
            }
        }
        public async Task<Student> Add(Student obj){
            var response = await _httpClient.PostAsJsonAsync($"api/Student",obj);
            if (response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Student>(
                    await response.Content.ReadAsStreamAsync());
            }
            else{
                throw new Exception ("Gagal Tambah Data Student");
            }
        }
    }    
}