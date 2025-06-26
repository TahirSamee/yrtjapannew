using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YRTJapan.Core;
using YRTJapan.Core.Entities;
using YRTJapan.Core.ViewModels;

namespace YRTJapan.Utility
{
    public static class StaticDetails
    {
        public const string ROLE_ADMIN = "Admin";
        public const string ROLE_EMPLOYEE = "Employee";
        public const string ROLE_CUSTOMER = "Customer";
        public const string ROLE_DATAENTRYOPERATOR = "DataEntryOperator";
        public const string ROLE_SALE = "Sale";
        public const string ROLE_ACCOUNTANT = "Accountant";

        public const string SQL_ALL_MAKERS = "select marka_name, count(model_name) from main group by marka_name order by marka_name ASC";
        public const string SQL_ALL_MODELS = "select model_name, count(model_name) from main group by model_name order by model_name ASC";
        public const string SQL_ALL_COLORS = "select color from main group by color order by color ASC";
        public static string SQL_ALL_ModelsByMakerName(string marka_name)
        {
            return $"select model_name, count(model_name) from main where marka_name = '{marka_name}' group by model_name order by model_name";
        }
        public static string SQL_Filtered_MakerName(string marka_name)
        {
            return $"select marka_name, count(model_name) from main where marka_name = '{marka_name}' marka_name order by marka_name ASC";
        }

        public static string SQL_ALL_ModelCodesByModelName(string model_name)
        {
            return $"select kuzov from main where model_name = '{model_name}' group by kuzov order by kuzov";
        }
        public const string SQL_ALL_DATA = "select * from main where auction_type != 1 ";
        public const string SQL_LANDING_PAGE_DATA = $"select id,marka_name, model_name, `year`, avg_price, start, finish, images from main where auction_type != 1 and avg_price != 0 order by year desc, avg_price asc";
        public static List<string> SQL_LANDING_PAGE()
        {
            var list = new List<string>();
            list.Add(SQL_ALL_MAKERS);
            //list.Add(SQL_ALL_MODELS);
            list.Add(SQL_LANDING_PAGE_DATA);
            return list;
        }
        public static List<string> SQL_STOCK_PAGE(CarSearchViewModel carSearch)
        {
            var list = new List<string>();
            list.Add(SQL_ALL_MAKERS);
            list.Add(SQL_ALL_MODELS);
            list.Add(SQL_ALL_COLORS);
            list.Add(SQL_ALL_DATA_BY_SEARCH_CRITERIA(carSearch));
            return list;
        }
        public static string SQL_ALL_CAR_DETAILS(string id)
        {
            //var query = new StringBuilder("select Images from main where id='{id}'");
            return $"select * from main where id='{id}'";
        }
        //public static string SQL_ALL_DATA_BY_SEARCH_CRITERIA(CarSearchViewModel carSearch)
        //{

        //    var query = new StringBuilder("select * from main where auction_type != 1");

        //    if (!string.IsNullOrEmpty(carSearch.MarkaName))
        //    {
        //        query.Append($" and marka_name = '{carSearch.MarkaName}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.HomeMarkaName))
        //    {
        //        query.Append($" and marka_name = '{carSearch.HomeMarkaName}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.ModelName))
        //    {
        //        query.Append($" and model_name = '{carSearch.ModelName}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.Type))
        //    {
        //        query.Append($" and kuzov = '{carSearch.Type}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.ModelCode))
        //    {
        //        query.Append($" and kuzov = '{carSearch.ModelCode}'");
        //    }

        //    bool hasOverPrice = !string.IsNullOrEmpty(carSearch.OverPrice) &&
        //                        int.TryParse(carSearch.OverPrice, out int overPriceValue) &&
        //                        overPriceValue != 0;

        //    bool hasUnderPrice = !string.IsNullOrEmpty(carSearch.UnderPrice) &&
        //                         int.TryParse(carSearch.UnderPrice, out int underPriceValue) &&
        //                         underPriceValue != 0;

