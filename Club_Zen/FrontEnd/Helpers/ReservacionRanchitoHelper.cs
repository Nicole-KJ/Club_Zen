using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class ReservacionRanchitoHelper
    {
        private ServiceRepository ServiceRepository;


        public ReservacionRanchitoHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<ReservacionRanchitoViewModel> GetAll()
        {
            List<ReservacionRanchitoViewModel> lista = new List<ReservacionRanchitoViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/reservacionRanchito");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<ReservacionRanchitoViewModel>>(content);
            }

            return lista;

        }




        public ReservacionRanchitoViewModel Get(int id)
        {
            ReservacionRanchitoViewModel ReservacionRanchitoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/reservacionRanchito/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionRanchitoViewModel = JsonConvert.DeserializeObject<ReservacionRanchitoViewModel>(content);



            return ReservacionRanchitoViewModel;
        }


        public ReservacionRanchitoViewModel Create(ReservacionRanchitoViewModel reservacionRanchito)
        {


            ReservacionRanchitoViewModel ReservacionRanchitoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/reservacionRanchito/", reservacionRanchito);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionRanchitoViewModel = JsonConvert.DeserializeObject<ReservacionRanchitoViewModel>(content);



            return ReservacionRanchitoViewModel;
        }

        public ReservacionRanchitoViewModel Edit(ReservacionRanchitoViewModel reservacionRanchito)
        {


            ReservacionRanchitoViewModel ReservacionRanchito;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/reservacionRanchito/", reservacionRanchito);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionRanchito = JsonConvert.DeserializeObject<ReservacionRanchitoViewModel>(content);



            return ReservacionRanchito;
        }



        public ReservacionRanchitoViewModel Delete(int id)
        {


            ReservacionRanchitoViewModel ReservacionRanchito;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/reservacionRanchito/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionRanchito = JsonConvert.DeserializeObject<ReservacionRanchitoViewModel>(content);



            return ReservacionRanchito;
        }

    }
}