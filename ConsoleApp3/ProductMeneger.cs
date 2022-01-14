using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ProductMeneger
    {

        public  void AddProduct(Mehsullar newMehsullar)
        {
            //Sql Code

            Console.WriteLine("mehsulun adi: " + newMehsullar.ad + " Mhesulun vergili qiymeti :"+ newMehsullar.qiymet *0.18+ "manat") ;


        }

       
    }
}
