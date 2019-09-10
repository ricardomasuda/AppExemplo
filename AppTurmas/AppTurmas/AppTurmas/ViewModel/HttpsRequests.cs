using AppTurmas.Model;
using AppTurmas.View.PopUpPage;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTurmas.ViewModel
{
    class HttpsRequests <Request, Response>
    {
        const string URL = "https://extranet.esqproducoes.com.br/app_turmas/";

        public static async Task<Response> PostAsync(Request _requisicao, Page _page = null)
        {

            //TODO- fazer teste aqui
            //var _load = new LoadPage();

            Response _return;
            //if (_page != null)
                //await _page.Navigation.PushPopupAsync(_load, true);
            try
            {
                var _json = JsonConvert.SerializeObject(_requisicao);
                var _url = URL + ((IRequest)_requisicao).Action;

                HttpClient _client = new HttpClient();
                _client.Timeout = new TimeSpan(0, 0, 15);

                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applcation/json"));

                HttpResponseMessage _result = null;
                if (_requisicao != null)
                {
                    var _content = new StringContent(_json, Encoding.UTF8, "application/json");
                    Debug.WriteLine("--------INICIO-----------");
                    Debug.WriteLine(_json);
                    _result = await _client.PostAsync(_url, _content);
                }

                //var _content = new StringContent(_json, Encoding.UTF8, "application/json");
                //var _result = await _client.PostAsync(_url, _content);

                var _jsonResposta = _result.Content.ReadAsStringAsync().Result;

                Debug.WriteLine("--------fim-----------");
                Debug.WriteLine(_jsonResposta);

                _return = JsonConvert.DeserializeObject<Response>(_jsonResposta);
            }
            catch (Exception e)
            {
                _return = default(Response);
            }
            //if (_page != null)
            //_load.Close();
            return _return;
        }
    }
}
