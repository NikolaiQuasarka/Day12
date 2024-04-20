using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;

namespace Task1
{
    internal class HigherEducation
    {
        public string UniversityName { get; set; }
        public string GivenToPerson {  get; set; }
        public string Speciality { get; set; }
        public string Degree { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double MidMark { get; set; }
        public override string ToString()
        {
            return $"{UniversityName}; {GivenToPerson}; {Speciality}; {Degree}; {StartDate.ToString("dd.MM.yyyy")}; {EndDate.ToString("dd.MM.yyyy")}; {MidMark}";
        }

        public static void FillHigherEducation(ref List<HigherEducation> list)
        {
            var random = new Random();
            var universityNames = new List<string>
{
    "Московский государственный университет",
    "Санкт-Петербургский государственный университет",
    "Новосибирский государственный университет",
    "Казанский федеральный университет",
    "Национальный исследовательский ядерный университет",
    "Московский физико-технический институт",
    "Национальный исследовательский университет",
    "Российский государственный гуманитарный университет",
    "Российский университет дружбы народов",
    "Московский государственный институт международных отношений"
};

            var givenToPersons = new List<string>
{
    "Иван Иванов",
    "Петр Петров",
    "Сергей Сергеев",
    "Анна Аннинская",
    "Елена Еленова",
    "Ольга Ольгова",
    "Алексей Алексеев",
    "Николай Николаев",
    "Мария Мариева",
    "Татьяна Татьянова"
};

            var specialities = new List<string>
{
    "Математика",
    "Физика",
    "Химия",
    "Биология",
    "Информатика",
    "История",
    "Филология",
    "Экономика",
    "Юриспруденция",
    "Медицина"
};

            var degrees = new List<string>
{
    "Бакалавр математики",
    "Магистр физики",
    "Кандидат химических наук",
    "Доктор биологических наук",
    "Бакалавр информатики",
    "Магистр истории",
    "Кандидат филологических наук",
    "Доктор экономических наук",
    "Бакалавр юриспруденции",
    "Магистр медицины"
};
            DateTime UStart = new DateTime(2000, 9, 1);
            for (int i = 0; i < 30; i++)
            {
               HigherEducation e= new HigherEducation
                {
                    UniversityName = universityNames[random.Next(universityNames.Count)],
                    GivenToPerson = givenToPersons[random.Next(givenToPersons.Count)],
                    Speciality = specialities[random.Next(specialities.Count)],
                    Degree = degrees[random.Next(degrees.Count)],
                    StartDate = UStart.AddDays(random.Next((DateTime.Today - UStart).Days-(7*365))),
                    
                MidMark = random.Next(1, 10)
                } ;
                e.EndDate = e.StartDate.AddYears(random.Next(4, 7));
                list.Add(e);    

            }
        }
    }
}
