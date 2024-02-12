using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.BLL.Feature.Guest.Queries.InterFace;
using HotelManagment.BLL.Mapping.GuestMap.Queries;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Guest.Queries.Reposoratory
{
    public class GetAllGuestRep : IGetAllGuestRep
    {
        private readonly HotelDBContext HotelDBContext;
        public GetAllGuestRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public List<GetAllGuestVM> GetAll()
        {
            var Data = HotelDBContext.Guests.Include(a=>a.Streets).ToList();
            if(Data is not null)
            return GetAllGuestMapping.Map(Data);
            return null;
        }
    }
}
