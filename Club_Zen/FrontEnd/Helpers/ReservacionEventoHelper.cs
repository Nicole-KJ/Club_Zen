using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class ReservacionEventoHelper
    {
        private ServiceRepository ServiceRepository;


        public ReservacionEventoHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<ReservacionEventoViewModel> GetAll()
        {
            List<ReservacionEventoViewModel> lista = new List<ReservacionEventoViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/reservacionEvento");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<ReservacionEventoViewModel>>(content);
            }

            return lista;

        }




        public ReservacionEventoViewModel Get(int id)
        {
            ReservacionEventoViewModel ReservacionEventoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/reservacionEvento/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionEventoViewModel = JsonConvert.DeserializeObject<ReservacionEventoViewModel>(content);



            return ReservacionEventoViewModel;
        }


        public ReservacionEventoViewModel Create(ReservacionEventoViewModel reservacionEvento)
        {


            ReservacionEventoViewModel ReservacionEventoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/reservacionEvento/", reservacionEvento);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionEventoViewModel = JsonConvert.DeserializeObject<ReservacionEventoViewModel>(content);



            return ReservacionEventoViewModel;
        }

        public ReservacionEventoViewModel Edit(ReservacionEventoViewModel reservacionEvento)
        {


            ReservacionEventoViewModel ReservacionEvento;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/reservacionEvento/", reservacionEvento);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionEvento = JsonConvert.DeserializeObject<ReservacionEventoViewModel>(content);



            return ReservacionEvento;
        }



        public ReservacionEventoViewModel Delete(int id)
        {


            ReservacionEventoViewModel ReservacionEvento;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/reservacionEvento/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionEvento = JsonConvert.DeserializeObject<ReservacionEventoViewModel>(content);



            return ReservacionEvento;
        }

    }
}