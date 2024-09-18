using Lesson_3;

PaidParking paidParking = new PaidParking()
{
    Name ="Паркинг 24",
    Location = "Калининград",
    ParkingPlace=1000,
};

paidParking.ArriveAuto(500);
paidParking.Print();
//Console.WriteLine("Количество въехавших машин на парковку:"+paidParking.Print());
paidParking.RunAwayAuto(30);
//Console.WriteLine("Количество уехавших машин:" + paidParking.Print());
paidParking.Print();