        //    if (hasOverPrice || hasUnderPrice)
        //    {
        //        // When OverPrice or UnderPrice is provided, ignore FromPrice and ToPrice.
        //        if (hasOverPrice)
        //        {
        //            query.Append($" and AVG_PRICE >= {carSearch.OverPrice}");
        //        }
        //        if (hasUnderPrice)
        //        {
        //            query.Append($" and AVG_PRICE <= {carSearch.UnderPrice}");
        //        }
        //    }
        //    else
        //    {
        //        // If both OverPrice and UnderPrice are 0 or null, then use FromPrice and ToPrice.
        //        if (!string.IsNullOrEmpty(carSearch.FromPrice) &&
        //            int.TryParse(carSearch.FromPrice, out int fromPriceValue) &&
        //            fromPriceValue != 0)
        //        {
        //            query.Append($" and AVG_PRICE >= {fromPriceValue}");
        //        }
        //        if (!string.IsNullOrEmpty(carSearch.ToPrice) &&
        //            int.TryParse(carSearch.ToPrice, out int toPriceValue) &&
        //            toPriceValue != 0)
        //        {
        //            query.Append($" and AVG_PRICE <= {toPriceValue}");
        //        }
        //    }

        //    if (!string.IsNullOrEmpty(carSearch.FromYear))
        //    {
        //        query.Append($" and year >= {carSearch.FromYear}");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.ToYear))
        //    {
        //        query.Append($" and year <= {carSearch.ToYear}");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.Engine))
        //    {
        //        query.Append($" and ENG_V = '{carSearch.Engine}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.Color))
        //    {
        //        query.Append($" and color = '{carSearch.Color}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.MilageFrom))
        //    {
        //        query.Append($" and mileage >= {carSearch.MilageFrom}");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.MilageTo))
        //    {
        //        query.Append($" and mileage <= {carSearch.MilageTo}");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.Transmission))
        //    {
        //        query.Append($" and kpp = '{carSearch.Transmission}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.SearchKeyword))
        //    {
        //        query.Append($" and marka_name like '%{carSearch.SearchKeyword}%' or model_name like '%{carSearch.SearchKeyword}%'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.HomeSearch))
        //    {
        //        query.Append($" and marka_name like '%{carSearch.HomeSearch}%' or model_name like '%{carSearch.HomeSearch}%'");
        //    }

        //    query.Append($" order by year desc, avg_price asc limit {(carSearch.Offset < 0 ? 0 : carSearch.Offset)}, {carSearch.ItemsPerPage}");

        //    return query.ToString();
        //}

