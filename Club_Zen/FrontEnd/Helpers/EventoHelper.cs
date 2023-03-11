using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class EventoHelper
    {
        private ServiceRepository ServiceRepository;


        public EventoHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<EventoViewModel> GetAll()
        {
            List<EventoViewModel> lista = new List<EventoViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/evento");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<EventoViewModel>>(content);
            }

            return lista;

        }




        public EventoViewModel Get(int id)
        {
            EventoViewModel EventoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/evento/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            EventoViewModel = JsonConvert.DeserializeObject<EventoViewModel>(content);



            return EventoViewModel;
        }


        public EventoViewModel Create(EventoViewModel evento)
        {


            EventoViewModel EventoViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/evento/", evento);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            EventoViewModel = JsonConvert.DeserializeObject<EventoViewModel>(content);



            return EventoViewModel;
        }

        public EventoViewModel Edit(EventoViewModel evento)
        {


            EventoViewModel Evento;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/evento/", evento);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Evento = JsonConvert.DeserializeObject<EventoViewModel>(content);



            return Evento;
        }



        public EventoViewModel Delete(int id)
        {


            EventoViewModel Evento;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/evento/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Evento = JsonConvert.DeserializeObject<EventoViewModel>(content);



            return Evento;
        }

    }
}
