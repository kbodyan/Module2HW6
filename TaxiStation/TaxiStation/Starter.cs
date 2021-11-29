using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation
{
    public class Starter
    {
        private const int _sectionSize = 5;
        private ICreateParkService _createSafariPark;
        private ICreateSectionService _createSectionService;
        private INumberOfKindsInSectionService _numberOfKindsInSectionService;
        private ISortByWeightService _sortByWeightService;
        private IFindAnimalByKindService _findAnimalByKindService;

        public Starter(
            ICreateParkService createSafariPark,
            ICreateSectionService createSectionService,
            INumberOfKindsInSectionService numberOfKindsInSectionService,
            ISortByWeightService sortByWeightService,
            IFindAnimalByKindService findAnimalByKindService)
        {
            _createSafariPark = createSafariPark;
            _createSectionService = createSectionService;
            _numberOfKindsInSectionService = numberOfKindsInSectionService;
            _sortByWeightService = sortByWeightService;
            _findAnimalByKindService = findAnimalByKindService;
        }

        public void Run()
        {
            var park = _createSafariPark.CreatePark();
            var section = _createSectionService.CreateSection(park, _sectionSize);
            var numbersOfKindsInSection = _numberOfKindsInSectionService.NumberOfKindsInSection(section);
            _sortByWeightService.SortByWeight(section);
            var resultOfSearch = _findAnimalByKindService.FindAnimalByKind(section, AnimalKinds.Lion);
        }
    }
}
