using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Library
    {
        public string Name { get; set; }
        public string Location {  get; set; }
        public TimeSpan TimeOpen { get; set; }
        public TimeSpan TimeClose { get; set; }
        public uint Capacity {  get; set; }
        public override string ToString()
        {
            return $"{Name}; {Location}; {TimeOpen}; {TimeClose}; {Capacity}";
        }

        public static void FillLibrary(ref List<Library> libraries)
        {
            var random = new Random();
            var names = new List<string>
{
    "Библиотека имени Пушкина",
    "Городская библиотека",
    "Университетская библиотека",
    "Библиотека имени Лермонтова",
    "Районная библиотека",
    "Центральная городская библиотека",
    "Библиотека искусств",
    "Научная библиотека",
    "Библиотека для детей и молодежи",
    "Библиотека иностранной литературы"
};
            var locations = new List<string>
{
    "Москва",
    "Санкт-Петербург",
    "Новосибирск",
    "Екатеринбург",
    "Казань",
    "Нижний Новгород",
    "Челябинск",
    "Самара",
    "Омск",
    "Ростов-на-Дону"
};

            for (int i = 0; i < 30; i++)
            {
                var timeOpen = new TimeSpan(random.Next(7, 10), 0, 0); // открывается в промежутке между 7 и 10 утра
                var timeClose = new TimeSpan(random.Next(17, 22), 0, 0); // закрывается в промежутке между 5 и 10 вечера
                var capacity = (uint)random.Next(100, 500); // вместимость от 100 до 500 человек

                libraries.Add(new Library
                {
                    Name = names[random.Next(names.Count)],
                    Location = locations[random.Next(locations.Count)],
                    TimeOpen = timeOpen,
                    TimeClose = timeClose,
                    Capacity = capacity
                });
            }
        }
    }   


}
