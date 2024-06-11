using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHTTP.Models
{
    public class Postagem 
    {
        int UserId { get; set; }
        int Id { get; set; }
        string Title { get; set; }
        string Body { get; set; }
    }
}
