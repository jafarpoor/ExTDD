
using WebApp.Models.Entites;
using System.Collections.Generic;
using WebApp.Services;

namespace WebApp.Models.MockData
{
    public class moqData
    {

        public List<Books> GetAll()
        {
            List<Books> books = new List<Books>()
            {
                 new Books { Id = 1 , Description ="x" , Name="iphone x" , Price = 15000},
                 new Books { Id = 2 , Description ="x2" , Name="iphone xx" , Price = 1000},
            };
            return books;
        }
    }
}
