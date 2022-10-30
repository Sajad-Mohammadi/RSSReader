using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Models;

namespace DAL
{
    public class AvsnittRepository : IAvsnittRepository<Avsnitt>
    {
        FileManager fileManager;
        List<Avsnitt> avsnittList;

        public AvsnittRepository()
        {
            avsnittList = new List<Avsnitt>();
            fileManager = new FileManager();
        }

        //Hämtar alla avsnitt som finns i den url som används när man lägger till en ny podcast
        public async Task<List<Avsnitt>> GetAllaAvsnittFromRSS(string url)
        {
            XmlReader rssReader = XmlReader.Create(url);
            SyndicationFeed rssFeed = await Task.Run(() => SyndicationFeed.Load(rssReader));

            List<Avsnitt> allaAvsnitt = new List<Avsnitt>();
            foreach (SyndicationItem item in rssFeed.Items)
            {
                Avsnitt avsnitt = new Avsnitt();
                avsnitt.Titel = item.Title.Text;
                avsnitt.Beskrivning = item.Summary.Text;
                allaAvsnitt.Add(avsnitt);
            }
            return allaAvsnitt;
        }

        public List<Avsnitt> GetAllaAvsnittFromArtikelTitel(string podcastTitel)
        {
            List<Avsnitt> allaAvsnitt = new List<Avsnitt>();

            return allaAvsnitt;
        }
    }
}
