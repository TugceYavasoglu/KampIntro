using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager
    {
        void Hesapla();
        void BiseyYap();

    }
}
//Interface, birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır.
//Loglama, kim ne zaman hangi operasyonu çağırmasıdır. Sistemde olan olayları gördüğümüz dökümdür.
