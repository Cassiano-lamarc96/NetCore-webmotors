using System;
using System.Collections.Generic;
using System.Text;
using Template.Application.ViewModels;

namespace Template.Application.Interfaces
{
    public interface IAnuncioService
    {
        List<AnuncioViewModel> Get();
        AnuncioViewModel GetbyId(int Id);
        AnuncioViewModel Post(AnuncioViewModel anuncio);
        bool Put(AnuncioViewModel anuncio);
        bool Delete(int Id);
    }
}
