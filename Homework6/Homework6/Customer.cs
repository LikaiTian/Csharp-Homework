using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    [Serializable]
    public class Customer
    {
        //客户属性
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        //构造函数
        public Customer() { }
        public Customer(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   Name == customer.Name &&
                   Age == customer.Age &&
                   Sex == customer.Sex;
        }

        public override int GetHashCode()
        {
            int hashCode = 876893833;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sex);
            return hashCode;
        }

        public override string ToString()
        {
            return "Name:" + Name + "\tAge:" + Age + "\tSex:" + Sex;
        }
    }
}
