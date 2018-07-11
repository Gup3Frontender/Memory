using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Memory.Pages
{
    public class IndexModel : PageModel
    {
        public BoardCreator boardCreator = new BoardCreator();



        public IndexModel()
        {
            for(int i = 0; i < 10; i++)
            {
                boardCreator.AddCardToList(new Card($"kartanumer{i}", i));
            }
        }
    }
}
