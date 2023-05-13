using Music.Net_App.DAL;
using Music.Net_App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.BLL
{
    public class CountryBLL
    {
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();
        public List<CountryDTO> GetAllCountry()
        {
            List<CountryDTO> countries = new List<CountryDTO>();
            var getAllCountry = from c in db.Countries
                                select new { c.CountryName };

            if(getAllCountry != null)
            {
                foreach (var item in getAllCountry)
                {
                    countries.Add(new CountryDTO
                    {
                        CountryName = item.CountryName
                    });
                }
                return countries;
            }
            return null;
        }
    }
}
