namespace Solution1.session3
{
    public class HoaDonDien
    {
        class KH
        {
            public string id{get; set; }
            public string name{get; set; }
            public string date{get; set; }
            public int amount{get; set; }
            public double cost{get; set; }
            public virtual void ThanhTien() { }
        }
        //test
        class KHVN : KH //danh cho khach hang Vietnam
        {
            public string usecase{get; set; }

            public KHVN()
            {
            }
            public override void ThanhTien()
            {
                if (amount <= 50)
                {
                    cost= amount * 1000;
                }
                else if (amount <= 100) 
                {
                    cost =(1000*50)+ ( (amount-50) * 1200);
                }else if (amount <= 200)
                {
                    cost = (1200 * 100) + ((amount - 100) * 1500);
                }
                else
                {
                    cost = (1500 * 200) + ((amount - 200) * 2000);
                }
            
            }
        }

        class KHQT : KH //danh cho khach hang quoc te
        {
            public string quoctich {get; set; }
            public KHQT()
            {
            }
            public override void ThanhTien()
            {
                cost= amount * 2000;
            }
        }
    }
}