using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alliance.NihonggoFlash.Core.Models
{
    [ImplementPropertyChanged]
    public class FlashCard
    {
        public string Word { get; set; }
        public string HowToRead { get; set; }
        public string Meaning { get; set; }
        public string Sample { get; set; }
    }
}
