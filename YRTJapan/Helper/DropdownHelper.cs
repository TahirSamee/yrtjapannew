using Microsoft.AspNetCore.Mvc.Rendering;
using YRTJapan.Core;

namespace YRTJapan.UI.Helper
{
    public class DropdownHelper
    {
        private static List<SelectListItem> _fromPrices;
        private static List<SelectListItem> _toPrices;
        private static List<SelectListItem> _fuelList;
        private static List<SelectListItem> _transmissionList;
        private static List<SelectListItem> _genderList;
        private static List<SelectListItem> _years;
        private static List<SelectListItem> _bodyTypes;
        private static List<DropDown> _bodyTypesList;
        private static List<SelectListItem> _steering;
        private static List<DropDown> _japenesMakersList;
        private static List<DropDown> _globalMakerList;
        private static List<Country> _countriesList;
        public static List<SelectListItem> GetYearsList
        {
            get
            {
                if (_years == null)
                {
                    int currentYear = DateTime.Now.Year;
                    _years = Enumerable.Range(1985, currentYear - 1985 + 1)
                                       .OrderByDescending(y => y)
                                       .Select(y => new SelectListItem
                                       {
                                           Text = y.ToString(),
                                           Value = y.ToString()
                                       })
                                       .ToList();
                }
                return _years;
            }
        }
        public static List<SelectListItem> GetPriceFromList()
        {
            if (_fromPrices == null)
            {
                // Populate your static list of cities only once.
                _fromPrices = new List<SelectListItem>
                {
                    new SelectListItem { Text = "500 USD", Value = "500" },
                    new SelectListItem { Text = "1000 USD", Value = "1000" },
                    new SelectListItem { Text = "2000 USD", Value = "2000" },
                    new SelectListItem { Text = "3000 USD", Value = "3000" },
                    new SelectListItem { Text = "5000 USD", Value = "5000" },
                    new SelectListItem { Text = "6000 USD", Value = "6000" },
                    new SelectListItem { Text = "7000 USD", Value = "7000" },
                    new SelectListItem { Text = "8000 USD", Value = "8000" },
                    new SelectListItem { Text = "9000 USD", Value = "9000" },
                    new SelectListItem { Text = "10,000 USD", Value = "10000" },
                    new SelectListItem { Text = "50,000 USD", Value = "50000" },
                    new SelectListItem { Text = "60,000 USD", Value = "60000" },
                    new SelectListItem { Text = "70,000 USD", Value = "70000" },
                    new SelectListItem { Text = "80,000 USD", Value = "80000" },
                    new SelectListItem { Text = "90,000 USD", Value = "90000" },
                    new SelectListItem { Text = "Above 1,00000 USD", Value = "100000" }
                };
            }
            return _fromPrices;
        }
        public static List<SelectListItem> GetPriceToList()
        {
            if (_toPrices == null)
            {
                _toPrices = new List<SelectListItem>
            {
                new SelectListItem { Text = "Under 500 USD", Value = "500" },
                new SelectListItem { Text = "1000 USD", Value = "1000" },
                new SelectListItem { Text = "2000 USD", Value = "2000" },
                new SelectListItem { Text = "3000 USD", Value = "3000" },
                new SelectListItem { Text = "5000 USD", Value = "5000" },
                new SelectListItem { Text = "6000 USD", Value = "6000" },
                new SelectListItem { Text = "7000 USD", Value = "7000" },
                new SelectListItem { Text = "8000 USD", Value = "8000" },
                new SelectListItem { Text = "9000 USD", Value = "9000" },
                new SelectListItem { Text = "10,000 USD", Value = "10000" },
                new SelectListItem { Text = "50,000 USD", Value = "50000" },
                new SelectListItem { Text = "60,000 USD", Value = "60000" },
                new SelectListItem { Text = "70,000 USD", Value = "70000" },
                new SelectListItem { Text = "80,000 USD", Value = "80000" },
                new SelectListItem { Text = "90,000 USD", Value = "90000" },
                new SelectListItem { Text = "1,00000 USD", Value = "100000" }
            };
            }
            return _toPrices;
        }
        public static List<SelectListItem> GetFuelList()
        {
            if (_fuelList == null)
            {
                _fuelList = new List<SelectListItem>
            {
                new SelectListItem { Text = "Petrol", Value = "Petrol" },
                new SelectListItem { Text = "Diesel", Value = "Diesel" },
                new SelectListItem { Text = "LPG", Value = "LPG" },
                new SelectListItem { Text = "CNG", Value = "CNG" },
                new SelectListItem { Text = "Electric Vehicles", Value = "Electric Vehicles" },
                new SelectListItem { Text = "Hybrid(petrol)", Value = "Hybrid(petrol)" },
                new SelectListItem { Text = "Hybrid(diesel)", Value = "Hybrid(diesel)" },
                new SelectListItem { Text = "Plug-in Hybrid(petrol)", Value = "Plug-in Hybrid(petrol)" },
                new SelectListItem { Text = "Plug-in Hybrid(diesel)", Value = "Plug-in Hybrid(diesel)" },
                new SelectListItem { Text = "Fuel Cell (hydrogen)", Value = "Fuel Cell (hydrogen)" },
                new SelectListItem { Text = "LNG", Value = "LNG" },
                new SelectListItem { Text = "Hybrid(lpg)", Value = "Hybrid(lpg)" }
            };
            }
            return _fuelList;
        }
        public static List<SelectListItem> GetTransmissionList()
        {
            if (_transmissionList == null)
            {
                _transmissionList = new List<SelectListItem>
            {
                new SelectListItem { Text = "Automatic", Value = "Automatic" },
                new SelectListItem { Text = "Manual", Value = "Manual" },
                new SelectListItem { Text = "Smoother", Value = "Smoother" },
                new SelectListItem { Text = "Semi AT", Value = "Semi AT" },
                new SelectListItem { Text = "Inomat", Value = "Inomat" },
                new SelectListItem { Text = "Duonic", Value = "Duonic" },
                new SelectListItem { Text = "Escot", Value = "Escot" },
                new SelectListItem { Text = "Proshift", Value = "Proshift" }
            };
            }
            return _transmissionList;
        }
        public static List<SelectListItem> GetGenderList()
        {
            if (_genderList == null)
            {
                _genderList = new List<SelectListItem>
            {
                new SelectListItem { Text = "Male", Value = "Male" },
                new SelectListItem { Text = "Female", Value = "Female" },
                new SelectListItem { Text = "Other", Value = "Other" }
            };
            }
            return _genderList;
        }
        public static List<SelectListItem> GetBodyTypesList
        {
            get
            {
                if (_bodyTypes == null)
                {
                    _bodyTypes = new List<SelectListItem>
                    {
                        new SelectListItem { Text = "Hatchback", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "SUV", Value = "images/search_by_shape/SUV.svg" },
                        new SelectListItem { Text = "Minivan", Value = "images/search_by_shape/Minivan.svg" },
                        new SelectListItem { Text = "Light car", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "Sedan", Value = "images/search_by_shape/Sedan.svg" },
                        new SelectListItem { Text = "Wagon", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "Truck", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "Coupe", Value = "images/search_by_shape/Coupe.svg" },
                        new SelectListItem { Text = "Van", Value = "images/search_by_shape/Van.svg" },
                        new SelectListItem { Text = "Convertible", Value = "images/search_by_shape/Convertible.svg" },
                        //new SelectListItem { Text = "Unspecified", Value = "93" },
                        new SelectListItem { Text = "STATION WAGON", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "Mini Vehicle", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "Sports Cars", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "Bus", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "PICKUP", Value = "images/search_by_shape/Pickup.svg" },
                        new SelectListItem { Text = "CAMPER", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "Machinery", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "Bikes", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "Ambulance", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "MINI VEHICLE -", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "MUV", Value = "images/search_by_shape/Hatchback.svg" },
                        new SelectListItem { Text = "Others", Value = "images/search_by_shape/Hatchback.svg" }
                    };
                }
                return _bodyTypes;
            }
        }
       

