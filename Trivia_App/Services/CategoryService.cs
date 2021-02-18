using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Trivia_App.Data;
using Microsoft.AspNetCore.Components;
using System.Timers;

namespace Trivia_App.Services
{
    public class CategoryService 
    {   
        //HTTP Client & Constructor 
        private  readonly HttpClient  httpClient;

        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        [Inject]
        public GameLengthService GameLengthService { get; set; }




        public Trivia_Categories categories = new Trivia_Categories();

        public Trivia myTrivia = new Trivia();

        public List<string> listOfCategories = new List<string>();

        public Dictionary<string, int> mapCategoryDict = new Dictionary<string, int>();

        public int chosenCategoryNumber;

        public string name = "Charley";
        
        public string chosenCategory = "";

        public bool wasGameStarted = false;



        //Methods
       //Map Category Subjects to ID Numbers
        public void MapChosenCategory()
        {


            var numberOfCategories = Enumerable.Range(9, 26).ToArray();


            //Adding Category Names to List
            foreach(var item in categories.Trivia_categories)
            {
                listOfCategories.Add(item.Name);

            
            }


         
            //Mapping Dictionary
            for (int i = 1; i < numberOfCategories.Length - 1; i++)
            {
                mapCategoryDict.Add(listOfCategories[i - 1], numberOfCategories[i - 1]);

            }



        }



        



        public void GetChosenCategorie()
        {

            var myCategory = mapCategoryDict.Where(r => r.Value == chosenCategoryNumber)
                       .Select(r => r.Key);

            chosenCategory = myCategory.FirstOrDefault();


        }


        // Call API
        public async Task HandleCategoryApi()
        {
            categories = await httpClient.GetFromJsonAsync<Trivia_Categories>($"https://opentdb.com/api_category.php");
        }



     




    }
}
