using System;

abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate() => _date;
    public int GetMinutes() => _minutes;

    public abstract double GetDistance(); // in kilometers
    public abstract double GetSpeed();    // in kph
    public abstract double GetPace();     // min per km

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}

// Running
class Running : Activity
{
    private double _distanceKm;

    public Running(string date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance() => _distanceKm;
    public override double GetSpeed() => (_distanceKm / GetMinutes()) * 60;
    public override double GetPace() => GetMinutes() / _distanceKm;
}

// Cycling
class Cycling : Activity
{
    private double _speedKph;

    public Cycling(string date, int minutes, double speedKph)
        : base(date, minutes)
    {
        _speedKph = speedKph;
    }

    public override double GetSpeed() => _speedKph;
    public override double GetDistance() => (_speedKph * GetMinutes()) / 60;
    public override double GetPace() => 60 / _speedKph;
}

// Swimming
class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
