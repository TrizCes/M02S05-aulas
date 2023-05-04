using System.Globalization;
using System.IO;
using escola.Service;
using escola.Interface;
using escola.Mocks;


IPessoasService _pessoasService = new PessoaService();

MenuService _menuService = new MenuService(_pessoasService);

_menuService.ExibirMenu();