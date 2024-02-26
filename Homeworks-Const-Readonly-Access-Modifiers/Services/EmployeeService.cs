using Homeworks_Const_Readonly_Access_Modifiers.Models;

namespace Homeworks_Const_Readonly_Access_Modifiers.Services
{
    internal class EmployeeService : Emplyee
    {
        public Emplyee[] GetAll()
        {
            Emplyee emplyee1 = new()
            {
                Id = 1,
                name = "Employe1",
                surname = "Employev1",
                adress = "Baki1",
                email = "employe1@gmail.com",
                age = 18,
            };

            Emplyee emplyee2 = new()
            {
                Id = 2,
                name = "Employe2",
                surname = "Employev2",
                adress = "Baki2",
                email = "employe2@gmail.com",
                age = 19,
            };

            Emplyee emplyee3 = new()
            {
                Id = 3,
                name = "Employe3",
                surname = "Employev3",
                adress = "Baki3",
                email = "employe3@gmail.com",
                age = 54,
            };

            Emplyee emplyee4 = new()
            {
                Id = 5,
                name = "Employe4",
                surname = "Employev4",
                adress = "Baki4",
                email = "employe1@gmail.com",
                age = 67,
            };

            Emplyee emplyee5 = new()
            {
                Id = 5,
                name = "Employe5",
                surname = "Employev5",
                adress = "Baki5",
                email = "tploye1@gmail.com",
                age = 23,
            };

            Emplyee emplyee6 = new()
            {
                Id = 6,
                name = "Employe6",
                surname = "Employev6",
                adress = "Baki6",
                email = "employe1@gmail.com",
                age = 13,
            };

            Emplyee emplyee7 = new()
            {
                Id = 7,
                name = "Employe7",
                surname = "Employev7",
                adress = "Baki7",
                email = "tmploye1@gmail.com",
                age = 42,
            };

            Emplyee[] employers = { emplyee1, emplyee2, emplyee3, emplyee4, emplyee5, emplyee6, emplyee7 };
            return employers;
        }

        public Emplyee[] GetAllByAge(Emplyee[] emplyees, int age)
        {
            //var emplyees = GetAll();
            return emplyees.Where(m => m.age > age).ToArray();
        }
        public int GetCountByAge(Emplyee[] emplyees,int firstAge,int LastAge)
        {
            return emplyees.Where(m=>m.age > firstAge && m.age< LastAge).Count();
        }
        public int SumOfAge(Emplyee[] emplyees)
        {
            return emplyees.Sum(m => m.age);
        }
        public Emplyee[] GetAllByCheckEmail(Emplyee[] emplyees, string str)
        {
            return emplyees.Where(m => m.email.StartsWith(str)).ToArray();
        }

        internal int SumOfAges(Emplyee[] emplyees)
        {
            throw new NotImplementedException();
        }
    }
}
