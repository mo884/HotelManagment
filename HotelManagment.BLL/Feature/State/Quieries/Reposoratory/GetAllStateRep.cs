using HotelManagment.BLL.Feature.State.ModelVM;
using HotelManagment.BLL.Feature.State.Quieries.Interface;
using HotelManagment.BLL.Mapping.StateMap.Queries;
using HotelManagment.DAL.Database;
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
            var Data = HotelDBContext.State.ToList();
            if (Data is not null)
                return StateMapping.Map(Data);

            return null;
        }
    }
}
