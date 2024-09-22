using Lesson_3;

PaidParking paidParking = new PaidParking()
{
    Name ="Паркинг 24",
    Location = "Калининград",
    ParkingPlace=1000,
    WaitingAuto=75
};

paidParking.ArriveAuto(500);
paidParking.Print();
paidParking.RunAwayAuto(30);
paidParking.Print();


