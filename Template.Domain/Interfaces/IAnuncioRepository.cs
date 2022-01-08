﻿using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;

namespace Template.Domain.Interfaces
{
    public interface IAnuncioRepository : IRepository<Anuncio>
    {
        public IEnumerable<Anuncio> GetAll();
    }
}
