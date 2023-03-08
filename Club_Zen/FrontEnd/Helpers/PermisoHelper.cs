using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class PermisoHelper
    {
        private ServiceRepository ServiceRepository;


        public PermisoHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<PermisoViewModel> GetAll()
        {
            List<PermisoViewModel> lista = new List<PermisoViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/permiso");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<PermisoViewModel>>(content);
            }

            return lista;

        }




        public PermisoViewModel Get(int id)
        {
            PermisoViewModel PermisoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/permiso/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            PermisoViewModel = JsonConvert.DeserializeObject<PermisoViewModel>(content);



            return PermisoViewModel;
        }


        public PermisoViewModel Create(PermisoViewModel permiso)
        {


            PermisoViewModel PermisoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/permiso/", permiso);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            PermisoViewModel = JsonConvert.DeserializeObject<PermisoViewModel>(content);



            return PermisoViewModel;
        }

    }
}