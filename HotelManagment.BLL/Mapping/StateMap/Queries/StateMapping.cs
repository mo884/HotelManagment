using HotelManagment.BLL.Feature.State.ModelVM;
using HotelManagment.BLL.Feature.State.Quieries.Reposoratory;
using HotelManagment.DAL.Entities.Adress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Mapping.StateMap.Queries
{
    public static class StateMapping
    {
        public static List<StateVM> Map(List<State> state)
        {

            List<StateVM> getAllStateVMs = new List<StateVM>();
            foreach (var item in state)
            {
                getAllStateVMs.Add(MapState(item));
            }
            return getAllStateVMs;
        }

        private static StateVM MapState(State state)
        {
            StateVM getAllStateRep = new StateVM()
            {
                ID = state.ID,
                StateName = state.StateName,
                ZIbCode = state.ZIbCode,
                cities = state.cities
            };
            return getAllStateRep;
        }
    }
}
