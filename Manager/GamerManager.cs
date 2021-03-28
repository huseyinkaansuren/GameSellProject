using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(UserValidationManager userValidationManager)
        {
            _userValidationService = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt olundu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
