using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YRTJapan.Core.Entities;
using YRTJapan.DataAccess.Data;
using YRTJapan.DataAccess.Repository.IRepository;

namespace YRTJapan.DataAccess.Repository
{
    internal class StockRepository : IStock
    {
        private readonly string _connectionString;
        private readonly string _imageFolderPath;

        public StockRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _imageFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "car-images");

            if (!Directory.Exists(_imageFolderPath))
                Directory.CreateDirectory(_imageFolderPath);
        }

        // ✅ CREATE
        public void AddCar(Car car, List<IFormFile> imageFiles)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var insertQuery = @"
INSERT INTO Car (ID, LOT, AUCTION_TYPE, AUCTION_DATE, AUCTION, MARKA_ID, MODEL_ID, MARKA_NAME, MODEL_NAME, YEAR, TOWN, ENG_V, PW, KUZOV, GRADE, COLOR, KPP, KPP_TYPE, PRIV, MILEAGE, EQUIP, RATE, START, FINISH, STATUS, TIME, AVG_PRICE, AVG_STRING, IMAGES, TAG2)
VALUES (@ID, @LOT, @AUCTION_TYPE, @AUCTION_DATE, @AUCTION, @MARKA_ID, @MODEL_ID, @MARKA_NAME, @MODEL_NAME, @YEAR, @TOWN, @ENG_V, @PW, @KUZOV, @GRADE, @COLOR, @KPP, @KPP_TYPE, @PRIV, @MILEAGE, @EQUIP, @RATE, @START, @FINISH, @STATUS, @TIME, @AVG_PRICE, @AVG_STRING, @IMAGES, @TAG2)";

                using (var cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", car.ID);
                    cmd.Parameters.AddWithValue("@LOT", car.LOT);
                    cmd.Parameters.AddWithValue("@AUCTION_TYPE", car.AUCTION_TYPE);
                    cmd.Parameters.AddWithValue("@AUCTION_DATE", car.AUCTION_DATE);
                    cmd.Parameters.AddWithValue("@AUCTION", car.AUCTION);
                    cmd.Parameters.AddWithValue("@MARKA_ID", car.MARKA_ID);
                    cmd.Parameters.AddWithValue("@MODEL_ID", car.MODEL_ID);
                    cmd.Parameters.AddWithValue("@MARKA_NAME", car.MARKA_NAME);
                    cmd.Parameters.AddWithValue("@MODEL_NAME", car.MODEL_NAME);
                    cmd.Parameters.AddWithValue("@YEAR", car.YEAR);
                    cmd.Parameters.AddWithValue("@TOWN", car.TOWN);
                    cmd.Parameters.AddWithValue("@ENG_V", car.ENG_V);
                    cmd.Parameters.AddWithValue("@PW", car.PW);
                    cmd.Parameters.AddWithValue("@KUZOV", car.KUZOV);
                    cmd.Parameters.AddWithValue("@GRADE", car.GRADE);
                    cmd.Parameters.AddWithValue("@COLOR", car.COLOR);
                    cmd.Parameters.AddWithValue("@KPP", car.KPP);
                    cmd.Parameters.AddWithValue("@KPP_TYPE", car.KPP_TYPE);
                    cmd.Parameters.AddWithValue("@PRIV", car.PRIV);
                    cmd.Parameters.AddWithValue("@MILEAGE", car.MILEAGE);
                    cmd.Parameters.AddWithValue("@EQUIP", car.EQUIP);
                    cmd.Parameters.AddWithValue("@RATE", car.RATE);
                    cmd.Parameters.AddWithValue("@START", car.START);
                    cmd.Parameters.AddWithValue("@FINISH", car.FINISH);
                    cmd.Parameters.AddWithValue("@STATUS", car.STATUS);
                    cmd.Parameters.AddWithValue("@TIME", car.TIME);
                    cmd.Parameters.AddWithValue("@AVG_PRICE", car.AVG_PRICE);
                    cmd.Parameters.AddWithValue("@AVG_STRING", car.AVG_STRING);
                    cmd.Parameters.AddWithValue("@IMAGES", car.IMAGES ?? "");
                    cmd.Parameters.AddWithValue("@TAG2", car.TAG2 ?? "");

                    cmd.ExecuteNonQuery();
                }

                // Save images
                if (imageFiles != null)
                {
                    foreach (var file in imageFiles)
                    {
                        string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                        string savePath = Path.Combine(_imageFolderPath, fileName);

                        using (var stream = new FileStream(savePath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }

                        string imageUrl = "/car-images/" + fileName;

                        var imgCmd = new SqlCommand("INSERT INTO CarImages (CarID, ImageUrl) VALUES (@CarID, @ImageUrl)", conn);
                        imgCmd.Parameters.AddWithValue("@CarID", car.ID);
                        imgCmd.Parameters.AddWithValue("@ImageUrl", imageUrl);
                        imgCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // ✅ READ
        public List<Car> GetAllCars()
        {
            var list = new List<Car>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Car", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var car = new Car
                        {
                            ID = reader["ID"].ToString(),
                            LOT = reader["LOT"].ToString(),
                            AUCTION_TYPE = reader["AUCTION_TYPE"].ToString(),
                            AUCTION_DATE = reader["AUCTION_DATE"].ToString(),
                            AUCTION = reader["AUCTION"].ToString(),
                            MARKA_ID = reader["MARKA_ID"].ToString(),
                            MODEL_ID = reader["MODEL_ID"].ToString(),
                            MARKA_NAME = reader["MARKA_NAME"].ToString(),
                            MODEL_NAME = reader["MODEL_NAME"].ToString(),
                            YEAR = reader["YEAR"].ToString(),
                            TOWN = reader["TOWN"].ToString(),
                            ENG_V = reader["ENG_V"].ToString(),
                            PW = reader["PW"].ToString(),
                            KUZOV = reader["KUZOV"].ToString(),
                            GRADE = reader["GRADE"].ToString(),
                            COLOR = reader["COLOR"].ToString(),
                            KPP = reader["KPP"].ToString(),
                            KPP_TYPE = reader["KPP_TYPE"].ToString(),
                            PRIV = reader["PRIV"].ToString(),
                            MILEAGE = reader["MILEAGE"].ToString(),
                            EQUIP = reader["EQUIP"].ToString(),
                            RATE = reader["RATE"].ToString(),
                            START = reader["START"].ToString(),
                            FINISH = reader["FINISH"].ToString(),
                            STATUS = reader["STATUS"].ToString(),
                            TIME = reader["TIME"].ToString(),
                            AVG_PRICE = reader["AVG_PRICE"].ToString(),
                            AVG_STRING = reader["AVG_STRING"].ToString(),
                            IMAGES = reader["IMAGES"].ToString(),
                            TAG2 = reader["TAG2"].ToString(),
                            carImages = GetCarImages(reader["ID"].ToString())
                        };

                        list.Add(car);
                    }
                }
            }

            return list;
        }

        private List<CarImage> GetCarImages(string carId)
        {
            var images = new List<CarImage>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM CarImages WHERE CarID = @CarID", conn);
                cmd.Parameters.AddWithValue("@CarID", carId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        images.Add(new CarImage
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            CarID = reader["CarID"].ToString(),
                            ImageUrl = reader["ImageUrl"].ToString()
                        });
                    }
                }
            }

            return images;
        }

        // ✅ UPDATE
        public void UpdateCar(Car car)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var updateQuery = @"
