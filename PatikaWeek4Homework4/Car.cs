using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework4
{
    public class Car
    {
        //Fields'lar tanımlanıyor.
        private string? _brand;
        private string? _model;
        private string? _color;
        private int numberDoors;

        //Property'ler tanımlanıyor
        public string Brand {
            get
            {
                return _brand;
            }
            set
            { 
                _brand = value;
            } 
        }
        public string Model { 
            get
            { 
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public string Color 
        {
            get
            { 
                return _color;            
            }
            set 
            { 
                _color = value;
            }
        }
        public int NumberDoors 
        {
            get
            {
                return numberDoors;
            }
            set
            {  //Kapı sayısının 2 veya 4 olması kontrol ediliyor.
                if(value==2 ||value==4)
                {
                    numberDoors = value;
                }
                else
                {
                    Console.WriteLine("\nKapı sayısı 2 veya 4 girilmeliydi.");
                    numberDoors = -1;

                }
            }     
                
        }
 
        public void CarInfo()
        {
            Console.WriteLine($"\n Markası..:{Brand}\n Modeli..:{Model}\n Rengi..:{Color}\n Kapı Sayısı..:{NumberDoors}");
        }

    }
}
