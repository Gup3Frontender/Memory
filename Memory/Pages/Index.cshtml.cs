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
            boardCreator.AddCardToList(new Card("images/bobr.jpg", 1));
            boardCreator.AddCardToList(new Card("images/bocian.jpg", 1));
            boardCreator.AddCardToList(new Card("images/dzik.jpg", 1));
            boardCreator.AddCardToList(new Card("images/jeż.jpg", 1));
            boardCreator.AddCardToList(new Card("images/kuna.jpg", 1));
            boardCreator.AddCardToList(new Card("images/lis.jpg", 1));
            boardCreator.AddCardToList(new Card("images/pliszka.jpg", 1));
            boardCreator.AddCardToList(new Card("images/niedzwiedz.jpg", 1));
            boardCreator.AddCardToList(new Card("images/sowa.jpg", 1));
            
        }
    }
}
