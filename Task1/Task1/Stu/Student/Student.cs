using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Stu.Student
{
    class Student
    {
        public string Firstname;
        public string RegistrationNumber;
        

        public string StudentCNIC { get; set; }
        public string Studenthobbies { get; set; }
        public string StudentDOB { get; set; }
        public Student()
        {

        }
        public Student(string Fname, string RegNo, string CNIC, string hobbies, string SDob)
        {
            for (int i = 0; i < Fname.Length; i++)
                if ((!(char.IsLetter(Fname[i]))) && (!(Fname.Contains(" "))))
                {
                    throw new ArgumentException("Only alpha characters may be used");
                }
                else
                {
                    Firstname = Fname;
                }
            for (int j = 0; j < 4; j++)
                if ((!(char.IsNumber(RegNo[j]))))
                    throw new ArgumentException("Only num characters may be used");
            if (!((RegNo[4] == '-') && (RegNo[7] == '-')))
                throw new ArgumentException("Only hypehen are be used");
            for (int i = 8; i < RegNo.Length; i++)
                if ((!(char.IsNumber(RegNo[i]))))
                    throw new ArgumentException("Only numeric characters may be used");
            RegistrationNumber = RegNo;
            //CNIC
            if (CNIC.Length == 13)
                StudentCNIC = CNIC;
            else
                throw new ArgumentException("Only numeric characters may be used");
            Studenthobbies = hobbies;
            StudentDOB = SDob;



        }
        public string Getfname()
        {
            return this.Firstname;
        }
        public void SetFName(string fname)
        {
            Firstname = fname;
        }

        public string GetRegNumber()
        {
            return this.RegistrationNumber;
        }
        public void SetRegNumber(string RegNo)
        {
            RegistrationNumber = RegNo;
        }
        public void PrintInfo()
        {
            Console.Write(Firstname);
            Console.WriteLine(RegistrationNumber);
            Console.WriteLine(StudentCNIC);
            Console.WriteLine(Studenthobbies);
        }

        /// <summary>  
        //check gender if last dig= odd then male or else female
        /// </summary>  
        /// <returns> Nothig </returns>

        public void GetGender()
        {
            string gender = Convert.ToInt32(StudentCNIC.Substring(StudentCNIC.Length - 1)) % 2 != 0 ? "male" : "female";
            Console.WriteLine(gender);
        }
        /// <summary>  
        /// For calculating age  
        /// </summary>  
        /// <returns> years, months,day</returns>  
        public string GetAge()
        {
            DateTime Dob = Convert.ToDateTime(StudentDOB);
            DateTime Now = DateTime.Now; //current date
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            DateTime PastYearDate = Dob.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
            int Hours = Now.Subtract(PastYearDate).Hours;
            int Minutes = Now.Subtract(PastYearDate).Minutes;
            int Seconds = Now.Subtract(PastYearDate).Seconds;
            return String.Format("Age: {0} Year(s) {1} Month(s) {2} Day(s) {3} Hour(s) {4} Second(s)",
            Years, Months, Days, Hours, Seconds);


        }
        public int NumberOfWordsInName()
        {
            string text = Firstname;
            int wordCount = 0, index = 0;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                {
                    index++;
                    wordCount++;
                }
            }
            return wordCount;
        }
    }
}