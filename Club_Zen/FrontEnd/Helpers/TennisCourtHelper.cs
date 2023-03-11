using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class TennisCourtHelper
    {
        private ServiceRepository ServiceRepository;


        public TennisCourtHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<TennisCourtViewModel> GetAll()
        {
            List<TennisCourtViewModel> lista = new List<TennisCourtViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/tennisCourt");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<TennisCourtViewModel>>(content);
            }

            return lista;

        }




        public TennisCourtViewModel Get(int id)
        {
            TennisCourtViewModel TennisCourtViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/tennisCourt/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            TennisCourtViewModel = JsonConvert.DeserializeObject<TennisCourtViewModel>(content);



            return TennisCourtViewModel;
        }


        public TennisCourtViewModel Create(TennisCourtViewModel tennisCourt)
        {


            TennisCourtViewModel TennisCourtViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/tennisCourt/", tennisCourt);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            TennisCourtViewModel = JsonConvert.DeserializeObject<TennisCourtViewModel>(content);



            return TennisCourtViewModel;
        }

        public TennisCourtViewModel Edit(TennisCourtViewModel tennisCourt)
        {


            TennisCourtViewModel TennisCourt;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/tennisCourt/", tennisCourt);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            TennisCourt = JsonConvert.DeserializeObject<TennisCourtViewModel>(content);



            return TennisCourt;
        }



        public TennisCourtViewModel Delete(int id)
        {


            TennisCourtViewModel TennisCourt;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/tennisCourt/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            TennisCourt = JsonConvert.DeserializeObject<TennisCourtViewModel>(content);



            return TennisCourt;
        }

    }
}