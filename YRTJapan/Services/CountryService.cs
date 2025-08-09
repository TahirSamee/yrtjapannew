using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using YRTJapan.DataAccess.Repository.IRepository;

namespace YRTJapan.UI.Services
{
    public class CountryService
    {
        private readonly ICountryRepository _countryRepo;

        public CountryService(ICountryRepository countryRepo)
        {
            _countryRepo = countryRepo;
        }

        private Lazy<List<SelectListItem>> _countries;

        public List<SelectListItem> GetDBCountryData
        {
            get
            {
                if (_countries == null)
                {
                    _countries = new Lazy<List<SelectListItem>>(() =>
                        _countryRepo.GetAll().Select(i => new SelectListItem
                        {
                            Text = i.Name,
                            Value = i.Id.ToString()
                        }).ToList());
                }
                return _countries.Value;
            }
        }
    }

}
