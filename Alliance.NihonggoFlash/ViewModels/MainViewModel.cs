using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alliance.NihonggoFlash.Models;
using Alliance.NihonggoFlash.Services;

namespace Alliance.NihonggoFlash.ViewModels
{
    [ImplementPropertyChanged]
    class MainViewModel
    {
        public FlashCard FlashCard { get; set; } = new FlashCard();
        System.Random _rng = new Random();

        public MainViewModel()
        {
            FlashCard = GetRandomCard();
        }

        private FlashCard GetRandomCard()
        {
            var cards = SimpleIoc.Default.GetInstance<IRepository>().Cards;
            //var count = cards.Count();
            return cards.First();
        }
    }
}