        public static string SQL_ALL_DATA_BY_SEARCH_CRITERIA(CarSearchViewModel carSearch)
        {
            var query = new StringBuilder("select * from main where auction_type != 1 and avg_price != 0");

            if (!string.IsNullOrEmpty(carSearch.MarkaName))
            {
                query.Append(" and marka_name = '" + carSearch.MarkaName + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.HomeMarkaName))
            {
                query.Append(" and marka_name = '" + carSearch.HomeMarkaName + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.ModelName))
            {
                query.Append(" and model_name = '" + carSearch.ModelName + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.Type))
            {
                query.Append(" and kuzov = '" + carSearch.Type + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.ModelCode))
            {
                query.Append(" and kuzov = '" + carSearch.ModelCode + "'");
            }

            // Price Filtering Section:
            // If OverPrice or UnderPrice are provided, they take precedence.
            bool hasOverPrice = !string.IsNullOrEmpty(carSearch.OverPrice) &&
                                int.TryParse(carSearch.OverPrice, out int overPriceValue) &&
                                overPriceValue != 0;
            bool hasUnderPrice = !string.IsNullOrEmpty(carSearch.UnderPrice) &&
                                 int.TryParse(carSearch.UnderPrice, out int underPriceValue) &&
                                 underPriceValue != 0;

            if (hasOverPrice || hasUnderPrice)
            {
                // Build condition based on the maximum of AVG_PRICE and FINISH.
                // If finish > avg_price then finish is used; else avg_price is used.
                var priceCondition = new StringBuilder(" and (");
                if (hasOverPrice)
                {
                    priceCondition.Append("((finish > avg_price and finish >= " + carSearch.OverPrice + ") or (finish <= avg_price and avg_price >= " + carSearch.OverPrice + "))");
                }
                if (hasUnderPrice)
                {
                    if (hasOverPrice)
                    {
                        priceCondition.Append(" and ");
                    }
                    priceCondition.Append("((finish > avg_price and finish <= " + carSearch.UnderPrice + ") or (finish <= avg_price and avg_price <= " + carSearch.UnderPrice + "))");
                }
                priceCondition.Append(")");
                query.Append(priceCondition.ToString());
            }
            else
            {
                // Otherwise, use FromPrice and ToPrice if provided.
                bool hasFromPrice = !string.IsNullOrEmpty(carSearch.FromPrice) &&
                                    int.TryParse(carSearch.FromPrice, out int fromPriceValue) &&
                                    fromPriceValue != 0;
                bool hasToPrice = !string.IsNullOrEmpty(carSearch.ToPrice) &&
                                  int.TryParse(carSearch.ToPrice, out int toPriceValue) &&
                                  toPriceValue != 0;
                if (hasFromPrice || hasToPrice)
                {
                    var priceCondition = new StringBuilder(" and (");
                    if (hasFromPrice)
                    {
                        priceCondition.Append("((finish > avg_price and finish >= " + carSearch.FromPrice + ") or (finish <= avg_price and avg_price >= " + carSearch.FromPrice + "))");
                    }
                    if (hasToPrice)
                    {
                        if (hasFromPrice)
                        {
                            priceCondition.Append(" and ");
                        }
                        priceCondition.Append("((finish > avg_price and finish <= " + carSearch.ToPrice + ") or (finish <= avg_price and avg_price <= " + carSearch.ToPrice + "))");
                    }
                    priceCondition.Append(")");
                    query.Append(priceCondition.ToString());
                }
            }

            if (!string.IsNullOrEmpty(carSearch.FromYear))
            {
                query.Append(" and year >= " + carSearch.FromYear);
            }
            if (!string.IsNullOrEmpty(carSearch.ToYear))
            {
                query.Append(" and year <= " + carSearch.ToYear);
            }
            if (!string.IsNullOrEmpty(carSearch.Engine))
            {
                query.Append(" and ENG_V = '" + carSearch.Engine + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.Color))
            {
                query.Append(" and color = '" + carSearch.Color + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.MilageFrom))
            {
                query.Append(" and mileage >= " + carSearch.MilageFrom);
            }
            if (!string.IsNullOrEmpty(carSearch.MilageTo))
            {
                query.Append(" and mileage <= " + carSearch.MilageTo);
            }
            if (!string.IsNullOrEmpty(carSearch.Transmission))
            {
                query.Append(" and kpp = '" + carSearch.Transmission + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.SearchKeyword))
            {
                query.Append(" and (marka_name like '%" + carSearch.SearchKeyword + "%' or model_name like '%" + carSearch.SearchKeyword + "%')");
            }
            if (!string.IsNullOrEmpty(carSearch.HomeSearch))
            {
                query.Append(" and (marka_name like '%" + carSearch.HomeSearch + "%'" +
                             " or model_name like '%" + carSearch.HomeSearch + "%'" +
                             " or year like '%" + carSearch.HomeSearch + "%'" +
                             " or kuzov like '%" + carSearch.HomeSearch + "%')");
            }


            //if (!string.IsNullOrEmpty(carSearch.HomeSearch))
            //{
            //    query.Append(" and (marka_name like '%" + carSearch.HomeSearch + "%' or model_name like '%" + carSearch.HomeSearch + "%')");
            //}

            query.Append(" order by year desc, avg_price asc limit " +
                         (carSearch.Offset < 0 ? 0 : carSearch.Offset) + ", " + carSearch.ItemsPerPage);

            return query.ToString();
        }

        //public static string SQL_ALL_DATA_BY_SEARCH_CRITERIA_COUNT(CarSearchViewModel carSearch)
        //{

        //    var query = new StringBuilder("select count(*) from main where auction_type != 1 && avg_price != 0");

        //    if (!string.IsNullOrEmpty(carSearch.MarkaName))
        //    {
        //        query.Append($" and marka_name = '{carSearch.MarkaName}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.HomeMarkaName))
        //    {
        //        query.Append($" and marka_name = '{carSearch.HomeMarkaName}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.ModelName))
        //    {
        //        query.Append($" and model_name = '{carSearch.ModelName}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.Type))
        //    {
        //        query.Append($" and kuzov = '{carSearch.Type}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.ModelCode))
        //    {
        //        query.Append($" and kuzov = '{carSearch.ModelCode}'");
        //    }
        //    bool hasOverPrice = !string.IsNullOrEmpty(carSearch.OverPrice) &&
        //                        int.TryParse(carSearch.OverPrice, out int overPriceValue) &&
        //                        overPriceValue != 0;