UPDATE Car SET LOT=@LOT, AUCTION_TYPE=@AUCTION_TYPE, AUCTION_DATE=@AUCTION_DATE, AUCTION=@AUCTION,
MARKA_ID=@MARKA_ID, MODEL_ID=@MODEL_ID, MARKA_NAME=@MARKA_NAME, MODEL_NAME=@MODEL_NAME, YEAR=@YEAR,
TOWN=@TOWN, ENG_V=@ENG_V, PW=@PW, KUZOV=@KUZOV, GRADE=@GRADE, COLOR=@COLOR, KPP=@KPP, KPP_TYPE=@KPP_TYPE,
PRIV=@PRIV, MILEAGE=@MILEAGE, EQUIP=@EQUIP, RATE=@RATE, START=@START, FINISH=@FINISH, STATUS=@STATUS,
TIME=@TIME, AVG_PRICE=@AVG_PRICE, AVG_STRING=@AVG_STRING, IMAGES=@IMAGES, TAG2=@TAG2
WHERE ID=@ID";

                var cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@ID", car.ID);
                cmd.Parameters.AddWithValue("@LOT", car.LOT);
                cmd.Parameters.AddWithValue("@AUCTION_TYPE", car.AUCTION_TYPE);
                cmd.Parameters.AddWithValue("@AUCTION_DATE", car.AUCTION_DATE);
                cmd.Parameters.AddWithValue("@AUCTION", car.AUCTION);
                cmd.Parameters.AddWithValue("@MARKA_ID", car.MARKA_ID);
                cmd.Parameters.AddWithValue("@MODEL_ID", car.MODEL_ID);
                cmd.Parameters.AddWithValue("@MARKA_NAME", car.MARKA_NAME);
                cmd.Parameters.AddWithValue("@MODEL_NAME", car.MODEL_NAME);
                cmd.Parameters.AddWithValue("@YEAR", car.YEAR);
                cmd.Parameters.AddWithValue("@TOWN", car.TOWN);
                cmd.Parameters.AddWithValue("@ENG_V", car.ENG_V);
                cmd.Parameters.AddWithValue("@PW", car.PW);
                cmd.Parameters.AddWithValue("@KUZOV", car.KUZOV);
                cmd.Parameters.AddWithValue("@GRADE", car.GRADE);
                cmd.Parameters.AddWithValue("@COLOR", car.COLOR);
                cmd.Parameters.AddWithValue("@KPP", car.KPP);
                cmd.Parameters.AddWithValue("@KPP_TYPE", car.KPP_TYPE);
                cmd.Parameters.AddWithValue("@PRIV", car.PRIV);
                cmd.Parameters.AddWithValue("@MILEAGE", car.MILEAGE);
                cmd.Parameters.AddWithValue("@EQUIP", car.EQUIP);
                cmd.Parameters.AddWithValue("@RATE", car.RATE);
                cmd.Parameters.AddWithValue("@START", car.START);
                cmd.Parameters.AddWithValue("@FINISH", car.FINISH);
                cmd.Parameters.AddWithValue("@STATUS", car.STATUS);
                cmd.Parameters.AddWithValue("@TIME", car.TIME);
                cmd.Parameters.AddWithValue("@AVG_PRICE", car.AVG_PRICE);
                cmd.Parameters.AddWithValue("@AVG_STRING", car.AVG_STRING);
                cmd.Parameters.AddWithValue("@IMAGES", car.IMAGES ?? "");
                cmd.Parameters.AddWithValue("@TAG2", car.TAG2 ?? "");

                cmd.ExecuteNonQuery();
            }
        }

        // ✅ DELETE
        public void DeleteCar(string carId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var cmd1 = new SqlCommand("DELETE FROM CarImages WHERE CarID = @CarID", conn);
                cmd1.Parameters.AddWithValue("@CarID", carId);
                cmd1.ExecuteNonQuery();

                var cmd2 = new SqlCommand("DELETE FROM Car WHERE ID = @ID", conn);
                cmd2.Parameters.AddWithValue("@ID", carId);
                cmd2.ExecuteNonQuery();
            }
        }
    }

}
