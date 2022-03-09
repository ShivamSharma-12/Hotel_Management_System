using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAcessLayer;

namespace BusinessLayer
{

    public class CustomerBL
    {

        public DataSet GetCityBL() // passing Bussiness object Here
        {
            try
            {
                HotelDAL objUserda = new HotelDAL(); // Creating object of Dataccess
                return objUserda.hh(); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public DataSet GetHotelByCityBL(string cityName) // passing Bussiness object Here
        {
            try
            {
                HotelDAL objUserda = new HotelDAL(); // Creating object of Dataccess
                return objUserda.searchcityBl(cityName); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public DataSet GetRoomTypeByHotelNameBL(string HotelName) // passing Bussiness object Here
        {
            try
            {
                HotelDAL objUserda = new HotelDAL(); // Creating object of Dataccess
                return objUserda.searchRoomTypeBl( HotelName); // calling Method of DataAccess
            }
            catch
            {
                throw;

            }

        }
        public DataSet GetRoomDetails(string HotelName, string RoomType) // passing Bussiness object Here
        {
            try
            {
                HotelDAL objUserda = new HotelDAL(); // Creating object of Dataccess
                return objUserda.SearchByRoomType(HotelName,RoomType); // calling Method of DataAccess
            }
            catch
            {
                throw;

            }

        }

        public int UpdateRates(int RatePerNight, int RoomTypeId, int HotelId) // passing Bussiness object Here
        {
            try
            {
                HotelDAL objUserda = new HotelDAL(); // Creating object of Dataccess
                return objUserda.UpdateRate(RatePerNight, RoomTypeId, HotelId); // calling Method of DataAccess
            }
            catch
            {
                throw;

            }

        }

    }
}