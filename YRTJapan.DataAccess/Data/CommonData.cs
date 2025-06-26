using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using YRTJapan.Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using YRTJapan.Core;
using Microsoft.Identity.Client;

namespace YRTJapan.DataAccess.Data
{
    public static class CommonData
    {
        public static List<string> GetAllCountriesData()
        {
            // List of country names as they appear in your select options
            var countries = new List<string>
            {
                "ALGERIA", "ANGOLA", "ANGUILLA", "ANTIGUA", "ARMENIA", "ARUBA", "AUSTRALIA", "AZERBAIJAN",
                "BAHAMAS", "BAHRAIN", "BANGLADESH", "BARBADOS", "BELGIUM", "BENIN", "BERMUDA", "BOLIVIA",
                "BOTSWANA", "BRITISH VIRGIN ISLANDS", "BRUNEI", "BULGARIA", "BURKINA FASO", "BURUNDI",
                "CAMBODIA", "CAMEROON", "CANADA", "CAYMAN", "CHILE", "COLOMBIA", "COMMONWEALTH OF DOMINICA",
                "COMOROS", "COOK ISLANDS", "COSTA RICA", "COTE DIVOIRE", "CROATIA", "CYPRUS", "DENMARK",
                "DJIBOUTI", "DOMINICAN REPUBLIC", "DR CONGO", "EAST TIMOR", "EGYPT", "EL SALVADOR",
                "UNITED KINGDOM", "ESTONIA", "ESWATINI", "ETHIOPIA", "FIJI", "FINLAND", "FRANCE",
                "FRENCH POLYNESIA", "GABON", "GAMBIA", "GEORGIA", "GERMANY", "GHANA", "GRENADA", "GUADELOUPE",
                "GUAM", "GUATEMALA", "GUINEA", "GUINEA-BISSAU", "GUYANA", "HAITI", "HONDURAS", "HONG KONG",
                "ICELAND", "INDIA", "INDONESIA", "IRELAND", "ITALY", "JAMAICA", "JORDAN", "KAZAKHSTAN",
                "KENYA", "KIRIBATI", "KUWAIT", "KYRGYZSTAN", "LEBANON", "LESOTHO", "LIBERIA", "LIBYA",
                "MADAGASCAR", "MALAWI", "MALAYSIA", "MALDIVES", "MALI", "MALTA", "MARSHELL ISLAND",
                "MARTINIQUE", "MAURITANIA", "MAURITIUS", "MEXICO", "MICRONESIA", "MONGOLIA", "MOROCCO",
                "MOZAMBIQUE", "MYANMAR", "NAMIBIA", "NAURU", "NETHERLAND", "NETHERLANDS ANTILLES",
                "NEW CALEDONIA", "NEW ZEALAND", "NICARAGUA", "NIGER", "NIGERIA", "NORWAY", "OMAN", "PAKISTAN",
                "PALAU", "PANAMA", "PAPUA NEW GUINEA", "PARAGUAY", "PERU", "PHILIPPINES", "POLAND", "PORTUGAL",
                "QATAR", "RC CONGO", "REPUBLIC OF ABKHAZIA", "REPUBLIC OF TOGO", "ROMANIA", "RUSSIA", "RWANDA",
                "SAINT MARTIN", "SAMOA", "SAUDI ARABIA", "SENEGAL", "SEYCHELLES", "SIERRA LEONE", "SINGAPORE",
                "SINT MAARTEN", "SOLOMON ISLANDS", "SOMALIA", "SOUTH AFRICA", "SOUTH KOREA", "SOUTH SUDAN",
                "SPAIN", "SRI LANKA", "STKITTS", "STLUCIA", "STVINCENT", "SUDAN", "SURINAME", "SWEDEN", "TAIWAN",
                "TAJIKISTAN", "TANZANIA", "THAILAND", "TONGA", "TRINIDAD", "TUNISIA", "TURKEY", "TURKMENISTAN",
                "TURKS AND CAICOS ISLANDS", "TUVALU", "UAE", "UGANDA", "UKRAINE", "UNITED STATES OF AMERICA",
                "URUGUAY", "VANUATU", "VENEZUELA", "VIETNAM", "YEMEN", "ZAMBIA", "ZANZIBAR", "ZIMBABWE"
            };
            return countries;
        }

        public static decimal UnderPrice { get; } = 3000;
        public static int NewArrivalLotsLimit { get; } = 300;
        public static int PageSize { get; } = 30;
        public static List<Country> GetCountriesList { get; } = new List<Country>
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
       
        public static List<DropDown> GetJapenesMakersList { get; } = new List<DropDown>
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
        public static List<DropDown> JapenesMakersSubset { get; } = GetJapenesMakersList.Take(6).ToList();

        public static List<DropDown> GetGlobalMakerList { get; } = new List<DropDown>
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
        public static List<DropDown> GlobalMakersSubset { get; } = GetGlobalMakerList.Take(6).ToList();

