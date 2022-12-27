using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.Entites;

namespace WebApp.Services
{
    public interface IBooksService
    {
        IEnumerable<Books> GetAll();
    }
}
