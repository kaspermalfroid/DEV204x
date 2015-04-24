using System;

namespace Module4
{
    class Program
    {
        struct Student
        {
            public string firstName;
            public string lastName;
            public BirthDate birthDate;
            public Student(string fN, string lN, BirthDate bD)
            {
                this.firstName = fN;
                this.lastName = lN;
                this.birthDate = bD;
            }
        }

        struct BirthDate
        {
            private int _year, _month, _day;
            public BirthDate(int y, int m, int d)
            {
                this._year = rangeCheckedYear(y);
                this._month = rangeCheckedMonth(m);
                this._day = rangeCheckedDay(d);
            }
            public override string ToString()
            {
                return string.Format("{0}-{1}-{2}", _year, _month, _day);
            }
            public int Year
            {
                get { return this._year; }
                set { this._year = rangeCheckedYear(value); }
            }
            public int Month
            {
                get { return this._month; }
                set { this._month = rangeCheckedMonth(value); }
            }
            public int Day
            {
                get { return this._day; }
                set { this._day = rangeCheckedDay(value); }
            }
            private static int rangeCheckedYear(int y)
            {
                int currentYear = DateTime.Now.Year;
                int minimumYear = currentYear - 150; // no people older than 150 at the moment
                if (y > currentYear)
                    return currentYear;
                else if (y < minimumYear) // no people older than 150 at the moment
                    return minimumYear;
                else
                    return y;
            }
            private static int rangeCheckedMonth(int m)
            {
                if (m > 12)
                    return 12;
                else if (m < 1)
                    return 1;
                else
                    return m;
            }
            private static int rangeCheckedDay(int d)
            {
                if (d > 31)
                    return 31;
                else if (d < 1)
                    return 1;
                else
                    return d;
            }
        }

        static void Main(string[] args)
        {
            Student[] studentList = new Student[5];
            studentList[0] = new Student("Johnny", "Cash", new BirthDate(2046, 2, 1));
            studentList[1] = new Student("Jeff", "Buckley", new BirthDate(1820, 4, 2));
            for (int counter = 0; counter < 2; counter++)
            {
                Console.WriteLine("Student {0} {1} was born on {2}", studentList[counter].firstName, studentList[counter].lastName, studentList[counter].birthDate);
            }
        }
    }
}
