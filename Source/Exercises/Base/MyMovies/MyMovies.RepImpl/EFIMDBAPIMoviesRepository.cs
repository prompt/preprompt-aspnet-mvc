using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using MyMovies.Rep;

namespace MyMovies.RepImpl {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DomainModel;
    using DomainModel.ServicesRepositoryInterfaces;
    using Rep.Helpers.Collections;

    public class EFIMDBAPIMoviesRepository : EFDbContextRepository<Movie, int>, IMoviesRepository
    {
        public EFIMDBAPIMoviesRepository(MovieDbContext moviesContext) : base(moviesContext) { }
    }
}