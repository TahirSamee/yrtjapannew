using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YRTJapan.Core.Entities;

namespace YRTJapan.Core
{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }  // ISO two-letter country code
    }
    public class CarColor
    {
        public string Color { get; set; }
    }
    public class Maker
    {
        public string marka_id { get; set; }
        public string marka_name { get; set; }
        public int models_count { get; set; }
        public string TAG1 { get; set; }
        public List<Model> models { get; set; }
    }

    public class Model
    {
        public string model_name { get; set; }
        public string marka_name { get; set; }
        public string year { get; set; }
        public int total_count { get; set; }
        public string TAG1 { get; set; }
    }
    public class ModelCode
    {
        public string model_name { get; set; }
        public string kuzov { get; set; }
        public string model_code { get; set; }
        public string year { get; set; }
        public int total_count { get; set; }
        public string TAG1 { get; set; }
    }

    public class DropDownDataList
    {
        public List<Car> ListCars { get; set; }
        public List<Maker> ListMakers { get; set; }
        public List<Model> ListModels { get; set; }
        public List<ModelCode> ListModelCodes { get; set; }
        public List<DropDown> ListBodyTypes { get; set; }
        public List<string> ListYears { get; set; }
        public List<DropDown> ListJapenesMakers { get; set; }
        public List<DropDown> ListGlobalMakers { get; set; }
        public List<DropDown> ListFromPrices { get; set; }
        public List<DropDown> ListToPrices { get; set; }
        public List<DropDown> ListFuel { get; set; }
        public List<DropDown> ListTransmission { get; set; }
        public List<Country> ListCountries { get; set; }
        public List<CarColor> ListColors { get; set; }
        public List<Favourite> ListFavourites { get; set; }
        // Add these properties
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public string HomePageSearchValue { get; set; }
        public string TAG1 { get; set; }
        public string HomeFilterMarka { get; set; }
    }

    public class DropDown
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
