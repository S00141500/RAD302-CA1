using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccaBetApi.Models;

namespace AccaBetApi.DAL
{
    public interface ICountriesRepository :IDisposable
    {
        List<Country> GetAllCountries();

        Country GetCountryByID(int? id);
    }
}
