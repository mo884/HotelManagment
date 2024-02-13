using HotelManagment.BLL.Feature.State.ModelVM;
using HotelManagment.BLL.Feature.State.Quieries.Interface;
using HotelManagment.BLL.Mapping.StateMap.Queries;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.State.Quieries.Reposoratory
{
    public class GetAllStateRep : IGetAllStateRep
    {
        private readonly HotelDBContext HotelDBContext;
        public GetAllStateRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public List<StateVM> GetAll()
        {
            var Data = HotelDBContext.State.Include(a => a.cities).ToList() ;
            if (Data is not null)
                return StateMapping.Map(Data);

            return null;
        }
    }
}
