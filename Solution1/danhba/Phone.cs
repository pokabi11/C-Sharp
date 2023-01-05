using Solution1.phonebook;

namespace Solution1.danhba
{
public abstract class Phone
	{
		public abstract void InsertPhone(String name, String phone);

        public abstract void RemovePhone(String name);

        public abstract void UpdatePhone(String name,String oldPhone, String newphone);

        public abstract PhoneNumber SearchPhone(String name);

        public abstract void Sort();

    }

    public class PhoneBook : Phone
    {
        public PhoneBook()
        {
            PhoneList = new List<PhoneNumber>();
        }

        public List<PhoneNumber> PhoneList { get; }


        // public override void InsertPhone(string name, string phone)
        // {
        //      foreach(PhoneNumber num in PhoneList)
        //     {
        //         if (num.Name.Equals(name))
        //         {
        //             if (num.Phone.Contains(phone))
        //             {
        //                 return;
        //             }
        //             num.Phone.Add(phone);
        //             return;
        //         }
        //     }
        //     PhoneNumber pn = new PhoneNumber(name, phone);
        //     PhoneList.Add(pn);
        // }

        public override void InsertPhone(string name, string phone)
        {
            PhoneList.ForEach(num =>
            {
                if (num.Name.Equals(name))
                {
                    if (num.Phone.Contains(phone))
                    {
                        return;
                    }
                    num.Phone.Add(phone);
                    return;
                }
            }
                
                );
            PhoneNumber pn = new PhoneNumber(name, phone);
            PhoneList.Add(pn);
        }

        public override void RemovePhone(string name)
        {
            foreach(PhoneNumber num in PhoneList)
            {
                if (num.Name.Equals(name))
                {
                    PhoneList.Remove(num);
                    return;
                }
            }
        }

        public override void UpdatePhone(string name, String oldPhone, string newphone)
        {
            foreach (PhoneNumber num in PhoneList)
            {
                if (num.Name.Equals(name) && num.Phone.Contains(oldPhone))
                {
                    num.Phone.Remove(oldPhone);
                    num.Phone.Add(newphone);
                    return;
                }
            }
        }
        
        public override PhoneNumber SearchPhone(string name)
        {
            foreach (PhoneNumber num in PhoneList)
            {
                if (num.Name.Equals(name))
                {
                    return num;
                }
            }
            return null;
        }
        
        public override void Sort()
        {
            PhoneList.Sort((num1, num2) =>
            {
                return num1.Name.CompareTo(num2.Name);
            });  
        }
    }
}