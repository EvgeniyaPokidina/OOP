using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class PaidParking
    {
        private int currentFill;
        public int CurrentFill
        {
            get { return currentFill; }
            set { currentFill = value; }
        }
        private string? name;
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        private string? location;
        public string? Location
        {
            get { return location; }
            set { location = value; }
        }
        private int? parkingPlace;
        public int? ParkingPlace
        { 
        get { return parkingPlace; }
            set { if (value > 0) parkingPlace = value;
                else throw new Exception("Введите верное количество мест");
            }
        }
        private int waitingAuto; 
        public int WaitingAuto
        {
            get { return waitingAuto; }
            set { waitingAuto = value; }
        }

        public void ArriveAuto(int arrive)
        {
            if (CurrentFill >= ParkingPlace)
            {
                waitingAuto += arrive; 
                Console.WriteLine($"Нет мест! {arrive} автомобилей добавлены в ожидание.");
                return;
            }
            if (CurrentFill + arrive <= parkingPlace) currentFill += arrive;
        }
        public void RunAwayAuto(int auto)
        {
            if (auto < 0) throw new Exception("количество уехавших машин не может быть меньше нуля");
                        currentFill -= auto;
        }
        public void Print()
        {
            Console.WriteLine($"Текущее количество мест на парковке: {CurrentFill}. Количество свободных мест: {ParkingPlace-currentFill}. " +
                $"Количество ожидающих авто {WaitingAuto}");
        }
    }
}
