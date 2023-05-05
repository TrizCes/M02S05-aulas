using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace excecoes.CustomExceptions
{
  public class UsuarioInvalidoException : Exception
  {
    public UsuarioInvalidoException() { }
    public UsuarioInvalidoException() : base() { }
  }
}