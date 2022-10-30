using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BL
{
    public class AvsnittController
    {
        private IAvsnittRepository<Avsnitt> avsnittRepository;

        public AvsnittController()
        {
            avsnittRepository = new AvsnittRepository();
        }

        public List<Avsnitt> GetAvsnitt(string artikel)
        {
            return avsnittRepository.GetAllaAvsnittFromArtikelTitel(artikel);
        }
    }
}
