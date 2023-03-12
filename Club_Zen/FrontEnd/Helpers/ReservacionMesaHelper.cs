using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class ReservacionMesaHelper
    {
        private ServiceRepository ServiceRepository;


        public ReservacionMesaHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<ReservacionMesaViewModel> GetAll()
        {
            List<ReservacionMesaViewModel> lista = new List<ReservacionMesaViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/reservacionMesa");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<ReservacionMesaViewModel>>(content);
            }

            return lista;

        }




        public ReservacionMesaViewModel Get(int id)
        {
            ReservacionMesaViewModel ReservacionMesaViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/reservacionMesa/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionMesaViewModel = JsonConvert.DeserializeObject<ReservacionMesaViewModel>(content);



            return ReservacionMesaViewModel;
        }


        public ReservacionMesaViewModel Create(ReservacionMesaViewModel reservacionMesa)
        {


            ReservacionMesaViewModel ReservacionMesaViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/reservacionMesa/", reservacionMesa);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionMesaViewModel = JsonConvert.DeserializeObject<ReservacionMesaViewModel>(content);



            return ReservacionMesaViewModel;
        }

        public ReservacionMesaViewModel Edit(ReservacionMesaViewModel reservacionMesa)
        {


            ReservacionMesaViewModel ReservacionMesa;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/reservacionMesa/", reservacionMesa);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionMesa = JsonConvert.DeserializeObject<ReservacionMesaViewModel>(content);



            return ReservacionMesa;
        }



        public ReservacionMesaViewModel Delete(int id)
        {


            ReservacionMesaViewModel ReservacionMesa;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/reservacionMesa/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ReservacionMesa = JsonConvert.DeserializeObject<ReservacionMesaViewModel>(content);



            return ReservacionMesa;
        }

    }
}