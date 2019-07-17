using AlbumFotos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumFotos.ViewComponents
{
    public class ImagemViewComponent : ViewComponent
    {
        private readonly Contexto _contexto;

        public ImagemViewComponent(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _contexto.Imagens.Where(x => x.AlbumId == id).ToListAsync());
        }
    }
}
