using System;
using System.Collections.Generic;
using System.Text;
using Template.Data.Context;
using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.Data.Repositories
{
    public class AnuncioRepository : Repository<Anuncio>, IAnuncioRepository
    {
        public AnuncioRepository(TemplateContext context): base(context) { }

        public IEnumerable<Anuncio> GetAll()
        {
            return Query(x => x.ID != 0);
        }
    }
}