        //    bool hasUnderPrice = !string.IsNullOrEmpty(carSearch.UnderPrice) &&
        //                         int.TryParse(carSearch.UnderPrice, out int underPriceValue) &&
        //                         underPriceValue != 0;

        //    if (hasOverPrice || hasUnderPrice)
        //    {
        //        // When OverPrice or UnderPrice is provided, ignore FromPrice and ToPrice.
        //        if (hasOverPrice)
        //        {
        //            query.Append($" and AVG_PRICE >= {carSearch.OverPrice}");
        //        }
        //        if (hasUnderPrice)
        //        {
        //            query.Append($" and AVG_PRICE <= {carSearch.UnderPrice}");
        //        }
        //    }
        //    else
        //    {
        //        // If both OverPrice and UnderPrice are 0 or null, then use FromPrice and ToPrice.
        //        if (!string.IsNullOrEmpty(carSearch.FromPrice) &&
        //            int.TryParse(carSearch.FromPrice, out int fromPriceValue) &&
        //            fromPriceValue != 0)
        //        {
        //            query.Append($" and AVG_PRICE >= {fromPriceValue}");
        //        }
        //        if (!string.IsNullOrEmpty(carSearch.ToPrice) &&
        //            int.TryParse(carSearch.ToPrice, out int toPriceValue) &&
        //            toPriceValue != 0)
        //        {
        //            query.Append($" and AVG_PRICE <= {toPriceValue}");
        //        }
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.FromYear))
        //    {
        //        query.Append($" and year >= {carSearch.FromYear}");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.ToYear))
        //    {
        //        query.Append($" and year <= {carSearch.ToYear}");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.Engine))
        //    {
        //        query.Append($" and ENG_V = '{carSearch.Engine}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.Color))
        //    {
        //        query.Append($" and color = '{carSearch.Engine}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.MilageFrom))
        //    {
        //        query.Append($" and mileage >= {carSearch.MilageFrom}");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.MilageTo))
        //    {
        //        query.Append($" and mileage <= {carSearch.MilageTo}");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.Transmission))
        //    {
        //        query.Append($" and kpp = '{carSearch.Transmission}'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.SearchKeyword))
        //    {
        //        query.Append($" and marka_name like '%{carSearch.SearchKeyword}%' or model_name like '%{carSearch.SearchKeyword}%'");
        //    }
        //    if (!string.IsNullOrEmpty(carSearch.HomeSearch))
        //    {
        //        query.Append($" and marka_name like '%{carSearch.HomeSearch}%' or model_name like '%{carSearch.HomeSearch}%'");
        //    }
        //    return query.ToString();
        //}

        public static string SQL_ALL_DATA_BY_SEARCH_CRITERIA_COUNT(CarSearchViewModel carSearch)
        {
            var query = new StringBuilder("select count(*) from main where auction_type != 1 and avg_price != 0");

            if (!string.IsNullOrEmpty(carSearch.MarkaName))
            {
                query.Append(" and marka_name = '" + carSearch.MarkaName + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.HomeMarkaName))
            {
                query.Append(" and marka_name = '" + carSearch.HomeMarkaName + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.ModelName))
            {
                query.Append(" and model_name = '" + carSearch.ModelName + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.Type))
            {
                query.Append(" and kuzov = '" + carSearch.Type + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.ModelCode))
            {
                query.Append(" and kuzov = '" + carSearch.ModelCode + "'");
            }

            // Price Filtering Section:
            // If OverPrice or UnderPrice are provided, they take precedence.
            bool hasOverPrice = !string.IsNullOrEmpty(carSearch.OverPrice) &&
                                int.TryParse(carSearch.OverPrice, out int overPriceValue) &&
                                overPriceValue != 0;
            bool hasUnderPrice = !string.IsNullOrEmpty(carSearch.UnderPrice) &&
                                 int.TryParse(carSearch.UnderPrice, out int underPriceValue) &&
                                 underPriceValue != 0;

            if (hasOverPrice || hasUnderPrice)
            {
                // Build condition based on the maximum of AVG_PRICE and FINISH.
                // If finish > avg_price then finish is used; else avg_price is used.
                var priceCondition = new StringBuilder(" and (");
                if (hasOverPrice)
                {
                    priceCondition.Append("((finish > avg_price and finish >= " + carSearch.OverPrice + ") or (finish <= avg_price and avg_price >= " + carSearch.OverPrice + "))");
                }
                if (hasUnderPrice)
                {
                    if (hasOverPrice)
                    {
                        priceCondition.Append(" and ");
                    }
                    priceCondition.Append("((finish > avg_price and finish <= " + carSearch.UnderPrice + ") or (finish <= avg_price and avg_price <= " + carSearch.UnderPrice + "))");
                }
                priceCondition.Append(")");
                query.Append(priceCondition.ToString());
            }
            else
            {
                // Otherwise, use FromPrice and ToPrice if provided.
                bool hasFromPrice = !string.IsNullOrEmpty(carSearch.FromPrice) &&
                                    int.TryParse(carSearch.FromPrice, out int fromPriceValue) &&
                                    fromPriceValue != 0;
                bool hasToPrice = !string.IsNullOrEmpty(carSearch.ToPrice) &&
                                  int.TryParse(carSearch.ToPrice, out int toPriceValue) &&
                                  toPriceValue != 0;
                if (hasFromPrice || hasToPrice)
                {
                    var priceCondition = new StringBuilder(" and (");
                    if (hasFromPrice)
                    {
                        priceCondition.Append("((finish > avg_price and finish >= " + carSearch.FromPrice + ") or (finish <= avg_price and avg_price >= " + carSearch.FromPrice + "))");
                    }
                    if (hasToPrice)
                    {
                        if (hasFromPrice)
                        {
                            priceCondition.Append(" and ");
                        }
                        priceCondition.Append("((finish > avg_price and finish <= " + carSearch.ToPrice + ") or (finish <= avg_price and avg_price <= " + carSearch.ToPrice + "))");
                    }
                    priceCondition.Append(")");
                    query.Append(priceCondition.ToString());
                }
            }

            if (!string.IsNullOrEmpty(carSearch.FromYear))
            {
                query.Append(" and year >= " + carSearch.FromYear);
            }
            if (!string.IsNullOrEmpty(carSearch.ToYear))
            {
                query.Append(" and year <= " + carSearch.ToYear);
            }
            if (!string.IsNullOrEmpty(carSearch.Engine))
            {
                query.Append(" and ENG_V = '" + carSearch.Engine + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.Color))
            {
                query.Append(" and color = '" + carSearch.Color + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.MilageFrom))
            {
                query.Append(" and mileage >= " + carSearch.MilageFrom);
            }
            if (!string.IsNullOrEmpty(carSearch.MilageTo))
            {
                query.Append(" and mileage <= " + carSearch.MilageTo);
            }
            if (!string.IsNullOrEmpty(carSearch.Transmission))
            {
                query.Append(" and kpp = '" + carSearch.Transmission + "'");
            }
            if (!string.IsNullOrEmpty(carSearch.SearchKeyword))
            {
                query.Append(" and (marka_name like '%" + carSearch.SearchKeyword + "%' or model_name like '%" + carSearch.SearchKeyword + "%')");
            }
            if (!string.IsNullOrEmpty(carSearch.HomeSearch))
            {
                query.Append(" and (marka_name like '%" + carSearch.HomeSearch + "%' or model_name like '%" + carSearch.HomeSearch + "%')");
            }
            return query.ToString();
        }
        public static List<Maker> ToMakers(List<Car> response)
        {
            var result = response
                        .GroupBy(x => x.MARKA_NAME) // Group by MARKA_NAME
                        .OrderBy(g => g.Key) // Order by MARKA_NAME
                        .Select(g => new Maker
                        {
                            marka_name = g.Key,
                            models_count = Convert.ToInt32(g.Sum(x => Convert.ToInt32(x.TAG2))) // Count of items in each group
                        }).ToList();

            return result;
        }
        public static List<Model> ToModels(List<Car> response)
        {
            var data = response.Select(m => new Model
                            {
                                marka_name = m.MARKA_NAME,
                                model_name = m.MODEL_NAME,
                                total_count = Convert.ToInt32(m.TAG2)
                                
                            }).ToList();

            return data;
        }

        public static List<Model> ToFillModels(List<Car> response)
        {
            var data = response.GroupBy(m => m.MODEL_NAME)
                           .Select(group => new Model
                           {
                               model_name = group.Key,
                               total_count = Convert.ToInt32(group.Sum(x => Convert.ToInt32(x.TAG2))) // Counting occurrences of each model name
                           }).ToList();
            return data;
        }
    }
}
