using Newtonsoft.Json;
using System.Net;

namespace DeckLab.Models
{
    public class DeckAI
    {
        public Deck CallAPI(string id, string endpoint)
        {
            string url = $"https://deckofcardsapi.com/api/deck/{id}/{endpoint}/?count=5";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();
            Deck result = JsonConvert.DeserializeObject<Deck>(JSON);
            return result;
        }
        //    public List<Card> GetCards(string JSON)
        //    {
        //        List<Card> result = JsonConvert.DeserializeObject<List<Card>>(JSON);
        //        return result;
        //    }
    }
}    
//https://deckofcardsapi.com/api/deck/ztnd3y2kis02/draw/?count=5
//lz3s327dp705