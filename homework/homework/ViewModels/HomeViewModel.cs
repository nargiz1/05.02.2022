using homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework.HomeViewModels
{
    public class HomeViewModel
    {
        public Jumborton jumborton { get; set; }
        public List<Counter> counter { get; set; }
        public List<CounterItem> counterItem { get; set; }
        public List<Feature> features { get; set; }
        public List<SocialMedia> socialMedias { get; set; }
        public List<News> news { get; set; }
        public List<Portfolio> portfolios { get; set; }
        public List<Category> categories { get; set; }
        public List<Pricing> pricings { get; set; }
        public List<Client> clients { get; set; }
    }
}
