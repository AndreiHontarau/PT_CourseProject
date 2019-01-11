using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class RentRegistrationService : IRentRegistrationService
    {
        private readonly IRentsRepository _rentsRepository;
        private readonly ICustomersRepository _customersRepository;
        private readonly IMoviesRepository _moviesRepository;

        public RentRegistrationService(IRentsRepository rentsRepository, ICustomersRepository customersRepository, IMoviesRepository moviesRepository)
        {
            _rentsRepository = rentsRepository;
            _customersRepository = customersRepository;
            _moviesRepository = moviesRepository;
        }
    }
}
