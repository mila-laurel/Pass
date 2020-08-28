using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass
{
    class Note
    {
        public string ToWhom { get; set; }
        public string From { get; set; }
        public Note(Adressee adressee)
        {
            switch (adressee)
            {
                case Adressee.ИвановАВ:
                    ToWhom = "Начальнику науно-производственного комплекса А.В. Иванову";
                    break;
                case Adressee.ПавловАИ:
                    ToWhom = "Начальнику 186 Управления по безопасности А.И. Павлову";
                    break;
            }
        }
    }
}