        public static List<DropDown> GetDropdownBodyTypesList
        {
            get
            {
                if (_bodyTypesList == null)
                {
                    _bodyTypesList = new List<DropDown>
                    {
                        new DropDown { Text = "Hatchback", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "SUV", Value = "images/search_by_shape/SUV.svg" },
                        new DropDown { Text = "Minivan", Value = "images/search_by_shape/Minivan.svg" },
                        new DropDown { Text = "Light car", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "Sedan", Value = "images/search_by_shape/Sedan.svg" },
                        new DropDown { Text = "Wagon", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "Truck", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "Coupe", Value = "images/search_by_shape/Coupe.svg" },
                        new DropDown { Text = "Van", Value = "images/search_by_shape/Van.svg" },
                        new DropDown { Text = "Convertible", Value = "images/search_by_shape/Convertible.svg" },
                        //new DropDown { Text = "Unspecified", Value = "93" },
                        new DropDown { Text = "STATION WAGON", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "Mini Vehicle", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "Sports Cars", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "Bus", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "PICKUP", Value = "images/search_by_shape/Pickup.svg" },
                        new DropDown { Text = "CAMPER", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "Machinery", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "Bikes", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "Ambulance", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "MINI VEHICLE -", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "MUV", Value = "images/search_by_shape/Hatchback.svg" },
                        new DropDown { Text = "Others", Value = "images/search_by_shape/Hatchback.svg" }
                    };
                }
                return _bodyTypesList;
            }
        }
        public static List<DropDown> BodyTypesSubset { get; } = GetDropdownBodyTypesList.Take(6).ToList();
        public static List<SelectListItem> Steering
        {
            get
            {
                if (_steering == null)
                {
                    _steering = new List<SelectListItem>
                    {
                        new SelectListItem { Text = "Right Hand Drive", Value = "RHD" },
                        new SelectListItem { Text = "Left Hand Drive", Value = "LHD" }
                    };
                }
                return _steering;
            }
        }
        public static List<DropDown> GetJapenesMakersList
        {
            get
            {
                if (_japenesMakersList == null)
                {
                    _japenesMakersList = new List<DropDown>
                    {
                        new DropDown { Text = "Toyota", Value = "images/makers/Toyota.svg" },
                        new DropDown { Text = "Honda", Value = "images/makers/Honda.svg" },
                        new DropDown { Text = "Mazda", Value = "images/makers/mazda.svg" },
                        new DropDown { Text = "Nissan", Value = "images/makers/nissan.svg" },
                        new DropDown { Text = "Mitsubishi", Value = "images/makers/Mitsubishi.svg" },
                        new DropDown { Text = "Subaru", Value = "images/makers/Subaru.svg" },
                        new DropDown { Text = "Suzuki", Value = "images/makers/suzuki.svg" },
                        new DropDown { Text = "Isuzu", Value = "images/makers/Isuzu.svg" },
                        new DropDown { Text = "Daihatsu", Value = "images/makers/Daihatsu.svg" },
                        new DropDown { Text = "Hino", Value = "images/makers/Hino.svg" },
                        new DropDown { Text = "Lexus", Value = "images/makers/Lexus.svg" }
                    };
                }
                return _japenesMakersList;
            }
        }
        public static List<DropDown> JapenesMakersSubset { get; } = GetJapenesMakersList.Take(6).ToList();
        public static List<DropDown> GetGlobalMakerList
        {
            get
            {
                if (_globalMakerList == null)
                {
                    _globalMakerList = new List<DropDown>
                    {
                         new DropDown { Text = "Mercedes Benz", Value = "images/global_makers/MercedesBenz.svg" },
                            new DropDown { Text = "BMW", Value = "images/global_makers/BMW.svg" },
                            new DropDown { Text = "Volkswagen", Value = "images/global_makers/Volkswagen.svg" },
                            new DropDown { Text = "Audi", Value = "images/global_makers/Audi.svg" },
                            new DropDown { Text = "Peugeot", Value = "images/global_makers/Peugeot.svg" },
                            new DropDown { Text = "Ford", Value = "images/global_makers/Ford.svg" },
                            new DropDown { Text = "Volvo", Value = "images/global_makers/Volvo.svg" },
                            new DropDown { Text = "Land Rover", Value = "images/global_makers/land.svg" },
                            new DropDown { Text = "Jaguar", Value = "images/global_makers/Jaguar.svg" },
                            new DropDown { Text = "Jeep", Value = "images/global_makers/Jeep.svg" },
                            new DropDown { Text = "Chevrolet", Value = "images/global_makers/Chevrolet.svg" },
                            new DropDown { Text = "KIA", Value = "images/global_makers/KIA.svg" },
                            new DropDown { Text = "Ssangyong", Value = "images/global_makers/Ssangyong.svg" },
                            new DropDown { Text = "Renault Samsung", Value = "images/global_makers/Renault.svg" }
                    };
                }
                return _globalMakerList;
            }
        }
        public static List<DropDown> GlobalMakersSubset { get; } = GetGlobalMakerList.Take(6).ToList();
        public static List<Country> GetCountriesList
        {
            get
            {
                if (_countriesList == null)
                {
                    _countriesList = new List<Country>
                    {
                        new Country { Name = "Algeria", Code = "DZ" },
                        new Country { Name = "Angola", Code = "AO" },
                        new Country { Name = "Anguilla", Code = "AI" },
                        new Country { Name = "Antigua", Code = "AG" },
                        new Country { Name = "Armenia", Code = "AM" },
                        new Country { Name = "Aruba", Code = "AW" },
                        new Country { Name = "Australia", Code = "AU" },
                        new Country { Name = "Azerbaijan", Code = "AZ" },
                        new Country { Name = "Bahamas", Code = "BS" },
                        new Country { Name = "Bahrain", Code = "BH" },
                        new Country { Name = "Bangladesh", Code = "BD" },
                        new Country { Name = "Barbados", Code = "BB" },
                        new Country { Name = "Belgium", Code = "BE" },
                        new Country { Name = "Benin", Code = "BJ" },
                        new Country { Name = "Bermuda", Code = "BM" },
                        new Country { Name = "Bolivia", Code = "BO" },
                        new Country { Name = "Botswana", Code = "BW" },
                        new Country { Name = "British Virgin Islands", Code = "VG" },
                        new Country { Name = "Brunei", Code = "BN" },
                        new Country { Name = "Bulgaria", Code = "BG" },
                        new Country { Name = "Burkina Faso", Code = "BF" },
                        new Country { Name = "Burundi", Code = "BI" },
                        new Country { Name = "Cambodia", Code = "KH" },
                        new Country { Name = "Cameroon", Code = "CM" },
                        new Country { Name = "Canada", Code = "CA" },
                        new Country { Name = "Cayman Islands", Code = "KY" },
                        new Country { Name = "Chile", Code = "CL" },
                        new Country { Name = "Colombia", Code = "CO" },
                        new Country { Name = "Commonwealth of Dominica", Code = "DM" },
                        new Country { Name = "Comoros", Code = "KM" },
                        new Country { Name = "Cook Islands", Code = "CK" },
                        new Country { Name = "Costa Rica", Code = "CR" },
                        new Country { Name = "Cote d'Ivoire", Code = "CI" },
                        new Country { Name = "Croatia", Code = "HR" },
                        new Country { Name = "Cyprus", Code = "CY" },
                        new Country { Name = "Denmark", Code = "DK" },
                        new Country { Name = "Djibouti", Code = "DJ" },
                        new Country { Name = "Dominican Republic", Code = "DO" },
                        new Country { Name = "DR Congo", Code = "CD" },
                        new Country { Name = "East Timor", Code = "TL" },
                        new Country { Name = "Egypt", Code = "EG" },
                        new Country { Name = "El Salvador", Code = "SV" },
                        new Country { Name = "United Kingdom", Code = "GB" },
                        new Country { Name = "Estonia", Code = "EE" },
                        new Country { Name = "Eswatini", Code = "SZ" },
                        new Country { Name = "Ethiopia", Code = "ET" },
                        new Country { Name = "Fiji", Code = "FJ" },
                        new Country { Name = "Finland", Code = "FI" },
                        new Country { Name = "France", Code = "FR" },
                        new Country { Name = "French Polynesia", Code = "PF" },
                        new Country { Name = "Gabon", Code = "GA" },
                        new Country { Name = "Gambia", Code = "GM" },
                        new Country { Name = "Georgia", Code = "GE" },
                        new Country { Name = "Germany", Code = "DE" },
                        new Country { Name = "Ghana", Code = "GH" },
                        new Country { Name = "Grenada", Code = "GD" },
                        new Country { Name = "Guadeloupe", Code = "GP" },
                        new Country { Name = "Guam", Code = "GU" },
                        new Country { Name = "Guatemala", Code = "GT" },
                        new Country { Name = "Guinea", Code = "GN" },
                        new Country { Name = "Guinea-Bissau", Code = "GW" },
                        new Country { Name = "Guyana", Code = "GY" },
                        new Country { Name = "Haiti", Code = "HT" },
                        new Country { Name = "Honduras", Code = "HN" },
                        new Country { Name = "Hong Kong", Code = "HK" },
                        new Country { Name = "Iceland", Code = "IS" },
                        new Country { Name = "India", Code = "IN" },
                        new Country { Name = "Indonesia", Code = "ID" },
                        new Country { Name = "Ireland", Code = "IE" },
                        new Country { Name = "Italy", Code = "IT" },
                        new Country { Name = "Jamaica", Code = "JM" },
                        new Country { Name = "Jordan", Code = "JO" },
                        new Country { Name = "Kazakhstan", Code = "KZ" },
                        new Country { Name = "Kenya", Code = "KE" },
                        new Country { Name = "Kiribati", Code = "KI" },
                        new Country { Name = "Kuwait", Code = "KW" },
                        new Country { Name = "Kyrgyzstan", Code = "KG" },
                        new Country { Name = "Lebanon", Code = "LB" },
                        new Country { Name = "Lesotho", Code = "LS" },
                        new Country { Name = "Liberia", Code = "LR" },
                        new Country { Name = "Libya", Code = "LY" },
                        new Country { Name = "Madagascar", Code = "MG" },
                        new Country { Name = "Malawi", Code = "MW" },
                        new Country { Name = "Malaysia", Code = "MY" },
                        new Country { Name = "Maldives", Code = "MV" },
                        new Country { Name = "Mali", Code = "ML" },
                        new Country { Name = "Malta", Code = "MT" },
                        new Country { Name = "Marshall Islands", Code = "MH" },
                        new Country { Name = "Martinique", Code = "MQ" },
                        new Country { Name = "Mauritania", Code = "MR" },
                        new Country { Name = "Mauritius", Code = "MU" },
                        new Country { Name = "Mexico", Code = "MX" },
                        new Country { Name = "Micronesia", Code = "FM" },
                        new Country { Name = "Mongolia", Code = "MN" },
                        new Country { Name = "Morocco", Code = "MA" },
                        new Country { Name = "Mozambique", Code = "MZ" },
                        new Country { Name = "Myanmar", Code = "MM" },
                        new Country { Name = "Namibia", Code = "NA" },
                        new Country { Name = "Nauru", Code = "NR" },
                        new Country { Name = "Netherlands", Code = "NL" },
                        new Country { Name = "Netherlands Antilles", Code = "AN" },
                        new Country { Name = "New Caledonia", Code = "NC" },
                        new Country { Name = "New Zealand", Code = "NZ" },
                        new Country { Name = "Nicaragua", Code = "NI" },
                        new Country { Name = "Niger", Code = "NE" },
                        new Country { Name = "Nigeria", Code = "NG" },
                        new Country { Name = "Norway", Code = "NO" },
                        new Country { Name = "Oman", Code = "OM" },
                        new Country { Name = "Pakistan", Code = "PK" },
                        new Country { Name = "Palau", Code = "PW" },
                        new Country { Name = "Panama", Code = "PA" },
                        new Country { Name = "Papua New Guinea", Code = "PG" },
                        new Country { Name = "Paraguay", Code = "PY" },
                        new Country { Name = "Peru", Code = "PE" },
                        new Country { Name = "Philippines", Code = "PH" },
                        new Country { Name = "Poland", Code = "PL" },
                        new Country { Name = "Portugal", Code = "PT" },
                        new Country { Name = "Qatar", Code = "QA" },
                        new Country { Name = "RC Congo", Code = "CG" },
                        new Country { Name = "Republic of Abkhazia", Code = "AB" },
                        new Country { Name = "Republic of Togo", Code = "TG" },
                        new Country { Name = "Romania", Code = "RO" },
                        new Country { Name = "Russia", Code = "RU" },
                        new Country { Name = "Rwanda", Code = "RW" },
                        new Country { Name = "Saint Martin", Code = "MF" },
                        new Country { Name = "Samoa", Code = "WS" },
                        new Country { Name = "Saudi Arabia", Code = "SA" },
                        new Country { Name = "Senegal", Code = "SN" },
                        new Country { Name = "Seychelles", Code = "SC" },
                        new Country { Name = "Sierra Leone", Code = "SL" },
                        new Country { Name = "Singapore", Code = "SG" },
                        new Country { Name = "Sint Maarten", Code = "SX" },
                        new Country { Name = "Solomon Islands", Code = "SB" },
                        new Country { Name = "Somalia", Code = "SO" },
                        new Country { Name = "South Africa", Code = "ZA" },
                        new Country { Name = "South Korea", Code = "KR" },
                        new Country { Name = "South Sudan", Code = "SS" },
                        new Country { Name = "Spain", Code = "ES" },
                        new Country { Name = "Sri Lanka", Code = "LK" },
                        new Country { Name = "St. Kitts", Code = "KN" },
                        new Country { Name = "St. Lucia", Code = "LC" },
                        new Country { Name = "St. Vincent", Code = "VC" },
                        new Country { Name = "Sudan", Code = "SD" },
                        new Country { Name = "Suriname", Code = "SR" },
                        new Country { Name = "Sweden", Code = "SE" },
                        new Country { Name = "Taiwan", Code = "TW" },
                        new Country { Name = "Tajikistan", Code = "TJ" },
                        new Country { Name = "Tanzania", Code = "TZ" },
                        new Country { Name = "Thailand", Code = "TH" },
                        new Country { Name = "Tonga", Code = "TO" },
                        new Country { Name = "Trinidad", Code = "TT" },
                        new Country { Name = "Tunisia", Code = "TN" },
                        new Country { Name = "Turkey", Code = "TR" },
                        new Country { Name = "Turkmenistan", Code = "TM" },
                        new Country { Name = "Turks and Caicos Islands", Code = "TC" },
                        new Country { Name = "Tuvalu", Code = "TV" },
                        new Country { Name = "UAE", Code = "AE" },
                        new Country { Name = "Uganda", Code = "UG" },
                        new Country { Name = "Ukraine", Code = "UA" },
                        new Country { Name = "United States of America", Code = "US" },
                        new Country { Name = "Uruguay", Code = "UY" },
                        new Country { Name = "Vanuatu", Code = "VU" },
                        new Country { Name = "Venezuela", Code = "VE" },
                        new Country { Name = "Vietnam", Code = "VN" },
                        new Country { Name = "Yemen", Code = "YE" },
                        new Country { Name = "Zambia", Code = "ZM" },
                        new Country { Name = "Zanzibar", Code = "" },  // Zanzibar does not have a recognized ISO country code
                        new Country { Name = "Zimbabwe", Code = "ZW" }
                        };
                }
                return _countriesList;
            }
        }
        public static List<Country> CountriesSubset { get; } = GetCountriesList.Take(10).ToList();
    }
}
