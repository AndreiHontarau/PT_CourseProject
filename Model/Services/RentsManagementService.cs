using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class RentsManagementService : IRentsManagementService
    {
        private readonly IRentsRepository _rentsRepository;
        private readonly ICustomersRepository _customersRepository;
        private readonly IMoviesRepository _moviesRepository;

        public RentsManagementService(IRentsRepository rentsRepository, ICustomersRepository customersRepository, IMoviesRepository moviesRepository)
        {
            _rentsRepository = rentsRepository;
            _customersRepository = customersRepository;
            _moviesRepository = moviesRepository;
        }
    }
}