        public static List<DropDown> GetAllBodyTypesList { get; } = new List<DropDown>
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
            new DropDown { Text = "Others", Value = "images/search_by_shape/Hatchback.svg" },
        };

        public static List<string> GetYearsList { get; } = YearsInitialization();

        private static List<string> YearsInitialization()
        {
            var years = new List<string>();
            int startYear = DateTime.Now.Year;
            for (int i = startYear; i >= 1985; i--)
            {
                years.Add(i.ToString());
            }
            return years;
        }

        public static List<DropDown> GetPriceFromList { get; } = new List<DropDown>
        {
            new DropDown { Text = "500 USD", Value = "500" },
            new DropDown { Text = "1000 USD", Value = "1000" },
            new DropDown { Text = "2000 USD", Value = "2000" },
            new DropDown { Text = "3000 USD", Value = "3000" },
            new DropDown { Text = "5000 USD", Value = "5000" },
            new DropDown { Text = "6000 USD", Value = "6000" },
            new DropDown { Text = "7000 USD", Value = "7000" },
            new DropDown { Text = "8000 USD", Value = "8000" },
            new DropDown { Text = "9000 USD", Value = "9000" },
            new DropDown { Text = "10,000 USD", Value = "10000" },
            new DropDown { Text = "50,000 USD", Value = "50000" },
            new DropDown { Text = "60,000 USD", Value = "60000" },
            new DropDown { Text = "70,000 USD", Value = "70000" },
            new DropDown { Text = "80,000 USD", Value = "80000" },
            new DropDown { Text = "90,000 USD", Value = "90000" },
            new DropDown { Text = "Above 1,00000 USD", Value = "100000" }
        };
        public static List<DropDown> GetPriceToList { get; } = new List<DropDown>
        {
            new DropDown { Text = "Under 500 USD", Value = "500" },
            new DropDown { Text = "1000 USD", Value = "1000" },
            new DropDown { Text = "2000 USD", Value = "2000" },
            new DropDown { Text = "3000 USD", Value = "3000" },
            new DropDown { Text = "5000 USD", Value = "5000" },
            new DropDown { Text = "6000 USD", Value = "6000" },
            new DropDown { Text = "7000 USD", Value = "7000" },
            new DropDown { Text = "8000 USD", Value = "8000" },
            new DropDown { Text = "9000 USD", Value = "9000" },
            new DropDown { Text = "10,000 USD", Value = "10000" },
            new DropDown { Text = "50,000 USD", Value = "50000" },
            new DropDown { Text = "60,000 USD", Value = "60000" },
            new DropDown { Text = "70,000 USD", Value = "70000" },
            new DropDown { Text = "80,000 USD", Value = "80000" },
            new DropDown { Text = "90,000 USD", Value = "90000" },
            new DropDown { Text = "1,00000 USD", Value = "100000" }
        };
        public static List<DropDown> GetFuelList { get; } = new List<DropDown>
        {
            new DropDown { Text = "Petrol", Value = "Petrol" },
            new DropDown { Text = "Diesel", Value = "Diesel" },
            new DropDown { Text = "LPG", Value = "LPG" },
            new DropDown { Text = "CNG", Value = "CNG" },
            new DropDown { Text = "Electric Vehicles", Value = "Electric Vehicles" },
            new DropDown { Text = "Hybrid(petrol)", Value = "Hybrid(petrol)" },
            new DropDown { Text = "Hybrid(diesel)", Value = "Hybrid(diesel)" },
            new DropDown { Text = "Plug-in Hybrid(petrol)", Value = "Plug-in Hybrid(petrol)" },
            new DropDown { Text = "Plug-in Hybrid(diesel)", Value = "Plug-in Hybrid(diesel)" },
            new DropDown { Text = "Fuel Cell (hydrogen)", Value = "Fuel Cell (hydrogen)" },
            new DropDown { Text = "LNG", Value = "LNG" },
            new DropDown { Text = "Hybrid(lpg)", Value = "Hybrid(lpg)" }
        };
        public static List<DropDown> GetTransmissionList { get; } = new List<DropDown>
        {
            new DropDown { Text = "Automatic", Value = "Automatic" },
            new DropDown { Text = "Manual", Value = "Manual" },
            new DropDown { Text = "Smoother", Value = "Smoother" },
            new DropDown { Text = "Semi AT", Value = "Semi AT" },
            new DropDown { Text = "Inomat", Value = "Inomat" },
            new DropDown { Text = "Duonic", Value = "Duonic" },
            new DropDown { Text = "Escot", Value = "Escot" },
            new DropDown { Text = "Proshift", Value = "Proshift" }
        };
        public static List<SelectListItem> GetGenderList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Text = "Male", Value = "Male" },
            new SelectListItem { Text = "Female", Value = "Female" },
            new SelectListItem { Text = "Other", Value = "Other" }
        };
    }
}
