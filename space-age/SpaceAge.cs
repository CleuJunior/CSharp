using System;

public class SpaceAge
{
    private readonly int _seconds;
    private const double EarthOrbitalPeriod = 31_557_600;
    private const double MercuryOrbitalPeriod = 0.240_846_7;
    private const double VenusOrbitalPeriod = 0.615_197_26;
    private const double MarsOrbitalPeriod = 1.880_815_8;
    private const double JupiterOrbitalPeriod = 11.862_615;
    private const double SaturnOrbitalPeriod = 29.447_498;
    private const double UranusOrbitalPeriod = 84.016_846;
    private const double NeptuneOrbitalPeriod = 164.791_32;

    public SpaceAge(int seconds) => _seconds = seconds;

    public double OnEarth() 
    {
        double earthEarth = _seconds / EarthOrbitalPeriod;

        return Math.Round(earthEarth, 2);
    }

    public double OnMercury() => DifferenceOrbitalPeriodOnEarth(MercuryOrbitalPeriod);

    public double OnVenus() => DifferenceOrbitalPeriodOnEarth(VenusOrbitalPeriod);

    public double OnMars() => DifferenceOrbitalPeriodOnEarth(MarsOrbitalPeriod);

    public double OnJupiter() => DifferenceOrbitalPeriodOnEarth(JupiterOrbitalPeriod);

    public double OnSaturn() => DifferenceOrbitalPeriodOnEarth(SaturnOrbitalPeriod);

    public double OnUranus() => DifferenceOrbitalPeriodOnEarth(UranusOrbitalPeriod);

    public double OnNeptune() => DifferenceOrbitalPeriodOnEarth(NeptuneOrbitalPeriod);

    private double DifferenceOrbitalPeriodOnEarth(double orbitalPeriod)
    {
        double onChosenPlanet = _seconds / (EarthOrbitalPeriod * orbitalPeriod);
        return Math.Round(onChosenPlanet, 2);
    }
}