using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class MesaHelper
    {
        private ServiceRepository ServiceRepository;


        public MesaHelper()
        {
            ServiceRepository = new ServiceRepository();

        }
        public MesaHelper(string token)
        {
            ServiceRepository = new ServiceRepository(token);

        }



        public List<MesaViewModel> GetAll()
        {
            List<MesaViewModel> lista = new List<MesaViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/mesa");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<MesaViewModel>>(content);
            }

            return lista;

        }




        public MesaViewModel Get(int id)
        {
            MesaViewModel MesaViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/mesa/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            MesaViewModel = JsonConvert.DeserializeObject<MesaViewModel>(content);



            return MesaViewModel;
        }


        public MesaViewModel Create(MesaViewModel mesa)
        {


            MesaViewModel MesaViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/mesa/", mesa);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            MesaViewModel = JsonConvert.DeserializeObject<MesaViewModel>(content);



            return MesaViewModel;
        }

        public MesaViewModel Edit(MesaViewModel mesa)
        {


            MesaViewModel Mesa;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/mesa/", mesa);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Mesa = JsonConvert.DeserializeObject<MesaViewModel>(content);



            return  Mesa;
        }



        public MesaViewModel Delete(int id)
        {


            MesaViewModel Mesa;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/mesa/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Mesa = JsonConvert.DeserializeObject<MesaViewModel>(content);



            return Mesa;
        }

    }
}
