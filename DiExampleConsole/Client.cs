using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DiExampleConsole
{
    public class Client
    {
        static readonly HttpClient httpClient = new HttpClient();

        ILogger logger;

        private string mockServerUrl = "https://5a949e1c-9dfe-454a-865e-0df58d2afd5f.mock.pstmn.io";

        /// <summary>
        /// Client doesn't care about ILogger Classtype
        /// Type will be injected by constructor, from outside
        /// </summary>
        /// <param name="logger"></param>
        public Client(ILogger logger)
        {
            this.logger = logger;
        }

        internal void DoSomething()
        {
            // Whether the Textlogger or ClientLogger is used is determined by the injection in the constructor
            logger.Log("Something happening here...", LogLevel.Informational);

            try
            {

                Task<int> valueTask = GetValue("a");

                Console.WriteLine("Something happening here...");
                valueTask.Wait();
                int value = valueTask.Result;
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message, LogLevel.Critical);
            }
        }

        public async Task<int> GetValue(string valueId)
        {
            int value = -1;
            try
            {
                string requestUri = $"{mockServerUrl}/GetValue?ValueId={valueId}";
                using HttpResponseMessage response = await httpClient.GetAsync(requestUri);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                JsonDocument doc = JsonDocument.Parse(responseBody);

                value = doc.RootElement.GetProperty("value").GetInt32();
            }
            catch (Exception ex)
            {
                throw ex;
                //ToDo: Do Something
            }
            return value;
        }

    }
}
