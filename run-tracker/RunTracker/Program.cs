using RunTracker;

Console.WriteLine("Hello, World!");

var easyrun = new OutdoorRun()
{
    RunId = "1",
    UserId = "#1",    
    TrackType = "Trail"
};

easyrun.StartRun();

var start = new Position(49.8344717, 18.1621950);
var end = new Position(49.8340183, 18.1641100);

easyrun.AddPosition(new Position(start.Lat, start.Lng));

// RUUUUUNNNNN
for (int i = 0; i < 10; i++)
{
    var deltaLat = start.Lat - end.Lat;
    var deltaLng = start.Lng - end.Lng;
    easyrun.AddPosition(new Position(start.Lat + deltaLat, start.Lng + deltaLng));
    await Task.Delay(1500);
}

easyrun.EndRun();

Console.WriteLine(easyrun.GetRunDetails());
