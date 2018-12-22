using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IMovieRegistrationService
    {
        void Registrate(MovieRecord newMovie, MovieRecordExtended newMovieExtended);
        List<CategoryRecord> ReadCategories();
    }
}
