using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class ReservacionTennisHelper
    {
        private ServiceRepository ServiceRepository;


        public ReservacionTennisHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<ReservacionTennisViewModel> GetAll()
        {
            List<ReservacionTennisViewModel> lista = new List<ReservacionTennisViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/reservacionTennis");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<ReservacionTennisViewModel>>(content);
            }

            return lista;

        }




        public ReservacionTennisViewModel Get(int id)
        {
            ReservacionTennisViewModel ReservacionTennisViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/reservacionTennis/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionTennisViewModel = JsonConvert.DeserializeObject<ReservacionTennisViewModel>(content);



            return ReservacionTennisViewModel;
        }


        public ReservacionTennisViewModel Create(ReservacionTennisViewModel reservacionTennis)
        {


            ReservacionTennisViewModel ReservacionTennisViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/reservacionTennis/", reservacionTennis);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionTennisViewModel = JsonConvert.DeserializeObject<ReservacionTennisViewModel>(content);



            return ReservacionTennisViewModel;
        }

    }
}