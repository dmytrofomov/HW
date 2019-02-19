using System;

namespace lesson2._2
{
    class Employee
    {
        private string Name { get; }
        private string SoName { get; }
        public DateTime dateStartWork { get; set; } = new DateTime(2017, 1, 1);
        public string Profession { get; set; } = "Manager";


        public Employee(string name, string soname)
        {
            Name = name;
            SoName = soname;
        }

        public void GetSallaryAndTax()
        {

            var salaryBase = this.Profession == "Manager" ? 2000 : 1000;

            var stazh = DateTime.Now - dateStartWork;
            var salary = stazh.Days / 365 * salaryBase;
            var tax = salary * 0.2;
            Console.WriteLine($"name ={this.Name}, soName = {this.SoName}," +
                $"proffesion = {this.Profession},salary = {salary}, tax = {tax}");
        }
    }
}
