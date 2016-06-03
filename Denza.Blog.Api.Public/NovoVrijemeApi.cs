using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoVrijeme.Api.Public
{
    public interface INovoVrijemeApi
    {
        Post GetPostById(uint id);

        Post GetPostsByCategoryName(string category);

        Post GetPostsByCategoryId(string category);
    }
}
